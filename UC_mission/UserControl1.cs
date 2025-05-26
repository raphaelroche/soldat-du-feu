using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Drawing;
using System.Diagnostics;
using PdfSharp.Pdf;

namespace UC_mission
{
    public partial class Mission : UserControl
    {
        private DataSet m_ds;
        private int m_idMission;
        private string m_dateDepart;
        private string m_dateRetour;
        private string m_type;
        private string m_motif;
        private string m_adresse;
        private string m_cr;
        private string m_caserne;

        public Mission(int idMission, string type, string dateDepart, string dateRetour,
            string caserne, string desc, string adresse, string cr, DataSet ds)
        {
            InitializeComponent();
            this.m_ds = ds;
            this.m_idMission = idMission;
            this.m_dateDepart = dateDepart;
            this.m_dateRetour = dateRetour;
            this.m_motif = desc;
            this.m_type = type;
            this.m_adresse = adresse;
            this.m_cr = cr;
            this.m_caserne = caserne;
            lblIDMission.Text = "Mission n°" + idMission;
            lblDate.Text = "Date : " + dateDepart;
            lblCaserne.Text = "Caserne : " + caserne;
            lblType.Text = type;
            lblDescription.Text = "--> " + desc;

            //images des boutons
            System.Drawing.Image imgClose = UC_mission.Properties.Resources.close;
            btnCloture.BackgroundImage = new Bitmap(imgClose, new Size(btnCloture.Width, btnCloture.Height)); // redimensionne l'image à la taille du bouton btnCloture
            btnCloture.BackgroundImageLayout = ImageLayout.Stretch;

            //images des boutons
            System.Drawing.Image imgRapport = UC_mission.Properties.Resources.rapport;
            btnRapport.BackgroundImage = new Bitmap(imgRapport, new Size(btnRapport.Width, btnRapport.Height)); // redimensionne l'image à la taille du bouton btnCloture
            btnRapport.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            // Créer le document PDF  
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Compte rendu";

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Polices  
            XFont normalFont = new XFont("Verdana", 12);
            XFont boldFont = new XFont("Verdana", 20);

            double x = 40;
            double y = 50;

            gfx.DrawString("Rapport de mission", boldFont, XBrushes.Black, new XPoint(x, y));

            y += 35;

            MessageBox.Show(this.m_dateRetour);
            string dateDepart = this.m_dateDepart.Split(' ')[0];
            string heureDepart = this.m_dateDepart.Split(' ')[1];

            gfx.DrawString("Déclenchée le " + dateDepart + " à " + heureDepart, normalFont, XBrushes.Black, new XPoint(x, y));

            y += 20;

            if (m_dateRetour.Length == 0)
            {
                gfx.DrawString("Mission toujours en cours.", normalFont, XBrushes.Black, new XPoint(x, y));
            }
            else
            {
                string dateRetour = this.m_dateRetour.Split(' ')[0];
                string heureRetour = this.m_dateRetour.Split(' ')[1];
                gfx.DrawString("Retour le " + dateRetour + " à " + heureRetour, normalFont, XBrushes.Black, new XPoint(x, y));
            }

            y += 20;

            // Ligne pointillée  
            XPen dottedPen = new XPen(XColors.Black, 0.5);
            dottedPen.DashStyle = XDashStyle.Dot;
            gfx.DrawLine(dottedPen, x, y, page.Width - x, y);

            y += 35;

            gfx.DrawString("Type de sinistre : " + this.m_type, normalFont, XBrushes.Black, new XPoint(x, y));

            y += 20;

            gfx.DrawString("Motif : " + this.m_motif, normalFont, XBrushes.Black, new XPoint(x, y));

            y += 20;

            gfx.DrawString("Adresse : " + this.m_adresse, normalFont, XBrushes.Black, new XPoint(x, y));

            y += 20;

            gfx.DrawString("Compte rendu : " + this.m_cr, normalFont, XBrushes.Black, new XPoint(x, y));

            y += 20;

            // Ligne pointillée  
            gfx.DrawLine(dottedPen, x, y, page.Width - x, y);

            y += 35;

            gfx.DrawString("Caserne : " + this.m_caserne, boldFont, XBrushes.Black, new XPoint(x, y));

            y += 30;

            gfx.DrawString("Pompiers afféctés : ", boldFont, XBrushes.Black, new XPoint(x, y));

            y += 20;

            int nbPompier = 0;
            int columnThreshold = 7;
            double columnX = x;
            double columnY = y;
            bool secondColumn = false;

            foreach (DataRow row in m_ds.Tables["Mobiliser"].Rows)
            {
                if (Convert.ToInt32(row["idMission"]) == this.m_idMission)
                {
                    int idPompier = Convert.ToInt32(row["matriculePompier"]);
                    int idHabilitation = Convert.ToInt32(row["idHabilitation"]);
                    DataRow[] pompierRows = m_ds.Tables["Pompier"].Select("matricule = " + idPompier);
                    if (pompierRows.Length > 0)
                    {
                        DataRow pompier = pompierRows[0];
                        string gradeCode = pompier["codeGrade"].ToString();
                        DataRow[] gradeRows = m_ds.Tables["Grade"].Select("code = '" + gradeCode + "'");
                        string gradeLabel = gradeRows.Length > 0 ? gradeRows[0]["libelle"].ToString() : "Inconnu";
                        string prenom = pompier["prenom"].ToString();
                        string nom = pompier["nom"].ToString();

                        DataRow[] habilitationRows = m_ds.Tables["Habilitation"].Select("id = " + idHabilitation);
                        string habilitationLabel = habilitationRows.Length > 0 ? habilitationRows[0]["libelle"].ToString() : "Inconnu";

                        gfx.DrawString($" ==> {gradeLabel} {nom} {prenom}", normalFont, XBrushes.Black, new XPoint(columnX, columnY));
                        columnY += 20;

                        // Vérifier si l'habilitation dépasse la moitié de la page  
                        if (gfx.MeasureString($"Habilitation: {habilitationLabel}", normalFont).Width > (page.Width - 2 * x) / 2)
                        {
                            gfx.DrawString($"     Habilitation: {habilitationLabel.Substring(0, habilitationLabel.Length / 2)}", normalFont, XBrushes.Black, new XPoint(columnX, columnY));
                            columnY += 20;
                            gfx.DrawString($"     {habilitationLabel.Substring(habilitationLabel.Length / 2)}", normalFont, XBrushes.Black, new XPoint(columnX, columnY));
                        }
                        else
                        {
                            gfx.DrawString($"     Habilitation: {habilitationLabel}", normalFont, XBrushes.Black, new XPoint(columnX, columnY));
                        }
                        columnY += 20;

                        nbPompier++;

                        if (nbPompier == columnThreshold && !secondColumn)
                        {
                            // Passer à la deuxième colonne  
                            columnX = page.Width / 2 + 20;
                            columnY = y;
                            secondColumn = true;
                        }
                    }
                }
            }


            // Ajouter une nouvelle page au document PDF  
            PdfPage secondPage = document.AddPage();
            XGraphics gfxSecondPage = XGraphics.FromPdfPage(secondPage);

            // Réinitialiser les coordonnées pour la nouvelle page  
            x = 40;
            y = 50;

            gfxSecondPage.DrawString("Suite du rapport de mission", boldFont, XBrushes.Black, new XPoint(x, y));

            y += 35;

            gfxSecondPage.DrawString("Engins utilisés :", boldFont, XBrushes.Black, new XPoint(x, y));
            y += 20;

            foreach (DataRow row in m_ds.Tables["PartirAvec"].Rows)
            {
                if (Convert.ToInt32(row["idMission"]) == this.m_idMission)
                {
                    String codeEngin = row["codeTypeEngin"].ToString();
                    String reparationEngin = row["reparationsEventuelles"].ToString();
                    DataRow[] enginRows = m_ds.Tables["TypeEngin"].Select($"code = '{codeEngin}'");
                    if (enginRows.Length > 0)
                    {
                        string nomEngin = enginRows[0]["nom"].ToString();
                        if (reparationEngin.Length == 0)
                        {
                            reparationEngin = "Pas de réparations à prévoir.";
                        }
                        gfxSecondPage.DrawString($" ==> {nomEngin}", normalFont, XBrushes.Black, new XPoint(x, y));
                        y += 15;
                        gfxSecondPage.DrawString($"      {reparationEngin}", normalFont, XBrushes.Black, new XPoint(x, y));
                        y += 20;
                    }
                }
            }

            // sauvegarder le document  
            string filename = "Rapports/mission" + this.m_idMission + ".pdf";
            document.Save(filename);
        }
    }
}

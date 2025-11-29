# 🚒 Gestion de Casernes de Pompiers - Application SDIS 67

Ce projet est une application de gestion complète pour les Services Départementaux d'Incendie et de Secours (SDIS 67). L'application permet au **régulateur** de la Direction de la Sécurité Civile (DSC) de superviser **quatre casernes**, le personnel, le matériel et l'ensemble des missions.

Le développement a été réalisé en **C#** avec le framework **.NET (Windows Forms ou WPF)** et une base de données **SQLite** pour le stockage local des informations.

## 🌟 Fonctionnalités Principales

L'application est structurée autour de cinq volets principaux, accessibles via un tableau de bord ergonomique :

### 1. Tableau de Bord des Missions (Volet 1)
* **Visualisation** : Récapitulatif des missions passées et en cours.
* **Clôture Rapide** : Option de clôture des missions au retour des pompiers.
* **Édition de Bilan** : Génération d'un **PDF** récapitulatif du bilan de mission.

### 2. Création et Affectation de Mission (Volet 2)
* **Saisie** : Enregistrement du motif, de l'adresse et de la nature du sinistre.
* **Logique d'Affectation Automatique** : Le programme sélectionne automatiquement :
    * Le **type d'engins** nécessaires en fonction du sinistre.
    * Les **pompiers disponibles** (ni en mission, ni en congé) possédant les **habilitations requises**.
* **Gestion des Casernes** : Bascule automatique vers une autre caserne si les engins requis ne sont pas disponibles localement.
* **Mode Déconnecté/Connecté** : Création initiale en local, répercussion dans la base de données à la clôture.

### 3. Gestion du Matériel (Volet 3)
* **Visualisation 1 à 1** : Consultation des engins d'une caserne spécifique.
* **Navigation** : Utilisation du **Data Binding** (liaison de données) pour une navigation fluide (avant/arrière) sans accès base de données.
* **État** : Affichage clair de l'état de l'engin (en mission / en panne).

### 4. Gestion du Personnel (Volet 4)
* **Consultation et Mise à Jour** : Gestion complète des données signalétiques, de la carrière et des habilitations des pompiers.
* **Droits d'Administration** : Mise à jour des données réservée aux utilisateurs avec droits d'administration.
* **Suivi de Carrière** : Mémorisation du grade actuel, des affectations antérieures et des habilitations obtenues.
* **Gestion des Congés** : Signalement clair du statut "en congé".
* **Transactions** : Utilisation de transactions pour garantir l'intégrité des mises à jour complexes (grade, affectation, congé).

### 5. Statistiques (Volet 5)
Des requêtes SQL spécifiques (pour le régulateur) sont implémentées pour fournir :
* **Pour une caserne** : Engins les plus utilisés, total d'heures d'utilisation.
* **Pour l'ensemble** : Nombre d'interventions par type de sinistre, habilitations les plus sollicitées, et liste des pompiers par habilitation.

## 🛠️ Stack Technique

* **Langage Principal** : C#
* **Framework** : .NET (Windows Forms ou WPF)
* **Base de Données** : SQLite (Fichier `SDIS67.db`)
* **Schéma Conceptuel** : Base de données construite selon le schéma conceptuel `bdPompier` (voir documentation annexe).
* **Bonnes Pratiques** :
  * Utilisation de classes dédiées pour la gestion de la connexion (`Connexion.cs`)
  * Partage du DataSet via la classe (`mesDatas.cs`)
## 🚀 Installation et Démarrage

1.  **Prérequis** : Assurez-vous d'avoir Version 7 de .NET installé.
2.  **Clonage** : Cloner ce dépôt : `git clone <URL_du_dépôt>`
3.  **Démarrage** : Ouvrez la solution `Sae24_Caserne.sln` avec Visual Studio et lancez le projet.

*(Note : Les droits de mise à jour sont conditionnés par la table `Admin`.)*

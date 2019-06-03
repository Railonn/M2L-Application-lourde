using Identification.BDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Generation du fichier PDF
using sharpPDF;
using sharpPDF.Enumerators;
using sharpPDF.Fonts;

namespace Identification.form
{
    public partial class frmCerfa : Form
    {
        private List<LigneFrais> lesFrais = new List<LigneFrais>();
        private List<Demandeurs> lesDemandeurs = new List<Demandeurs>();
        private List<Clubs> lesClubs = new List<Clubs>();

        public frmCerfa()
        {
            InitializeComponent();

            this.initiliseList();
            this.setCbDonnateur();
            this.setCbBeneficiare();
        }

        /// <summary>
        /// initialise les listes
        ///     lesFrais, lesDemandeurs, lesLigues
        /// via la base de données
        /// </summary>
        private void initiliseList()
        {
            Connection.Init();

            lesFrais = Connection.GetLigneFrais();
            lesDemandeurs = Connection.GetLesDemandeur();
            lesClubs = Connection.GetLesClubs();
        }

        /// <summary>
        /// Recherche si une ligne de frais et presente des la list lesLignes
        /// en fonction du mail de lbDemandeur 
        /// et de la date de lbDateDemande
        /// </summary>
        /// <returns>Renvoie une ligne si trouver</returns>
        private LigneFrais rechercheLigneFrais()
        {
            LigneFrais laLigne = null;

            bool trouver = false;
            int i = 0;
            while (lesFrais.Count > i && !trouver)
            {
                if (true)
                {
                    laLigne = lesFrais[i];
                    trouver = true;
                }

                i++;
            }

            return laLigne;
        }

        /// <summary>
        /// Recherche si un demandeur et presente des la list lesDemandeurs
        /// en fonction de l'adressemail d'une ligne de frais
        /// </summary>
        /// <param name="laLigne"></param>
        /// <returns></returns>
        private Demandeurs rechercheDemandeur(LigneFrais laLigne)
        {
            Demandeurs leDemandeur = null;

            bool trouve = false;
            int i = 0;

            while (lesDemandeurs.Count > i && !trouve)
            {
                if (lesDemandeurs[i].AdresseMail == laLigne.AdresseMail)
                {
                    leDemandeur = lesDemandeurs[i];
                    trouve = true;
                }

                i++;
            }

            return leDemandeur;
        }

        /// <summary>
        /// Recherche si un club et présent dans la list lesClubs
        /// en fonction du nom du clubs
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        private Clubs rechercheClubs(string nom)
        {
            Clubs unClubs = null;

            bool trouve = false;
            int i = 0;

            while (lesClubs.Count > i && !trouve)
            {
                if (lesClubs[i].NomClub == nom)
                {
                    unClubs = lesClubs[i];
                    trouve = true;
                }

                i++;
            }

            return unClubs;
        }

        public void setCbBeneficiare()
        {
            foreach (Clubs unClub in lesClubs)
            {
                this.cbBeneficiare.Items.Add(unClub.NomClub);           
            }
        }

        public void setCbDonnateur()
        {
            foreach (Demandeurs unDemandeur in lesDemandeurs)
            {
                this.cbDonnateur.Items.Add(unDemandeur.Nom);
            }
        }

        private void cbBeneficiare_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pdfDocument myDoc = new pdfDocument("RemiseImpot", "ME");
            pdfPage myFirstPage = myDoc.addPage();


            myDoc.createPDF(@"C:\Users\William\Documents\Remises_Impots.pdf");
            myFirstPage = null;
            myDoc = null;
        }
    }
}

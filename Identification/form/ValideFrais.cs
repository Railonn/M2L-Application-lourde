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

namespace Identification.form
{
    public partial class FrmValideFrais : Form
    {
        // Constante cout retenue par kilometre
        private const decimal COUTKM = 0.28M;

        private List<LigneFrais> lesFrais = new List<LigneFrais>();
        private List<Motif> lesMotifs = new List<Motif>();

        public FrmValideFrais()
        {
            InitializeComponent();

            this.ChargerLesFrais();
            this.ChargerLesDemandeurs();
        }

        /// <summary>
        /// Initialise les listes lesFrais et lesMotif via la base de donnée
        /// </summary>
        private void ChargerLesFrais()
        {
            Connection.Init();

            lesFrais = Connection.GetLigneFrais();
            lesMotifs = Connection.GetLesMotifs();
        }

        /// <summary>
        /// Recherche tout les mails des demandeurs
        /// et les ajoutes a la listBox lbDemandeur
        /// </summary>
        private void ChargerLesDemandeurs()
        {
            lbDemandeur.Items.Clear();

            foreach (LigneFrais unFrais in lesFrais)
            {
                if(!lbDemandeur.Items.Contains(unFrais.AdresseMail) && !unFrais.LigneValider)
                    lbDemandeur.Items.Add(unFrais.AdresseMail);
            }

            if (lbDemandeur.Items.Count == 0)
                lbDemandeur.Hide();
        }

        /// <summary>
        /// Recherche toute les dates de la demande choisie
        /// et les ajoutes a la listBox lbDemande
        /// </summary>
        /// <param name="mailDemandeur">Mail du demandeur</param>
        private void ChargerLigneFrais(string mailDemandeur)
        {
            lbDateDemande.Items.Clear();

            foreach (LigneFrais unFrais in lesFrais)
            {
                if (!unFrais.LigneValider && unFrais.AdresseMail == mailDemandeur)
                    lbDateDemande.Items.Add(unFrais.DateFrais);
            }      
        }

        /// <summary>
        /// Recherche si une ligne de frais et presente des la list lesLignes
        /// en fonction du mail de lbDemandeur 
        /// et de la date de lbDateDemande
        /// </summary>
        /// <returns>Renvoie une ligne si trouver</returns>
        private LigneFrais RechercheLigneFrais()
        {
            LigneFrais laLigne = null;

            bool trouver = false;
            int i = 0;
            while (lesFrais.Count > i && !trouver)
            {
                if (lesFrais[i].AdresseMail == lbDemandeur.Text && lesFrais[i].DateFrais.ToShortDateString() == lbDateDemande.Text)
                {
                    laLigne = lesFrais[i];
                    trouver = true;
                }

                i++;
            }

            return laLigne;
        }

        /// <summary>
        /// Recherche si un motif et presente des la list lesMotifs
        /// en fonction de l'idMotif d'une ligne de frais
        /// </summary>
        /// <param name="laLigne">Ligne de frais</param>
        /// <returns>return la motif si trouver</returns>
        private Motif RechercheMotif(LigneFrais laLigne)
        {
            Motif leMotif = null;

            bool trouver = false;
            int i = 0;
            while (lesMotifs.Count > i && !trouver)
            {
                if (lesMotifs[i].IdMotif == laLigne.IdMotif)
                {
                    leMotif = lesMotifs[i];
                    trouver = true;
                }

                i++;
            }

            return leMotif;
        }

        /// <summary>
        /// gestion de la valuer maximal autoriser a valider
        /// en fonction des valeur des textBoxs demande
        /// </summary>
        private void SetMaximum()
        {
            this.numKmValide.Maximum = decimal.Parse(this.txtKmDemande.Text);
            this.numPeageValide.Maximum = decimal.Parse(this.txtPeageDemande.Text);
            this.numRepasValide.Maximum = decimal.Parse(this.txtRepasDemande.Text);
            this.numHebergementValide.Maximum = decimal.Parse(this.txtHebergementDemande.Text);
        }

        /// <summary>
        /// Calcule du cout d'une ligne
        /// </summary>
        /// <param name="kmParcourue">km pracourue</param>
        /// <param name="coutPeage">cout du péage</param>
        /// <param name="coutRepas">cout du repas</param>
        /// <param name="coutHeberge">cout de l'hebergement</param>
        /// <returns>renvoie le resultat du calcule</returns>
        private decimal CalculCout(long kmParcourue, decimal coutPeage, decimal coutRepas, decimal coutHeberge)
        {
            return kmParcourue * COUTKM + coutPeage + coutRepas + coutHeberge;
        }

        /// <summary>
        /// Gestion des infomrations concernant la demande frais
        /// </summary>
        private void ChargerInfoDemande()
        {
            //recherche de la ligne concerné
            LigneFrais laLigne = RechercheLigneFrais();
            
            //si laLigne existe
            if (laLigne != null)
            {
                //recherche du Motif de la ligne
                Motif leMotif = RechercheMotif(laLigne);

                //affichage des infomration concernant la demande
                if (leMotif != null)
                    this.txtMotif.Text = leMotif.Libelle;
                else
                    this.txtMotif.Text = "Erreur de motif";

                this.txtTrajet.Text = laLigne.Trajet;
                this.txtKmDemande.Text = laLigne.Km.ToString();
                this.txtPeageDemande.Text = laLigne.CoutPeage.ToString();
                this.txtRepasDemande.Text = laLigne.CoutRepas.ToString();
                this.txtHebergementDemande.Text = laLigne.CoutHeberge.ToString();

                //empeche le depassement des valeurs maximum demander
                this.SetMaximum();

                //calcule du total de la demande
                this.txtTotalDemande.Text = this.CalculCout(long.Parse(this.txtKmDemande.Text), decimal.Parse(this.txtPeageDemande.Text), decimal.Parse(this.txtRepasDemande.Text), decimal.Parse(this.txtHebergementDemande.Text)).ToString();
            }            
        }

        /// <summary>
        /// réinitialise toute les informations des textBoxs
        /// </summary>
        private void ClearInformation()
        {
            this.txtMotif.Clear();
            this.txtTrajet.Clear();
            this.txtKmDemande.Clear();
            this.txtPeageDemande.Clear();
            this.txtRepasDemande.Clear();
            this.txtHebergementDemande.Clear();
            this.txtTotalDemande.Clear();

            this.numKmValide.Value = 0;
            this.numPeageValide.Value = 0.00M;
            this.numRepasValide.Value = 0.00M;
            this.numHebergementValide.Value = 0.00M;
            this.txtTotalValide.Text = "0.00";
        }

        /// <summary>
        /// Apelle de la fonction chargerLigneFrais en fonction de l'index selectionné dans la listBox lbDemandeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbDemandeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChargerLigneFrais(this.lbDemandeur.Text);
        }

        /// <summary>
        /// Apelle de la fonction chargerInfoDemande en fonction de l"index selectionné dans le listBox lbDemande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbDateDemande_SelectedIndexChanged(object sender, EventArgs e)
        {          
            this.ChargerInfoDemande();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbDateDemande_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.ClearInformation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbDemandeur_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.lbDateDemande.Items.Clear();
            this.ClearInformation();
        }

        /// <summary>
        /// Mise a jour du cout total valider
        /// fonction apellé sur chaque zone de nombre 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumValide_ValueChanged(object sender, EventArgs e)
        {
            this.txtTotalValide.Text = this.CalculCout((long)this.numKmValide.Value, this.numPeageValide.Value, this.numRepasValide.Value, this.numHebergementValide.Value).ToString();
        }

        /// <summary>
        /// Click pour valider les frais de la ligne en cour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Confirmer la demande d'un demande d'un montant de " + this.txtTotalValide.Text + "€ ?", "Validation", MessageBoxButtons.YesNo);

            if (resultat == DialogResult.Yes)
            {
                if (lbDemandeur.Items.Count > 0)
                {
                    int ligneAJouter = Connection.ValidationLigneFrais((long)this.numKmValide.Value, this.numPeageValide.Value, this.numRepasValide.Value, this.numHebergementValide.Value, this.lbDemandeur.Text, this.lbDateDemande.Text);

                    if (ligneAJouter != 0)
                    {
                        MessageBox.Show("La validation a bien été bien prise en compte");

                        // Mise a jour des listes 
                        this.ChargerLesFrais();
                        this.ChargerLesDemandeurs();

                        // Efface les informations
                        this.lbDateDemande.Items.Clear();
                        this.ClearInformation();
                    }
                    else
                        MessageBox.Show("Une erreur de validation s'est produite.");
                }
                else
                {
                    MessageBox.Show("Aucune demande de remboursement de notes de frais n'a était effectuée.", "Validation impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

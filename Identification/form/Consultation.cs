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
    public partial class frmConsultation : Form
    {
        private List<Demandeurs> lesDemandeurs = new List<Demandeurs>();
        private List<LigneFrais> lesFrais = new List<LigneFrais>();
        private List<Motif> lesMotifs = new List<Motif>();   

        public frmConsultation()
        {
            InitializeComponent();

            this.initiliseList();
            this.setListView();
        }

        /// <summary>
        /// initialise les listes
        ///     lesFrais, lesMotifs, lesDemandeurs
        /// via la base de données
        /// </summary>
        private void initiliseList()
        {
            Connection.Init();

            lesFrais = Connection.GetLigneFrais();
            lesMotifs = Connection.GetLesMotifs();
            lesDemandeurs = Connection.GetLesDemandeur();
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
        /// Recherche si un motif et presente des la list lesMotifs
        /// en fonction de l'idMotif d'une ligne de frais
        /// </summary>
        /// <param name="laLigne">Ligne de frais</param>
        /// <returns>return la motif si trouver</returns>
        private Motif rechercheMotif(LigneFrais laLigne)
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
        /// Recherche si un demandeur et presente des la list lesMotifs
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
        /// Gestion du contenue du ListView : lvFrais
        /// Crée les groupe
        /// ajoute le contenue des demandes
        /// </summary>
        private void setListView()
        {
            //nettoie les information contenue dans le listView lvFrais
            this.lvFrais.Groups.Clear();
            this.lvFrais.Items.Clear();

            //list de controle des groupes
            List<string> lesGroupes = new List<string>();

            Demandeurs unDemandeurs;

            //creation des groupe un seul par mail
            foreach (LigneFrais uneLigne in lesFrais)
            {
                unDemandeurs = this.rechercheDemandeur(uneLigne);
                ListViewGroup nouveauGroupe = new ListViewGroup(uneLigne.AdresseMail, unDemandeurs.Nom.ToUpper() + " " + unDemandeurs.Prenom);

                if(!lesGroupes.Contains(nouveauGroupe.Name))
                    this.lvFrais.Groups.Add(nouveauGroupe);

                lesGroupes.Add(nouveauGroupe.Name);
            }

            //remplisage du contenue (demande de frais)
            foreach (ListViewGroup unGroupe in lvFrais.Groups)
            { 
                foreach (LigneFrais uneLigne in lesFrais)
                {
                    if (unGroupe.Name == uneLigne.AdresseMail && uneLigne.LigneValider)
                    {
                        ListViewItem nouveauItem = new ListViewItem(uneLigne.DateFrais.ToShortDateString(), unGroupe);

                        nouveauItem.SubItems.Add(new ListViewItem.ListViewSubItem(nouveauItem, this.rechercheMotif(uneLigne).Libelle));
                        nouveauItem.SubItems.Add(new ListViewItem.ListViewSubItem(nouveauItem, uneLigne.Trajet));
                        nouveauItem.SubItems.Add(new ListViewItem.ListViewSubItem(nouveauItem, uneLigne.KmOk + "/" + uneLigne.Km));
                        nouveauItem.SubItems.Add(new ListViewItem.ListViewSubItem(nouveauItem, uneLigne.CoutPeageOk + "/" + uneLigne.CoutPeage));
                        nouveauItem.SubItems.Add(new ListViewItem.ListViewSubItem(nouveauItem, uneLigne.CoutRepasOk + "/" + uneLigne.CoutRepas));
                        nouveauItem.SubItems.Add(new ListViewItem.ListViewSubItem(nouveauItem, uneLigne.CoutHebergeOk + "/" + uneLigne.CoutHeberge));

                        this.lvFrais.Items.Add(nouveauItem);
                    }
                }
            }
        }

        private void lvFrais_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mail = "";
            string date = "";

            foreach (int index in this.lvFrais.SelectedIndices)
            {
                mail = this.lvFrais.Items[index].Group.Name;
                date = this.lvFrais.Items[index].Text;
            }

            DialogResult resultat = MessageBox.Show("Voulez-vous annuler la validation de la ligne de frais de " + mail + " faite le " + date + " ?", "Annulation de la demande", MessageBoxButtons.YesNo);

            if (resultat == DialogResult.Yes)
            {
                int ligneAJouter = Connection.AnnuleLigneFrais(mail, date);

                if (ligneAJouter != 0)
                {
                    MessageBox.Show("L'annulation a bien été bien prise en compte");

                    //actualisation des liste et du contenue afficher
                    this.initiliseList();
                    this.setListView();
                }
                else
                    MessageBox.Show("Une erreur c'est produite");
            }
        }
    }
}

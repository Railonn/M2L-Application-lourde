using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Connexion à la base de données
using Identification.BDD;
using Identification.form;

namespace Identification
{
    public partial class FrmIdentification : Form
    { 
        public FrmIdentification()
        {
            InitializeComponent();
        }

        private void BtnValide_Click(object sender, EventArgs e)
        {
            // Initialisation de la connexion
            Connection.Init();

            // Verification des identifiants saisis
            if (Connection.MdpConnection(txtLogin.Text, txtMdp.Text))
                this.OpenGestion();
            else
                MessageBox.Show("Vos identifiant sont erronés.", "Connexion impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
        }

        // Permet d'ouvrir le formulaire Gestion
        public void OpenGestion()
        {
            Gestion frmGestion = new Gestion();
            Hide();
            frmGestion.ShowDialog();
        }
        
        // Permet à l'utilisateur de fermer correctement l'application
        private void FermerApplication_Click(object sender, EventArgs e)
        {
             DialogResult resultat = MessageBox.Show("Voulez-vous quitter l'application ?", "Confirmation", MessageBoxButtons.YesNo);

            if (resultat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void ConsulterLesFraisToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmConsultation frmConsultation = new FrmConsultation();
            frmConsultation.ShowDialog();
        }

        private void GeneréLeDocumentCERFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCerfa frmCerfa = new frmCerfa();
            frmCerfa.ShowDialog();
        }

        private void DéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmIdentification frmIdentification = new FrmIdentification();
            frmIdentification.Show();
        }

        private void VoirLesModificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoriqueDesValidations frmHistorique = new HistoriqueDesValidations();
            frmHistorique.Show();
        }

        private void ValiderLesFraisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmValideFrais frmLigne = new FrmValideFrais();
            frmLigne.ShowDialog();
        }

        private void Gestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

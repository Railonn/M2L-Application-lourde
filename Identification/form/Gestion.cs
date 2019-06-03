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

        private void ValiderLesFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmValideFrais frmLigne = new FrmValideFrais();
            frmLigne.ShowDialog();
        }

        private void ConsulterLesFraisToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmConsultation frmConsultation = new frmConsultation();
            frmConsultation.ShowDialog();
        }

        private void GeneréLeDocumentCERFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCerfa frmCerfa = new frmCerfa();
            frmCerfa.ShowDialog();
        }

        private void DéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FrmIdentification frmIdentification = new FrmIdentification();
            frmIdentification.Show();
        }
    }
}

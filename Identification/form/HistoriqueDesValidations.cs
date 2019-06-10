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
    public partial class HistoriqueDesValidations : Form
    {
        private List<HistoriqueActions> lesActions = new List<HistoriqueActions>();

        public HistoriqueDesValidations()
        {
            InitializeComponent();
            ChargerLesActions();
            this.SetListView();
        }

        private void ChargerLesActions()
        {
            Connection.Init();
            lesActions = Connection.GetLesActions();
        }


        public void SetListView()
        {
            //nettoie les information contenue dans le listView lvFrais
            this.lvActionsTresoriers.Groups.Clear();
            this.lvActionsTresoriers.Items.Clear();

            //remplisage du contenue (demande de frais)
            foreach (HistoriqueActions uneAction in lesActions)
            {
                ListViewItem nouveauItem = new ListViewItem(uneAction.AdresseMail);

                nouveauItem.SubItems.Add(new ListViewItem.ListViewSubItem(nouveauItem, uneAction.DateFraisModif.ToShortDateString()));
                nouveauItem.SubItems.Add(new ListViewItem.ListViewSubItem(nouveauItem, uneAction.ActionRealisée.ToString()));

                this.lvActionsTresoriers.Items.Add(nouveauItem);
            }
        }
    }
}

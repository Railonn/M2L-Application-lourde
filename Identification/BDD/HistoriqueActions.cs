using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identification.BDD
{
    public class HistoriqueActions
    {
        public string AdresseMail { get; set; }
        public DateTime DateFraisModif { get; set; }
        public string ActionRealisée { get; set; }

        public HistoriqueActions(string adresseMail, DateTime dateFraisModif, string actionRealisée)
        {
            this.AdresseMail = adresseMail;
            this.DateFraisModif = dateFraisModif;
            this.ActionRealisée = actionRealisée;
        }

        public HistoriqueActions()
        {

        }

    }
}

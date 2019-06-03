using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identification.BDD
{
    public class Lien
    {
        private string adresseMail;
        private string numeroLicence;

        public string AdresseMail { get => adresseMail; set => adresseMail = value; }
        public string NumeroLicence { get => numeroLicence; set => numeroLicence = value; }

        public Lien(string adresseMail, string numeroLicence)
        {
            this.adresseMail = adresseMail;
            this.numeroLicence = numeroLicence;
        }
    }
}

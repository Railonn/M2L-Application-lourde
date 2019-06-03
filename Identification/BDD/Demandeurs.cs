using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identification.BDD
{
    public class Demandeurs
    {
        private string adresseMail;
        private string cp;
        private string nom;
        private string numRecu;
        private string password;
        private string prenom;
        private string rue;
        private string ville;

        public string AdresseMail { get => adresseMail; set => adresseMail = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Nom { get => nom; set => nom = value; }
        public string NumRecu { get => numRecu; set => numRecu = value; }
        public string Password { get => password; set => password = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Ville { get => ville; set => ville = value; }

        public Demandeurs(string adresseMail, string cp, string nom, string numRecu, string password, string prenom, string rue, string ville)
        {
            this.adresseMail = adresseMail;
            this.cp = cp;
            this.nom = nom;
            this.numRecu = numRecu;
            this.password = password;
            this.prenom = prenom;
            this.rue = rue;
            this.ville = ville;
        }

        public Demandeurs()
        {

        }
    }
}

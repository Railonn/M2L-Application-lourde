using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identification.BDD
{
    public class Adherents
    {
        private string adresse;
        private string cp;
        private DateTime dateNais;
        private string email;
        private string nom;
        private string numeroLicence;
        private string numClub;
        private string prenom;
        private char sexe;
        private string ville;

        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }
        public DateTime DateNais { get => dateNais; set => dateNais = value; }
        public string Email { get => email; set => email = value; }
        public string Nom { get => nom; set => nom = value; }
        public string NumeroLicence { get => numeroLicence; set => numeroLicence = value; }
        public string NumClub { get => numClub; set => numClub = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public char Sexe { get => sexe; set => sexe = value; }
        public string Ville { get => ville; set => ville = value; }

        public Adherents(string adresse, string cp, DateTime dateNais, string email, string nom, string numeroLicence, string numClub, string prenom, char sexe, string ville)
        {
            this.adresse = adresse;
            this.cp = cp;
            this.dateNais = dateNais;
            this.email = email;
            this.nom = nom;
            this.numeroLicence = numeroLicence;
            this.numClub = numClub;
            this.prenom = prenom;
            this.sexe = sexe;
            this.ville = ville;
        }

    }
}

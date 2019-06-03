using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identification.BDD
{
    public class Clubs
    {
        private string cp;
        private string nomClub;
        private string numeroLicence;
        private string numClub;
        private string numLigue;
        private string pswTreso;
        private string rue;
        private string ville;

        public string Cp { get => cp; set => cp = value; }
        public string NomClub { get => nomClub; set => nomClub = value; }
        public string NumeroLicence { get => numeroLicence; set => numeroLicence = value; }
        public string NumClub { get => numClub; set => numClub = value; }
        public string NumLigue { get => numLigue; set => numLigue = value; }
        public string PswTreso { get => pswTreso; set => pswTreso = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Ville { get => ville; set => ville = value; }

        public Clubs(string cp, string nomClub, string numeroLicence, string numClub, string numLigue, string pswTreso, string rue, string ville)
        {
            this.cp = cp;
            this.nomClub = nomClub;
            this.numeroLicence = numeroLicence;
            this.numClub = numClub;
            this.numLigue = numLigue;
            this.pswTreso = pswTreso;
            this.rue = rue;
            this.ville = ville;
        }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Clubs()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identification.BDD
{
    public class ligues
    {
        private string nom;
        private string numLigue;
        private string president;
        private string sigle;

        public string Nom { get => nom; set => nom = value; }
        public string NumLigue { get => numLigue; set => numLigue = value; }
        public string President { get => president; set => president = value; }
        public string Sigle { get => sigle; set => sigle = value; }

        public ligues(string nom, string numLigue, string president, string sigle)
        {
            this.nom = nom;
            this.numLigue = numLigue;
            this.president = president;
            this.sigle = sigle;
        }

        public ligues()
        {

        }
    }
}

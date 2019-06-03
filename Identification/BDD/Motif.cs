using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identification.BDD
{
    public class Motif
    {
        private Int64 idMotif;
        private string libelle;

        public Int64 IdMotif { get => idMotif; set => idMotif = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public Motif(Int64 idMotif, string libelle)
        {
            this.idMotif = idMotif;
            this.libelle = libelle;
        }

        public Motif()
        {

        }
    }
}

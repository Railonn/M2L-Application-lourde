using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identification.BDD
{
    public class LigneFrais
    {
        private string adresseMail;
        private DateTime dateFrais;
        private Int64 idMotif;
        private string trajet;
        private Int64 km;
        private decimal coutPeage;
        private decimal coutRepas;
        private decimal coutHeberge;
        private Int64 kmOk;
        private decimal coutPeageOk;
        private decimal coutRepasOk;
        private decimal coutHebergeOk;
        private decimal total;      
        private bool ligneValider;
        private string numClub;

        public string AdresseMail { get => adresseMail; set => adresseMail = value; }
        public DateTime DateFrais { get => dateFrais; set => dateFrais = value; }
        public Int64 IdMotif { get => idMotif; set => idMotif = value; }
        public string Trajet { get => trajet; set => trajet = value; }
        public Int64 Km { get => km; set => km = value; }
        public decimal CoutPeage { get => coutPeage; set => coutPeage = value; }
        public decimal CoutRepas { get => coutRepas; set => coutRepas = value; }
        public decimal CoutHeberge { get => coutHeberge; set => coutHeberge = value; }
        public Int64 KmOk { get => kmOk; set => kmOk = value; }
        public decimal CoutPeageOk { get => coutPeageOk; set => coutPeageOk = value; }
        public decimal CoutRepasOk { get => coutRepasOk; set => coutRepasOk = value; }
        public decimal CoutHebergeOk { get => coutHebergeOk; set => coutHebergeOk = value; }
        public decimal Total { get => total; set => total = value; }
        public bool LigneValider { get => ligneValider; set => ligneValider = value; }
        public string NumClub { get => numClub; set => numClub = value; }

        /// <summary>
        /// COnstructeur de ligne frais
        /// </summary>
        /// <param name="adresseMail"></param>
        /// <param name="dateFrais"></param>
        /// <param name="idMotif"></param>
        /// <param name="trajet"></param>
        /// <param name="km"></param>
        /// <param name="coutPeage"></param>
        /// <param name="coutRepas"></param>
        /// <param name="coutHeberge"></param>
        /// <param name="kmOk"></param>
        /// <param name="coutPeageOk"></param>
        /// <param name="coutRepasOk"></param>
        /// <param name="coutHebergeOk"></param>
        /// <param name="total"></param>
        /// <param name="ligneValider"></param>
        /// <param name="numClub"></param>
        public LigneFrais(string adresseMail, DateTime dateFrais, long idMotif, string trajet, long km, decimal coutPeage, decimal coutRepas, decimal coutHeberge, long kmOk, decimal coutPeageOk, decimal coutRepasOk, decimal coutHebergeOk, decimal total, bool ligneValider, string numClub)
        {
            this.adresseMail = adresseMail;
            this.dateFrais = dateFrais;
            this.idMotif = idMotif;
            this.trajet = trajet;
            this.km = km;
            this.coutPeage = coutPeage;
            this.coutRepas = coutRepas;
            this.coutHeberge = coutHeberge;
            this.kmOk = kmOk;
            this.coutPeageOk = coutPeageOk;
            this.coutRepasOk = coutRepasOk;
            this.coutHebergeOk = coutHebergeOk;
            this.total = total;
            this.ligneValider = ligneValider;
            this.numClub = numClub;
        }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public LigneFrais()
        {

        }
    }
}

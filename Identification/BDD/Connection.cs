using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Using pour la base de données (utilisation des references mysql.data et mysql.web)
using MySql.Data.MySqlClient;

namespace Identification.BDD
{
    public static class Connection
    {
        private static MySqlConnection connect;

        /// <summary>
        /// Connexion a la base de donnée MYSQL
        /// </summary>
        public static void Init()
        {
            connect = new MySqlConnection
            {
                //ConnectionString = "SERVER =172.16.106.4; DATABASE=FREDI; UID=william; PASSWORD=3568" ou 1234/151292
                //ConnectionString = "SERVER=172.16.106.4; DATABASE=FREDI; UID=loic; PASSWORD=3568"
            };
        }

        /// <summary>
        /// Connexion a l'application
        /// </summary>
        /// <param name="login">login de connexion</param>
        /// <param name="mdp">mot de passe de connexion</param>
        /// <returns>un boolean</returns>
        public static bool MdpConnection(string login, string mdp)
        {
            bool mdpOk = false;

            // Ouverture de la connexion à la base de données
            connect.Open();

            // Création de la requête 
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select PSWTRESO " +
                "from CLUBS " +
                "where NUMERO_LICENCE = '" + login + "'";

            // Execution de la requête
            MySqlDataReader reader = cmd.ExecuteReader();

            // Lecture des resultats
            while (reader.Read())
            {
                if ((string)reader["PSWTRESO"] == mdp)
                {
                    mdpOk = true;
                }
            }

            // Fermeture de la connexion et retourne un booléen
            connect.Close();
            return mdpOk;
        }

        /// <summary>
        /// Recherche tout les demandeurs
        /// </summary>
        /// <returns>List de demmandeur</returns>
        public static List<Demandeurs> GetLesDemandeur()
        {
            List<Demandeurs> lesDemandeur = new List<Demandeurs>();

            // Ouverture de la connexion à la base de données
            connect.Open();

            // Création de la requête
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from DEMANDEURS";

            // Execution de la requête
            MySqlDataReader reader = cmd.ExecuteReader();

            // Lecture des resultats
            while (reader.Read())
            {
                Demandeurs unDemandeur = new Demandeurs
                {
                    AdresseMail = (string)reader["ADRESSE_MAIL"],
                    Nom = (string)reader["NOM"],
                    Prenom = (string)reader["PRENOM"],
                    Rue = (string)reader["RUE"],
                    Cp = (string)reader["CP"],
                    Ville = (string)reader["VILLE"],
                    Password = (string)reader["PASSWORD"],
                    NumRecu = (string)reader["NUM_RECU"]
                };

                lesDemandeur.Add(unDemandeur);
            }

            // Fermeture de la connexion
            connect.Close();

            return lesDemandeur;
        }

        /// <summary>
        /// Recherche toute les lignes de frais
        /// </summary>
        /// <returns>Liste contenant les lignes de frais</returns>
        public static List<LigneFrais> GetLigneFrais()
        {
            List<LigneFrais> lesLignes = new List<LigneFrais>();

            // Ouverture de la connexion à la base de données
            connect.Open();

            // Création de la requête
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from LIGNES_FRAIS";

            // Execution de la requête
            MySqlDataReader reader = cmd.ExecuteReader();

            // Lecture des informations
            while (reader.Read())
            {
                LigneFrais uneLigne = new LigneFrais
                {
                    AdresseMail = (string)reader["ADRESSE_MAIL"],
                    DateFrais = (DateTime)reader["DATE_FRAIS"],
                    IdMotif = (Int64)reader["ID_MOTIF"],
                    Trajet = (string)reader["TRAJET"],
                    Km = (Int64)reader["KM"],
                    CoutPeage = (decimal)reader["COUT_PEAGE"],
                    CoutRepas = (decimal)reader["COUT_REPAS"],
                    CoutHeberge = (decimal)reader["COUT_HEBERGEMENT"],
                    KmOk = (Int64)reader["KM_VALIDE"],
                    CoutPeageOk = (decimal)reader["PEAGE_VALIDE"],
                    CoutRepasOk = (decimal)reader["REPAS_VALIDE"],
                    CoutHebergeOk = (decimal)reader["HEBERGEMENT_VALIDE"],
                    LigneValider = (bool)reader["LIGNEVALIDE"]
                };
                //uneLigne.NumClub = (string)reader["NUM_CLUB"];

                lesLignes.Add(uneLigne);
            }

            // Fermeture de la connexion
            connect.Close();

            return lesLignes;
        }

        /// <summary>
        /// Recherche tout les motifs
        /// </summary>
        /// <returns>Liste des motifs</returns>
        public static List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();

            // Ouverture de la connexion à la base de données
            connect.Open();

            // Création de la requête
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from MOTIFS";

            // Execution de la requête
            MySqlDataReader reader = cmd.ExecuteReader();

            // Lecture des informations
            while (reader.Read())
            {
                Motif unMotif = new Motif
                {
                    IdMotif = (Int64)reader["ID_MOTIF"],
                    Libelle = (string)reader["LIBELLE"]
                };

                lesMotifs.Add(unMotif);
            }

            // Fermeture de la connexion
            connect.Close();

            return lesMotifs;
        }

        /// <summary>
        /// Recherche toute les ligues
        /// </summary>
        /// <returns>List de ligue</returns>
        public static List<ligues> GetLesLigue()
        {
            List<ligues> lesLigues = new List<ligues>();

            // Ouverture de la connexion à la base de données
            connect.Open();

            // Création de la requête
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from LIGUES";

            // Execution de la requête
            MySqlDataReader reader = cmd.ExecuteReader();

            // Lecture des informations
            while (reader.Read())
            {
                ligues uneLigue = new ligues
                {
                    NumLigue = (string)reader["NUM_LIGUE"],
                    Nom = (string)reader["NOM"],
                    Sigle = (string)reader["SIGLE"],
                    President = (string)reader["PRESIDENT"]
                };

                lesLigues.Add(uneLigue);
            }

            // Fermeture de la connexion
            connect.Close();

            return lesLigues;
        }

        /// <summary>
        /// Recherche toute les clubs
        /// </summary>
        /// <returns>List de ligue</returns>
        public static List<Clubs> GetLesClubs()
        {
            List<Clubs> lesClubs = new List<Clubs>();

            // Ouverture de la connexion à la base de données
            connect.Open();

            // Création de la requête
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from CLUBS";

            // Execution de la requête
            MySqlDataReader reader = cmd.ExecuteReader();

            // Lecture des informations
            while (reader.Read())
            {
                Clubs unClubs = new Clubs
                {
                    NumClub = (string)reader["NUM_CLUB"],
                    NumLigue = (string)reader["NUM_LIGUE"],
                    NumeroLicence = (string)reader["NUMERO_LICENCE"],
                    PswTreso = (string)reader["PSWTRESO"],
                    NomClub = (string)reader["NOM_CLUB"],
                    Ville = (string)reader["NOM_CLUB"],
                    Cp = (string)reader["VILLE"],
                    Rue = (string)reader["RUE"]
                };

                lesClubs.Add(unClubs);
            }

            // Fermeture de la connexion
            connect.Close();

            return lesClubs;
        }

        /// <summary>
        /// Nombre de demande en fonction d'un demandeur
        /// </summary>
        /// <param name="mail">mail du demandeur</param>
        /// <returns></returns>
        public static Int64 NbDemande(string mail)
        {
            Int64 nbDem = 0;

            // Ouverture de la connexion à la base de données
            connect.Open();

            // Création de la requête
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select count(ADRESSE_MAIL) " +
                "from LIGNES_FRAIS " +
                "where ADRESSE_MAIL = '" + mail + "'";

            // Execution de la requête
            MySqlDataReader reader = cmd.ExecuteReader();

            // Lecture des informations
            while (reader.Read())
            {
                nbDem = (Int64)reader[0];
            }

            // Fermeture de la connexion
            connect.Close();

            return nbDem;
        }

        /// <summary>
        /// met a jour un ligne de frais
        /// </summary>
        /// <param name="kmParcourue">km validé</param>
        /// <param name="coutPeage">peage validé</param>
        /// <param name="coutRepas">repas validé</param>
        /// <param name="coutHeberge">hebergement validé</param>
        /// <param name="mail">mail du demandeur</param>
        /// <param name="date">date de la demande</param>
        /// <returns>le nombre de ligne mise a jours</returns>
        public static int ValidationLigneFrais(long kmParcourue, decimal coutPeage, decimal coutRepas, decimal coutHeberge, string mail, string date)
        {
            // Si il y a une date, alors on adapte en format MySql
            if (date != "")
                date = date.Substring(6, 4) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);

            // Ouverture de la connexion à la base de données
            connect.Open();

            // Création de la requête
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "update LIGNES_FRAIS " +
                "set KM_VALIDE = '" + kmParcourue + "', PEAGE_VALIDE = '" + coutPeage + "', REPAS_VALIDE = '" + coutRepas + "', HEBERGEMENT_VALIDE = '" + coutHeberge + "', LIGNEVALIDE = '1' " +
                "where ADRESSE_MAIL = '" + mail + "' and DATE_FRAIS = '" + date + "'";

            // Represente le nombre de ligne affecter et execution 
            int nbAJout = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            connect.Close();

            return nbAJout;
        }

        public static int AnnuleLigneFrais(string leMail, string laDate)
        {
            // Si il y a une date, alors on adapte en format MySql
            if (laDate != "")
                laDate = laDate.Substring(6, 4) + "-" + laDate.Substring(3, 2) + "-" + laDate.Substring(0, 2);

            // Ouverture de la connexion à la base de données
            connect.Open();

            // Création de la requête
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "update LIGNES_FRAIS " +
                "set LIGNEVALIDE = 0 " +
                "where ADRESSE_MAIL = '" + leMail + "' and DATE_FRAIS = '" + laDate + "'";

            // Represente le nombre de ligne affecter et execution 
            int nbAJout = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            connect.Close();

            return nbAJout;
        }
    }
}

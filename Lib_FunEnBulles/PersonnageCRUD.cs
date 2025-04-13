using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using lib_FunEnBulles;

namespace lib_FunEnBulles
{
    public class PersonnageCRUD
    {
        #region Propriétés
        private SQLiteConnection connection;
        #endregion
        #region Constructeurs
        /// <summary>
        /// Ingitialise une nouvelle instance de la classe PersonnageCRUD
        /// Elle dispose: d'un nom de base de données
        /// Elle créer une base de données
        /// Elle se connecte 
        /// Elle créer la table personnage si elle n'existe pas
        /// </summary>
        /// <param name="nomBdD">nom de la base de données</param>
        public PersonnageCRUD(string nomBdD)
        {
            connection = new SQLiteConnection("Data Source=" + nomBdD + ".sqlite;Version=3;");
            connection.Open();
            CreerTable();
        }
        #endregion
        #region Méthodes
        /// <summary>
        /// CreerTable permet de créer la table personnage si elle n'existe pas
        /// </summary>
        private void CreerTable()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS personnage" +
                "(PersonnageNum INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                " PersonnageNom TEXT NOT NULL," +
                " PersonnageInspiration TEXT NOT NULL," +
                " PersonnageImage TEXT DEFAULT NULL," +
                " PersonnageSexe TEXT NOT NULL," +
                " PersonnageNationalite TEXT DEFAULT NULL," +
                " PersonnageTitre TEXT DEFAULT NULL," +
                " PersonnageNomAnglais TEXT DEFAULT NULL," +
                " PersonnageNomAllemand TEXT DEFAULT NULL)";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// PersonnageExiste permets de vérifier si 
        /// un personnage existe déjà dans la table table personnage
        /// </summary>
        /// <param name="Personnage">Personnage à vérifier</param>
        /// <returns>False si pas trouvé, true sinon</returns>
        public bool PersonnageExiste(Personnage Personnage)
        {
            string query = "SELECT PersonnageNum " +
                "FROM Personnage " +
                "WHERE PersonnageNom = @PersonnageNom";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@PersonnageNom", Personnage.PersonnageNom);
            var result = command.ExecuteScalar();
            return result != null;
        }
        /// <summary>
        /// AjouterPersonnage permet d'ajouter un Personnage s'il n'existe pas déjà à la table personnage
        /// Elle dispose d'un personnage
        /// </summary>
        /// <param name="Personnage"></param>
        public void AjouterPersonnage(Personnage personnage)
        {
            if (!PersonnageExiste(personnage))
            {
                //Ajouter dans la tabe un enregistrement            
                string query = "INSERT INTO personnage(" +
                    "PersonnageNom, PersonnageInspiration, PersonnageImage, " +
                    "PersonnageSexe, PersonnageNationalite, PersonnageTitre, " +
                    "PersonnageNomAnglais, PersonnageNomAllemand) " +
                    "VALUES(@PersonnageNom, @PersonnageInspiration, @PersonnageImage, " +
                    "@PersonnageSexe, @PersonnageNationalite, @PersonnageTitre, " +
                    "@PersonnageNomAnglais, @PersonnageNomAllemand)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@PersonnageNom", personnage.PersonnageNom);
                command.Parameters.AddWithValue("@PersonnageInspiration", personnage.PersonnageInspiration);
                command.Parameters.AddWithValue("@PersonnageImage", personnage.PersonnageImage);
                command.Parameters.AddWithValue("@PersonnageSexe", personnage.PersonnageSexe);
                command.Parameters.AddWithValue("@PersonnageNationalite", personnage.PersonnageNationalite);
                command.Parameters.AddWithValue("@PersonnageTitre", personnage.PersonnageTitre);
                command.Parameters.AddWithValue("@PersonnageNomAnglais", personnage.PersonnageNomAnglais);
                command.Parameters.AddWithValue("@PersonnageNomAllemand", personnage.PersonnageNomAllemand);
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// ModifierPersonnage permet de modifier un Personnage s'il existe déjàde la table personnage
        /// Elle dispose d'un Personnage
        /// </summary>
        /// <param name="personnage">Personnage selectionné</param>
        public void ModifierPersonnage(Personnage personnage)
        {
            if (PersonnageExiste(personnage))
            {
                //Modifie un enregistrement
                string query = "UPDATE personnage SET " +
                    "PersonnageNom = @PersonnageNom, " +
                    "PersonnageInspiration = @PersonnageInspiration, " +
                    "PersonnageImage = @PersonnageImage, " +
                    "PersonnageSexe = @PersonnageSexe, " +
                    "PersonnageNationalite = @PersonnageNationalite, " +
                    "PersonnageTitre = @PersonnageTitre, " +
                    "PersonnageNomAnglais = @PersonnageNomAnglais, " +
                    "PersonnageNomAllemand = @PersonnageNomAllemand " +
                    "WHERE PersonnageNum = @PersonnageNum";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@PersonnageNom", personnage.PersonnageNom);
                command.Parameters.AddWithValue("@PersonnageInspiration", personnage.PersonnageInspiration);
                command.Parameters.AddWithValue("@PersonnageImage", personnage.PersonnageImage);
                command.Parameters.AddWithValue("@PersonnageSexe", personnage.PersonnageSexe);
                command.Parameters.AddWithValue("@PersonnageNationalite", personnage.PersonnageNationalite);
                command.Parameters.AddWithValue("@PersonnageTitre", personnage.PersonnageTitre);
                command.Parameters.AddWithValue("@PersonnageNomAnglais", personnage.PersonnageNomAnglais);
                command.Parameters.AddWithValue("@PersonnageNomAllemand", personnage.PersonnageNomAllemand);
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// SupprimerPersonnage permet de supprimer un Personnage s'il existe et qu'il n'est pas null de la table Personnage
        /// </summary>
        /// <param name="personnage">Personnage selectionner</param>
        public void SupprimerPersonnage(Personnage personnage)
        {
            if (personnage != null && PersonnageExiste(personnage))
            {
                //Supprime un enregistrement
                string query = "DELETE FROM personnage " +
                        "WHERE PersonnageNum = @PersonnageNum";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@PersonnageNum", personnage.PersonnageNum);
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Retourne la liste de tous les Personnages dans la base.
        /// </summary>
        public List<Personnage> ListerPersonnages()
        {
            List<Personnage> ListePersonnages = new List<Personnage>();
            string query = "SELECT * FROM personnage";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Personnage personnage = new Personnage(
                        Convert.ToInt16(reader["PersonnageNum"]),
                        reader["PersonnageNom"].ToString(),
                        reader["PersonnageInspiration"].ToString(),
                        reader["PersonnageImage"].ToString(),
                        reader["PersonnageSexe"].ToString(),
                        reader["PersonnageNationalite"].ToString(),
                        reader["PersonnageTitre"].ToString(),
                        reader["PersonnageNomAnglais"].ToString(),
                        reader["PersonnageNomAllemand"].ToString()
                    );
                    ListePersonnages.Add(personnage);
                }
            }
            return ListePersonnages;
        }
        #endregion
    }
}

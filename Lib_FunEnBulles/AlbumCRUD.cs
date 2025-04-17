using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Net.Mime.MediaTypeNames;

namespace lib_FunEnBulles
{
    /// <summary>
    /// Cette classe représante la gestion de la bdd 
    /// Elle permet de:
    /// Créer des tables
    /// Lister des albums
    /// Ajouter des albums
    /// Modifier des albums
    /// Supprimer des albums
    /// </summary>
    public class AlbumCRUD
    {
        #region Propriétés
        /// <summary>
        /// Connection à SQLite
        /// </summary>
        private SQLiteConnection connection;
        #endregion
        #region Constructeurs
        /// <summary>
        /// Ingitialise une nouvelle instance de la classe AlbumCRUD
        /// Elle dispose: d'un nom de base de données
        /// Elle créer une base de données
        /// Elle se connecte 
        /// Elle créer la table album si elle n'existe pas
        /// </summary>
        /// <param name="nomBdD">nom de la base de données</param>
        public AlbumCRUD(string nomBdD)
        {
            connection = new SQLiteConnection("Data Source=" + nomBdD + ".sqlite;Version=3;");
            connection.Open();
            SupprimerTable();
            CreerTable();
        }
        #endregion
        #region Méthodes
        /// <summary>
        /// CreerTable permet de créer la table personnage si elle n'existe pas
        /// </summary>
        private void CreerTable()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS album " +
                "(AlbumNum INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                " AlbumImage TEXT NOT NULL," +
                " AlbumTitre TEXT NOT NULL," +
                " AlbumIsbn TEXT UNIQUE NOT NULL," +
                " AlbumAnnee INTEGER NOT NULL," +
                " AlbumEdition TEXT NOT NULL)";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
            RemplirBdd();
        }
        /// <summary>
        /// RemplirBdd permets de remplir la bdd avec les données fourni
        /// </summary>
        private void RemplirBdd()
        {
            string checkTableVide = "SELECT COUNT(*) FROM album";
            SQLiteCommand commandCheck = new SQLiteCommand(checkTableVide, connection);
            int rowCount = Convert.ToInt32(commandCheck.ExecuteScalar());

            if (rowCount == 0)
            {
                // Appelle ta méthode pour remplir la BDD
                string remplirTableQuery = "INSERT INTO `album` (`AlbumNum`, `AlbumIsbn`, `AlbumTitre`, `AlbumAnnee`, `AlbumEdition`, `AlbumImage`) " +
                    "VALUES (1, '9782012101333', 'Astérix le Gaulois', 1961, 'Hachette', 'asterix_01'), (2, '9782012101340', 'La Serpe d''Or', 1962, 'Hachette', 'asterix_02'), (3, '9782012101357', 'Astérix et les Goths', 1963, 'Hachette', 'asterix_03'), (4, '9782012101367', 'Astérix Gladiateur', 1964, 'Hachette', 'asterix_04'), (5, '9782012101371', 'Le Tour de Gaule d''Astérix', 1965, 'Hachette', 'asterix_05'), (6, '9782012101388', 'Astérix et Cléopâtre', 1965, 'Hachette', 'asterix_06'), (7, '9782012101395', 'Le Combat des chefs', 1966, 'Hachette', 'asterix_07'), (8, '9782012101401', 'Astérix chez les Bretons', 1966, 'Hachette', 'asterix_08'), (9, '9782012101418', 'Astérix chez les Normands', 1967, 'Hachette', 'asterix_09'), (10, '9782012101425', 'Astérix Légionnaire', 1967, 'Hachette', 'asterix_10'), (11, '9782012101437', 'Le Bouclier Arverne', 1968, 'Hachette', 'asterix_11'), (12, '9782012101449', 'Astérix aux jeux Olympiques', 1968, 'Hachette', 'asterix_12'), (13, '9782012101456', 'Astérix et le chaudron', 1969, 'Hachette', 'asterix_13'), (14, '9782012101463', 'Astérix en Hispanie', 1969, 'Hachette', 'asterix_14'), (15, '9782012101470', 'La Zizanie', 1970, 'Hachette', 'asterix_15'), (16, '9782012101487', 'Astérix chez les Helvètes', 1970, 'Hachette', 'asterix_16'), (17, '9782012101494', 'Le Domaine des Dieux', 1971, 'Hachette', 'asterix_17'), (18, '9782012101500', 'Les Lauriers de César', 1972, 'Hachette Livre', 'asterix_18'), (19, '9782012101517', 'Le Devin', 1972, 'Hachette', 'asterix_19'), (20, '9782012101524', 'Astérix en Corse', 1973, 'Hachette', 'asterix_20'), (21, '9782012101531', 'Le Cadeau de César', 1974, 'Hachette', 'asterix_21'), (22, '9782012101548', 'La Grande Traversée', 1975, 'Hachette', 'asterix_22'), (23, '9782012101555', 'Obélix et Compagnie', 1976, 'Hachette', 'asterix_23'), (24, '9782012101562', 'Astérix Chez les Belges', 1979, 'Hachette', 'asterix_24'), (25, '9782864970002', 'Le Grand Fossé', 1980, 'Albert René', 'asterix_25'), (26, '9782864970040', 'L''Odyssée d''Astérix', 1981, 'Albert René', 'asterix_26'), (27, '9782864970118', 'Le Fils d''Astérix', 1983, 'Albert René', 'asterix_27'), (28, '9782864970200', 'Astérix chez Rahazade', 1987, 'Albert René', 'asterix_28'), (29, '9782864970538', 'La Rose et le Glaive', 1991, 'Albert René', 'asterix_29'), (30, '9782864970965', 'La Galère d''Obélix', 1996, 'Albert René', 'asterix_30'), (31, '9782864971436', 'Astérix et Latraviata', 2001, 'Albert René', 'asterix_31'), (32, '9782864971535', 'Astérix la rentrée Gauloise', 2003, 'Albert René', 'asterix_32'), (33, '9782864971702', 'Le Ciel lui tombe sur la tête', 2005, 'Albert René', 'asterix_33'), (34, '9782864972303', 'L''anniversaire d''Astérix et Obélix', 2009, 'Albert René', 'asterix_34'), (35, '9782864972662', 'Astérix chez les Pictes', 2013, 'Editions Albert René', 'asterix_35'), (36, '9782864972716', 'Le Papyrus de César', 2015, 'Editions Albert René', 'asterix_36'), (37, '9782864973270', 'Astérix et la Transitalique', 2017, 'Editions Albert René', 'asterix_37'), (38, '9782864973423', 'La Fille de Vercingétorix', 2019, 'Éditions Albert René', 'asterix_38'), (39, '9782864973492', 'Astérix et le Griffon', 2021, 'Éditions Albert René', 'asterix_39'), (40, '9782014001334', 'L’Iris blanc', 2023, 'Éditions Albert René', 'asterix_40');";
                SQLiteCommand commandRemplir = new SQLiteCommand(remplirTableQuery, connection);
                commandRemplir.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// AlbumExiste permets de vérifier si 
        /// un album existe déjà dans la table table album
        /// </summary>
        /// <param name="album">Album à vérifier</param>
        /// <returns>False si pas trouvé, true sinon</returns>
        public bool AlbumExiste(Album album)
        {
            string query = "SELECT * " +
                "FROM album " +
                "WHERE AlbumNum = @AlbumNum";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@AlbumNum", album.AlbumNum);
            var result = command.ExecuteScalar();
            return result != null;
        }
        /// <summary>
        /// AjouterAlbum permet d'ajouter un album s'il n'existe pas déjà à la table album
        /// Elle dispose d'un album
        /// </summary>
        /// <param name="album"></param>
        public void AjouterAlbum(Album album)
        {
            if (!AlbumExiste(album))
            {
                //Ajouter dans la tabe un enregistrement            
                string query = "INSERT INTO `album` (`AlbumIsbn`, `AlbumTitre`, `AlbumAnnee`, `AlbumEdition`, `AlbumImage`)" +
                          "VALUES (@AlbumIsbn, @AlbumTitre, @AlbumAnnee, @AlbumEdition, @AlbumImage);";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@AlbumIsbn", album.AlbumIsbn);
                command.Parameters.AddWithValue("@AlbumTitre", album.AlbumTitre);
                command.Parameters.AddWithValue("@AlbumAnnee", album.AlbumAnnee);
                command.Parameters.AddWithValue("@AlbumEdition", album.AlbumEdition);
                command.Parameters.AddWithValue("@AlbumImage", album.AlbumImage);
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// ModifierAlbum permet de modifier un album s'il existe déjàde la table album
        /// Elle dispose d'un album
        /// </summary>
        /// <param name="album">Album selectionner</param>
        public void ModifierAlbum(Album album)
        {
            if (AlbumExiste(album))
            {
                //Modifie un enregistrement
                string query = "UPDATE album SET " +
                    " AlbumIsbn = @AlbumIsbn, " +
                    " AlbumTitre = @AlbumTitre, " +
                    " AlbumAnnee = @AlbumAnnee, " +
                    " AlbumEdition = @AlbumEdition, " +
                    " AlbumImage = @AlbumImage " +
                    " WHERE AlbumNum = @AlbumNum";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@AlbumIsbn", album.AlbumIsbn);
                command.Parameters.AddWithValue("@AlbumTitre", album.AlbumTitre);
                command.Parameters.AddWithValue("@AlbumAnnee", album.AlbumAnnee);
                command.Parameters.AddWithValue("@AlbumEdition", album.AlbumEdition);
                command.Parameters.AddWithValue("@AlbumImage", album.AlbumImage);
                command.Parameters.AddWithValue("@AlbumNum", album.AlbumNum);
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// SupprimerAlbum permet de supprimer un album s'il existe et qu'il n'est pas null de la table album
        /// </summary>
        /// <param name="album">Album selectionner</param>
        public void SupprimerAlbum(Album album)
        {
            if (album != null && AlbumExiste(album))
            {
                //Supprime un enregistrement
                string query = "DELETE FROM album " +
                        "WHERE AlbumNum = @AlbumNum ";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@AlbumNum", album.AlbumNum);
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Retourne la liste de tous les albums dans la base.
        /// </summary>
        public List<Album> ListerAlbums(string filtre="")
        {
            List<Album> albums = new List<Album>();
            string query = "SELECT * FROM album " +
                "WHERE AlbumIsbn LIKE @filtre " +
                "OR AlbumTitre LIKE @filtre " +
                "OR AlbumAnnee LIKE @filtre " +
                "OR AlbumEdition LIKE @filtre ";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@filtre", "%" + filtre + "%");
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album album = new Album(
                        Convert.ToInt32(reader["AlbumNum"]),
                        reader["AlbumIsbn"].ToString(),
                        reader["AlbumTitre"].ToString(),
                        Convert.ToInt32(reader["AlbumAnnee"]),
                        reader["AlbumEdition"].ToString(),
                        reader["AlbumImage"].ToString()
                    );
                    albums.Add(album);
                }
            }
            return albums;
        }

        /// <summary>
        /// Permet de supprimr la table album si elle existe
        /// </summary>
        private void SupprimerTable()
        {
            string dropTableQuery = "DROP TABLE IF EXISTS album";
            SQLiteCommand command = new SQLiteCommand(dropTableQuery, connection);

            command.ExecuteNonQuery();
            
        }

        #endregion
    }
}

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
            CreerTable();
        }
        #endregion
        #region Méthodes
        /// <summary>
        /// CreerTable permet de créer la table album si elle n'existe pas
        /// </summary>
        private void CreerTable()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS album" +
                "(AlbumNum INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                " AlbumIsbn TEXT UNIQUE NOT NULL," +
                " AlbumTitre TEXT NOT NULL," +
                " AlbumAnnee INTEGER NOT NULL," +
                " AlbumEdition TEXT NOT NULL," +
                " AlbumImage TEXT NOT NULL)";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// AlbumExiste permets de vérifier si 
        /// un album existe déjà dans la table table album
        /// </summary>
        /// <param name="album">Album à vérifier</param>
        /// <returns>False si pas trouvé, true sinon</returns>
        public bool AlbumExiste(Album album)
        {
            string query = "SELECT AlbumNum " +
                "FROM album " +
                "WHERE AlbumTitre = @AlbumTitre";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@AlbumTitre", album.AlbumTitre);
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
                          " VALUES(@AlbumIsbn, @AlbumTitre, @AlbumAnnee, @AlbumEdition, @AlbumImage)";
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
                string query = "UPDATE album SET" +
                    " AlbumIsbn = @AlbumIsbn," +
                    " AlbumTitre = @AlbumTitre," +
                    " AlbumAnnee = @AlbumAnnee," +
                    " AlbumEdition = @AlbumEdition," +
                    " AlbumImage = @AlbumImage" +
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
                        "WHERE AlbumNum = @AlbumNum";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@AlbumNum", album.AlbumNum);
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Retourne la liste de tous les albums dans la base.
        /// </summary>
        public List<Album> ListerAlbums()
        {
            List<Album> albums = new List<Album>();
            string query = "SELECT * FROM album";
            SQLiteCommand command = new SQLiteCommand(query, connection);
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
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using lib_FunEnBulles;

namespace lib_FunEnBulles
{

    /// <summary>
    /// Cette classe représante la gestion de la bdd 
    /// Elle permet de:
    /// Créer une table apparaitreAlbum
    /// Lister des albums ainsi que les perosnnages présent dans l'album
    /// Ajouter des personnages à un album
    /// Supprimer des albums
    /// Supprimer la présence de perosnnages d'un album
    /// </summary>
    public class PersonnageAlbumCRD
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
        public PersonnageAlbumCRD(string nomBdD)
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
            string createTableQuery = "CREATE TABLE IF NOT EXISTS apparaitreAlbum " +
                "(NumPersonnage INTEGER NOT NULL, " +
                "NumAlbum INTEGER NOT NULL, " +
                "PRIMARY KEY (NumPersonnage, NumAlbum), " +
                "FOREIGN KEY (NumPersonnage) REFERENCES personnage(PersonnageNum) ON DELETE CASCADE ON UPDATE CASCADE, " +
                "FOREIGN KEY (NumAlbum) REFERENCES album(AlbumNum) ON DELETE CASCADE ON UPDATE CASCADE);"
                ;
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
            RemplirBdd();
        }
        /// <summary>
        /// RemplirBdd permets de remplir la bdd avec les données fourni
        /// </summary>
        private void RemplirBdd()
        {
            string checkTableVide = "SELECT COUNT(*) FROM apparaitreAlbum";
            SQLiteCommand commandCheck = new SQLiteCommand(checkTableVide, connection);
            int rowCount = Convert.ToInt32(commandCheck.ExecuteScalar());

            if (rowCount == 0)
            {
                // Appelle ta méthode pour remplir la BDD
                string remplirTableQuery = "INSERT INTO `apparaitreAlbum` (`NumPersonnage`, `NumAlbum`) " +
                "VALUES (3, 1), (43, 1), (50, 1), (52, 1), (62, 1), (63, 1), (80, 1), (85, 1), (127, 1), (154, 1), (156, 1), (159, 1), (165, 1), (190, 1), (191, 1), (201, 1), (204, 1), (211, 1), (221, 1), (230, 1), (43, 2), (47, 2), (50, 2), (52, 2), (54, 2), (76, 2), (80, 2), (85, 2), (124, 2), (187, 2), (194, 2), (230, 2), (6, 3), (7, 3), (8, 3), (11, 3), (16, 3), (22, 3), (27, 3), (28, 3), (30, 3), (32, 3), (36, 3), (37, 3), (43, 3), (50, 3), (52, 3), (55, 3), (65, 3), (80, 3), (85, 3), (88, 3), (93, 3), (120, 3), (144, 3), (145, 3), (148, 3), (161, 3), (164, 3), (209, 3), (230, 3), (239, 3), (2, 4), (3, 4), (12, 4), (39, 4), (43, 4), (50, 4), (52, 4), (75, 4), (80, 4), (85, 4), (86, 4), (119, 4), (121, 4), (142, 4), (153, 4), (169, 4), (189, 4), (204, 4), (217, 4), (220, 4), (230, 4), (2, 5), (3, 5), (13, 5), (39, 5), (43, 5), (50, 5), (52, 5), (56, 5), (61, 5), (62, 5), (64, 5), (68, 5), (78, 5), (80, 5), (82, 5), (85, 5), (91, 5), (114, 5), (115, 5), (118, 5), (119, 5), (132, 5), (155, 5), (163, 5), (167, 5), (176, 5), (183, 5), (184, 5), (198, 5), (200, 5), (210, 5), (212, 5), (230, 5), (237, 5), (1, 6), (3, 6), (5, 6), (13, 6), (14, 6), (23, 6), (24, 6), (38, 6), (39, 6), (40, 6), (43, 6), (50, 6), (52, 6), (62, 6), (80, 6), (85, 6), (110, 6), (123, 6), (126, 6), (183, 6), (204, 6), (230, 6), (43, 7), (48, 7), (50, 7), (51, 7), (52, 7), (57, 7), (59, 7), (60, 7), (80, 7), (85, 7), (125, 7), (162, 7), (183, 7), (205, 7), (230, 7), (268, 7), (2, 8), (3, 8), (18, 8), (39, 8), (41, 8), (43, 8), (50, 8), (52, 8), (62, 8), (80, 8), (85, 8), (183, 8), (204, 8), (230, 8), (289, 8), (290, 8), (3, 9), (4, 9), (10, 9), (26, 9), (35, 9), (43, 9), (50, 9), (52, 9), (62, 9), (72, 9), (80, 9), (85, 9), (160, 9), (183, 9), (230, 9), (240, 9), (253, 9), (304, 9), (2, 10), (3, 10), (9, 10), (39, 10), (43, 10), (50, 10), (52, 10), (62, 10), (69, 10), (80, 10), (85, 10), (95, 10), (147, 10), (183, 10), (204, 10), (230, 10), (247, 10), (259, 10), (43, 11), (46, 11), (50, 11), (52, 11), (58, 11), (62, 11), (67, 11), (80, 11), (85, 11), (90, 11), (139, 11), (151, 11), (183, 11), (204, 11), (207, 11), (216, 11), (230, 11), (2, 12), (3, 12), (39, 12), (43, 12), (45, 12), (50, 12), (52, 12), (58, 12), (62, 12), (80, 12), (85, 12), (183, 12), (193, 12), (230, 12), (280, 12), (299, 12), (300, 12), (2, 13), (3, 13), (39, 13), (43, 13), (45, 13), (50, 13), (52, 13), (58, 13), (62, 13), (79, 13), (80, 13), (85, 13), (183, 13), (230, 13), (250, 13), (251, 13), (2, 14), (3, 14), (33, 14), (39, 14), (43, 14), (45, 14), (50, 14), (52, 14), (58, 14), (62, 14), (74, 14), (80, 14), (83, 14), (85, 14), (158, 14), (183, 14), (195, 14), (199, 14), (204, 14), (218, 14), (222, 14), (228, 14), (230, 14), (2, 15), (3, 15), (39, 15), (43, 15), (45, 15), (50, 15), (52, 15), (58, 15), (62, 15), (74, 15), (80, 15), (83, 15), (85, 15), (107, 15), (171, 15), (183, 15), (185, 15), (186, 15), (204, 15), (208, 15), (215, 15), (220, 15), (230, 15), (42, 16), (43, 16), (45, 16), (50, 16), (52, 16), (62, 16), (80, 16), (83, 16), (85, 16), (116, 16), (117, 16), (183, 16), (188, 16), (230, 16), (2, 17), (3, 17), (39, 17), (43, 17), (45, 17), (50, 17), (52, 17), (58, 17), (62, 17), (74, 17), (80, 17), (83, 17), (85, 17), (137, 17), (183, 17), (185, 17), (202, 17), (204, 17), (230, 17), (302, 17), (39, 18), (43, 18), (50, 18), (52, 18), (58, 18), (73, 18), (80, 18), (183, 18), (204, 18), (230, 18), (274, 18), (275, 18), (2, 19), (3, 19), (39, 19), (43, 19), (45, 19), (50, 19), (52, 19), (58, 19), (62, 19), (73, 19), (74, 19), (80, 19), (83, 19), (85, 19), (89, 19), (183, 19), (185, 19), (186, 19), (204, 19), (220, 19), (230, 19), (264, 19), (2, 20), (3, 20), (18, 20), (25, 20), (33, 20), (39, 20), (41, 20), (43, 20), (45, 20), (46, 20), (50, 20), (52, 20), (56, 20), (58, 20), (61, 20), (62, 20), (64, 20), (74, 20), (80, 20), (83, 20), (85, 20), (86, 20), (129, 20), (183, 20), (185, 20), (186, 20), (214, 20), (228, 20), (230, 20), (234, 20), (297, 20), (298, 20), (43, 21), (45, 21), (50, 21), (52, 21), (58, 21), (62, 21), (74, 21), (80, 21), (83, 21), (84, 21), (85, 21), (96, 21), (183, 21), (185, 21), (186, 21), (204, 21), (230, 21), (267, 21), (271, 21), (2, 22), (3, 22), (19, 22), (39, 22), (43, 22), (45, 22), (50, 22), (52, 22), (62, 22), (80, 22), (83, 22), (85, 22), (183, 22), (224, 22), (226, 22), (230, 22), (231, 22), (235, 22), (43, 23), (45, 23), (50, 23), (52, 23), (58, 23), (62, 23), (74, 23), (80, 23), (83, 23), (85, 23), (106, 23), (128, 23), (141, 23), (183, 23), (185, 23), (204, 23), (230, 23), (241, 23), (242, 23), (243, 23), (245, 23), (2, 24), (3, 24), (15, 24), (39, 24), (43, 24), (45, 24), (50, 24), (52, 24), (58, 24), (62, 24), (80, 24), (83, 24), (85, 24), (183, 24), (204, 24), (225, 24), (230, 24), (258, 24), (259, 24), (260, 24), (261, 24), (288, 24), (3, 25), (43, 25), (44, 25), (45, 25), (49, 25), (50, 25), (52, 25), (58, 25), (62, 25), (66, 25), (70, 25), (80, 25), (83, 25), (85, 25), (92, 25), (94, 25), (183, 25), (230, 25), (266, 25), (270, 25), (2, 26), (3, 26), (12, 26), (39, 26), (43, 26), (45, 26), (50, 26), (52, 26), (62, 26), (80, 26), (83, 26), (85, 26), (97, 26), (131, 26), (183, 26), (204, 26), (230, 26), (2, 27), (3, 27), (5, 27), (39, 27), (43, 27), (45, 27), (50, 27), (52, 27), (58, 27), (62, 27), (74, 27), (80, 27), (83, 27), (85, 27), (112, 27), (183, 27), (185, 27), (186, 27), (204, 27), (213, 27), (220, 27), (230, 27), (233, 27), (244, 27), (2, 28), (3, 28), (20, 28), (21, 28), (31, 28), (39, 28), (43, 28), (45, 28), (50, 28), (52, 28), (58, 28), (62, 28), (80, 28), (83, 28), (85, 28), (183, 28), (185, 28), (204, 28), (229, 28), (230, 28), (2, 29), (3, 29), (39, 29), (43, 29), (45, 29), (50, 29), (52, 29), (58, 29), (62, 29), (74, 29), (77, 29), (80, 29), (83, 29), (85, 29), (183, 29), (185, 29), (186, 29), (204, 29), (230, 29), (2, 30), (3, 30), (5, 30), (17, 30), (18, 30), (34, 30), (39, 30), (43, 30), (45, 30), (50, 30), (52, 30), (58, 30), (62, 30), (69, 30), (80, 30), (83, 30), (85, 30), (109, 30), (183, 30), (185, 30), (204, 30), (230, 30), (2, 31), (3, 31), (39, 31), (43, 31), (45, 31), (50, 31), (52, 31), (53, 31), (58, 31), (62, 31), (69, 31), (71, 31), (80, 31), (81, 31), (83, 31), (85, 31), (87, 31), (95, 31), (108, 31), (183, 31), (185, 31), (204, 31), (206, 31), (230, 31), (247, 31), (277, 31), (43, 32), (45, 32), (50, 32), (52, 32), (53, 32), (58, 32), (62, 32), (69, 32), (71, 32), (74, 32), (80, 32), (81, 32), (83, 32), (85, 32), (87, 32), (183, 32), (185, 32), (186, 32), (204, 32), (230, 32), (236, 32), (255, 32), (2, 33), (3, 33), (43, 33), (45, 33), (50, 33), (52, 33), (58, 33), (62, 33), (74, 33), (80, 33), (83, 33), (85, 33), (183, 33), (185, 33), (230, 33), (2, 34), (3, 34), (5, 34), (12, 34), (15, 34), (18, 34), (20, 34), (24, 34), (25, 34), (26, 34), (31, 34), (33, 34), (39, 34), (43, 34), (45, 34), (46, 34), (48, 34), (50, 34), (52, 34), (58, 34), (59, 34), (62, 34), (69, 34), (71, 34), (72, 34), (73, 34), (74, 34), (76, 34), (77, 34), (80, 34), (83, 34), (85, 34), (89, 34), (93, 34), (95, 34), (107, 34), (137, 34), (183, 34), (185, 34), (186, 34), (192, 34), (193, 34), (204, 34), (230, 34), (2, 35), (3, 35), (32, 35), (39, 35), (43, 35), (45, 35), (50, 35), (52, 35), (58, 35), (74, 35), (80, 35), (83, 35), (85, 35), (183, 35), (185, 35), (186, 35), (204, 35), (223, 35), (230, 35), (232, 35), (246, 35), (292, 35), (293, 35), (294, 35), (295, 35), (296, 35), (2, 36), (3, 36), (32, 36), (39, 36), (43, 36), (45, 36), (50, 36), (52, 36), (58, 36), (74, 36), (80, 36), (83, 36), (85, 36), (181, 36), (182, 36), (183, 36), (185, 36), (186, 36), (204, 36), (230, 36), (238, 36), (248, 36), (262, 36), (263, 36), (265, 36), (283, 36), (301, 36), (303, 36), (2, 37), (39, 37), (43, 37), (45, 37), (50, 37), (52, 37), (80, 37), (85, 37), (180, 37), (183, 37), (197, 37), (203, 37), (204, 37), (230, 37), (252, 37), (276, 37), (291, 37), (249, 38), (256, 38), (257, 38), (269, 38), (278, 39), (281, 39), (282, 39), (285, 39), (286, 39), (287, 39), (305, 39), (306, 39), (254, 40), (272, 40), (273, 40);";
                SQLiteCommand commandRemplir = new SQLiteCommand(remplirTableQuery, connection);
                commandRemplir.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// PersonnageAlbumExiste permets de vérifier si 
        /// un personnage est présent dans un album.
        /// </summary>
        /// <param name="album">Album à vérifier</param>
        /// <param name="personnage">Personnage à vérifier</param>
        /// <returns>False si pas trouvé, true sinon</returns>
        public bool PersonnageAlbumExiste(Personnage personnage, Album album)
        {
            string query = "SELECT * " +
                "FROM apparaitreAlbum " +
                "WHERE NumPersonnage = @NumPersonnage " +
                "AND NumAlbum = @NumAlbum ";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@NumPersonnage", personnage.PersonnageNum);
            command.Parameters.AddWithValue("@NumAlbum", album.AlbumNum);
            var result = command.ExecuteScalar();
            return result != null;
        }
        /// <summary>
        /// ApparaitreAlbumExiste permet d'ajouter un personnage dans un album s'il n'existe pas déjà dans un album
        /// Elle dispose d'un album et d'un personnage
        /// </summary>
        /// <param name="personnage">Personnage à ajouter</param>
        /// <param name="album">Album dans lequel ajouter le perosnnage</param>
        public void AjouterPersonnageDansAlbum(Personnage personnage, Album album)
        {
            if (!PersonnageAlbumExiste(personnage, album))
            {
                //Ajouter dans la tabe un enregistrement            
                string query = "INSERT INTO `apparaitreAlbum` (`NumPersonnage`, `NumAlbum`)" +
                          "VALUES (@NumPersonnage, @NumAlbum);";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@NumPersonnage", personnage.PersonnageNum);
                command.Parameters.AddWithValue("@NumAlbum", album.AlbumNum);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// SupprimerPersonnageUnAlbum permet de supprimer un personnage d'un album s'il existe et qu'il n'est pas null de la table album
        /// </summary>
        /// <param name="personnage">Perosnnage a supprimer</param>
        /// <param name="album">Album selectionner</param>
        public void SupprimerPersonnageUnAlbum(Personnage personnage, Album album)
        {
            if (album != null && PersonnageAlbumExiste(personnage, album))
            {
                //Supprime un enregistrement
                string query = "DELETE FROM apparaitreAlbum " +
                        "WHERE NumAlbum = @NumAlbum " +
                        "AND NumPersonnage = @NumPersonnage";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@NumPersonnage", personnage.PersonnageNum);
                command.Parameters.AddWithValue("@NumAlbum", album.AlbumNum);
                command.ExecuteNonQuery();
            }
        }
        /// SupprimerAlbumsPersonnage permet de supprimer un album 
        /// et de dissocié les personnages de l'album puiqu'il est supprimer
        /// </summary>
        /// <param name="album">Album selectionner</param>
        public void SupprimerAlbumsPersonnage(Album album)
        {
            if (album != null)
            {
                //Supprime un enregistrement
                string query = "DELETE FROM apparaitreAlbum " +
                        "WHERE NumAlbum = @NumAlbum;";                        
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@NumAlbum", album.AlbumNum);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// SupprimerPersonnageDeTousLesAlbums permet de supprimer 
        /// un personnage de tous les albums de la table aparaitreAlbum s'il n'est pas null.
        /// </summary>
        /// <param name="personnage">Perosnnage a supprimer</param>
        public void SupprimerPersonnageDeTousLesAlbums(Personnage personnage)
        {
            if (personnage != null)
            {
                string query = "DELETE FROM apparaitreAlbum WHERE NumPersonnage = @NumPersonnage";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@NumPersonnage", personnage.PersonnageNum);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Retourne la liste de tous les personnes dans un album dans la table perosnnage en lien avec un album.
        /// </summary>
        public List<Personnage> ListerPersonnagesParAlbum(int numAlbum)
        {
            List<Personnage> personnages = new List<Personnage>();

            string query = "SELECT * FROM personnage " +
                           "INNER JOIN apparaitreAlbum ON personnage.PersonnageNum = apparaitreAlbum.NumPersonnage " +
                           "WHERE apparaitreAlbum.NumAlbum = @NumAlbum";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NumAlbum", numAlbum);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Personnage personnage = new Personnage(
                            Convert.ToInt32(reader["PersonnageNum"]),
                            reader["PersonnageNom"].ToString(),
                            reader["PersonnageInspiration"].ToString(),
                            reader["PersonnageSexe"].ToString(),
                            reader["PersonnageImage"].ToString(),
                            reader["PersonnageNationalite"].ToString(),
                            reader["PersonnageTitre"].ToString(),
                            reader["PersonnageNomAnglais"].ToString(),
                            reader["PersonnageNomAllemand"].ToString()
                        );

                        personnages.Add(personnage);
                    }
                }
            }

            return personnages;
        }

        /// <summary>
        /// Retourne la liste de tous les albums ou un perosnnages apparait dedans.
        /// </summary>
        public List<Album> ListerAlbumsParPersonnage(int numPersonnage)
        {
            List<Album> albums = new List<Album>();

            string query = "SELECT * FROM album " +
                           "INNER JOIN apparaitreAlbum ON album.AlbumNum = apparaitreAlbum.NumAlbum " +
                           "WHERE apparaitreAlbum.NumPersonnage = @NumPersonnage";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NumPersonnage", numPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Album album = new Album(
                            Convert.ToInt32(reader["AlbumNum"]),
                            reader["AlbumIsbn"].ToString(),
                            reader["AlbumTitre"].ToString(),
                            Convert.ToInt32(reader["AlbumAnnee"].ToString()),
                            reader["AlbumEdition"].ToString(),
                            reader["AlbumImage"].ToString()
                        );

                        albums.Add(album);
                    }
                }
            }

            return albums;
        }
        /// <summary>
        /// ListerPersonnagesParAlbum retourne la liste de tous les perosnnages présent dans un album.
        /// </summary>
        /// <param name="numAlbum">numéro de l'album</param>
        /// <param name="filtre">saisie de l'utilisateur</param>
        /// <returns>La liste des perosnnages</returns>
        public List<Personnage> ListerPersonnagesParAlbum( int numAlbum, string filtre ="")
        {
            List<Personnage> personnages = new List<Personnage>();

            string query = "SELECT * FROM album " +
                "INNER JOIN apparaitreAlbum ON apparaitreAlbum.NumAlbum = album.AlbumNum " +
                "INNER JOIN personnage ON personnage.PersonnageNum = apparaitreAlbum.NumPersonnage " +
                "WHERE album.AlbumNum = @NumAlbum " +
                "AND (PersonnageNom LIKE @filtre " +
                "OR PersonnageInspiration LIKE @filtre " +
                "OR PersonnageSexe LIKE @filtre " +
                "OR PersonnageImage LIKE @filtre " +
                "OR PersonnageTitre LIKE @filtre " +
                "OR PersonnageNomAnglais LIKE @filtre " +
                "OR PersonnageNomAllemand LIKE @filtre);";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NumAlbum", numAlbum);
                command.Parameters.AddWithValue("@filtre", "%" + filtre + "%");

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Personnage personnage = new Personnage(
                            Convert.ToInt32(reader["PersonnageNum"]),
                            reader["PersonnageNom"].ToString(),
                            reader["PersonnageInspiration"].ToString(),
                            reader["PersonnageSexe"].ToString(),
                            reader["PersonnageImage"].ToString(),
                            reader["PersonnageNationalite"].ToString(),
                            reader["PersonnageTitre"].ToString(),
                            reader["PersonnageNomAnglais"].ToString(),
                            reader["PersonnageNomAllemand"].ToString()
                        );

                        personnages.Add(personnage);
                    }
                }
            }

            return personnages;
        }
        /// <summary>
        /// Permet de supprimr la table album si elle existe
        /// </summary>
        private void SupprimerTable()
        {
            string dropTableQuery = "DROP TABLE IF EXISTS apparaitreAlbum";
            SQLiteCommand command = new SQLiteCommand(dropTableQuery, connection);

            command.ExecuteNonQuery();

        }

        #endregion
    }
}

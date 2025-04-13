using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_FunEnBulles
{
    /// <summary>
    /// Cette classe représente un Album
    /// Un Album dispose d'un Numéro, d'un ISBN,
    /// d'un Titre, d'une Année d'apparition, d'une Edition 
    /// et d'une Image
    /// </summary>
    public class Album
    {
        #region Propriétés
        private int _albumNum;
        private string _albumIsbn;
        private string _albumTitre;
        private int _albumAnnee;
        private string _albumEdition;
        private string _albumImage;
        #endregion
        #region Property
        /// <summary>
        /// Obtient ou modifie l'image de l'Album
        /// </summary>
        public string AlbumImage
        {
            get { return _albumImage; }
            set { _albumImage = value; }
        }

        /// <summary>
        /// Obtient ou modifie l'édition de l'Album
        /// </summary>
        public string AlbumEdition
        {
            get { return _albumEdition; }
            set { _albumEdition = value; }
        }

        /// <summary>
        /// Obtient ou modifie l'année de parution de l'Album
        /// </summary>
        public int AlbumAnnee
        {
            get { return _albumAnnee; }
            set { _albumAnnee = value; }
        }

        /// <summary>
        /// Obtient ou modifie le titre de l'Album
        /// </summary>
        public string AlbumTitre
        {
            get { return _albumTitre; }
            set { _albumTitre = value; }
        }

        /// <summary>
        /// Obtient ou modifie l'ISBN de l'Album
        /// </summary>
        public string AlbumIsbn
        {
            get { return _albumIsbn; }
            set { _albumIsbn = value; }
        }

        /// <summary>
        /// Obtient ou modifie le numéro de l'Album
        /// </summary>
        public int AlbumNum
        {
            get { return _albumNum; }
            set { _albumNum = value; }
        }
        #endregion
        #region Constructeurs
        /// <summary>
        /// Initialise une nouvelle instance de Album
        /// Un Album dispose d'un numéro, d'un Isbn, d'un titre,
        /// d'une année d'apparition, d'une édition
        /// et d'une image
        /// </summary>
        /// <param name="albumNum">Numéro de l'album</param>
        /// <param name="albumIsbn">Isbn de l'album</param>
        /// <param name="albumTitre">Titre de l'album</param>
        /// <param name="albumAnnee">Année de parution de l'album</param>
        /// <param name="albumEdition">Edition de l'album</param>
        /// <param name="albumImage">Image de l'album</param>
        public Album(int albumNum, string albumIsbn, string albumTitre, int albumAnnee, string albumEdition, string albumImage)
        {
            _albumNum = albumNum;
            _albumIsbn = albumIsbn;
            _albumTitre = albumTitre;
            _albumAnnee = albumAnnee;
            _albumEdition = albumEdition;
            _albumImage = albumImage;
        }
        #endregion
    }
}
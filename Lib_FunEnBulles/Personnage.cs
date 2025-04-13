using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_FunEnBulles
{
    /// <summary>
    /// Cette classe représante un personnage
    /// Un personnage dispose:
    /// D'un numéro correspondant à son id
    /// D'un nom
    /// D'une inspiration
    /// D'une image
    /// D'un sexe
    /// D'une nationalité
    /// D'un nom en anglais optionnel
    /// D'un nom en allemand optionnel
    /// </summary>
    public class Personnage
    {

        #region Propriétés
        private int _personnageNum;
        private string _personnageNom;
        private string _personnageInspiration;
        private string? _personnageImage;
        private string _personnageSexe;
        private string? _personnageNationalite;
        private string? _personnageTitre;
        private string? _personnageNomAnglais;
        private string? _personnageNomAllemand;
        #endregion
        #region Property
        /// <summary>
        /// Obtient ou modifie le sexe du personnage
        /// </summary> 
        public string PersonnageSexe
        {
            get { return _personnageSexe; }
            set { _personnageSexe = value; }
        }
        /// <summary>
        /// Obtient ou modifie le nom Allemand du personnage
        /// </summary> 
        public string PersonnageNomAllemand
        {
            get { return _personnageNomAllemand; }
            set { _personnageNomAllemand = value; }
        }

        /// <summary>
        /// Obtient ou modifie le nom Anlgais du personnage
        /// </summary>
        public string PersonnageNomAnglais
        {
            get { return _personnageNomAnglais; }
            set { _personnageNomAnglais = value; }
        }

        /// <summary>
        /// Obtient ou modifie le titre du personnage
        /// </summary>
        public string PersonnageTitre
        {
            get { return _personnageTitre; }
            set { _personnageTitre = value; }
        }

        /// <summary>
        /// Obtient ou modifie la nationalite du personnage
        /// </summary>
        public string PersonnageNationalite
        {
            get { return _personnageNationalite; }
            set { _personnageNationalite = value; }
        }

        /// <summary>
        /// Obtient ou modifie l'image du personnage
        /// </summary>
        public string PersonnageImage
        {
            get { return _personnageImage; }
            set { _personnageImage = value; }
        }

        /// <summary>
        /// Obtient ou modifie l'inspiration du personnage
        /// </summary>
        public string PersonnageInspiration
        {
            get { return _personnageInspiration; }
            set { _personnageInspiration = value; }
        }

        /// <summary>
        /// Obtient ou modifie le nom du personnage
        /// </summary>
        public string PersonnageNom
        {
            get { return _personnageNom; }
            set { _personnageNom = value; }
        }

        /// <summary>
        /// Obtient le numéro du personnage
        /// </summary>
        public int PersonnageNum
        {
            get { return _personnageNum; }
            private set { _personnageNum = value; }
        }
        #endregion
        #region Constructeur
        /// <summary>
        /// Initialise une nouvelle instance de la classe Personnage
        ///Un personnage dispose obligatoirement d'un nom, 
        ///d'une inspiration et d'un sexe. Pour le reste des propriété les définir clairement.
        ///Exemple:
        ///var personnage = new Personnage("Kerøsen", "kerosène", "M", personnageTitre="viking")
        /// </summary>
        /// <param name="personnageNom">Nom</param>
        /// <param name="personnageInspiration">Inspiration</param>
        /// <param name="personnageSexe">Sexe</param>
        /// <param name="personnageImage">Image</param>
        /// <param name="personnageNationalite">Nationalite</param>
        /// <param name="personnageTitre">Titre</param>
        /// <param name="personnageNomAnglais">Nom anglais</param>
        /// <param name="personnageNomAllemand">Nom allemand</param>
        public Personnage(string personnageNom, string personnageInspiration, string personnageSexe,
            string? personnageImage = null, string? personnageNationalite = null, string? personnageTitre = null,
            string? personnageNomAnglais = null, string? personnageNomAllemand = null)
        {
            _personnageNom = personnageNom;
            _personnageInspiration = personnageInspiration;
            _personnageImage = personnageImage;
            _personnageSexe = personnageSexe;
            _personnageNationalite = personnageNationalite;
            _personnageTitre = personnageTitre;
            _personnageNomAnglais = personnageNomAnglais;
            _personnageNomAllemand = personnageNomAllemand;
        }
        /// <summary>
        /// Initialise une nouvelle instance de la classe Personnage
        /// Utilisé pour créer un objet Personnage à partir d'un enregistrement existant dans la base de données.
        /// </summary>
        /// <param name="personnageNum">Numéro qui identifie le personnage</param>
        /// <param name="personnageNom">Nom</param>
        /// <param name="personnageInspiration">Inspiration</param>
        /// <param name="personnageSexe">Sexe</param>
        /// <param name="personnageImage">Image</param>
        /// <param name="personnageNationalite">Nationalite</param>
        /// <param name="personnageTitre">Titre</param>
        /// <param name="personnageNomAnglais">Nom anglais</param>
        /// <param name="personnageNomAllemand">Nom allemand</param>
        public Personnage(int personnageNum, string personnageNom, string personnageInspiration, string personnageSexe,
        string? personnageImage = null, string? personnageNationalite = null, string? personnageTitre = null,
        string? personnageNomAnglais = null, string? personnageNomAllemand = null)
        {
            _personnageNum = personnageNum;
            _personnageNom = personnageNom;
            _personnageInspiration = personnageInspiration;
            _personnageImage = personnageImage;
            _personnageSexe = personnageSexe;
            _personnageNationalite = personnageNationalite;
            _personnageTitre = personnageTitre;
            _personnageNomAnglais = personnageNomAnglais;
            _personnageNomAllemand = personnageNomAllemand;
        }
        #endregion
    }
}

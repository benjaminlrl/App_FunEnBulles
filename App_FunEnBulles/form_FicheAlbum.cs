using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib_FunEnBulles;
using System.Data.SQLite;
namespace App_FunEnBulles
{
    public partial class form_FicheAlbum : Form
    {
        private PersonnageAlbumCRD bddFunEnBulles;
        private Album album;

        public form_FicheAlbum(Album albumSelect)
        {
            InitializeComponent();
            album = albumSelect;
            RecupDataBase();
            AfficherFiche(album);
            AfficherListePersonnagesAlbum(album);
        }

        private void RecupDataBase()
        {
            bddFunEnBulles = new PersonnageAlbumCRD("bddFunEnBulles");

        }

        private void AfficherFiche(Album Album)
        {

            string nomfichier = Album.AlbumImage;
            pictureBoxAlbum.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(nomfichier);
            labelTitre.Text += Album.AlbumTitre.ToString();
            labelEdition.Text += Album.AlbumEdition.ToString();
            labelAnnee.Text += Album.AlbumAnnee.ToString();
            labelisbn.Text += Album.AlbumIsbn.ToString();
        }

        private void AfficherListePersonnagesAlbum(Album album)
        {
            // Initialisation de la classe PersonnageAlbumCRD pour récupérer les personnages
            var listePersonnagesAlbum = bddFunEnBulles.ListerPersonnagesParAlbum(album.AlbumNum);

            // Nettoyage du DataGridView
            dataGridViewListePersonnagesAlbum.Columns.Clear();
            dataGridViewListePersonnagesAlbum.Rows.Clear();

            // Création des colonnes manuellement
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Image";
            imgCol.Name = "Image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewListePersonnagesAlbum.Columns.Add(imgCol);

            // Ajouter la colonne "Nom"
            dataGridViewListePersonnagesAlbum.Columns.Add("PersonnageNom", "Nom");

            // Charger et afficher les personnages dans le DataGridView
            foreach (var personnage in listePersonnagesAlbum)
            {
                Image image = null;

                // Vérifier si le nom d'image est valide et charger l'image
                try
                {
                    // Charger l'image à partir des ressources embarquées                    
                    image = (Image)Properties.Resources.ResourceManager.GetObject(personnage.PersonnageImage);

                    // Si l'image n'est pas trouvée dans les ressources, utiliser une image par défaut
                    if (image == null)
                    {
                        image = null;  // Remplacer par le nom de ton image par défaut
                    }
                }
                catch
                {
                    image = null;  // Remplacer par l'image par défaut en cas d'erreur
                }

                // Ajouter la ligne avec l'image et le nom du personnage
                dataGridViewListePersonnagesAlbum.Rows.Add(image, personnage.PersonnageNom);
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void form_FicheAlbum_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }

        private void form_FicheAlbum_Load(object sender, EventArgs e)
        {
            dataGridViewListePersonnagesAlbum.ClearSelection();
        }
    }
}

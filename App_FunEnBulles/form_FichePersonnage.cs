using lib_FunEnBulles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_FunEnBulles
{
    public partial class form_FichePersonnage : Form
    {
        private Personnage personnage;
        private PersonnageAlbumCRD bddFunEnBulles;
        private Album album;
        public form_FichePersonnage(Personnage personnageSelect)
        {
            InitializeComponent();
            RecupDataBase();
            personnage = personnageSelect;
            AfficherFiche(personnage);
            AfficherListeAlbumsPersonnage(personnage);
        }

        private void RecupDataBase()
        {
            bddFunEnBulles = new PersonnageAlbumCRD("bddFunEnBulles");
        }
        private void AfficherFiche(Personnage personnage)
        {

            string nomfichier = personnage.PersonnageImage;
            if (nomfichier != null)
            {
                pictureBoxPersonnage.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(nomfichier);
            }
            labelNom.Text += personnage.PersonnageNom.ToString();
            labelNomAnglais.Text += personnage.PersonnageNomAnglais.ToString();
            labelNomAllemand.Text += personnage.PersonnageNomAllemand.ToString();
            labelNationalite.Text += personnage.PersonnageNationalite.ToString();
            labelSexe.Text += personnage.PersonnageSexe.ToString();
            labelinspiration.Text += personnage.PersonnageInspiration.ToString();
            labelTitre.Text += personnage.PersonnageTitre.ToString();
        }

        private void AfficherListeAlbumsPersonnage(Personnage personnage)
        {
            // Initialisation de la classe PersonnageAlbumCRD pour récupérer les personnages
            var listeAlbumsPersonnage = bddFunEnBulles.ListerAlbumsParPersonnage(personnage.PersonnageNum);

            dataGridViewListeAlbums.Columns.Clear();
            dataGridViewListeAlbums.Rows.Clear();

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Image";
            imgCol.Name = "Image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewListeAlbums.Columns.Add(imgCol);

            dataGridViewListeAlbums.Columns.Add("AlbumTitre", "Titre");
            foreach (var album in listeAlbumsPersonnage)
            {
                Image image = null;
                try
                {
                    image = (Image)Properties.Resources.ResourceManager.GetObject(album.AlbumImage);
                    if (image == null)
                    {
                        image = null;
                    }
                }
                catch
                {
                    image = null;
                }
                dataGridViewListeAlbums.Rows.Add(image, album.AlbumTitre);
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

        private void dataGridViewListeAlbums_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Permet le défilement avec les flèches, sans déplacer la sélection si nécessaire
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true; // Cela indique que l'événement de touche doit être traité comme un événement de mouvement de ligne ou de colonne.
            }
        }

        private void form_FichePersonnage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
    }
}

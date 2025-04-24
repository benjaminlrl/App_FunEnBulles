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
    public partial class form_RechercheAlbum : Form
    {
        private SQLiteConnection Connection;
        private AlbumCRUD bddFunEnBulles;
        private Album album;
        private Album albumSelect;
        public form_RechercheAlbum()
        {
            InitializeComponent();
            RecupDataBase();
            ChargerAlbum("");
        }
        private void RecupDataBase()
        {
            bddFunEnBulles = new AlbumCRUD("bddFunEnBulles");
        }

        private void ChargerAlbum(string filtre)
        {
            var albums = bddFunEnBulles.ListerAlbums(filtre); // Charge les albums
            dataGridViewAlbums.RowTemplate.Height = 250;

            // Nettoyage du DataGridView
            dataGridViewAlbums.Columns.Clear();
            dataGridViewAlbums.Rows.Clear();

            // Création des colonnes manuellement
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Image";
            imgCol.Name = "Image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewAlbums.Columns.Add(imgCol);

            dataGridViewAlbums.Columns.Add("AlbumTitre", "Titre");
            dataGridViewAlbums.Columns.Add("AlbumEdition", "Édition");
            dataGridViewAlbums.Columns.Add("AlbumAnnee", "Année");
            dataGridViewAlbums.Columns.Add("AlbumIsbn", "Isbn");

            dataGridViewAlbums.Columns.Add("AlbumNum", "Numéro");
            dataGridViewAlbums.Columns.Add("AlbumImage", "image");
            dataGridViewAlbums.Columns["AlbumImage"].Visible = false;
            dataGridViewAlbums.Columns["AlbumNum"].Visible = false;

            foreach (var album in albums)
            {
                Image image = null;

                // Si tu utilises les ressources
                try
                {
                    image = (Image)Properties.Resources.ResourceManager.GetObject(album.AlbumImage);
                }
                catch
                {
                    image = null; // ou une image par défaut
                }

                dataGridViewAlbums.Rows.Add(image, album.AlbumTitre, album.AlbumEdition, album.AlbumAnnee, album.AlbumIsbn, album.AlbumNum, album.AlbumImage);
            }
        }

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            ChargerAlbum(textBoxRecherche.Text);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_Acceuil acceuil = new form_Acceuil();
            acceuil.FormClosed += (s, args) => this.Close();
            acceuil.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow uneLigne = dataGridViewAlbums.Rows[e.RowIndex];
                albumSelect = new Album(
                               int.Parse(uneLigne.Cells["AlbumNum"].Value.ToString()),
                               uneLigne.Cells["AlbumIsbn"].Value.ToString(),
                               uneLigne.Cells["AlbumTitre"].Value.ToString(),
                               int.Parse(uneLigne.Cells["AlbumAnnee"].Value.ToString()),
                               uneLigne.Cells["AlbumEdition"].Value.ToString(),
                               uneLigne.Cells["AlbumImage"].Value.ToString()
                               );

                form_FicheAlbum fichePersonnage = new form_FicheAlbum(albumSelect);
                fichePersonnage.Show();
            }

        }
        private void dataGridViewAlbums_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Permet la navigation uniquement entre les lignes sans changer de colonne (flèches haut/bas)
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                // Cela empêche que la touche soit consommée autrement par le DataGridView.
                e.IsInputKey = true;
            }

            // Empêche la navigation avec la touche Tab (entre les colonnes), mais permet la navigation entre les lignes
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true; // Cela évite le changement de colonne
            }

            // Si on appuie sur Enter, on déclenche un clic sur la cellule actuellement sélectionnée
            if (e.KeyCode == Keys.Enter)
            {
                var currentRow = dataGridViewAlbums.CurrentRow;

                // Si une cellule est sélectionnée
                if (currentRow != null)
                {
                    var currentCell = dataGridViewAlbums.CurrentCell;

                    // Simuler un clic sur la cellule en déclenchant l'événement CellClick
                    dataGridViewAlbums_CellClick(dataGridViewAlbums, new DataGridViewCellEventArgs(currentCell.ColumnIndex, currentCell.RowIndex));
                }
            }
        }

        private void buttonRechercheAleatoireAlbum_Click(object sender, EventArgs e)
        {
            List<Album> listeAlbums = bddFunEnBulles.ListerAlbums("");
            Album albumAleatoire = bddFunEnBulles.AlbumAleatoire(listeAlbums);
            form_FicheAlbum ficheAlbum = new form_FicheAlbum(albumAleatoire);
            ficheAlbum.Show();
        }

        private void form_RechercheAlbum_Load(object sender, EventArgs e)
        {
            dataGridViewAlbums.ClearSelection();
        }
    }
}

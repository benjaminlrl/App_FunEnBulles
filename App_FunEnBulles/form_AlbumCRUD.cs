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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App_FunEnBulles
{
    public partial class form_AlbumCRUD : Form
    {
        private AlbumCRUD bddFunEnBulles;
        private PersonnageAlbumCRD bddFunEnBullesPersonnageAlbums;
        private Album albumSelect;
        public form_AlbumCRUD()
        {
            InitializeComponent();
            RecupDataBase();
            ChargerAlbums("");
        }

        private void RecupDataBase()
        {
            bddFunEnBulles = new AlbumCRUD("bddFunEnBulles");
            bddFunEnBullesPersonnageAlbums = new PersonnageAlbumCRD("bddFunEnBulles");
        }

        private void ChargerAlbums(string filtre)
        {
            var albums = bddFunEnBulles.ListerAlbums(filtre); // Charge les albums

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

                ChargerAlbumSelectionne(albumSelect);

            }
        }
        private void ChargerAlbumSelectionne(Album albumSelect)
        {
            textBoxTitre.Text = albumSelect.AlbumTitre.ToString();
            textBoxIsbn.Text = albumSelect.AlbumIsbn.ToString();
            textBoxEdition.Text = albumSelect.AlbumEdition.ToString();
            textBoxAnnee.Text = albumSelect.AlbumAnnee.ToString();
            textBoxImage.Text = albumSelect.AlbumImage.ToString();
            if (albumSelect.AlbumImage != null)
            {
                string nomImage = albumSelect.AlbumImage.ToString();
                pictureBoxImage.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(nomImage);
            }
        }
        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            ChargerAlbums(textBoxRecherche.Text);
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_MenuParametre menuParametre = new form_MenuParametre();
            menuParametre.FormClosed += (s, args) => this.Close();
            menuParametre.Show();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitre.Text) ||
                    string.IsNullOrWhiteSpace(textBoxImage.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAnnee.Text) ||
                    string.IsNullOrWhiteSpace(textBoxIsbn.Text) ||
                    string.IsNullOrWhiteSpace(textBoxEdition.Text))
            {
                MessageBox.Show("Erreur lors de l'ajout de l'album. Le Titre, l'Isbn " +
                                "l'image, l'année et l'edition sont obligatoires afin de créer un album.");
                return;
            }
            Album album = new Album(
                textBoxIsbn.Text.ToString(),
                textBoxTitre.Text.ToString(),
                Convert.ToInt32(textBoxAnnee.Text.ToString()),
                textBoxEdition.Text.ToString(),
                textBoxImage.Text.ToString()
                );
            try
            {
                if (bddFunEnBulles.AlbumExiste(album))
                {
                    MessageBox.Show("L'album que vous essayez de créer existe déjà. " +
                                    "Veuillez le nommer autrement ou le modifier directement via le bouton modifier.");
                }
                else
                {
                    bddFunEnBulles.AjouterAlbum(album);
                    MessageBox.Show("Album ajouté avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'ajout de l'album :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChargerAlbums("");
            ClearInput();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (albumSelect == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un personnage à modifier.");
                return;
            }

            bool rienChange =
                albumSelect.AlbumTitre == textBoxTitre.Text &&
                albumSelect.AlbumIsbn == textBoxIsbn.Text &&
                albumSelect.AlbumEdition == textBoxEdition.Text &&
                albumSelect.AlbumAnnee == Convert.ToInt16(textBoxAnnee.Text) &&
                albumSelect.AlbumImage == textBoxImage.Text;

            if (rienChange)
            {
                MessageBox.Show("Aucune modification détectée. L'album n’a pas été mis à jour.");
                return;
            }

            albumSelect.AlbumTitre = textBoxTitre.Text.ToString();
            albumSelect.AlbumIsbn = textBoxIsbn.Text.ToString();
            albumSelect.AlbumEdition = textBoxEdition.Text.ToString();
            albumSelect.AlbumAnnee = Convert.ToInt16(textBoxAnnee.Text);
            albumSelect.AlbumImage = textBoxImage.Text.ToString();

            try
            {

                if (string.IsNullOrWhiteSpace(textBoxTitre.Text) ||
                    string.IsNullOrWhiteSpace(textBoxImage.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAnnee.Text) ||
                    string.IsNullOrWhiteSpace(textBoxIsbn.Text) ||
                    string.IsNullOrWhiteSpace(textBoxEdition.Text))
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'album.Le Titre, l'Isbn " +
                                    "l'image, l'année et l'edition sont obligatoires afin de modifier un album.");
                }
                else
                {
                    bddFunEnBulles.ModifierAlbum(albumSelect);
                    MessageBox.Show("Album modifié avec succès !");
                }
                ChargerAlbumSelectionne(albumSelect);
                ChargerAlbums("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la modification de l'album :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

            DialogResult confirmSupp = MessageBox.Show(
                "Êtes-vous certain de vouloir supprimer " + albumSelect.AlbumTitre + " de l'encyclopédie ?\n" +
                "Cette action est irréversible et l'album sera retiré et les perosnnages attribu ne le seront plus.",
                "Confirmation de suppression",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            try
            {
                if (confirmSupp == DialogResult.OK)
                {
                    bddFunEnBulles.SupprimerAlbum(albumSelect);
                    bddFunEnBullesPersonnageAlbums.SupprimerAlbumsPersonnage(albumSelect);
                    MessageBox.Show(
                        "L'album a bien été supprimé de l'encyclopédie.",
                        "Suppression réussie",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Une erreur est survenue lors de la suppression : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            ChargerAlbums("");
            ClearInput();

        }

        private void ClearInput()
        {
            textBoxTitre.Clear();
            textBoxIsbn.Clear();
            textBoxImage.Clear();
            textBoxEdition.Clear();
            textBoxAnnee.Clear();
            pictureBoxImage.BackgroundImage = null;
            albumSelect = null;
        }

        private void buttonViderChamps_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void buttonAlbum_Click(object sender, EventArgs e)
        {
            if (albumSelect == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un album dans la liste.",
                                "Aucun album sélectionné",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            form_PersonnageAlbumCRUD personnageAlbumCRUD = new form_PersonnageAlbumCRUD(albumSelect);
            personnageAlbumCRUD.FormClosed += (s, args) => this.Close();
            personnageAlbumCRUD.Show();
        }
    }
}

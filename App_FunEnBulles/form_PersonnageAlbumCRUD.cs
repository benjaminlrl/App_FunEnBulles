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

    public partial class form_PersonnageAlbumCRUD : Form
    {
        private PersonnageAlbumCRD bddFunEnBulles;
        private Album album;
        private Personnage personnage;
        public form_PersonnageAlbumCRUD(Album albumSelect)
        {
            InitializeComponent();
            album = albumSelect;
            RecupDataBase();
            AfficherFicheAlbum(album);
            AfficherListePersonnagesAlbum(album);
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_MenuParametre menuParametre = new form_MenuParametre();
            menuParametre.FormClosed += (s, args) => this.Close();
            menuParametre.Show();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RecupDataBase()
        {
            bddFunEnBulles = new PersonnageAlbumCRD("bddFunEnBulles");

        }
        private void AfficherFichePersonnage(Personnage personnage)
        {

            string image = personnage.PersonnageImage;
            if (image != null)
            {
                pictureBoxPersonnage.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(image);
            }
            labelNomPersonnage.Text = "Nom : " + personnage.PersonnageNom.ToString();
            labelNationalite.Text = "Nationalité : " + personnage.PersonnageNationalite.ToString();
            labelSexe.Text = "Sexe : " + personnage.PersonnageSexe.ToString();
            labelinspiration.Text = "Inspiration : " + personnage.PersonnageInspiration.ToString();
            labelTitrePersonnage.Text = "Titre : " + personnage.PersonnageTitre.ToString();
        }

        private void AfficherFicheAlbum(Album Album)
        {
            string nomfichier = Album.AlbumImage;
            pictureBoxAlbum.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(nomfichier);
            labelTitre.Text += Album.AlbumTitre.ToString();
            labelEdition.Text += Album.AlbumEdition.ToString();
            labelAnnee.Text += Album.AlbumAnnee.ToString();
            labelisbn.Text += Album.AlbumIsbn.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="album">Album en question</param>
        /// <param name="filtre">saisie de l'utilisateur</param>
        private void AfficherListePersonnagesAlbum(Album album, string filtre = "")
        {
            var listePersonnagesAlbum = bddFunEnBulles.ListerPersonnagesParAlbum(album.AlbumNum, filtre);

            dataGridViewPersonnages.Columns.Clear();
            dataGridViewPersonnages.Rows.Clear();

            // Ajout des colonnes invisibles (pour la reconstruction du personnage)
            dataGridViewPersonnages.Columns.Add("PersonnageNum", "Num");
            dataGridViewPersonnages.Columns.Add("PersonnageNom", "Nom");
            dataGridViewPersonnages.Columns.Add("PersonnageImage", "NomImage");
            dataGridViewPersonnages.Columns.Add("PersonnageInspiration", "Inspiration");
            dataGridViewPersonnages.Columns.Add("PersonnageSexe", "Sexe");
            dataGridViewPersonnages.Columns.Add("PersonnageNationalite", "Nationalité");
            dataGridViewPersonnages.Columns.Add("PersonnageTitre", "Titre");
            dataGridViewPersonnages.Columns.Add("PersonnageNomAnglais", "Nom Anglais");
            dataGridViewPersonnages.Columns.Add("PersonnageNomAllemand", "Nom Allemand");

            // Ajout de la colonne visible "Image"
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Image";
            imgCol.Name = "Image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewPersonnages.Columns.Add(imgCol);

            // Masquer toutes les colonnes sauf Image et Nom
            foreach (DataGridViewColumn col in dataGridViewPersonnages.Columns)
            {
                if (col.Name != "PersonnageNom" && col.Name != "Image")
                    col.Visible = false;
            }

            // Réorganise l’ordre pour afficher Image avant Nom
            dataGridViewPersonnages.Columns["Image"].DisplayIndex = 0;
            dataGridViewPersonnages.Columns["PersonnageNom"].DisplayIndex = 1;

            // Remplissage des lignes
            foreach (var personnage in listePersonnagesAlbum)
            {
                Image image = null;
                try
                {
                    image = (Image)Properties.Resources.ResourceManager.GetObject(personnage.PersonnageImage);
                }
                catch
                {
                    image = null;
                }

                dataGridViewPersonnages.Rows.Add(
                    personnage.PersonnageNum,
                    personnage.PersonnageNom,
                    personnage.PersonnageImage,
                    personnage.PersonnageInspiration,
                    personnage.PersonnageSexe,
                    personnage.PersonnageNationalite,
                    personnage.PersonnageTitre,
                    personnage.PersonnageNomAnglais,
                    personnage.PersonnageNomAllemand,
                    image
                );
            }
        }

        private void dataGridViewPersonnages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow uneLigne = dataGridViewPersonnages.Rows[e.RowIndex];
                personnage = new Personnage(
                               int.Parse(uneLigne.Cells["PersonnageNum"].Value.ToString()),
                               uneLigne.Cells["PersonnageNom"].Value.ToString(),
                               uneLigne.Cells["PersonnageInspiration"].Value.ToString(),
                               uneLigne.Cells["PersonnageSexe"].Value.ToString(),
                               uneLigne.Cells["PersonnageImage"].Value.ToString(),
                               uneLigne.Cells["PersonnageNationalite"].Value.ToString(),
                               uneLigne.Cells["PersonnageTitre"].Value.ToString(),
                               uneLigne.Cells["PersonnageNomAnglais"].Value.ToString(),
                               uneLigne.Cells["PersonnageNomAllemand"].Value.ToString()
                               );
                AfficherFichePersonnage(personnage);

            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (personnage == null)
            {
                MessageBox.Show("Aucun personnage sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirmSupp = MessageBox.Show(
                "Êtes-vous certain de vouloir supprimer " + personnage.PersonnageNom + " de l'album ?\n" +
                "Cette action est irréversible et le personnage sera retiré de l'album.",
                "Confirmation de suppression",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (bddFunEnBulles.PersonnageAlbumExiste(personnage, album))
            {
                try
                {
                    bddFunEnBulles.SupprimerPersonnageUnAlbum(personnage, album);
                    AfficherListePersonnagesAlbum(album);
                    ClearLabel();

                    MessageBox.Show("Personnage supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression du personnage : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Le personnage n'existe pas dans cet album", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ClearLabel permet de remettre l'affiche des labels au text d'origine.
        /// </summary>
        private void ClearLabel()
        {
            labelNomPersonnage.Text = "Nom : ";
            labelNationalite.Text = "Nationalité : ";
            labelSexe.Text = "Sexe : ";
            labelinspiration.Text = "Inspiration : ";
            labelTitre.Text = "Titre : ";
            pictureBoxPersonnage.BackgroundImage = null;
        }

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            //Affichage dynamique de la liste des Perosnnages présent dans un album
            AfficherListePersonnagesAlbum(album, textBoxRecherche.Text);
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_RecherchePersonnageAjout recherchePersonnageAjout = new form_RecherchePersonnageAjout(album);
            recherchePersonnageAjout.FormClosed += (s, args) => this.Close();
            recherchePersonnageAjout.Show();
        }

        private void form_PersonnageAlbumCRUD_Load(object sender, EventArgs e)
        {
            dataGridViewPersonnages.ClearSelection();
        }
    }
}

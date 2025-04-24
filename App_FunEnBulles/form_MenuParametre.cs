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

namespace App_FunEnBulles
{
    public partial class form_MenuParametre : Form
    {
        private PersonnageCRUD bddFunEnBullePersonnageCRUD;
        private AlbumCRUD bddFunEnBulleAlbumCRUD;
        private PersonnageAlbumCRD bddFunEnBullePerosnnageAlbumCRUD;
        public form_MenuParametre()
        {
            InitializeComponent();
            RecupDataBase();
        }
        private void RecupDataBase()
        {
            bddFunEnBullePersonnageCRUD = new PersonnageCRUD("bddFunEnBulles");
            bddFunEnBullePerosnnageAlbumCRUD = new PersonnageAlbumCRD("bddFunEnBulles");
            bddFunEnBulleAlbumCRUD = new AlbumCRUD("bddFunEnBulles");
        }
        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonPersonnage_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_PersonnageCRUD perosnnageCRUD = new form_PersonnageCRUD();
            perosnnageCRUD.FormClosed += (s, args) => this.Close();
            perosnnageCRUD.Show();

        }

        private void buttonReinitialiserBdd_Click_1(object sender, EventArgs e)
        {
            DialogResult confirmSupp = MessageBox.Show(
                "Êtes-vous certain de vouloir réinitialiser la base de données de l'encyplédie ?\n" +
                "Cette action est irréversible et la base de données sera réinitialisé avec les albums et personnages par défaut.",
                "Confirmation de réinitialisation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            try
            {
                if (confirmSupp == DialogResult.OK)
                {
                    bddFunEnBullePersonnageCRUD.SupprimerTable();
                    bddFunEnBulleAlbumCRUD.SupprimerTable();
                    bddFunEnBullePerosnnageAlbumCRUD.SupprimerTable();
                    MessageBox.Show(
                        "La base de données a bien été réinitialisée de l'encyclopédie.",
                        "Réinitialisation réussie",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Une erreur est survenue lors de la réinitialisation : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void buttonAlbum_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_AlbumCRUD albumCRUD = new form_AlbumCRUD();
            albumCRUD.FormClosed += (s, args) => this.Close();
            albumCRUD.Show();
        }
    }
}

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
//using static System.Net.Mime.MediaTypeNames;
using DrawingImage = System.Drawing.Image;

namespace App_FunEnBulles
{
    public partial class form_PersonnageCRUD : Form
    {
        private PersonnageCRUD bddFunEnBulles;
        private PersonnageAlbumCRD bddFunEnBullesPersonnageAlbums;
        private Personnage personnageSelect;
        public form_PersonnageCRUD()
        {
            InitializeComponent();
            RecupDataBase();
            ChargerPersonnages("");
        }

        private void ChargerPersonnages(string filtre = "")
        {
            dataGridViewPersonnages.DataSource = bddFunEnBulles.ListerPersonnages(filtre);

            if (dataGridViewPersonnages.Columns.Contains("PersonnageTitre"))
                dataGridViewPersonnages.Columns["PersonnageTitre"].Visible = false;
                dataGridViewPersonnages.Columns["PersonnageImage"].Visible = false;

            dataGridViewPersonnages.Columns["PersonnageNum"].DisplayIndex = 0;
            dataGridViewPersonnages.Columns["PersonnageNom"].DisplayIndex = 1;
            dataGridViewPersonnages.Columns["PersonnageInspiration"].DisplayIndex = 2;
            dataGridViewPersonnages.Columns["PersonnageSexe"].DisplayIndex = 3;
            dataGridViewPersonnages.Columns["PersonnageNationalite"].DisplayIndex = 4;
            dataGridViewPersonnages.Columns["PersonnageNomAnglais"].DisplayIndex = 5;
            dataGridViewPersonnages.Columns["PersonnageNomAllemand"].DisplayIndex = 6;

            dataGridViewPersonnages.Columns["PersonnageNum"].HeaderText = "Num";
            dataGridViewPersonnages.Columns["PersonnageNom"].HeaderText = "Nom";
            dataGridViewPersonnages.Columns["PersonnageInspiration"].HeaderText = "Inspiration";
            dataGridViewPersonnages.Columns["PersonnageSexe"].HeaderText = "Sexe";
            dataGridViewPersonnages.Columns["PersonnageNationalite"].HeaderText = "Nationalité";
            dataGridViewPersonnages.Columns["PersonnageTitre"].HeaderText = "Titre";
            dataGridViewPersonnages.Columns["PersonnageNomAnglais"].HeaderText = "Nom Anglais";
            dataGridViewPersonnages.Columns["PersonnageNomAllemand"].HeaderText = "Nom Allemand";
        }
        private void RecupDataBase()
        {
            bddFunEnBulles = new PersonnageCRUD("bddFunEnBulles");
            bddFunEnBullesPersonnageAlbums = new PersonnageAlbumCRD("bddFunEnBulles");
        }

        private void dataGridViewPersonnages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow uneLigne = dataGridViewPersonnages.Rows[e.RowIndex];
                personnageSelect = new Personnage(
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
                ChargerPersonnageSelectionne(personnageSelect);

            }
        }
        private void ChargerPersonnageSelectionne(Personnage perosnnageSelect)
        {
            textBoxNom.Text = personnageSelect.PersonnageNom;
            textBoxInspiration.Text = personnageSelect.PersonnageInspiration;
            textBoxNationalite.Text = personnageSelect.PersonnageNationalite;
            textBoxImage.Text = personnageSelect.PersonnageImage;
            textBoxNomAllemand.Text = personnageSelect.PersonnageNomAllemand;
            textBoxNomAnglais.Text = personnageSelect.PersonnageNomAnglais;
            textBoxTitre.Text = personnageSelect.PersonnageTitre;
            if (!string.IsNullOrWhiteSpace(personnageSelect.PersonnageImage))
            {
                try
                {
                    pictureBoxPersonnageImage.BackgroundImage =
                        (Bitmap)Properties.Resources.ResourceManager.GetObject(personnageSelect.PersonnageImage);
                }
                catch
                {
                    pictureBoxPersonnageImage.BackgroundImage = null;
                }
            }
            if (personnageSelect.PersonnageSexe == "M")
            {
                radioButtonSexeM.Checked = true;
            }
            if (personnageSelect.PersonnageSexe == "F")
            {
                radioButtonSexeF.Checked = true;
            }
        }
        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            ChargerPersonnages(textBoxRecherche.Text);
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
            string personnageSexe = "M";
            if (radioButtonSexeF.Checked == true)
            {
                personnageSexe = "F";
            }
            Personnage personnage = new Personnage(
                textBoxNom.Text.ToString(),
                textBoxInspiration.Text.ToString(),
                personnageSexe,
                textBoxImage.Text.ToString(),
                textBoxNationalite.Text.ToString(),
                textBoxTitre.Text.ToString(),
                textBoxNomAnglais.Text.ToString(),
                textBoxNomAllemand.Text.ToString()
                );
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNom.Text) ||
                    string.IsNullOrWhiteSpace(textBoxInspiration.Text) ||
                    (!radioButtonSexeF.Checked && !radioButtonSexeM.Checked))
                {
                    MessageBox.Show("Erreur lors de l'ajout du personnage. Le nom, l'inspiration " +
                                    "et le sexe sont obligatoires afin de créer un personnage.");
                }
                else if (bddFunEnBulles.PersonnageExiste(personnage))
                {
                    MessageBox.Show("Le personnage que vous essayez de créer existe déjà. " +
                                    "Veuillez le nommer autrement ou le modifier directement via le bouton modifier.");
                }
                else
                {
                    bddFunEnBulles.AjouterPersonnage(personnage);
                    MessageBox.Show("Personnage ajouté avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'ajout du personnage :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearInput();
            ChargerPersonnages("");
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (personnageSelect == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un personnage à modifier.");
                return;
            }

            string nouveauSexe = radioButtonSexeM.Checked ? "M" : "F";

            bool rienChange =
                personnageSelect.PersonnageNom == textBoxNom.Text &&
                personnageSelect.PersonnageInspiration == textBoxInspiration.Text &&
                personnageSelect.PersonnageSexe == nouveauSexe &&
                personnageSelect.PersonnageImage == textBoxImage.Text &&
                personnageSelect.PersonnageNationalite == textBoxNationalite.Text &&
                personnageSelect.PersonnageTitre == textBoxTitre.Text &&
                personnageSelect.PersonnageNomAnglais == textBoxNomAnglais.Text &&
                personnageSelect.PersonnageNomAllemand == textBoxNomAllemand.Text;

            if (rienChange)
            {
                MessageBox.Show("Aucune modification détectée. Le personnage n’a pas été mis à jour.");
                return;
            }

            personnageSelect.PersonnageNom = textBoxNom.Text;
            personnageSelect.PersonnageInspiration = textBoxInspiration.Text;
            personnageSelect.PersonnageSexe = nouveauSexe;
            personnageSelect.PersonnageImage = textBoxImage.Text;
            personnageSelect.PersonnageNationalite = textBoxNationalite.Text;
            personnageSelect.PersonnageTitre = textBoxTitre.Text;
            personnageSelect.PersonnageNomAnglais = textBoxNomAnglais.Text;
            personnageSelect.PersonnageNomAllemand = textBoxNomAllemand.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNom.Text) ||
                    string.IsNullOrWhiteSpace(textBoxInspiration.Text) ||
                    (!radioButtonSexeF.Checked && !radioButtonSexeM.Checked))
                {
                    MessageBox.Show("Erreur lors de la modification du personnage. Le nom, l'inspiration " +
                                    "et le sexe sont obligatoires afin de modifier un personnage.");
                }
                else
                {
                    bddFunEnBulles.ModifierPersonnage(personnageSelect);
                    MessageBox.Show("Personnage modifié avec succès !");
                }
                ChargerPersonnageSelectionne(personnageSelect);
                ChargerPersonnages("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la modification du personnage :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (personnageSelect == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un personnage à supprimer.");
                return;
            }
            DialogResult confirmSupp = MessageBox.Show(
                "Êtes-vous certain de vouloir supprimer " + personnageSelect.PersonnageNom + " de l'encyclopédie ?\n" +
                "Cette action est irréversible et le personnage sera retiré des albums.",
                "Confirmation de suppression",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            try
            {
                if (confirmSupp == DialogResult.OK)
                {
                    bddFunEnBulles.SupprimerPersonnage(personnageSelect);
                    bddFunEnBullesPersonnageAlbums.SupprimerPersonnageDeTousLesAlbums(personnageSelect);
                    MessageBox.Show(
                        "Le personnage a bien été supprimé de l'encyclopédie.",
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
            ClearInput();
            ChargerPersonnages("");

        }

        private void ClearInput()
        {
            textBoxNom.Clear();
            textBoxInspiration.Clear();
            radioButtonSexeF.Checked = false;
            radioButtonSexeM.Checked = false;
            textBoxImage.Clear();
            textBoxNationalite.Clear();
            textBoxTitre.Clear();
            textBoxNomAnglais.Clear();
            textBoxNomAllemand.Clear();
            pictureBoxPersonnageImage.BackgroundImage = null;
            textBoxRecherche.Clear();
            personnageSelect = null;
        }

        private void buttonViderChamps_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
    }
}

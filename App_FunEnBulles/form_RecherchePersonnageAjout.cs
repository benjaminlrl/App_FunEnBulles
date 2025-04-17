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
    public partial class form_RecherchePersonnageAjout : Form
    {
        private PersonnageCRUD bddFunEnBulles;
        private PersonnageAlbumCRD bddFunEnBullesPersonnageAlbumCRUD;
        private Album album;
        private Personnage personnage;
        private Personnage personnageSelect;
        public form_RecherchePersonnageAjout(Album albumSelect)
        {
            InitializeComponent();
            RecupDataBase();
            ChargerPersonnage("");
            album = albumSelect;
        }

        private void RecupDataBase()
        {
            bddFunEnBulles = new PersonnageCRUD("bddFunEnBulles");
            bddFunEnBullesPersonnageAlbumCRUD = new PersonnageAlbumCRD("bddFunEnBulles");
        }
        /// <summary>
        /// ChargerPersonnage permet d'afficher la liste des personnages qui contienne la saisie de l'utilisateur pour que l'utilistauer puisse voir quelles personnages il peut ajouter à son album
        /// </summary>
        /// <param name="filtre">saisie de l'utilisateur</param>
        private void ChargerPersonnage(string filtre)
        {
            dataGridViewPersonnages.DataSource = bddFunEnBulles.ListerPersonnages(filtre);
            dataGridViewPersonnages.RowTemplate.Height = 250;

            // Ensuite, définis manuellement l’ordre des colonnes et les en-têtes
            dataGridViewPersonnages.Columns["PersonnageNum"].Visible = false;
            dataGridViewPersonnages.Columns["PersonnageTitre"].Visible = false;
            dataGridViewPersonnages.Columns["PersonnageImage"].Visible = false;
            dataGridViewPersonnages.Columns["PersonnageNom"].DisplayIndex = 1;
            dataGridViewPersonnages.Columns["PersonnageInspiration"].DisplayIndex = 2;
            dataGridViewPersonnages.Columns["PersonnageSexe"].DisplayIndex = 3;
            dataGridViewPersonnages.Columns["PersonnageNationalite"].DisplayIndex = 4;
            dataGridViewPersonnages.Columns["PersonnageNomAnglais"].DisplayIndex = 5;
            dataGridViewPersonnages.Columns["PersonnageNomAllemand"].DisplayIndex = 6;
            dataGridViewPersonnages.Columns["PersonnageNom"].HeaderText = "Nom";
            dataGridViewPersonnages.Columns["PersonnageInspiration"].HeaderText = "Inspiration";
            dataGridViewPersonnages.Columns["PersonnageSexe"].HeaderText = "Sexe";
            dataGridViewPersonnages.Columns["PersonnageNationalite"].HeaderText = "Nationalité";
            dataGridViewPersonnages.Columns["PersonnageTitre"].HeaderText = "Titre";
            dataGridViewPersonnages.Columns["PersonnageNomAnglais"].HeaderText = "Nom Anglais";
            dataGridViewPersonnages.Columns["PersonnageNomAllemand"].HeaderText = "Nom Allemand";


        }

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            //Affiche dynamique de la saisie.
            ChargerPersonnage(textBoxRecherche.Text);
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

                if (personnageSelect == null)
                {
                    MessageBox.Show("Aucun personnage sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult confirmSupp = MessageBox.Show(
                    $"Êtes-vous certain de vouloir ajouter {personnageSelect.PersonnageNom} à l'album ?",
                    "Confirmation d'ajout",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (confirmSupp == DialogResult.OK)
                {
                    try
                    {
                        bddFunEnBullesPersonnageAlbumCRUD.AjouterPersonnageDansAlbum(personnageSelect,album);
                        ChargerPersonnage("");

                        MessageBox.Show("Personnage ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'ajout du personnage : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRechercheAleatoirePersonnage_Click(object sender, EventArgs e)
        {
            //genere un perosnnage aleatoire parmis tous ce de la table personnage
            List<Personnage> listePersonnages = bddFunEnBulles.ListerPersonnages("");
            Personnage personnageAleatoire = bddFunEnBulles.PersonnageAleatoire(listePersonnages);
            form_FichePersonnage fichePersonnage = new form_FichePersonnage(personnageAleatoire);
            fichePersonnage.Show();
        }

        private void dataGridViewPersonnages_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Permet le défilement avec les flèches, sans déplacer la sélection si nécessaire
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true; // Cela indique que l'événement de touche doit être traité comme un événement de mouvement de ligne ou de colonne.
            }
            if (e.KeyCode == Keys.Enter)
            {
                var currentCell = dataGridViewPersonnages.CurrentCell;

                // Si une cellule est sélectionnée
                if (currentCell != null)
                {
                    // Simuler un clic sur la cellule en déclenchant l'événement CellClick
                    dataGridViewPersonnages_CellContentClick(dataGridViewPersonnages, new DataGridViewCellEventArgs(currentCell.ColumnIndex, currentCell.RowIndex));
                }
            }
        }
    }
}

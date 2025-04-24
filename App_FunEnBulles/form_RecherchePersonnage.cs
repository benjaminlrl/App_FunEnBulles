using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib_FunEnBulles;

namespace App_FunEnBulles
{

    public partial class form_RecherchePersonnage : Form
    {
        private SQLiteConnection Connection;
        private PersonnageCRUD bddFunEnBulles;
        private Personnage personnage;
        private Personnage personnageSelect;
        public form_RecherchePersonnage()
        {
            InitializeComponent();
            RecupDataBase();
            ChargerPersonnage("");

        }

        private void RecupDataBase()
        {
            bddFunEnBulles = new PersonnageCRUD("bddFunEnBulles");
        }
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

                form_FichePersonnage fichePersonnage = new form_FichePersonnage(personnageSelect);
                fichePersonnage.Show();
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

        private void buttonRechercheAleatoirePersonnage_Click(object sender, EventArgs e)
        {
            List<Personnage> listePersonnages = bddFunEnBulles.ListerPersonnages("");
            Personnage personnageAleatoire = bddFunEnBulles.PersonnageAleatoire(listePersonnages);
            form_FichePersonnage fichePersonnage = new form_FichePersonnage(personnageAleatoire);
            fichePersonnage.Show();
        }

        private void dataGridViewPersonnages_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
                var currentRow = dataGridViewPersonnages.CurrentRow;

                // Si une cellule est sélectionnée
                if (currentRow != null)
                {
                    var currentCell = dataGridViewPersonnages.CurrentCell;

                    // Simuler un clic sur la cellule en déclenchant l'événement CellClick
                    dataGridViewPersonnages_CellContentClick(dataGridViewPersonnages, new DataGridViewCellEventArgs(currentCell.ColumnIndex, currentCell.RowIndex));
                }
            }
        }

        private void form_RecherchePersonnage_Load(object sender, EventArgs e)
        {
            dataGridViewPersonnages.ClearSelection();
        }
    }
}

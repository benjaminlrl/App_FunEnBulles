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
    public partial class form_MenuParametre : Form
    {
        public form_MenuParametre()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_AlbumCRUD albumCRUD = new form_AlbumCRUD();
            albumCRUD.FormClosed += (s, args) => this.Close();
            albumCRUD.Show();
        }
    }
}

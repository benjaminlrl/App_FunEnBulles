namespace App_FunEnBulles
{
    public partial class form_Acceuil : Form
    {
        public form_Acceuil()
        {
            InitializeComponent();
        }

        private void buttonRecherchePersonnages_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_RecherchePersonnage recherchePersonnage = new form_RecherchePersonnage();
            recherchePersonnage.FormClosed += (s, args) => this.Close();
            recherchePersonnage.Show();
        }

        private void buttonConsulterAlbums_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_RechercheAlbum rechercheAlbum = new form_RechercheAlbum();
            rechercheAlbum.FormClosed += (s, args) => this.Close();
            rechercheAlbum.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonParametre_Click(object sender, EventArgs e)
        {
            form_MenuParametre menuParametre = new form_MenuParametre();
            menuParametre.FormClosed += (s, args) => this.Close();
            menuParametre.Show();
        }
    }
}

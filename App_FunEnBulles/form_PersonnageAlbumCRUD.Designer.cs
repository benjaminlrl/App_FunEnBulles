namespace App_FunEnBulles
{
    partial class form_PersonnageAlbumCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonQuitter = new Button();
            buttonRetour = new Button();
            textBoxRecherche = new TextBox();
            labelRecherche = new Label();
            buttonAjouter = new Button();
            buttonSupprimer = new Button();
            dataGridViewPersonnages = new DataGridView();
            labelisbn = new Label();
            labelAnnee = new Label();
            labelEdition = new Label();
            labelTitre = new Label();
            label50 = new Label();
            pictureBoxAlbum = new PictureBox();
            labelSexe = new Label();
            labelTitrePersonnage = new Label();
            labelinspiration = new Label();
            labelNomPersonnage = new Label();
            pictureBoxPersonnage = new PictureBox();
            labelNationalite = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonnages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonnage).BeginInit();
            SuspendLayout();
            // 
            // buttonQuitter
            // 
            buttonQuitter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuitter.BackColor = Color.DarkRed;
            buttonQuitter.ForeColor = Color.White;
            buttonQuitter.Location = new Point(1132, 21);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(128, 59);
            buttonQuitter.TabIndex = 106;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonRetour
            // 
            buttonRetour.BackColor = Color.Gold;
            buttonRetour.Location = new Point(12, 21);
            buttonRetour.Name = "buttonRetour";
            buttonRetour.Size = new Size(119, 59);
            buttonRetour.TabIndex = 105;
            buttonRetour.Text = "Retour";
            buttonRetour.UseVisualStyleBackColor = false;
            buttonRetour.Click += buttonRetour_Click;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRecherche.Location = new Point(874, 402);
            textBoxRecherche.Margin = new Padding(6, 5, 6, 5);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.Size = new Size(386, 47);
            textBoxRecherche.TabIndex = 91;
            textBoxRecherche.TextChanged += textBoxRecherche_TextChanged;
            // 
            // labelRecherche
            // 
            labelRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRecherche.AutoSize = true;
            labelRecherche.Location = new Point(695, 405);
            labelRecherche.Margin = new Padding(6, 0, 6, 0);
            labelRecherche.Name = "labelRecherche";
            labelRecherche.Size = new Size(176, 39);
            labelRecherche.TabIndex = 83;
            labelRecherche.Text = "Rechercher:";
            // 
            // buttonAjouter
            // 
            buttonAjouter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonAjouter.AutoSize = true;
            buttonAjouter.Location = new Point(360, 311);
            buttonAjouter.Margin = new Padding(6, 5, 6, 5);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(464, 66);
            buttonAjouter.TabIndex = 85;
            buttonAjouter.Text = "Ajouter un personnage";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSupprimer.AutoSize = true;
            buttonSupprimer.Location = new Point(972, 311);
            buttonSupprimer.Margin = new Padding(6, 5, 6, 5);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(211, 66);
            buttonSupprimer.TabIndex = 87;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // dataGridViewPersonnages
            // 
            dataGridViewPersonnages.AllowUserToAddRows = false;
            dataGridViewPersonnages.AllowUserToDeleteRows = false;
            dataGridViewPersonnages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPersonnages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPersonnages.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPersonnages.BackgroundColor = Color.White;
            dataGridViewPersonnages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonnages.Location = new Point(0, 459);
            dataGridViewPersonnages.Margin = new Padding(6, 5, 6, 5);
            dataGridViewPersonnages.Name = "dataGridViewPersonnages";
            dataGridViewPersonnages.ReadOnly = true;
            dataGridViewPersonnages.RowHeadersWidth = 62;
            dataGridViewPersonnages.Size = new Size(1273, 339);
            dataGridViewPersonnages.TabIndex = 80;
            dataGridViewPersonnages.CellClick += dataGridViewPersonnages_CellClick;
            // 
            // labelisbn
            // 
            labelisbn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelisbn.AutoSize = true;
            labelisbn.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelisbn.Location = new Point(205, 160);
            labelisbn.Name = "labelisbn";
            labelisbn.Size = new Size(97, 35);
            labelisbn.TabIndex = 113;
            labelisbn.Text = "Isbn : ";
            // 
            // labelAnnee
            // 
            labelAnnee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelAnnee.AutoSize = true;
            labelAnnee.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelAnnee.Location = new Point(205, 195);
            labelAnnee.Name = "labelAnnee";
            labelAnnee.Size = new Size(115, 35);
            labelAnnee.TabIndex = 112;
            labelAnnee.Text = "Année : ";
            // 
            // labelEdition
            // 
            labelEdition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEdition.AutoSize = true;
            labelEdition.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelEdition.Location = new Point(205, 123);
            labelEdition.Name = "labelEdition";
            labelEdition.Size = new Size(115, 35);
            labelEdition.TabIndex = 111;
            labelEdition.Text = "Edition :";
            // 
            // labelTitre
            // 
            labelTitre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelTitre.Location = new Point(205, 86);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(105, 35);
            labelTitre.TabIndex = 110;
            labelTitre.Text = "Titre : ";
            // 
            // label50
            // 
            label50.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label50.AutoSize = true;
            label50.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label50.Location = new Point(12, 402);
            label50.Name = "label50";
            label50.Size = new Size(438, 35);
            label50.TabIndex = 109;
            label50.Text = "Personnages présents dans l'album :";
            // 
            // pictureBoxAlbum
            // 
            pictureBoxAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxAlbum.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAlbum.Location = new Point(12, 86);
            pictureBoxAlbum.Name = "pictureBoxAlbum";
            pictureBoxAlbum.Size = new Size(187, 217);
            pictureBoxAlbum.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxAlbum.TabIndex = 108;
            pictureBoxAlbum.TabStop = false;
            // 
            // labelSexe
            // 
            labelSexe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSexe.AutoSize = true;
            labelSexe.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelSexe.Location = new Point(859, 160);
            labelSexe.Name = "labelSexe";
            labelSexe.Size = new Size(102, 35);
            labelSexe.TabIndex = 118;
            labelSexe.Text = "Sexe : ";
            // 
            // labelTitrePersonnage
            // 
            labelTitrePersonnage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitrePersonnage.AutoSize = true;
            labelTitrePersonnage.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelTitrePersonnage.Location = new Point(859, 195);
            labelTitrePersonnage.Name = "labelTitrePersonnage";
            labelTitrePersonnage.Size = new Size(105, 35);
            labelTitrePersonnage.TabIndex = 117;
            labelTitrePersonnage.Text = "Titre : ";
            // 
            // labelinspiration
            // 
            labelinspiration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelinspiration.AutoSize = true;
            labelinspiration.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelinspiration.Location = new Point(859, 123);
            labelinspiration.Name = "labelinspiration";
            labelinspiration.Size = new Size(162, 35);
            labelinspiration.TabIndex = 116;
            labelinspiration.Text = "Inspiration :";
            // 
            // labelNomPersonnage
            // 
            labelNomPersonnage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNomPersonnage.AutoSize = true;
            labelNomPersonnage.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelNomPersonnage.Location = new Point(859, 86);
            labelNomPersonnage.Name = "labelNomPersonnage";
            labelNomPersonnage.Size = new Size(97, 35);
            labelNomPersonnage.TabIndex = 115;
            labelNomPersonnage.Text = "Nom : ";
            // 
            // pictureBoxPersonnage
            // 
            pictureBoxPersonnage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxPersonnage.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxPersonnage.Location = new Point(666, 86);
            pictureBoxPersonnage.Name = "pictureBoxPersonnage";
            pictureBoxPersonnage.Size = new Size(187, 217);
            pictureBoxPersonnage.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxPersonnage.TabIndex = 114;
            pictureBoxPersonnage.TabStop = false;
            // 
            // labelNationalite
            // 
            labelNationalite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNationalite.AutoSize = true;
            labelNationalite.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelNationalite.Location = new Point(859, 230);
            labelNationalite.Name = "labelNationalite";
            labelNationalite.Size = new Size(173, 35);
            labelNationalite.TabIndex = 119;
            labelNationalite.Text = "Nationalité : ";
            // 
            // form_PersonnageAlbumCRUD
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 780);
            Controls.Add(labelNationalite);
            Controls.Add(labelSexe);
            Controls.Add(labelTitrePersonnage);
            Controls.Add(labelinspiration);
            Controls.Add(labelNomPersonnage);
            Controls.Add(pictureBoxPersonnage);
            Controls.Add(labelisbn);
            Controls.Add(labelAnnee);
            Controls.Add(labelEdition);
            Controls.Add(labelTitre);
            Controls.Add(label50);
            Controls.Add(pictureBoxAlbum);
            Controls.Add(buttonQuitter);
            Controls.Add(buttonRetour);
            Controls.Add(textBoxRecherche);
            Controls.Add(labelRecherche);
            Controls.Add(buttonAjouter);
            Controls.Add(buttonSupprimer);
            Controls.Add(dataGridViewPersonnages);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "form_PersonnageAlbumCRUD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_PerosnnagesAlbumCRUD";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonnages).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbum).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonnage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonQuitter;
        private Button buttonRetour;
        private TextBox textBoxRecherche;
        private Label labelRecherche;
        private Button buttonAjouter;
        private Button buttonSupprimer;
        private DataGridView dataGridViewPersonnages;
        private Label labelisbn;
        private Label labelAnnee;
        private Label labelEdition;
        private Label labelTitre;
        private Label label50;
        private PictureBox pictureBoxAlbum;
        private Label labelSexe;
        private Label labelTitrePersonnage;
        private Label labelinspiration;
        private Label labelNomPersonnage;
        private PictureBox pictureBoxPersonnage;
        private Label labelNationalite;
    }
}
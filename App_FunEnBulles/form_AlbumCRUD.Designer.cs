namespace App_FunEnBulles
{
    partial class form_AlbumCRUD
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
            label6 = new Label();
            textBoxImage = new TextBox();
            label5 = new Label();
            textBoxAnnee = new TextBox();
            label1 = new Label();
            textBoxIsbn = new TextBox();
            pictureBoxImage = new PictureBox();
            textBoxRecherche = new TextBox();
            labelNomAnglais = new Label();
            textBoxEdition = new TextBox();
            labelTitre = new Label();
            labelRecherche = new Label();
            textBoxTitre = new TextBox();
            buttonAjouter = new Button();
            buttonModifier = new Button();
            buttonSupprimer = new Button();
            dataGridViewAlbums = new DataGridView();
            buttonViderChamps = new Button();
            buttonAlbum = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbums).BeginInit();
            SuspendLayout();
            // 
            // buttonQuitter
            // 
            buttonQuitter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuitter.BackColor = Color.DarkRed;
            buttonQuitter.ForeColor = Color.White;
            buttonQuitter.Location = new Point(1132, 12);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(128, 59);
            buttonQuitter.TabIndex = 77;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonRetour
            // 
            buttonRetour.BackColor = Color.Gold;
            buttonRetour.Location = new Point(12, 12);
            buttonRetour.Name = "buttonRetour";
            buttonRetour.Size = new Size(119, 59);
            buttonRetour.TabIndex = 76;
            buttonRetour.Text = "Retour";
            buttonRetour.UseVisualStyleBackColor = false;
            buttonRetour.Click += buttonRetour_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(604, 351);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 39);
            label6.TabIndex = 74;
            label6.Text = "Image* :";
            // 
            // textBoxImage
            // 
            textBoxImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxImage.Location = new Point(733, 348);
            textBoxImage.Margin = new Padding(6, 5, 6, 5);
            textBoxImage.Name = "textBoxImage";
            textBoxImage.Size = new Size(235, 47);
            textBoxImage.TabIndex = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 311);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 39);
            label5.TabIndex = 70;
            label5.Text = "Année* :";
            // 
            // textBoxAnnee
            // 
            textBoxAnnee.Location = new Point(180, 308);
            textBoxAnnee.Margin = new Padding(6, 5, 6, 5);
            textBoxAnnee.Name = "textBoxAnnee";
            textBoxAnnee.Size = new Size(402, 47);
            textBoxAnnee.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 168);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 39);
            label1.TabIndex = 64;
            label1.Text = "Isbn* : ";
            // 
            // textBoxIsbn
            // 
            textBoxIsbn.Location = new Point(180, 160);
            textBoxIsbn.Margin = new Padding(6, 5, 6, 5);
            textBoxIsbn.Name = "textBoxIsbn";
            textBoxIsbn.Size = new Size(402, 47);
            textBoxIsbn.TabIndex = 65;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxImage.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxImage.Location = new Point(671, 12);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(297, 319);
            pictureBoxImage.TabIndex = 63;
            pictureBoxImage.TabStop = false;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxRecherche.Location = new Point(809, 454);
            textBoxRecherche.Margin = new Padding(6, 5, 6, 5);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.Size = new Size(451, 47);
            textBoxRecherche.TabIndex = 62;
            textBoxRecherche.TextChanged += textBoxRecherche_TextChanged;
            // 
            // labelNomAnglais
            // 
            labelNomAnglais.AutoSize = true;
            labelNomAnglais.Location = new Point(29, 235);
            labelNomAnglais.Margin = new Padding(6, 0, 6, 0);
            labelNomAnglais.Name = "labelNomAnglais";
            labelNomAnglais.Size = new Size(139, 39);
            labelNomAnglais.TabIndex = 60;
            labelNomAnglais.Text = "Edition* :";
            // 
            // textBoxEdition
            // 
            textBoxEdition.Location = new Point(180, 232);
            textBoxEdition.Margin = new Padding(6, 5, 6, 5);
            textBoxEdition.Name = "textBoxEdition";
            textBoxEdition.Size = new Size(402, 47);
            textBoxEdition.TabIndex = 61;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Location = new Point(29, 94);
            labelTitre.Margin = new Padding(6, 0, 6, 0);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(125, 39);
            labelTitre.TabIndex = 53;
            labelTitre.Text = "Titre* : ";
            // 
            // labelRecherche
            // 
            labelRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelRecherche.AutoSize = true;
            labelRecherche.Location = new Point(621, 457);
            labelRecherche.Margin = new Padding(6, 0, 6, 0);
            labelRecherche.Name = "labelRecherche";
            labelRecherche.Size = new Size(176, 39);
            labelRecherche.TabIndex = 55;
            labelRecherche.Text = "Rechercher:";
            // 
            // textBoxTitre
            // 
            textBoxTitre.Location = new Point(155, 86);
            textBoxTitre.Margin = new Padding(6, 5, 6, 5);
            textBoxTitre.Name = "textBoxTitre";
            textBoxTitre.Size = new Size(427, 47);
            textBoxTitre.TabIndex = 56;
            // 
            // buttonAjouter
            // 
            buttonAjouter.AutoSize = true;
            buttonAjouter.BackColor = Color.Green;
            buttonAjouter.Location = new Point(15, 446);
            buttonAjouter.Margin = new Padding(6, 5, 6, 5);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(176, 49);
            buttonAjouter.TabIndex = 57;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = false;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.AutoSize = true;
            buttonModifier.Location = new Point(217, 446);
            buttonModifier.Margin = new Padding(6, 5, 6, 5);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(176, 49);
            buttonModifier.TabIndex = 58;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.AutoSize = true;
            buttonSupprimer.BackColor = Color.Red;
            buttonSupprimer.ForeColor = Color.White;
            buttonSupprimer.Location = new Point(419, 447);
            buttonSupprimer.Margin = new Padding(6, 5, 6, 5);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(176, 49);
            buttonSupprimer.TabIndex = 59;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // dataGridViewAlbums
            // 
            dataGridViewAlbums.AllowUserToAddRows = false;
            dataGridViewAlbums.AllowUserToDeleteRows = false;
            dataGridViewAlbums.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlbums.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAlbums.BackgroundColor = Color.White;
            dataGridViewAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlbums.Location = new Point(0, 508);
            dataGridViewAlbums.Margin = new Padding(6, 5, 6, 5);
            dataGridViewAlbums.MultiSelect = false;
            dataGridViewAlbums.Name = "dataGridViewAlbums";
            dataGridViewAlbums.ReadOnly = true;
            dataGridViewAlbums.RowHeadersWidth = 62;
            dataGridViewAlbums.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAlbums.Size = new Size(1273, 271);
            dataGridViewAlbums.TabIndex = 52;
            dataGridViewAlbums.CellClick += dataGridViewAlbums_CellClick;
            // 
            // buttonViderChamps
            // 
            buttonViderChamps.AutoSize = true;
            buttonViderChamps.Location = new Point(180, 388);
            buttonViderChamps.Margin = new Padding(6, 5, 6, 5);
            buttonViderChamps.Name = "buttonViderChamps";
            buttonViderChamps.Size = new Size(245, 49);
            buttonViderChamps.TabIndex = 78;
            buttonViderChamps.Text = "Vider les champs";
            buttonViderChamps.UseVisualStyleBackColor = true;
            buttonViderChamps.Click += buttonViderChamps_Click;
            // 
            // buttonAlbum
            // 
            buttonAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAlbum.BackColor = Color.DarkRed;
            buttonAlbum.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAlbum.ForeColor = Color.White;
            buttonAlbum.Location = new Point(1078, 168);
            buttonAlbum.Name = "buttonAlbum";
            buttonAlbum.Size = new Size(167, 163);
            buttonAlbum.TabIndex = 79;
            buttonAlbum.Text = "Ajouter ou supprimer les personnages de l'album";
            buttonAlbum.UseVisualStyleBackColor = false;
            buttonAlbum.Click += buttonAlbum_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 53);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 80;
            label2.Text = "*champ obligatoire";
            // 
            // form_AlbumCRUD
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 780);
            Controls.Add(label2);
            Controls.Add(buttonAlbum);
            Controls.Add(buttonViderChamps);
            Controls.Add(buttonQuitter);
            Controls.Add(buttonRetour);
            Controls.Add(label6);
            Controls.Add(textBoxImage);
            Controls.Add(label5);
            Controls.Add(textBoxAnnee);
            Controls.Add(label1);
            Controls.Add(textBoxIsbn);
            Controls.Add(pictureBoxImage);
            Controls.Add(textBoxRecherche);
            Controls.Add(labelNomAnglais);
            Controls.Add(textBoxEdition);
            Controls.Add(labelTitre);
            Controls.Add(labelRecherche);
            Controls.Add(textBoxTitre);
            Controls.Add(buttonAjouter);
            Controls.Add(buttonModifier);
            Controls.Add(buttonSupprimer);
            Controls.Add(dataGridViewAlbums);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "form_AlbumCRUD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Console d'aministration des Albums";
            Load += form_AlbumCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbums).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonQuitter;
        private Button buttonRetour;
        private Label label6;
        private TextBox textBoxImage;
        private PictureBox pictureBoxImage;
        private TextBox textBoxIsbn;
        private TextBox textBoxEdition;
        private RadioButton radioButtonSexeM;
        private RadioButton radioButtonSexeF;
        private Label label5;
        private TextBox textBoxNomAllemand;
        private Label label4;
        private TextBox textBoxTitre;
        private Label label3;
        private TextBox textBoxNationalite;
        private Label label1;
        private TextBox textBoxInspiration;
        private PictureBox pictureBoxPersonnageImage;
        private TextBox textBoxRecherche;
        private Label labelNomAnglais;
        private TextBox textBoxNomAnglais;
        private Label labelTitre;
        private Label label2;
        private Label labelRecherche;
        private TextBox textBoxAnnee;
        private Button buttonAjouter;
        private Button buttonModifier;
        private Button buttonSupprimer;
        private DataGridView dataGridViewAlbums;
        private Button buttonViderChamps;
        private Button buttonAlbum;
    }
}
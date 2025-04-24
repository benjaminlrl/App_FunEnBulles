namespace App_FunEnBulles
{
    partial class form_FichePersonnage
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
            labelinspiration = new Label();
            pictureBoxPersonnage = new PictureBox();
            labelNom = new Label();
            labelNomAnglais = new Label();
            labelNomAllemand = new Label();
            labelSexe = new Label();
            labelNationalite = new Label();
            buttonFermer = new Button();
            buttonExit = new Button();
            dataGridViewListeAlbums = new DataGridView();
            labelTitre = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonnage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListeAlbums).BeginInit();
            SuspendLayout();
            // 
            // labelinspiration
            // 
            labelinspiration.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelinspiration.Location = new Point(12, 353);
            labelinspiration.Name = "labelinspiration";
            labelinspiration.Size = new Size(680, 37);
            labelinspiration.TabIndex = 10;
            labelinspiration.Text = "Inspiration : ";
            // 
            // pictureBoxPersonnage
            // 
            pictureBoxPersonnage.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPersonnage.Location = new Point(253, 12);
            pictureBoxPersonnage.Name = "pictureBoxPersonnage";
            pictureBoxPersonnage.Size = new Size(187, 186);
            pictureBoxPersonnage.TabIndex = 8;
            pictureBoxPersonnage.TabStop = false;
            // 
            // labelNom
            // 
            labelNom.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelNom.Location = new Point(12, 205);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(486, 37);
            labelNom.TabIndex = 12;
            labelNom.Text = "Nom : ";
            // 
            // labelNomAnglais
            // 
            labelNomAnglais.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelNomAnglais.Location = new Point(12, 242);
            labelNomAnglais.Name = "labelNomAnglais";
            labelNomAnglais.Size = new Size(486, 37);
            labelNomAnglais.TabIndex = 13;
            labelNomAnglais.Text = "Nom anglais : ";
            // 
            // labelNomAllemand
            // 
            labelNomAllemand.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelNomAllemand.Location = new Point(12, 279);
            labelNomAllemand.Name = "labelNomAllemand";
            labelNomAllemand.Size = new Size(486, 37);
            labelNomAllemand.TabIndex = 14;
            labelNomAllemand.Text = "Nom allemand : ";
            // 
            // labelSexe
            // 
            labelSexe.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelSexe.Location = new Point(539, 338);
            labelSexe.Name = "labelSexe";
            labelSexe.Size = new Size(142, 37);
            labelSexe.TabIndex = 15;
            labelSexe.Text = "Sexe : ";
            // 
            // labelNationalite
            // 
            labelNationalite.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelNationalite.Location = new Point(12, 316);
            labelNationalite.Name = "labelNationalite";
            labelNationalite.Size = new Size(486, 37);
            labelNationalite.TabIndex = 16;
            labelNationalite.Text = "Nationalité : ";
            // 
            // buttonFermer
            // 
            buttonFermer.BackColor = Color.Gold;
            buttonFermer.Location = new Point(12, 12);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Size = new Size(133, 59);
            buttonFermer.TabIndex = 29;
            buttonFermer.Text = "Retour";
            buttonFermer.UseVisualStyleBackColor = false;
            buttonFermer.Click += buttonFermer_Click;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExit.BackColor = Color.DarkRed;
            buttonExit.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(539, 12);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(142, 59);
            buttonExit.TabIndex = 28;
            buttonExit.Text = "Quitter";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // dataGridViewListeAlbums
            // 
            dataGridViewListeAlbums.AllowUserToAddRows = false;
            dataGridViewListeAlbums.AllowUserToDeleteRows = false;
            dataGridViewListeAlbums.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewListeAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListeAlbums.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewListeAlbums.BackgroundColor = Color.White;
            dataGridViewListeAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListeAlbums.Location = new Point(0, 393);
            dataGridViewListeAlbums.Name = "dataGridViewListeAlbums";
            dataGridViewListeAlbums.RowHeadersWidth = 62;
            dataGridViewListeAlbums.Size = new Size(692, 323);
            dataGridViewListeAlbums.TabIndex = 30;
            dataGridViewListeAlbums.PreviewKeyDown += dataGridViewListeAlbums_PreviewKeyDown;
            // 
            // labelTitre
            // 
            labelTitre.AutoEllipsis = true;
            labelTitre.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelTitre.Location = new Point(455, 205);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(237, 121);
            labelTitre.TabIndex = 31;
            labelTitre.Text = "Titre : ";
            // 
            // form_FichePersonnage
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 716);
            ControlBox = false;
            Controls.Add(labelTitre);
            Controls.Add(dataGridViewListeAlbums);
            Controls.Add(buttonFermer);
            Controls.Add(buttonExit);
            Controls.Add(labelNationalite);
            Controls.Add(labelSexe);
            Controls.Add(labelNomAllemand);
            Controls.Add(labelNomAnglais);
            Controls.Add(labelNom);
            Controls.Add(labelinspiration);
            Controls.Add(pictureBoxPersonnage);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(5);
            Name = "form_FichePersonnage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fiche Personnage";
            Load += form_FichePersonnage_Load;
            PreviewKeyDown += form_FichePersonnage_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonnage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListeAlbums).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelinspiration;
        private PictureBox pictureBoxPersonnage;
        private Label labelNom;
        private Label labelNomAnglais;
        private Label labelNomAllemand;
        private Label labelSexe;
        private Label labelNationalite;
        private Button buttonFermer;
        private Button buttonExit;
        private DataGridView dataGridViewListeAlbums;
        private Label labelTitre;
    }
}
namespace App_FunEnBulles
{
    partial class form_FicheAlbum
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
            dataGridViewListePersonnagesAlbum = new DataGridView();
            labelisbn = new Label();
            labelAnnee = new Label();
            labelEdition = new Label();
            labelTitre = new Label();
            labelinspiration = new Label();
            pictureBoxAlbum = new PictureBox();
            buttonExit = new Button();
            buttonFermer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListePersonnagesAlbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbum).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListePersonnagesAlbum
            // 
            dataGridViewListePersonnagesAlbum.AllowUserToAddRows = false;
            dataGridViewListePersonnagesAlbum.AllowUserToDeleteRows = false;
            dataGridViewListePersonnagesAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewListePersonnagesAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListePersonnagesAlbum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewListePersonnagesAlbum.BackgroundColor = Color.White;
            dataGridViewListePersonnagesAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListePersonnagesAlbum.Location = new Point(0, 399);
            dataGridViewListePersonnagesAlbum.Name = "dataGridViewListePersonnagesAlbum";
            dataGridViewListePersonnagesAlbum.ReadOnly = true;
            dataGridViewListePersonnagesAlbum.RowHeadersWidth = 62;
            dataGridViewListePersonnagesAlbum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListePersonnagesAlbum.Size = new Size(692, 323);
            dataGridViewListePersonnagesAlbum.TabIndex = 25;
            // 
            // labelisbn
            // 
            labelisbn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelisbn.AutoSize = true;
            labelisbn.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelisbn.Location = new Point(12, 309);
            labelisbn.Name = "labelisbn";
            labelisbn.Size = new Size(97, 35);
            labelisbn.TabIndex = 24;
            labelisbn.Text = "Isbn : ";
            // 
            // labelAnnee
            // 
            labelAnnee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelAnnee.AutoSize = true;
            labelAnnee.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelAnnee.Location = new Point(470, 309);
            labelAnnee.Name = "labelAnnee";
            labelAnnee.Size = new Size(115, 35);
            labelAnnee.TabIndex = 23;
            labelAnnee.Text = "Année : ";
            // 
            // labelEdition
            // 
            labelEdition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEdition.AutoSize = true;
            labelEdition.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelEdition.Location = new Point(12, 272);
            labelEdition.Name = "labelEdition";
            labelEdition.Size = new Size(115, 35);
            labelEdition.TabIndex = 22;
            labelEdition.Text = "Edition :";
            // 
            // labelTitre
            // 
            labelTitre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelTitre.Location = new Point(12, 235);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(105, 35);
            labelTitre.TabIndex = 21;
            labelTitre.Text = "Titre : ";
            // 
            // labelinspiration
            // 
            labelinspiration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelinspiration.AutoSize = true;
            labelinspiration.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelinspiration.Location = new Point(12, 361);
            labelinspiration.Name = "labelinspiration";
            labelinspiration.Size = new Size(438, 35);
            labelinspiration.TabIndex = 19;
            labelinspiration.Text = "Personnages présents dans l'album :";
            // 
            // pictureBoxAlbum
            // 
            pictureBoxAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxAlbum.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAlbum.Location = new Point(253, 5);
            pictureBoxAlbum.Name = "pictureBoxAlbum";
            pictureBoxAlbum.Size = new Size(187, 217);
            pictureBoxAlbum.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxAlbum.TabIndex = 18;
            pictureBoxAlbum.TabStop = false;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExit.BackColor = Color.DarkRed;
            buttonExit.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(532, 12);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(149, 59);
            buttonExit.TabIndex = 26;
            buttonExit.Text = "Quitter";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonFermer
            // 
            buttonFermer.BackColor = Color.Gold;
            buttonFermer.Location = new Point(12, 12);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Size = new Size(133, 59);
            buttonFermer.TabIndex = 30;
            buttonFermer.Text = "Retour";
            buttonFermer.UseVisualStyleBackColor = false;
            buttonFermer.Click += buttonFermer_Click;
            // 
            // form_FicheAlbum
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 716);
            ControlBox = false;
            Controls.Add(buttonFermer);
            Controls.Add(buttonExit);
            Controls.Add(dataGridViewListePersonnagesAlbum);
            Controls.Add(labelisbn);
            Controls.Add(labelAnnee);
            Controls.Add(labelEdition);
            Controls.Add(labelTitre);
            Controls.Add(labelinspiration);
            Controls.Add(pictureBoxAlbum);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(5);
            Name = "form_FicheAlbum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fiche Album";
            Load += form_FicheAlbum_Load;
            PreviewKeyDown += form_FicheAlbum_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListePersonnagesAlbum).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewListePersonnagesAlbum;
        private Label labelisbn;
        private Label labelAnnee;
        private Label labelEdition;
        private Label labelTitre;
        private Label labelinspiration;
        private PictureBox pictureBoxAlbum;
        private Button buttonExit;
        private Button buttonFermer;
    }
}
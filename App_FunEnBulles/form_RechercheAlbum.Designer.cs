namespace App_FunEnBulles
{
    partial class form_RechercheAlbum
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
            dataGridViewAlbums = new DataGridView();
            label1 = new Label();
            textBoxRecherche = new TextBox();
            buttonMenu = new Button();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbums).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAlbums
            // 
            dataGridViewAlbums.AllowUserToAddRows = false;
            dataGridViewAlbums.AllowUserToDeleteRows = false;
            dataGridViewAlbums.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlbums.BackgroundColor = Color.White;
            dataGridViewAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlbums.Location = new Point(0, 289);
            dataGridViewAlbums.Name = "dataGridViewAlbums";
            dataGridViewAlbums.RowHeadersWidth = 62;
            dataGridViewAlbums.Size = new Size(1553, 617);
            dataGridViewAlbums.TabIndex = 0;
            dataGridViewAlbums.CellClick += dataGridViewAlbums_CellClick;
            dataGridViewAlbums.PreviewKeyDown += dataGridViewAlbums_PreviewKeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 152);
            label1.Name = "label1";
            label1.Size = new Size(506, 50);
            label1.TabIndex = 1;
            label1.Text = "Recherche sur les Albums :";
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRecherche.BorderStyle = BorderStyle.FixedSingle;
            textBoxRecherche.Location = new Point(774, 159);
            textBoxRecherche.Margin = new Padding(5);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.Size = new Size(524, 47);
            textBoxRecherche.TabIndex = 2;
            textBoxRecherche.TextChanged += textBoxRecherche_TextChanged;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.Gold;
            buttonMenu.Location = new Point(12, 12);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(119, 59);
            buttonMenu.TabIndex = 6;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExit.BackColor = Color.DarkRed;
            buttonExit.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(1422, 12);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(119, 59);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // form_RechercheAlbum
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1553, 902);
            Controls.Add(buttonExit);
            Controls.Add(buttonMenu);
            Controls.Add(textBoxRecherche);
            Controls.Add(label1);
            Controls.Add(dataGridViewAlbums);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "form_RechercheAlbum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_RechercheAlbum";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbums).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAlbums;
        private Label label1;
        private TextBox textBoxRecherche;
        private Button buttonMenu;
        private Button buttonExit;
    }
}
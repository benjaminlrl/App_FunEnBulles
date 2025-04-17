namespace App_FunEnBulles
{
    partial class form_RecherchePersonnageAjout
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
            buttonExit = new Button();
            buttonMenu = new Button();
            label1 = new Label();
            dataGridViewPersonnages = new DataGridView();
            textBoxRecherche = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonnages).BeginInit();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExit.BackColor = Color.DarkRed;
            buttonExit.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(1357, 12);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(119, 59);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.Gold;
            buttonMenu.Location = new Point(29, 12);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(119, 59);
            buttonMenu.TabIndex = 10;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 175);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(785, 50);
            label1.TabIndex = 9;
            label1.Text = "Rechercher dans l'encyclopédie d'Astérix :";
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
            dataGridViewPersonnages.GridColor = Color.Black;
            dataGridViewPersonnages.Location = new Point(-4, 399);
            dataGridViewPersonnages.Margin = new Padding(10, 8, 10, 8);
            dataGridViewPersonnages.Name = "dataGridViewPersonnages";
            dataGridViewPersonnages.ReadOnly = true;
            dataGridViewPersonnages.RowHeadersWidth = 62;
            dataGridViewPersonnages.Size = new Size(1517, 484);
            dataGridViewPersonnages.TabIndex = 8;
            dataGridViewPersonnages.CellClick += dataGridViewPersonnages_CellContentClick;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRecherche.BorderStyle = BorderStyle.FixedSingle;
            textBoxRecherche.Location = new Point(832, 181);
            textBoxRecherche.Margin = new Padding(5);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.Size = new Size(524, 47);
            textBoxRecherche.TabIndex = 7;
            textBoxRecherche.TextChanged += textBoxRecherche_TextChanged;
            // 
            // form_RecherchePersonnageAjout
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 894);
            Controls.Add(buttonExit);
            Controls.Add(buttonMenu);
            Controls.Add(label1);
            Controls.Add(dataGridViewPersonnages);
            Controls.Add(textBoxRecherche);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "form_RecherchePersonnageAjout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_RecherchePersonnageAjout";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonnages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExit;
        private Button buttonMenu;
        private Label label1;
        private DataGridView dataGridViewPersonnages;
        private TextBox textBoxRecherche;
    }
}
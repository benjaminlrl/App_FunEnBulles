namespace App_FunEnBulles
{
    partial class form_RecherchePersonnage
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
            textBoxRecherche = new TextBox();
            dataGridViewPersonnages = new DataGridView();
            label1 = new Label();
            buttonMenu = new Button();
            buttonExit = new Button();
            buttonRechercheAleatoirePersonnage = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonnages).BeginInit();
            SuspendLayout();
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRecherche.BorderStyle = BorderStyle.FixedSingle;
            textBoxRecherche.Location = new Point(832, 197);
            textBoxRecherche.Margin = new Padding(5);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.Size = new Size(524, 47);
            textBoxRecherche.TabIndex = 0;
            textBoxRecherche.TextChanged += textBoxRecherche_TextChanged;
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
            dataGridViewPersonnages.Location = new Point(-4, 415);
            dataGridViewPersonnages.Margin = new Padding(10, 8, 10, 8);
            dataGridViewPersonnages.Name = "dataGridViewPersonnages";
            dataGridViewPersonnages.ReadOnly = true;
            dataGridViewPersonnages.RowHeadersWidth = 62;
            dataGridViewPersonnages.Size = new Size(1517, 484);
            dataGridViewPersonnages.TabIndex = 2;
            dataGridViewPersonnages.CellContentClick += dataGridViewPersonnages_CellContentClick;
            dataGridViewPersonnages.PreviewKeyDown += dataGridViewPersonnages_PreviewKeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 191);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(785, 50);
            label1.TabIndex = 3;
            label1.Text = "Rechercher dans l'encyclopédie d'Astérix :";
            label1.Click += label1_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.Gold;
            buttonMenu.Location = new Point(29, 28);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(119, 59);
            buttonMenu.TabIndex = 4;
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
            buttonExit.Location = new Point(1357, 28);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(119, 59);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonRechercheAleatoirePersonnage
            // 
            buttonRechercheAleatoirePersonnage.BackColor = Color.Gold;
            buttonRechercheAleatoirePersonnage.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRechercheAleatoirePersonnage.Location = new Point(425, 285);
            buttonRechercheAleatoirePersonnage.Name = "buttonRechercheAleatoirePersonnage";
            buttonRechercheAleatoirePersonnage.Size = new Size(558, 78);
            buttonRechercheAleatoirePersonnage.TabIndex = 6;
            buttonRechercheAleatoirePersonnage.Text = "Découvrir un personnage";
            buttonRechercheAleatoirePersonnage.UseVisualStyleBackColor = false;
            buttonRechercheAleatoirePersonnage.Click += buttonRechercheAleatoirePersonnage_Click;
            // 
            // form_RecherchePersonnage
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 894);
            Controls.Add(buttonRechercheAleatoirePersonnage);
            Controls.Add(buttonExit);
            Controls.Add(buttonMenu);
            Controls.Add(label1);
            Controls.Add(dataGridViewPersonnages);
            Controls.Add(textBoxRecherche);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "form_RecherchePersonnage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonnages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRecherche;
        private DataGridView dataGridViewPersonnages;
        private Label label1;
        private Button buttonMenu;
        private Button buttonExit;
        private Button buttonRechercheAleatoirePersonnage;
    }
}
namespace App_FunEnBulles
{
    partial class form_Acceuil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonRecherchePersonnages = new Button();
            buttonConsulterAlbums = new Button();
            label1 = new Label();
            buttonExit = new Button();
            buttonParametre = new Button();
            SuspendLayout();
            // 
            // buttonRecherchePersonnages
            // 
            buttonRecherchePersonnages.Anchor = AnchorStyles.None;
            buttonRecherchePersonnages.BackColor = Color.Gold;
            buttonRecherchePersonnages.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRecherchePersonnages.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRecherchePersonnages.Image = Properties.Resources.loupe1;
            buttonRecherchePersonnages.Location = new Point(82, 305);
            buttonRecherchePersonnages.Margin = new Padding(5);
            buttonRecherchePersonnages.Name = "buttonRecherchePersonnages";
            buttonRecherchePersonnages.RightToLeft = RightToLeft.No;
            buttonRecherchePersonnages.Size = new Size(481, 86);
            buttonRecherchePersonnages.TabIndex = 0;
            buttonRecherchePersonnages.Text = "Rechercher un personnages";
            buttonRecherchePersonnages.TextAlign = ContentAlignment.MiddleRight;
            buttonRecherchePersonnages.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonRecherchePersonnages.UseVisualStyleBackColor = false;
            buttonRecherchePersonnages.Click += buttonRecherchePersonnages_Click;
            // 
            // buttonConsulterAlbums
            // 
            buttonConsulterAlbums.Anchor = AnchorStyles.None;
            buttonConsulterAlbums.BackColor = Color.DarkRed;
            buttonConsulterAlbums.BackgroundImageLayout = ImageLayout.Zoom;
            buttonConsulterAlbums.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConsulterAlbums.ForeColor = Color.White;
            buttonConsulterAlbums.Image = Properties.Resources.livre;
            buttonConsulterAlbums.Location = new Point(647, 305);
            buttonConsulterAlbums.Margin = new Padding(5);
            buttonConsulterAlbums.Name = "buttonConsulterAlbums";
            buttonConsulterAlbums.RightToLeft = RightToLeft.No;
            buttonConsulterAlbums.Size = new Size(468, 86);
            buttonConsulterAlbums.TabIndex = 1;
            buttonConsulterAlbums.Text = "Consulter les albums";
            buttonConsulterAlbums.TextAlign = ContentAlignment.MiddleRight;
            buttonConsulterAlbums.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonConsulterAlbums.UseVisualStyleBackColor = false;
            buttonConsulterAlbums.Click += buttonConsulterAlbums_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 166);
            label1.Name = "label1";
            label1.Size = new Size(659, 50);
            label1.TabIndex = 2;
            label1.Text = "L'encyclopédie intéractive d'Astérix";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExit.BackColor = Color.DarkRed;
            buttonExit.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(1096, 641);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(133, 59);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Quitter";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonParametre
            // 
            buttonParametre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonParametre.BackgroundImage = Properties.Resources.parametre;
            buttonParametre.BackgroundImageLayout = ImageLayout.Center;
            buttonParametre.Location = new Point(1155, 12);
            buttonParametre.Name = "buttonParametre";
            buttonParametre.Size = new Size(67, 63);
            buttonParametre.TabIndex = 7;
            buttonParametre.UseVisualStyleBackColor = true;
            buttonParametre.Click += buttonParametre_Click;
            // 
            // form_Acceuil
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 712);
            Controls.Add(buttonParametre);
            Controls.Add(buttonExit);
            Controls.Add(label1);
            Controls.Add(buttonConsulterAlbums);
            Controls.Add(buttonRecherchePersonnages);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "form_Acceuil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "L'encyclopédie intéractive d'Astérix";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRecherchePersonnages;
        private Button buttonConsulterAlbums;
        private Label label1;
        private Button buttonExit;
        private Button buttonParametre;
    }
}

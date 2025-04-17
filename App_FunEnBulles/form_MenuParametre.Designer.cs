namespace App_FunEnBulles
{
    partial class form_MenuParametre
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
            label1 = new Label();
            buttonPersonnage = new Button();
            buttonAlbum = new Button();
            buttonFermer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 111);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(371, 50);
            label1.TabIndex = 0;
            label1.Text = "Panneau de contrôle";
            // 
            // buttonPersonnage
            // 
            buttonPersonnage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPersonnage.BackColor = Color.Gold;
            buttonPersonnage.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPersonnage.Location = new Point(63, 187);
            buttonPersonnage.Name = "buttonPersonnage";
            buttonPersonnage.Size = new Size(426, 114);
            buttonPersonnage.TabIndex = 1;
            buttonPersonnage.Text = "Ajouter modifier supprimer un personnage";
            buttonPersonnage.UseVisualStyleBackColor = false;
            buttonPersonnage.Click += buttonPersonnage_Click;
            // 
            // buttonAlbum
            // 
            buttonAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAlbum.BackColor = Color.DarkRed;
            buttonAlbum.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAlbum.ForeColor = Color.White;
            buttonAlbum.Location = new Point(63, 341);
            buttonAlbum.Name = "buttonAlbum";
            buttonAlbum.Size = new Size(426, 114);
            buttonAlbum.TabIndex = 2;
            buttonAlbum.Text = "Ajouter modifier supprimer un album";
            buttonAlbum.UseVisualStyleBackColor = false;
            buttonAlbum.Click += button1_Click;
            // 
            // buttonFermer
            // 
            buttonFermer.BackColor = Color.Gold;
            buttonFermer.Location = new Point(12, 12);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Size = new Size(133, 59);
            buttonFermer.TabIndex = 31;
            buttonFermer.Text = "Fermer";
            buttonFermer.UseVisualStyleBackColor = false;
            buttonFermer.Click += buttonFermer_Click;
            // 
            // form_MenuParametre
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 759);
            Controls.Add(buttonFermer);
            Controls.Add(buttonAlbum);
            Controls.Add(buttonPersonnage);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "form_MenuParametre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_MenuParametre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonPersonnage;
        private Button buttonAlbum;
        private Button buttonFermer;
    }
}
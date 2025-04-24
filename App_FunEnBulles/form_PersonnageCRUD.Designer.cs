namespace App_FunEnBulles
{
    partial class form_PersonnageCRUD
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
            labelNomAnglais = new Label();
            textBoxNomAnglais = new TextBox();
            labelDescription = new Label();
            labelNom = new Label();
            label2 = new Label();
            labelRecherche = new Label();
            textBoxNom = new TextBox();
            buttonAjouter = new Button();
            buttonModifier = new Button();
            buttonSupprimer = new Button();
            dataGridViewPersonnages = new DataGridView();
            textBoxRecherche = new TextBox();
            pictureBoxPersonnageImage = new PictureBox();
            label1 = new Label();
            textBoxInspiration = new TextBox();
            label3 = new Label();
            textBoxNationalite = new TextBox();
            label4 = new Label();
            textBoxTitre = new TextBox();
            label5 = new Label();
            textBoxNomAllemand = new TextBox();
            radioButtonSexeF = new RadioButton();
            radioButtonSexeM = new RadioButton();
            label6 = new Label();
            textBoxImage = new TextBox();
            buttonRetour = new Button();
            buttonQuitter = new Button();
            buttonViderChamps = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonnages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonnageImage).BeginInit();
            SuspendLayout();
            // 
            // labelNomAnglais
            // 
            labelNomAnglais.AutoSize = true;
            labelNomAnglais.Location = new Point(27, 202);
            labelNomAnglais.Margin = new Padding(6, 0, 6, 0);
            labelNomAnglais.Name = "labelNomAnglais";
            labelNomAnglais.Size = new Size(195, 39);
            labelNomAnglais.TabIndex = 34;
            labelNomAnglais.Text = "Nom anglais : ";
            // 
            // textBoxNomAnglais
            // 
            textBoxNomAnglais.Location = new Point(240, 199);
            textBoxNomAnglais.Margin = new Padding(6, 5, 6, 5);
            textBoxNomAnglais.Name = "textBoxNomAnglais";
            textBoxNomAnglais.Size = new Size(340, 47);
            textBoxNomAnglais.TabIndex = 35;
            // 
            // labelDescription
            // 
            labelDescription.Location = new Point(620, -27);
            labelDescription.Margin = new Padding(6, 0, 6, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(126, 25);
            labelDescription.TabIndex = 32;
            labelDescription.Text = "Description :";
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(27, 96);
            labelNom.Margin = new Padding(6, 0, 6, 0);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(116, 39);
            labelNom.TabIndex = 21;
            labelNom.Text = "Nom* : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 424);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 39);
            label2.TabIndex = 23;
            label2.Text = "Sexe* : ";
            // 
            // labelRecherche
            // 
            labelRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelRecherche.AutoSize = true;
            labelRecherche.Location = new Point(663, 469);
            labelRecherche.Margin = new Padding(6, 0, 6, 0);
            labelRecherche.Name = "labelRecherche";
            labelRecherche.Size = new Size(176, 39);
            labelRecherche.TabIndex = 24;
            labelRecherche.Text = "Rechercher:";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(153, 88);
            textBoxNom.Margin = new Padding(6, 5, 6, 5);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(427, 47);
            textBoxNom.TabIndex = 25;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAjouter.AutoSize = true;
            buttonAjouter.BackColor = Color.Green;
            buttonAjouter.Location = new Point(1053, 116);
            buttonAjouter.Margin = new Padding(6, 5, 6, 5);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(176, 59);
            buttonAjouter.TabIndex = 29;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = false;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonModifier.AutoSize = true;
            buttonModifier.Location = new Point(1053, 202);
            buttonModifier.Margin = new Padding(6, 5, 6, 5);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(176, 59);
            buttonModifier.TabIndex = 30;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSupprimer.AutoSize = true;
            buttonSupprimer.BackColor = Color.Red;
            buttonSupprimer.ForeColor = Color.White;
            buttonSupprimer.Location = new Point(1053, 291);
            buttonSupprimer.Margin = new Padding(6, 5, 6, 5);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(176, 64);
            buttonSupprimer.TabIndex = 31;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
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
            dataGridViewPersonnages.Location = new Point(0, 528);
            dataGridViewPersonnages.Margin = new Padding(6, 5, 6, 5);
            dataGridViewPersonnages.Name = "dataGridViewPersonnages";
            dataGridViewPersonnages.ReadOnly = true;
            dataGridViewPersonnages.RowHeadersWidth = 62;
            dataGridViewPersonnages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPersonnages.Size = new Size(1273, 261);
            dataGridViewPersonnages.TabIndex = 20;
            dataGridViewPersonnages.CellContentClick += dataGridViewPersonnages_CellContentClick;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxRecherche.Location = new Point(874, 461);
            textBoxRecherche.Margin = new Padding(6, 5, 6, 5);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.Size = new Size(386, 47);
            textBoxRecherche.TabIndex = 36;
            textBoxRecherche.TextChanged += textBoxRecherche_TextChanged;
            // 
            // pictureBoxPersonnageImage
            // 
            pictureBoxPersonnageImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxPersonnageImage.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxPersonnageImage.Location = new Point(614, 25);
            pictureBoxPersonnageImage.Name = "pictureBoxPersonnageImage";
            pictureBoxPersonnageImage.Size = new Size(361, 308);
            pictureBoxPersonnageImage.TabIndex = 37;
            pictureBoxPersonnageImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 150);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 39);
            label1.TabIndex = 38;
            label1.Text = "Inspiration* : ";
            // 
            // textBoxInspiration
            // 
            textBoxInspiration.Location = new Point(240, 142);
            textBoxInspiration.Margin = new Padding(6, 5, 6, 5);
            textBoxInspiration.Name = "textBoxInspiration";
            textBoxInspiration.Size = new Size(340, 47);
            textBoxInspiration.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 373);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(184, 39);
            label3.TabIndex = 40;
            label3.Text = "Nationalité : ";
            // 
            // textBoxNationalite
            // 
            textBoxNationalite.Location = new Point(240, 370);
            textBoxNationalite.Margin = new Padding(6, 5, 6, 5);
            textBoxNationalite.Name = "textBoxNationalite";
            textBoxNationalite.Size = new Size(340, 47);
            textBoxNationalite.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 316);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 39);
            label4.TabIndex = 42;
            label4.Text = "Titre : ";
            // 
            // textBoxTitre
            // 
            textBoxTitre.Location = new Point(153, 313);
            textBoxTitre.Margin = new Padding(6, 5, 6, 5);
            textBoxTitre.Name = "textBoxTitre";
            textBoxTitre.Size = new Size(427, 47);
            textBoxTitre.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 259);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(212, 39);
            label5.TabIndex = 44;
            label5.Text = "Nom allemand :";
            // 
            // textBoxNomAllemand
            // 
            textBoxNomAllemand.Location = new Point(240, 256);
            textBoxNomAllemand.Margin = new Padding(6, 5, 6, 5);
            textBoxNomAllemand.Name = "textBoxNomAllemand";
            textBoxNomAllemand.Size = new Size(340, 47);
            textBoxNomAllemand.TabIndex = 45;
            // 
            // radioButtonSexeF
            // 
            radioButtonSexeF.AutoSize = true;
            radioButtonSexeF.Location = new Point(334, 422);
            radioButtonSexeF.Name = "radioButtonSexeF";
            radioButtonSexeF.Size = new Size(59, 43);
            radioButtonSexeF.TabIndex = 46;
            radioButtonSexeF.TabStop = true;
            radioButtonSexeF.Text = "F";
            radioButtonSexeF.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexeM
            // 
            radioButtonSexeM.AutoSize = true;
            radioButtonSexeM.Location = new Point(423, 422);
            radioButtonSexeM.Name = "radioButtonSexeM";
            radioButtonSexeM.Size = new Size(66, 43);
            radioButtonSexeM.TabIndex = 47;
            radioButtonSexeM.TabStop = true;
            radioButtonSexeM.Text = "M";
            radioButtonSexeM.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(614, 358);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 39);
            label6.TabIndex = 48;
            label6.Text = "Image :";
            // 
            // textBoxImage
            // 
            textBoxImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxImage.Location = new Point(740, 350);
            textBoxImage.Margin = new Padding(6, 5, 6, 5);
            textBoxImage.Name = "textBoxImage";
            textBoxImage.Size = new Size(235, 47);
            textBoxImage.TabIndex = 49;
            // 
            // buttonRetour
            // 
            buttonRetour.BackColor = Color.Gold;
            buttonRetour.Location = new Point(12, 12);
            buttonRetour.Name = "buttonRetour";
            buttonRetour.Size = new Size(119, 59);
            buttonRetour.TabIndex = 50;
            buttonRetour.Text = "Retour";
            buttonRetour.UseVisualStyleBackColor = false;
            buttonRetour.Click += buttonRetour_Click;
            // 
            // buttonQuitter
            // 
            buttonQuitter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuitter.BackColor = Color.DarkRed;
            buttonQuitter.ForeColor = Color.White;
            buttonQuitter.Location = new Point(1132, 12);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(128, 59);
            buttonQuitter.TabIndex = 51;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonViderChamps
            // 
            buttonViderChamps.AutoSize = true;
            buttonViderChamps.Location = new Point(276, 469);
            buttonViderChamps.Margin = new Padding(6, 5, 6, 5);
            buttonViderChamps.Name = "buttonViderChamps";
            buttonViderChamps.Size = new Size(245, 49);
            buttonViderChamps.TabIndex = 79;
            buttonViderChamps.Text = "Vider les champs";
            buttonViderChamps.UseVisualStyleBackColor = true;
            buttonViderChamps.Click += buttonViderChamps_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(153, 55);
            label7.Name = "label7";
            label7.Size = new Size(187, 28);
            label7.TabIndex = 81;
            label7.Text = "*champ obligatoire";
            // 
            // form_PersonnageCRUD
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 780);
            Controls.Add(label7);
            Controls.Add(buttonViderChamps);
            Controls.Add(buttonQuitter);
            Controls.Add(buttonRetour);
            Controls.Add(label6);
            Controls.Add(textBoxImage);
            Controls.Add(radioButtonSexeM);
            Controls.Add(radioButtonSexeF);
            Controls.Add(label5);
            Controls.Add(textBoxNomAllemand);
            Controls.Add(label4);
            Controls.Add(textBoxTitre);
            Controls.Add(label3);
            Controls.Add(textBoxNationalite);
            Controls.Add(label1);
            Controls.Add(textBoxInspiration);
            Controls.Add(pictureBoxPersonnageImage);
            Controls.Add(textBoxRecherche);
            Controls.Add(labelNomAnglais);
            Controls.Add(textBoxNomAnglais);
            Controls.Add(labelDescription);
            Controls.Add(labelNom);
            Controls.Add(label2);
            Controls.Add(labelRecherche);
            Controls.Add(textBoxNom);
            Controls.Add(buttonAjouter);
            Controls.Add(buttonModifier);
            Controls.Add(buttonSupprimer);
            Controls.Add(dataGridViewPersonnages);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "form_PersonnageCRUD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Console d'aministration des Personnages";
            Load += form_PersonnageCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonnages).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonnageImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNomAnglais;
        private TextBox textBoxNomAnglais;
        private Label labelDescription;
        private Label labelNom;
        private Label label2;
        private Label labelRecherche;
        private TextBox textBoxNom;
        private Button buttonAjouter;
        private Button buttonModifier;
        private Button buttonSupprimer;
        private DataGridView dataGridViewPersonnages;
        private TextBox textBoxRecherche;
        private PictureBox pictureBoxPersonnageImage;
        private Label label1;
        private TextBox textBoxInspiration;
        private Label label3;
        private TextBox textBoxNationalite;
        private Label label4;
        private TextBox textBoxTitre;
        private Label label5;
        private TextBox textBoxNomAllemand;
        private RadioButton radioButtonSexeF;
        private RadioButton radioButtonSexeM;
        private Label label6;
        private TextBox textBoxImage;
        private Button buttonRetour;
        private Button buttonQuitter;
        private Button buttonViderChamps;
        private Label label7;
    }
}
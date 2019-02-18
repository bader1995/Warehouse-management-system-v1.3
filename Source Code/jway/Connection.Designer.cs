namespace jway
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_db_nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bc_annuler = new System.Windows.Forms.Button();
            this.bc_connecter = new System.Windows.Forms.Button();
            this.list_type_authentification = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mot_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom_utilisateur = new System.Windows.Forms.TextBox();
            this.txt_nom_serveur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txt_db_nom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bc_annuler);
            this.panel1.Controls.Add(this.bc_connecter);
            this.panel1.Controls.Add(this.list_type_authentification);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_mot_pass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_nom_utilisateur);
            this.panel1.Controls.Add(this.txt_nom_serveur);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 273);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Location = new System.Drawing.Point(200, 180);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Supprimer la configuration";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(171, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Enregistrer les informations";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_db_nom
            // 
            this.txt_db_nom.Location = new System.Drawing.Point(171, 46);
            this.txt_db_nom.Name = "txt_db_nom";
            this.txt_db_nom.Size = new System.Drawing.Size(182, 20);
            this.txt_db_nom.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nom de base de données :";
            // 
            // bc_annuler
            // 
            this.bc_annuler.BackColor = System.Drawing.Color.Red;
            this.bc_annuler.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_annuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bc_annuler.Location = new System.Drawing.Point(278, 231);
            this.bc_annuler.Name = "bc_annuler";
            this.bc_annuler.Size = new System.Drawing.Size(75, 31);
            this.bc_annuler.TabIndex = 9;
            this.bc_annuler.Text = "Annuler";
            this.bc_annuler.UseVisualStyleBackColor = false;
            this.bc_annuler.Click += new System.EventHandler(this.bc_annuler_Click);
            // 
            // bc_connecter
            // 
            this.bc_connecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bc_connecter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_connecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bc_connecter.Location = new System.Drawing.Point(171, 231);
            this.bc_connecter.Name = "bc_connecter";
            this.bc_connecter.Size = new System.Drawing.Size(75, 31);
            this.bc_connecter.TabIndex = 8;
            this.bc_connecter.Text = "Connecter";
            this.bc_connecter.UseVisualStyleBackColor = false;
            this.bc_connecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_type_authentification
            // 
            this.list_type_authentification.FormattingEnabled = true;
            this.list_type_authentification.Items.AddRange(new object[] {
            "Authentification Windows",
            "Authentification SQL Server"});
            this.list_type_authentification.Location = new System.Drawing.Point(171, 79);
            this.list_type_authentification.Name = "list_type_authentification";
            this.list_type_authentification.Size = new System.Drawing.Size(182, 21);
            this.list_type_authentification.TabIndex = 3;
            this.list_type_authentification.SelectedIndexChanged += new System.EventHandler(this.list_type_authentification_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mode d\'authentification :";
            // 
            // txt_mot_pass
            // 
            this.txt_mot_pass.Enabled = false;
            this.txt_mot_pass.Location = new System.Drawing.Point(171, 150);
            this.txt_mot_pass.Name = "txt_mot_pass";
            this.txt_mot_pass.PasswordChar = '*';
            this.txt_mot_pass.Size = new System.Drawing.Size(182, 20);
            this.txt_mot_pass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe :";
            // 
            // txt_nom_utilisateur
            // 
            this.txt_nom_utilisateur.Enabled = false;
            this.txt_nom_utilisateur.Location = new System.Drawing.Point(171, 115);
            this.txt_nom_utilisateur.Name = "txt_nom_utilisateur";
            this.txt_nom_utilisateur.Size = new System.Drawing.Size(182, 20);
            this.txt_nom_utilisateur.TabIndex = 4;
            // 
            // txt_nom_serveur
            // 
            this.txt_nom_serveur.Location = new System.Drawing.Point(171, 14);
            this.txt_nom_serveur.Name = "txt_nom_serveur";
            this.txt_nom_serveur.Size = new System.Drawing.Size(182, 20);
            this.txt_nom_serveur.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom d\'utilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de serveur :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jway.Properties.Resources.boxbarimage5;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(417, 490);
            this.Name = "Connection";
            this.Text = "Jwork WMS: Connexion";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox list_type_authentification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mot_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nom_utilisateur;
        private System.Windows.Forms.TextBox txt_nom_serveur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bc_annuler;
        private System.Windows.Forms.Button bc_connecter;
        private System.Windows.Forms.TextBox txt_db_nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
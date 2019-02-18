namespace jway
{
    partial class produit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produit));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_rechercher = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_sortie = new System.Windows.Forms.DateTimePicker();
            this.txt_entree = new System.Windows.Forms.DateTimePicker();
            this.date_expiration = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_quantité = new System.Windows.Forms.TextBox();
            this.bc_ajouter = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.bc_supprimer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bc_modifier = new System.Windows.Forms.Button();
            this.bc_vider = new System.Windows.Forms.Button();
            this.bc_retour = new System.Windows.Forms.Button();
            this.list_type = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.list_categorie = new System.Windows.Forms.ComboBox();
            this.list_cage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list_etage = new System.Windows.Forms.ComboBox();
            this.txt_poids = new System.Windows.Forms.TextBox();
            this.txt_prix = new System.Windows.Forms.TextBox();
            this.txt_libelle = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bc_imprimer = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(453, 484);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // txt_rechercher
            // 
            this.txt_rechercher.Location = new System.Drawing.Point(533, 19);
            this.txt_rechercher.Name = "txt_rechercher";
            this.txt_rechercher.Size = new System.Drawing.Size(224, 20);
            this.txt_rechercher.TabIndex = 16;
            this.txt_rechercher.TextChanged += new System.EventHandler(this.txt_rechercher_TextChanged);
            this.txt_rechercher.Enter += new System.EventHandler(this.txt_rechercher_Enter);
            this.txt_rechercher.MouseLeave += new System.EventHandler(this.txt_rechercher_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txt_sortie);
            this.panel2.Controls.Add(this.txt_entree);
            this.panel2.Controls.Add(this.date_expiration);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt_quantité);
            this.panel2.Controls.Add(this.bc_ajouter);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.bc_supprimer);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bc_modifier);
            this.panel2.Controls.Add(this.bc_vider);
            this.panel2.Controls.Add(this.bc_retour);
            this.panel2.Controls.Add(this.list_type);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.list_categorie);
            this.panel2.Controls.Add(this.list_cage);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.list_etage);
            this.panel2.Controls.Add(this.txt_poids);
            this.panel2.Controls.Add(this.txt_prix);
            this.panel2.Controls.Add(this.txt_libelle);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 518);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(370, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(369, 488);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 10);
            this.label15.TabIndex = 43;
            this.label15.Text = "F4";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Blue;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(267, 488);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 10);
            this.label16.TabIndex = 42;
            this.label16.Text = "F3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Red;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(175, 488);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 10);
            this.label17.TabIndex = 41;
            this.label17.Text = "F2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(74, 488);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 10);
            this.label18.TabIndex = 40;
            this.label18.Text = "F1";
            // 
            // txt_sortie
            // 
            this.txt_sortie.Enabled = false;
            this.txt_sortie.Location = new System.Drawing.Point(142, 289);
            this.txt_sortie.Name = "txt_sortie";
            this.txt_sortie.Size = new System.Drawing.Size(221, 20);
            this.txt_sortie.TabIndex = 7;
            // 
            // txt_entree
            // 
            this.txt_entree.Enabled = false;
            this.txt_entree.Location = new System.Drawing.Point(141, 289);
            this.txt_entree.Name = "txt_entree";
            this.txt_entree.Size = new System.Drawing.Size(222, 20);
            this.txt_entree.TabIndex = 39;
            this.txt_entree.Visible = false;
            // 
            // date_expiration
            // 
            this.date_expiration.Location = new System.Drawing.Point(142, 256);
            this.date_expiration.Name = "date_expiration";
            this.date_expiration.Size = new System.Drawing.Size(221, 20);
            this.date_expiration.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(229, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(139, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 12);
            this.label14.TabIndex = 36;
            this.label14.Text = "Code à barre :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 35;
            this.label13.Text = "Quantité :";
            // 
            // txt_quantité
            // 
            this.txt_quantité.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantité.Location = new System.Drawing.Point(142, 420);
            this.txt_quantité.Name = "txt_quantité";
            this.txt_quantité.Size = new System.Drawing.Size(222, 20);
            this.txt_quantité.TabIndex = 11;
            this.txt_quantité.TextChanged += new System.EventHandler(this.txt_quantité_TextChanged);
            // 
            // bc_ajouter
            // 
            this.bc_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bc_ajouter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_ajouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bc_ajouter.Location = new System.Drawing.Point(12, 462);
            this.bc_ajouter.Name = "bc_ajouter";
            this.bc_ajouter.Size = new System.Drawing.Size(82, 42);
            this.bc_ajouter.TabIndex = 12;
            this.bc_ajouter.Text = "Ajouter";
            this.bc_ajouter.UseVisualStyleBackColor = false;
            this.bc_ajouter.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "Date de sortie :";
            // 
            // bc_supprimer
            // 
            this.bc_supprimer.BackColor = System.Drawing.Color.Red;
            this.bc_supprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_supprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bc_supprimer.Location = new System.Drawing.Point(106, 462);
            this.bc_supprimer.Name = "bc_supprimer";
            this.bc_supprimer.Size = new System.Drawing.Size(89, 42);
            this.bc_supprimer.TabIndex = 13;
            this.bc_supprimer.Text = "Supprimer";
            this.bc_supprimer.UseVisualStyleBackColor = false;
            this.bc_supprimer.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "Date d\'entrée :";
            this.label5.Visible = false;
            // 
            // bc_modifier
            // 
            this.bc_modifier.BackColor = System.Drawing.Color.Blue;
            this.bc_modifier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_modifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bc_modifier.Location = new System.Drawing.Point(205, 462);
            this.bc_modifier.Name = "bc_modifier";
            this.bc_modifier.Size = new System.Drawing.Size(82, 42);
            this.bc_modifier.TabIndex = 14;
            this.bc_modifier.Text = "Modifier";
            this.bc_modifier.UseVisualStyleBackColor = false;
            this.bc_modifier.Click += new System.EventHandler(this.button4_Click);
            // 
            // bc_vider
            // 
            this.bc_vider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bc_vider.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_vider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bc_vider.Location = new System.Drawing.Point(301, 462);
            this.bc_vider.Name = "bc_vider";
            this.bc_vider.Size = new System.Drawing.Size(89, 42);
            this.bc_vider.TabIndex = 15;
            this.bc_vider.Text = "Vider";
            this.bc_vider.UseVisualStyleBackColor = false;
            this.bc_vider.Click += new System.EventHandler(this.button6_Click);
            // 
            // bc_retour
            // 
            this.bc_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_retour.Image = global::jway.Properties.Resources.if_arrow_return_up_left_11219;
            this.bc_retour.Location = new System.Drawing.Point(12, 15);
            this.bc_retour.Name = "bc_retour";
            this.bc_retour.Size = new System.Drawing.Size(39, 33);
            this.bc_retour.TabIndex = 0;
            this.bc_retour.UseVisualStyleBackColor = true;
            this.bc_retour.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_type
            // 
            this.list_type.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_type.FormattingEnabled = true;
            this.list_type.Location = new System.Drawing.Point(141, 149);
            this.list_type.Name = "list_type";
            this.list_type.Size = new System.Drawing.Size(222, 20);
            this.list_type.TabIndex = 3;
            this.list_type.SelectedIndexChanged += new System.EventHandler(this.list_type_SelectedIndexChanged);
            this.list_type.SelectedValueChanged += new System.EventHandler(this.list_type_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "Type :";
            // 
            // list_categorie
            // 
            this.list_categorie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_categorie.FormattingEnabled = true;
            this.list_categorie.Location = new System.Drawing.Point(141, 181);
            this.list_categorie.Name = "list_categorie";
            this.list_categorie.Size = new System.Drawing.Size(222, 20);
            this.list_categorie.TabIndex = 4;
            // 
            // list_cage
            // 
            this.list_cage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_cage.FormattingEnabled = true;
            this.list_cage.Location = new System.Drawing.Point(142, 82);
            this.list_cage.Name = "list_cage";
            this.list_cage.Size = new System.Drawing.Size(222, 20);
            this.list_cage.TabIndex = 1;
            this.list_cage.SelectedIndexChanged += new System.EventHandler(this.list_cage_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cage :";
            // 
            // list_etage
            // 
            this.list_etage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_etage.FormattingEnabled = true;
            this.list_etage.Location = new System.Drawing.Point(141, 118);
            this.list_etage.Name = "list_etage";
            this.list_etage.Size = new System.Drawing.Size(222, 20);
            this.list_etage.TabIndex = 2;
            // 
            // txt_poids
            // 
            this.txt_poids.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_poids.Location = new System.Drawing.Point(142, 391);
            this.txt_poids.Name = "txt_poids";
            this.txt_poids.Size = new System.Drawing.Size(222, 20);
            this.txt_poids.TabIndex = 10;
            this.txt_poids.TextChanged += new System.EventHandler(this.txt_poids_TextChanged);
            // 
            // txt_prix
            // 
            this.txt_prix.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix.Location = new System.Drawing.Point(142, 354);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(222, 20);
            this.txt_prix.TabIndex = 9;
            this.txt_prix.TextChanged += new System.EventHandler(this.txt_prix_TextChanged);
            // 
            // txt_libelle
            // 
            this.txt_libelle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_libelle.Location = new System.Drawing.Point(142, 322);
            this.txt_libelle.Name = "txt_libelle";
            this.txt_libelle.Size = new System.Drawing.Size(222, 20);
            this.txt_libelle.TabIndex = 8;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(142, 215);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(222, 20);
            this.txt_id.TabIndex = 5;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "Poids :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "Etage :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "Catégorie :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Prix :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Libelle :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date d\'éxpiration :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rechercher (F11):";
            // 
            // bc_imprimer
            // 
            this.bc_imprimer.BackgroundImage = global::jway.Properties.Resources.if_Print_1493286;
            this.bc_imprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bc_imprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_imprimer.Location = new System.Drawing.Point(763, 17);
            this.bc_imprimer.Name = "bc_imprimer";
            this.bc_imprimer.Size = new System.Drawing.Size(55, 23);
            this.bc_imprimer.TabIndex = 18;
            this.bc_imprimer.UseVisualStyleBackColor = true;
            this.bc_imprimer.Click += new System.EventHandler(this.bc_imprimer_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(821, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 12);
            this.label19.TabIndex = 19;
            this.label19.Text = "(F12)";
            // 
            // produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 538);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.bc_imprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_rechercher);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "produit";
            this.Text = "Jwork WMS: Produit";
            this.Load += new System.EventHandler(this.produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bc_retour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_rechercher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_poids;
        private System.Windows.Forms.TextBox txt_prix;
        private System.Windows.Forms.TextBox txt_libelle;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox list_etage;
        private System.Windows.Forms.ComboBox list_cage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox list_categorie;
        private System.Windows.Forms.ComboBox list_type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bc_ajouter;
        private System.Windows.Forms.Button bc_supprimer;
        private System.Windows.Forms.Button bc_modifier;
        private System.Windows.Forms.Button bc_vider;
        private System.Windows.Forms.TextBox txt_quantité;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bc_imprimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker txt_sortie;
        private System.Windows.Forms.DateTimePicker txt_entree;
        private System.Windows.Forms.DateTimePicker date_expiration;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
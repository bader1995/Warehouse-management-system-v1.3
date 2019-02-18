namespace jway
{
    partial class cage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bc_modifier = new System.Windows.Forms.Button();
            this.bc_ajouter = new System.Windows.Forms.Button();
            this.bc_supprimer = new System.Windows.Forms.Button();
            this.txt_rechercher = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bc_vider = new System.Windows.Forms.Button();
            this.txt_poids = new System.Windows.Forms.TextBox();
            this.bc_retour = new System.Windows.Forms.Button();
            this.txt_capacite = new System.Windows.Forms.TextBox();
            this.txt_nbr_etage = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(326, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(392, 344);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // bc_modifier
            // 
            this.bc_modifier.BackColor = System.Drawing.Color.Blue;
            this.bc_modifier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_modifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bc_modifier.Location = new System.Drawing.Point(55, 277);
            this.bc_modifier.Name = "bc_modifier";
            this.bc_modifier.Size = new System.Drawing.Size(91, 46);
            this.bc_modifier.TabIndex = 7;
            this.bc_modifier.Text = "Modifier";
            this.bc_modifier.UseVisualStyleBackColor = false;
            this.bc_modifier.Click += new System.EventHandler(this.button3_Click);
            // 
            // bc_ajouter
            // 
            this.bc_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bc_ajouter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_ajouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bc_ajouter.Location = new System.Drawing.Point(55, 225);
            this.bc_ajouter.Name = "bc_ajouter";
            this.bc_ajouter.Size = new System.Drawing.Size(91, 46);
            this.bc_ajouter.TabIndex = 5;
            this.bc_ajouter.Text = "Ajouter";
            this.bc_ajouter.UseVisualStyleBackColor = false;
            this.bc_ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // bc_supprimer
            // 
            this.bc_supprimer.BackColor = System.Drawing.Color.Red;
            this.bc_supprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_supprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bc_supprimer.Location = new System.Drawing.Point(158, 225);
            this.bc_supprimer.Name = "bc_supprimer";
            this.bc_supprimer.Size = new System.Drawing.Size(91, 46);
            this.bc_supprimer.TabIndex = 6;
            this.bc_supprimer.Text = "Supprimer";
            this.bc_supprimer.UseVisualStyleBackColor = false;
            this.bc_supprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_rechercher
            // 
            this.txt_rechercher.Location = new System.Drawing.Point(436, 20);
            this.txt_rechercher.Name = "txt_rechercher";
            this.txt_rechercher.Size = new System.Drawing.Size(282, 20);
            this.txt_rechercher.TabIndex = 9;
            this.txt_rechercher.TextChanged += new System.EventHandler(this.txt_rechercher_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bc_vider);
            this.panel2.Controls.Add(this.txt_poids);
            this.panel2.Controls.Add(this.bc_retour);
            this.panel2.Controls.Add(this.bc_modifier);
            this.panel2.Controls.Add(this.txt_capacite);
            this.panel2.Controls.Add(this.bc_supprimer);
            this.panel2.Controls.Add(this.bc_ajouter);
            this.panel2.Controls.Add(this.txt_nbr_etage);
            this.panel2.Controls.Add(this.txt_numero);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 370);
            this.panel2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(229, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 10);
            this.label10.TabIndex = 12;
            this.label10.Text = "F4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(124, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 10);
            this.label9.TabIndex = 11;
            this.label9.Text = "F3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(229, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 10);
            this.label8.TabIndex = 10;
            this.label8.Text = "F2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(124, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 10);
            this.label7.TabIndex = 9;
            this.label7.Text = "F1";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 8;
            // 
            // bc_vider
            // 
            this.bc_vider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bc_vider.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_vider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bc_vider.Location = new System.Drawing.Point(158, 277);
            this.bc_vider.Name = "bc_vider";
            this.bc_vider.Size = new System.Drawing.Size(91, 46);
            this.bc_vider.TabIndex = 8;
            this.bc_vider.Text = "Vider";
            this.bc_vider.UseVisualStyleBackColor = false;
            this.bc_vider.Click += new System.EventHandler(this.bc_vider_Click);
            // 
            // txt_poids
            // 
            this.txt_poids.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_poids.Location = new System.Drawing.Point(114, 171);
            this.txt_poids.Name = "txt_poids";
            this.txt_poids.Size = new System.Drawing.Size(159, 20);
            this.txt_poids.TabIndex = 4;
            this.txt_poids.TextChanged += new System.EventHandler(this.txt_poids_TextChanged);
            // 
            // bc_retour
            // 
            this.bc_retour.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_retour.Image = global::jway.Properties.Resources.if_arrow_return_up_left_11219;
            this.bc_retour.Location = new System.Drawing.Point(12, 13);
            this.bc_retour.Name = "bc_retour";
            this.bc_retour.Size = new System.Drawing.Size(46, 29);
            this.bc_retour.TabIndex = 10;
            this.bc_retour.UseVisualStyleBackColor = true;
            this.bc_retour.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_capacite
            // 
            this.txt_capacite.Enabled = false;
            this.txt_capacite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_capacite.Location = new System.Drawing.Point(114, 139);
            this.txt_capacite.Name = "txt_capacite";
            this.txt_capacite.Size = new System.Drawing.Size(159, 20);
            this.txt_capacite.TabIndex = 3;
            this.txt_capacite.Text = "0";
            this.txt_capacite.TextChanged += new System.EventHandler(this.txt_capacite_TextChanged);
            // 
            // txt_nbr_etage
            // 
            this.txt_nbr_etage.Enabled = false;
            this.txt_nbr_etage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nbr_etage.Location = new System.Drawing.Point(114, 105);
            this.txt_nbr_etage.Name = "txt_nbr_etage";
            this.txt_nbr_etage.Size = new System.Drawing.Size(159, 20);
            this.txt_nbr_etage.TabIndex = 2;
            this.txt_nbr_etage.Text = "0";
            this.txt_nbr_etage.TextChanged += new System.EventHandler(this.txt_nbr_etage_TextChanged);
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(114, 70);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(159, 20);
            this.txt_numero.TabIndex = 1;
            this.txt_numero.TextChanged += new System.EventHandler(this.txt_numero_TextChanged);
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poids de cage :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre d\'étage :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rechercher (F11):";
            // 
            // cage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 404);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_rechercher);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "cage";
            this.Text = "Jwork WMS: Cage";
            this.Load += new System.EventHandler(this.cage_Load);
            this.TextChanged += new System.EventHandler(this.cage_TextChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cage_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bc_ajouter;
        private System.Windows.Forms.Button bc_modifier;
        private System.Windows.Forms.Button bc_supprimer;
        private System.Windows.Forms.Button bc_retour;
        private System.Windows.Forms.TextBox txt_rechercher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_poids;
        private System.Windows.Forms.TextBox txt_capacite;
        private System.Windows.Forms.TextBox txt_nbr_etage;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bc_vider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
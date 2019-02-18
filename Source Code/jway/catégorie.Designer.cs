namespace jway
{
    partial class catégorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catégorie));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bc_modifier = new System.Windows.Forms.Button();
            this.bc_supprimer = new System.Windows.Forms.Button();
            this.bc_ajouter = new System.Windows.Forms.Button();
            this.txt_rechercher = new System.Windows.Forms.TextBox();
            this.bc_vider = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bc_retour = new System.Windows.Forms.Button();
            this.list_type = new System.Windows.Forms.ComboBox();
            this.txt_date_creation = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(360, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(446, 364);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // bc_modifier
            // 
            this.bc_modifier.BackColor = System.Drawing.Color.Blue;
            this.bc_modifier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_modifier.ForeColor = System.Drawing.Color.White;
            this.bc_modifier.Location = new System.Drawing.Point(82, 322);
            this.bc_modifier.Name = "bc_modifier";
            this.bc_modifier.Size = new System.Drawing.Size(91, 46);
            this.bc_modifier.TabIndex = 6;
            this.bc_modifier.Text = "Modifier";
            this.bc_modifier.UseVisualStyleBackColor = false;
            this.bc_modifier.Click += new System.EventHandler(this.button4_Click);
            // 
            // bc_supprimer
            // 
            this.bc_supprimer.BackColor = System.Drawing.Color.Red;
            this.bc_supprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_supprimer.ForeColor = System.Drawing.Color.White;
            this.bc_supprimer.Location = new System.Drawing.Point(179, 270);
            this.bc_supprimer.Name = "bc_supprimer";
            this.bc_supprimer.Size = new System.Drawing.Size(91, 46);
            this.bc_supprimer.TabIndex = 5;
            this.bc_supprimer.Text = "Supprimer";
            this.bc_supprimer.UseVisualStyleBackColor = false;
            this.bc_supprimer.Click += new System.EventHandler(this.button3_Click);
            // 
            // bc_ajouter
            // 
            this.bc_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bc_ajouter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_ajouter.ForeColor = System.Drawing.Color.White;
            this.bc_ajouter.Location = new System.Drawing.Point(82, 270);
            this.bc_ajouter.Name = "bc_ajouter";
            this.bc_ajouter.Size = new System.Drawing.Size(91, 46);
            this.bc_ajouter.TabIndex = 4;
            this.bc_ajouter.Text = "Ajouter";
            this.bc_ajouter.UseVisualStyleBackColor = false;
            this.bc_ajouter.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_rechercher
            // 
            this.txt_rechercher.Location = new System.Drawing.Point(471, 28);
            this.txt_rechercher.Name = "txt_rechercher";
            this.txt_rechercher.Size = new System.Drawing.Size(335, 20);
            this.txt_rechercher.TabIndex = 8;
            this.txt_rechercher.TextChanged += new System.EventHandler(this.txt_rechercher_TextChanged);
            // 
            // bc_vider
            // 
            this.bc_vider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bc_vider.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_vider.ForeColor = System.Drawing.Color.White;
            this.bc_vider.Location = new System.Drawing.Point(179, 322);
            this.bc_vider.Name = "bc_vider";
            this.bc_vider.Size = new System.Drawing.Size(91, 46);
            this.bc_vider.TabIndex = 7;
            this.bc_vider.Text = "Vider";
            this.bc_vider.UseVisualStyleBackColor = false;
            this.bc_vider.Click += new System.EventHandler(this.bc_vider_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.bc_retour);
            this.panel2.Controls.Add(this.list_type);
            this.panel2.Controls.Add(this.txt_date_creation);
            this.panel2.Controls.Add(this.txt_nom);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bc_modifier);
            this.panel2.Controls.Add(this.bc_vider);
            this.panel2.Controls.Add(this.bc_ajouter);
            this.panel2.Controls.Add(this.bc_supprimer);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 395);
            this.panel2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(249, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 10);
            this.label10.TabIndex = 16;
            this.label10.Text = "F4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(151, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 10);
            this.label9.TabIndex = 15;
            this.label9.Text = "F3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(249, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 10);
            this.label8.TabIndex = 14;
            this.label8.Text = "F2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(151, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 10);
            this.label7.TabIndex = 13;
            this.label7.Text = "F1";
            // 
            // bc_retour
            // 
            this.bc_retour.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_retour.Image = global::jway.Properties.Resources.if_arrow_return_up_left_11219;
            this.bc_retour.Location = new System.Drawing.Point(15, 17);
            this.bc_retour.Name = "bc_retour";
            this.bc_retour.Size = new System.Drawing.Size(49, 33);
            this.bc_retour.TabIndex = 9;
            this.bc_retour.UseVisualStyleBackColor = true;
            this.bc_retour.Click += new System.EventHandler(this.bc_retour_Click);
            // 
            // list_type
            // 
            this.list_type.FormattingEnabled = true;
            this.list_type.Location = new System.Drawing.Point(143, 79);
            this.list_type.Name = "list_type";
            this.list_type.Size = new System.Drawing.Size(165, 21);
            this.list_type.TabIndex = 1;
            // 
            // txt_date_creation
            // 
            this.txt_date_creation.Enabled = false;
            this.txt_date_creation.Location = new System.Drawing.Point(143, 163);
            this.txt_date_creation.Name = "txt_date_creation";
            this.txt_date_creation.Size = new System.Drawing.Size(165, 20);
            this.txt_date_creation.TabIndex = 3;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(143, 119);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(165, 20);
            this.txt_nom.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(143, 116);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(165, 20);
            this.txt_id.TabIndex = 1;
            this.txt_id.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date de Registration :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id :";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rechercher (F11) :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(143, 31);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 12);
            this.lbl_date.TabIndex = 17;
            // 
            // catégorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_rechercher);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "catégorie";
            this.Text = "Jwork WMS : Catégorie";
            this.Load += new System.EventHandler(this.catégorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bc_retour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bc_modifier;
        private System.Windows.Forms.Button bc_supprimer;
        private System.Windows.Forms.Button bc_ajouter;
        private System.Windows.Forms.TextBox txt_rechercher;
        private System.Windows.Forms.Button bc_vider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox list_type;
        private System.Windows.Forms.TextBox txt_date_creation;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_date;
    }
}
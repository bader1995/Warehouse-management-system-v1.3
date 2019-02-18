namespace jway
{
    partial class Profil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_cin = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_mot_passe = new System.Windows.Forms.TextBox();
            this.date_registration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_confirmation = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_confirmation);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.date_registration);
            this.panel1.Controls.Add(this.txt_mot_passe);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_prenom);
            this.panel1.Controls.Add(this.txt_nom);
            this.panel1.Controls.Add(this.txt_cin);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 424);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_cin
            // 
            this.txt_cin.Location = new System.Drawing.Point(159, 54);
            this.txt_cin.Name = "txt_cin";
            this.txt_cin.ReadOnly = true;
            this.txt_cin.Size = new System.Drawing.Size(198, 20);
            this.txt_cin.TabIndex = 0;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(159, 96);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(198, 20);
            this.txt_nom.TabIndex = 1;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(159, 140);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(198, 20);
            this.txt_prenom.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(159, 180);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(198, 20);
            this.txt_email.TabIndex = 3;
            // 
            // txt_mot_passe
            // 
            this.txt_mot_passe.Location = new System.Drawing.Point(159, 222);
            this.txt_mot_passe.Name = "txt_mot_passe";
            this.txt_mot_passe.PasswordChar = '*';
            this.txt_mot_passe.Size = new System.Drawing.Size(198, 20);
            this.txt_mot_passe.TabIndex = 4;
            // 
            // date_registration
            // 
            this.date_registration.Location = new System.Drawing.Point(159, 298);
            this.date_registration.Name = "date_registration";
            this.date_registration.ReadOnly = true;
            this.date_registration.Size = new System.Drawing.Size(198, 20);
            this.date_registration.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "CIN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "E-mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mot de passe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date de registration :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_annuler);
            this.panel2.Controls.Add(this.btn_modifier);
            this.panel2.Location = new System.Drawing.Point(159, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 66);
            this.panel2.TabIndex = 13;
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.Blue;
            this.btn_modifier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_modifier.Location = new System.Drawing.Point(12, 12);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(85, 41);
            this.btn_modifier.TabIndex = 1;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.Red;
            this.btn_annuler.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_annuler.Location = new System.Drawing.Point(103, 12);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(85, 41);
            this.btn_annuler.TabIndex = 2;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.label7.Location = new System.Drawing.Point(26, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Confirmation :";
            // 
            // txt_confirmation
            // 
            this.txt_confirmation.Location = new System.Drawing.Point(159, 261);
            this.txt_confirmation.Name = "txt_confirmation";
            this.txt_confirmation.PasswordChar = '*';
            this.txt_confirmation.Size = new System.Drawing.Size(198, 20);
            this.txt_confirmation.TabIndex = 15;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 448);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 487);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 487);
            this.Name = "Profil";
            this.Text = "Jwork WMS: Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox date_registration;
        private System.Windows.Forms.TextBox txt_mot_passe;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_cin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.TextBox txt_confirmation;
        private System.Windows.Forms.Label label7;
    }
}
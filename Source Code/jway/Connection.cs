using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace jway
{
    public partial class Connection : Form
    {
        public static SqlConnection cnx;
        public static string cnx_string;

        public Connection()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                bc_connecter.PerformClick();
                return true;

            }else if(keyData == (Keys.Escape))
            {
                bc_annuler.PerformClick();
                return true;

            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                try
                {
                    File.Delete(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\log.txt");
                    MessageBox.Show("la configuration et bien supprimer.", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    linkLabel1.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }else if(keyData == (Keys.Control | Keys.Tab))
            {
                if(checkBox1.Checked == false)
                {
                    checkBox1.Checked = true;
                }else
                {
                    checkBox1.Checked = false;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_nom_serveur.Text != "" && txt_db_nom.Text != "")
                {
                    string nom_serveur = txt_nom_serveur.Text;
                    string nom_utilisateur = txt_nom_utilisateur.Text;
                    string mot_pass = txt_mot_pass.Text;
                    string db_name = txt_db_nom.Text;

                    if (list_type_authentification.SelectedItem.ToString() == "Authentification Windows")
                    {
                        cnx = new SqlConnection("Data Source=" + nom_serveur + "; Integrated Security=TRUE; Initial Catalog=" + txt_db_nom.Text);
                        cnx.Open();

                        cnx_string = "Data Source=" + nom_serveur + "; Integrated Security=TRUE; Initial Catalog=" + txt_db_nom.Text;

                        if (checkBox1.Checked == true && cnx.State == System.Data.ConnectionState.Open)
                        {
                            if (txt_nom_utilisateur.Enabled == false)
                            {
                                string createText = "Authentification Windows : \n" + nom_serveur + "\n" + db_name;
                                File.WriteAllText(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\log.txt", createText);
                            }
                        }

                        MessageBox.Show("Bien connecter au base de données : " + db_name, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (list_type_authentification.SelectedItem.ToString() == "Authentification SQL Server")
                    {
                        cnx = new SqlConnection("Data Source=" + nom_serveur + "; Integrated Security=FALSE; Initial Catalog=" + db_name + "; User ID=" + txt_nom_utilisateur.Text + "; Password=" + txt_mot_pass.Text);
                        cnx.Open();

                        cnx_string = "Data Source=" + nom_serveur + "; Integrated Security=FALSE; Initial Catalog=" + db_name + "; User ID=" + txt_nom_utilisateur.Text + "; Password=" + txt_mot_pass.Text;

                        if (checkBox1.Checked == true && cnx.State == System.Data.ConnectionState.Open)
                        {
                            string createText = "Authentification SQL Server : \n" + nom_serveur + "\n" + db_name + "\n" + nom_utilisateur + "\n" + mot_pass;
                            File.WriteAllText(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\log.txt", createText);
                        }

                        MessageBox.Show("Bien connecter au base de données : " + db_name, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }else
                {
                    MessageBox.Show("Remplissez tous les champs!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Problem d'authentification : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            if(File.Exists(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\log.txt"))
            {
                linkLabel1.Enabled = true;
            }
        }

        private void list_type_authentification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(list_type_authentification.SelectedItem.ToString() == "Authentification Windows")
            {
                txt_nom_utilisateur.Enabled = false;
                txt_mot_pass.Enabled = false;

            }else
            {
                txt_nom_utilisateur.Enabled = true;
                txt_mot_pass.Enabled = true;
            }
        }

        private void bc_annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                File.Delete(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\log.txt");
                MessageBox.Show("la configuration et bien supprimer.", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
                linkLabel1.Enabled = false;

            }catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

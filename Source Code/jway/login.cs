using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace jway
{
    public partial class login : Form
    {
        public SqlConnection cnx;
        public SqlCommand cmd;
        public SqlDataAdapter dap;
        public DataSet ds;
        public static string user;
        public static string nom;
        public static string cin;
        public static string prénom;
        public static string id;

        public login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin cr = new admin();
            cr.Show();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_email.Text != "" && txt_password.Text != "")
            {
                try
                {
                    if(!File.Exists(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\log.txt"))
                    {
                        cnx = new SqlConnection(Connection.cnx_string);
                        cnx.Open();

                    }else
                    {
                        string readText = File.ReadAllText(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\log.txt");

                        if (readText.Contains("Windows"))
                        {

                            List<string> found = new List<string>();
                            string line;
                            using (StreamReader file = new StreamReader(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\log.txt"))
                            {
                                while ((line = file.ReadLine()) != null)
                                {
                                    found.Add(line);
                                }
                            }

                            cnx = new SqlConnection("Data Source=" + found[1].ToString() + "; Integrated Security=TRUE; Initial Catalog=" + found[2].ToString());
                            cnx.Open();
                            Connection.cnx = cnx;

                        }
                        else if (readText.Contains("SQL"))
                        {
                            List<string> found = new List<string>();
                            string line;
                            using (StreamReader file = new StreamReader(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\log.txt"))
                            {
                                while ((line = file.ReadLine()) != null)
                                {
                                    found.Add(line);
                                }
                            }

                            cnx = new SqlConnection("Data Source=" + found[1].ToString() + "; Integrated Security=FALSE; Initial Catalog=" + found[2].ToString() + "; User ID=" + found[3].ToString() + "; Password=" + found[4].ToString());
                            cnx.Open();
                            Connection.cnx = cnx;
                        }
                    }

                    cmd = new SqlCommand("select * from utilisateurs where [e-mail] = @email and [Mot de passe] = @mot_de_passe", cnx);

                    cmd.Parameters.Add("@email", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@mot_de_passe", SqlDbType.NVarChar);

                    cmd.Parameters["@email"].Value = txt_email.Text;
                    cmd.Parameters["@mot_de_passe"].Value = Base64Encode(txt_password.Text);

                    dap = new SqlDataAdapter(cmd);

                    ds = new DataSet();

                    dap.Fill(ds, "utilisateurs");

                    if (ds.Tables["utilisateurs"].Rows.Count > 0)
                    {
                        user = ds.Tables["utilisateurs"].Rows[0]["type"].ToString();
                        nom = ds.Tables["utilisateurs"].Rows[0][1].ToString();
                        prénom = ds.Tables["utilisateurs"].Rows[0][2].ToString();
                        id = ds.Tables["utilisateurs"].Rows[0]["cin"].ToString();

                        string cin = ds.Tables["utilisateurs"].Rows[0][0].ToString();

                        cmd.CommandText = "update utilisateurs set [date de dernière connexion] = getdate() where cin = '" + cin + "'";
                        cmd.Connection = cnx;
                        cmd.ExecuteNonQuery();

                        index cm = new index();

                        cm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email / Mot de passe, Incorrect!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch
                {
                    MessageBox.Show("Problem de connexion!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }else
            {
                MessageBox.Show("Remplissez tous les champs!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                btn_login.PerformClick();
                return true;

            }else if (keyData == (Keys.Escape))
            {
                bc_annuler.PerformClick();
                return true;
            
            }else if (keyData == (Keys.F8))
            {
                verification dm = new verification();
                dm.Show();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void login_Load(object sender, EventArgs e)
        {
            try
            {
                this.CenterToScreen();
                label3.Text = DateTime.Now.ToString();

            }catch(Exception ex)
            {
                MessageBox.Show("Problem de connection : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bc_annuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }

        private void paramétresToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void configurationDeServeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verification vc = new verification();
            vc.Show();
        }
    }
}

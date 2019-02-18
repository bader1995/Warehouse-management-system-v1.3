using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace jway
{
    public partial class admin : Form
    {
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter dap;

        public admin()
        {
            InitializeComponent();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string password)
        {
            byte[] data = Convert.FromBase64String(password);
            string decodedString = Encoding.UTF8.GetString(data);

            return decodedString;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btn_inscription_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_cin.Text != "" && txt_nom.Text != "" && txt_prenom.Text != "" && txt_email.Text != "" && txt_mot_de_passe.Text != "" && txt_confirmation.Text != "")
                {
                    if(txt_mot_de_passe.Text == txt_confirmation.Text)
                    {

                        if(IsValidEmail(txt_email.Text))
                        {
                            cmd.CommandText = "insert into utilisateurs ([cin], [Nom], [Prénom], [e-mail], [Mot de passe], [Type]) values ('" + txt_cin.Text + "', '" + txt_nom.Text + "', '" + txt_prenom.Text + "', '" + txt_email.Text + "', '" + Base64Encode(txt_mot_de_passe.Text) + "', '" + type_list.SelectedItem.ToString() + "')";
                            cmd.Connection = Connection.cnx;

                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "select * from utilisateurs";
                            ds = new DataSet();
                            dap = new SqlDataAdapter(cmd);
                            dap.Fill(ds, "utilisateurs");
                            dataGridView1.DataSource = ds.Tables["utilisateurs"];
                            dataGridView1.Refresh();

                            MessageBox.Show("L'utilisateur et bien ajouter!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }else
                        {
                            MessageBox.Show("L'adresse email n'est pas valid!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }else
                    {
                        MessageBox.Show("Mot de passe et Confirmation n'est pas identique!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }else
                {
                    MessageBox.Show("Remplissez tous les champs!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch
            {
                MessageBox.Show("Problem d'ajout : L'utilisateur et déja existe", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                btn_ajouter.PerformClick();
                return true;

            }
            else if (keyData == (Keys.F2))
            {
                btn_supprimer.PerformClick();
                return true;

            }
            else if (keyData == (Keys.F3))
            {
                btn_modifier.PerformClick();
                return true;

            }
            else if (keyData == Keys.Escape)
            {
                bc_retour.PerformClick();
                return true;

            }
            else if (keyData == Keys.F4)
            {
                btn_vider.PerformClick();

            }
            else if (keyData == (Keys.G | Keys.Control))
            {
                dataGridView1.Focus();

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                }
            }
            else if (keyData == Keys.F11)
            {
                txt_rechercher.Focus();
            }
            else if(keyData == (Keys.Control | Keys.I))
            {
                txt_cin.Focus();
            
            }else if(keyData == (Keys.Control | Keys.Tab) )
            {
                if(checkBox1.Checked == true)
                {
                    checkBox1.Checked = false;
                }else
                {
                    checkBox1.Checked = true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Inscription_Load(object sender, EventArgs e)
        {

           try
           {

               lbl_date.Text = DateTime.Now.ToString();

               WindowState = FormWindowState.Maximized;

               this.CenterToScreen();

               type_list.Items.Add("Admin");
               type_list.Items.Add("Utilisateur");

               cmd = new SqlCommand();
               cmd.Connection = Connection.cnx;
               cmd.CommandText = "select * from utilisateurs";

               ds = new DataSet();

               dap = new SqlDataAdapter(cmd);

               dap.Fill(ds, "utilisateurs");

               dataGridView1.DataSource = ds.Tables["utilisateurs"];

               dataGridView1.Refresh();

           }catch (Exception ex)
           {
               MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cin.Text != "" && txt_nom.Text != "" && txt_prenom.Text != "" && txt_email.Text != "" && txt_mot_de_passe.Text != "" && txt_confirmation.Text != "")
                {
                    if (txt_mot_de_passe.Text == txt_confirmation.Text)
                    {
                        if (IsValidEmail(txt_email.Text))
                        {
                            cmd = new SqlCommand();
                            cmd.CommandText = "update utilisateurs set [Nom] = '" + txt_nom.Text + "', [Prénom] = '" + txt_prenom.Text + "', [e-mail] = '" + txt_email.Text + "', [Mot de passe] = '" + Base64Encode(txt_mot_de_passe.Text) + "', [type] = '" + type_list.SelectedItem.ToString() + "' where cin = '" + txt_cin.Text + "'";
                            cmd.Connection = Connection.cnx;

                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "select * from utilisateurs";
                            ds = new DataSet();
                            dap = new SqlDataAdapter(cmd);
                            dap.Fill(ds, "utilisateurs");
                            dataGridView1.DataSource = ds.Tables["utilisateurs"];
                            dataGridView1.Refresh();

                            MessageBox.Show("Les informations et bien modifier!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("L'adresse email n'est pas valid!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Mot de passe et Confirmation n'est pas identique!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }else
                {
                    MessageBox.Show("Remplissez tous les champs!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem de modification : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void bc_retour_Click(object sender, EventArgs e)
        {
            index dm = new index();
            dm.Show();
            this.Hide();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand();

                int p = dataGridView1.CurrentCell.RowIndex;
                txt_cin.Text = dataGridView1.Rows[p].Cells["cin"].Value.ToString();
                cmd.CommandText = "delete from utilisateurs where cin = '" + txt_cin.Text + "'";
                cmd.Connection = Connection.cnx;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select * from utilisateurs";
                ds = new DataSet();
                dap = new SqlDataAdapter(cmd);
                dap.Fill(ds, "utilisateurs");
                dataGridView1.DataSource = ds.Tables["utilisateurs"];
                dataGridView1.Refresh();

            }catch (Exception ex)
            {
                MessageBox.Show("Problem de suppression : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ClearSelection();
                txt_cin.Clear();
                txt_nom.Clear();
                txt_prenom.Clear();
                txt_email.Clear();
                txt_mot_de_passe.Clear();
                txt_confirmation.Clear();
                type_list.SelectedIndex = -1;
                btn_modifier.Enabled = false;
                btn_supprimer.Enabled = false;

            }catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void rechercher(string valeur)
        {

            if (valeur == "")
            {
                string query = "SELECT * FROM utilisateurs";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.cnx);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                string query = "SELECT * FROM utilisateurs WHERE cin like '%" + valeur + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.cnx);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rechercher(txt_rechercher.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jway", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int p = dataGridView1.CurrentCell.RowIndex;

                txt_cin.Text = dataGridView1.Rows[p].Cells["cin"].Value.ToString();
                txt_nom.Text = dataGridView1.Rows[p].Cells["nom"].Value.ToString();
                txt_prenom.Text = dataGridView1.Rows[p].Cells["prénom"].Value.ToString();
                txt_email.Text = dataGridView1.Rows[p].Cells["e-mail"].Value.ToString();
                type_list.SelectedItem = dataGridView1.Rows[p].Cells["type"].Value;
                txt_mot_de_passe.Text = Base64Decode(dataGridView1.Rows[p].Cells["mot de passe"].Value.ToString());

                btn_supprimer.Enabled = true;
                btn_modifier.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_mot_de_passe.PasswordChar == '*')
            {
                txt_mot_de_passe.PasswordChar = '\0';

            }else
            {
                txt_mot_de_passe.PasswordChar = '*';
            }
        }

        private void configurerLeServeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.Show();
        }
    }
}

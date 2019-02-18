using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jway
{
    public partial class cage : Form
    {
        public SqlCommand cmd;
        public SqlDataAdapter dap;
        public DataSet ds;
        public SqlCommandBuilder cb;

        public cage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_nbr_etage.Text != "" && txt_capacite.Text != "" && txt_poids.Text != "")
                {
                    cmd.CommandText = "insert into cage (Numéro, [Nombre d'étage], [Quantité total], [Poids de cage]) values ('" + txt_numero.Text + "','" + txt_nbr_etage.Text + "', '" + txt_capacite.Text + "', '" + txt_poids.Text + "')";
                    cmd.Connection = Connection.cnx;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Le cage et bien ajouter.", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.ClearSelection();

                    ds.Reset();

                    cmd.CommandText = "select * from cage";

                    dap.Fill(ds, "cage");

                    dataGridView1.DataSource = null;

                    dataGridView1.DataSource = ds.Tables[0];
                    
                }else
                {
                    MessageBox.Show("Remplissez tous les champs !", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch
            {
                MessageBox.Show("Problem d'insertion : La cage et déja existe", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Keyboard shortcuts

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                bc_ajouter.PerformClick();
                return true;
            
            }else if(keyData == (Keys.F2))
            {
                bc_supprimer.PerformClick();
                return true;
            
            }else if(keyData == (Keys.F3))
            {
                bc_modifier.PerformClick();
                return true;

            }else if(keyData == Keys.Escape)
            {
                bc_retour.PerformClick();
                return true;

            }else if(keyData == Keys.F4)
            {
                bc_vider.PerformClick();

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

            }else if(keyData == (Keys.I | Keys.Control))
            {
                txt_numero.Focus();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void cage_Load(object sender, EventArgs e)
        {

            try
            {

                label5.Text = DateTime.Now.ToString();

                WindowState = FormWindowState.Maximized;

                this.CenterToScreen();

                cmd = new SqlCommand("select * from cage", Connection.cnx);
                dap = new SqlDataAdapter(cmd);
                ds = new DataSet();
                cb = new SqlCommandBuilder(dap);
                dap.Fill(ds, "cage");
                dataGridView1.DataSource = ds.Tables[0];

                bc_supprimer.Enabled = false;
                bc_modifier.Enabled = false;
            
            }catch(Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            index cx = new index();
            cx.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string x = dataGridView1.SelectedCells[0].Value.ToString();

                cmd.CommandText = "delete from cage where Numéro = " + x;

                cmd.ExecuteNonQuery();

                ds.Tables["cage"].Clear();

                cmd.CommandText = "select * from cage";

                dap.Fill(ds, "cage");

                dataGridView1.Refresh();

            }catch
            {
                MessageBox.Show("Problem de suppression : la cage n'est pas vide ", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_numero.Text != "" && txt_capacite.Text != "" && txt_nbr_etage.Text != "" && txt_poids.Text != "")
                {
                    cmd.CommandText = "update cage set [Nombre d'étage] = '" + txt_nbr_etage.Text + "', [Quantité total] = '" + txt_capacite.Text + "', [Poids de cage] = '" + txt_poids.Text + "' where Numéro = " + txt_numero.Text;
                    cmd.ExecuteNonQuery();

                    ds.Tables["cage"].Clear();

                    cmd.CommandText = "select * from cage";

                    dap.Fill(ds, "cage");

                    dataGridView1.DataSource = ds.Tables["cage"];

                    dataGridView1.Refresh();

                    MessageBox.Show("Les information bien modifier", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else
                {
                    MessageBox.Show("Remplissez tous les champs", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Problem de modification : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        // Search function
        public void rechercher(string valeur)
        {
            if(valeur == "")
            {
                string query = "SELECT * FROM cage";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.cnx);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }else
            {
                string query = "SELECT * FROM cage WHERE Numéro = '" + valeur + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.cnx);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void txt_rechercher_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txt_rechercher.Text);

            }catch
            {
                txt_rechercher.Clear();
            }

            try
            {
                rechercher(txt_rechercher.Text);

            }catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
        }

        private void bc_vider_Click(object sender, EventArgs e)
        {
            try
            {
                txt_numero.Clear();
                txt_nbr_etage.Text = "0";
                txt_poids.Clear();
                txt_capacite.Text = "0";
                dataGridView1.ClearSelection();
                bc_supprimer.Enabled = false;
                bc_modifier.Enabled = false;

            }catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txt_numero.Text);
            }
            catch
            {
                txt_numero.Clear();
            }
        }

        private void txt_nbr_etage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txt_nbr_etage.Text);

            }
            catch
            {
                txt_nbr_etage.Clear();
            }
        }

        private void txt_capacite_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txt_capacite.Text);

            }
            catch
            {
                txt_capacite.Clear();
            }
        }

        private void txt_poids_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(txt_poids.Text);

            }
            catch
            {
                txt_poids.Clear();
            }
        }

        private void cage_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int x = dataGridView1.SelectedCells[0].RowIndex;

                txt_numero.Text = dataGridView1.Rows[x].Cells["Numéro"].Value.ToString();
                txt_nbr_etage.Text = dataGridView1.Rows[x].Cells["Nombre d'étage"].Value.ToString();
                txt_capacite.Text = dataGridView1.Rows[x].Cells["Quantité total"].Value.ToString();
                txt_poids.Text = dataGridView1.Rows[x].Cells["poids de cage"].Value.ToString();

                bc_modifier.Enabled = true;
                bc_supprimer.Enabled = true;

            }
            catch
            {
            }
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cage_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

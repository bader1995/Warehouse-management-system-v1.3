using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace jway
{
    public partial class catégorie : Form
    {
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter dap;
        public SqlCommandBuilder cb;

        public catégorie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_nom.Text != "" && list_type.SelectedItem.ToString() != "")
                {
                    cmd.CommandText = "insert into categorie (nom, [Date de registration], type) values ('" + txt_nom.Text + "', '" + DateTime.Now.ToShortDateString() + "', ( select id from type where nom = '" + list_type.SelectedItem.ToString() + "'))";

                    cmd.ExecuteNonQuery();

                    ds.Tables["categorie"].Clear();

                    cmd.CommandText = "select * from categorie";

                    dap.Fill(ds, "categorie");

                    dataGridView1.Refresh();

                    MessageBox.Show("OK pour ajouter", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else
                {
                    MessageBox.Show("Remplissez tous les champs.", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch
            {
                MessageBox.Show("Problem d'insertion : Le catégorie et déja existe", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                bc_ajouter.PerformClick();
                return true;

            }
            else if (keyData == (Keys.F2))
            {
                bc_supprimer.PerformClick();
                return true;

            }
            else if (keyData == (Keys.F3))
            {
                bc_modifier.PerformClick();
                return true;

            }
            else if (keyData == Keys.Escape)
            {
                bc_retour.PerformClick();
                return true;

            }
            else if (keyData == Keys.F4)
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
            }
            else if (keyData == (Keys.I | Keys.Control))
            {
                list_type.Focus();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void catégorie_Load(object sender, EventArgs e)
        {

            try
            {
                lbl_date.Text = DateTime.Now.ToString();

                WindowState = FormWindowState.Maximized;

                this.CenterToScreen();

                cmd = new SqlCommand("select * from categorie", Connection.cnx);
                ds = new DataSet();
                dap = new SqlDataAdapter(cmd);
                cb = new SqlCommandBuilder(dap);
                dap.Fill(ds, "categorie");
                dataGridView1.DataSource = ds.Tables["categorie"];

                cmd.CommandText = "select * from type";

                dap.Fill(ds, "type");

                bc_modifier.Enabled = false;
                bc_supprimer.Enabled = false;

                foreach(DataRow x in ds.Tables["type"].Rows)
                {
                    list_type.Items.Add(x["nom"]);
                }

            }catch
            {
            }

            dataGridView1.ClearSelection();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_nom.Text != "" && txt_date_creation.Text != "")
                {
                    cmd.CommandText = "update categorie set nom = '" + txt_nom.Text + "', type = ( select id from type where nom = '" + list_type.SelectedItem.ToString() + "') where id = " + txt_id.Text;

                    cmd.ExecuteNonQuery();

                    ds.Tables["categorie"].Clear();

                    cmd.CommandText = "select * from categorie";

                    dap.Fill(ds, "categorie");

                    dataGridView1.Refresh();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Le catégorie et bien modifier", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                }else
                {
                    MessageBox.Show("Remplissez tous les champs", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem d'insertion : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dataGridView1.SelectedCells[0].RowIndex;

                string p = dataGridView1.Rows[x].Cells[0].Value.ToString();

                cmd.CommandText = "delete from categorie where Id = " + p;

                cmd.ExecuteNonQuery();

                ds.Tables["categorie"].Clear();

                cmd.CommandText = "select * from categorie";

                dap.Fill(ds, "categorie");

                dataGridView1.Refresh();

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem de suppression : " + ex.Message, "Jway",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from categorie where id = " + txt_rechercher.Text, Connection.cnx);

                ds.Clear();

                dap.Fill(ds, "categorie");

                if(ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Le categorie et déja exist!", "Jway", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Le categorie n'exist pas", "Jway", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }catch
            {
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }

        private void bc_retour_Click(object sender, EventArgs e)
        {
            index d1 = new index();
            d1.Show();
            this.Close();
        }

        private void bc_vider_Click(object sender, EventArgs e)
        {
            try
            {
                txt_id.Clear();
                txt_nom.Clear();
                txt_date_creation.Clear();
                dataGridView1.ClearSelection();
                bc_modifier.Enabled = false;
                bc_supprimer.Enabled = false;

            }catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        public void rechercher(string valeur)
        {

            if (valeur == "")
            {
                string query = "SELECT * FROM categorie";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.cnx);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            else
            {
                string query = "SELECT * FROM categorie WHERE id = '" + valeur + "'";
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

            }
            catch
            {
                txt_rechercher.Clear();
            }

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
                int x = dataGridView1.SelectedCells[0].RowIndex;

                txt_id.Text = dataGridView1.Rows[x].Cells["id"].Value.ToString();
                txt_nom.Text = dataGridView1.Rows[x].Cells["nom"].Value.ToString();
                txt_date_creation.Text = dataGridView1.Rows[x].Cells["date de registration"].Value.ToString();
                string type = dataGridView1.Rows[x].Cells[3].Value.ToString();

                cmd.CommandText = "select Nom from type where id = " + type;

                ds.Tables["type"].Clear();

                dap.Fill(ds, "type");

                list_type.SelectedItem = ds.Tables["type"].Rows[0]["Nom"];

                bc_modifier.Enabled = true;
                bc_supprimer.Enabled = true;
            }
            catch
            {
            }
        }
    }
}

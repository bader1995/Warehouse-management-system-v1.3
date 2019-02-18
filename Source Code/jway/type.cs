using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jway
{
    public partial class type : Form
    {

        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter dap;

        public type()
        {
            InitializeComponent();
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
                txt_nom.Focus();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void type_Load(object sender, EventArgs e)
        {

           try
           {
               lbl_date.Text = DateTime.Now.ToString();

               WindowState = FormWindowState.Maximized;

               this.CenterToScreen();

               cmd = new SqlCommand("select * from type", Connection.cnx);

               ds = new DataSet();

               dap = new SqlDataAdapter(cmd);

               dap.Fill(ds, "type");

               dataGridView1.DataSource = ds.Tables["type"];

               bc_modifier.Enabled = false;
               bc_supprimer.Enabled = false;

           }catch
           {
           }

           dataGridView1.ClearSelection();

        }

        public void rechercher(string valeur)
        {

            if (valeur == "")
            {
                string query = "SELECT * FROM type";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.cnx);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            else
            {
                string query = "SELECT * FROM type WHERE id = '" + valeur + "'";
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
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bc_ajouter_Click(object sender, EventArgs e)
        {
            try
            {

                if(txt_nom.Text != "" && txt_nbr_calories.Text != "")
                {
                    cmd.CommandText = "insert into type (nom, [Date de registration], [Nombre de calories]) values ('" + txt_nom.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + txt_nbr_calories.Text + "')";

                    cmd.ExecuteNonQuery();

                    ds.Tables["type"].Clear();

                    cmd.CommandText = "select * from type";

                    dap.Fill(ds, "type");

                    dataGridView1.Refresh();

                    MessageBox.Show("Le type et bien ajouter", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else
                {
                    MessageBox.Show("Remplissez tous les champs!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch
            {
                MessageBox.Show("Problem d'insertion : Le type et déja existe", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bc_supprimer_Click(object sender, EventArgs e)
        {
            try
            {

                string x = dataGridView1.SelectedCells[0].Value.ToString();

                cmd.CommandText = "delete from type where id = " + x;

                cmd.ExecuteNonQuery();

                ds.Tables["type"].Clear();

                cmd.CommandText = "select * from type";

                dap.Fill(ds, "type");

                dataGridView1.Refresh();


            }catch (Exception ex)
            {
                MessageBox.Show("Problem de suppression : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void bc_modifier_Click(object sender, EventArgs e)
        {
            try
            {

                if(txt_id.Text != "" && txt_nom.Text != "" && txt_nbr_calories.Text != "")
                {

                    cmd.CommandText = "update type set nom = '" + txt_nom.Text + "', [Nombre de calories] = '" + txt_nbr_calories.Text + "' where id = '" + txt_id.Text + "'";

                    cmd.ExecuteNonQuery();

                    // Refresh the dataGridView

                    ds.Tables["type"].Clear();

                    cmd.CommandText = "select * from type";

                    dap.Fill(ds, "type");

                    dataGridView1.DataSource = ds.Tables["type"];

                    dataGridView1.Refresh();

                    MessageBox.Show("Le type et bien modifier.", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else
                {
                    MessageBox.Show("Remplissez tous les champs", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bc_vider_Click(object sender, EventArgs e)
        {

            try
            {
                txt_nom.Clear();
                txt_nbr_calories.Clear();
                txt_id.Clear();
                date_registration.Clear();
                dataGridView1.ClearSelection();
                bc_modifier.Enabled = false;
                bc_supprimer.Enabled = false;

            }catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index c1 = new index();
            c1.Show();
            this.Close();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_nbr_calories_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(txt_nbr_calories.Text);

            }catch
            {
                txt_nbr_calories.Clear();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int x = dataGridView1.SelectedCells[0].RowIndex;

                txt_id.Text = dataGridView1.Rows[x].Cells["id"].Value.ToString();
                txt_nom.Text = dataGridView1.Rows[x].Cells["nom"].Value.ToString();
                txt_nbr_calories.Text = dataGridView1.Rows[x].Cells["Nombre de calories"].Value.ToString();
                date_registration.Text = dataGridView1.Rows[x].Cells["date de registration"].Value.ToString();
                bc_supprimer.Enabled = true;
                bc_modifier.Enabled = true;

            }
            catch
            {
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }
    }
}

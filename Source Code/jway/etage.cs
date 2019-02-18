using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jway
{
    public partial class etage : Form
    {
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter dap;

        public etage()
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
            
            }else if(keyData == Keys.F5)
            {
                bc_vide.PerformClick();

            }else if(keyData == Keys.F6)
            {
                bc_plein.PerformClick();

            }else if(keyData == Keys.F7)
            {
                bc_utilisé.PerformClick();
            }
            else if (keyData == Keys.F11)
            {
                txt_rechercher.Focus();
            }
            else if (keyData == (Keys.I | Keys.Control))
            {
                list_cage.Focus();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void etage_Load(object sender, EventArgs e)
        {

           try
           {
               lbl_date.Text = DateTime.Now.ToString();

               WindowState = FormWindowState.Maximized;

               this.CenterToScreen();

               cmd = new SqlCommand("select * from étage", Connection.cnx);

               dap = new SqlDataAdapter(cmd);

               ds = new DataSet();

               dap.Fill(ds, "étage");

               dataGridView1.DataSource = ds.Tables["étage"];
               bc_modifier.Enabled = false;
               bc_supprimer.Enabled = false;

           }catch
           {

           }

            // Remplissage de la list cage

            cmd.CommandText = "select * from cage";

            dap.Fill(ds, "cage");

            foreach(DataRow dr in ds.Tables["cage"].Rows)
            {
                list_cage.Items.Add(dr["Numéro"]);
            }

            dataGridView1.ClearSelection();

        }

        private void bc_ajouter_Click(object sender, EventArgs e)
        {
            try
            {

                if(txt_poids.Text != "" && txt_quantite.Text != "")
                {

                    cmd.CommandText = "insert into étage (Id, quantité, cage, [poids d'étage], [Quantité maximale]) values ('" + txt_id.Text + "', '" + txt_quantite.Text + "', '" + list_cage.SelectedItem.ToString() + "', '" + txt_poids.Text + "', '" + txt_capacité_maximale.Text + "')";
                   
                    cmd.ExecuteNonQuery();

                    ds.Tables["étage"].Clear();

                    cmd.CommandText = "select * from étage";

                    dap.Fill(ds, "étage");

                    dataGridView1.DataSource = ds.Tables["étage"];

                    dataGridView1.Refresh();

                    MessageBox.Show("L'etage et bien ajouter", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else
                {
                    MessageBox.Show("Remplissez tous les champs.", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch
            {
                MessageBox.Show("Problem d'insertion : L'étage et déja existe.", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bc_retour_Click(object sender, EventArgs e)
        {
            index d1 = new index();
            d1.Show();
            this.Close();
        }

        public void rechercher(string valeur)
        {

            if (valeur == "")
            {
                string query = "SELECT * FROM étage";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.cnx);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            else
            {
                string query = "SELECT * FROM étage WHERE Id = '" + valeur + "'";
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void bc_modifier_Click(object sender, EventArgs e)
        {
            try
            {

                if(txt_poids.Text != "")
                {
                    cmd.CommandText = "update étage set Quantité = '" + txt_quantite.Text + "', Cage = '" + list_cage.SelectedItem.ToString() + "', [Poids d'étage] = '" + txt_poids.Text + "', [Quantité maximale] = " + txt_capacité_maximale.Text + " where Id = " + txt_id.Text;

                    cmd.ExecuteNonQuery();

                    ds.Tables["étage"].Clear();

                    cmd.CommandText = "select * from étage";

                    dap.Fill(ds, "étage");

                    dataGridView1.DataSource = ds.Tables["étage"];

                    dataGridView1.Refresh();

                    MessageBox.Show("L'étage et bien modifier", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else
                {
                    MessageBox.Show("Remplissez tous les champs.", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Problem de modification : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bc_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string x = dataGridView1.SelectedCells[0].Value.ToString();


                cmd.CommandText = "delete from étage where Id = " + x;

                cmd.ExecuteNonQuery();

                ds.Tables["étage"].Clear();

                cmd.CommandText = "select * from étage";

                dap.Fill(ds, "étage");

                dataGridView1.DataSource = ds.Tables["étage"];

                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem de suppression d'étage : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_poids_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(txt_poids.Text);
            }catch
            {
                txt_poids.Clear();
            }
        }

        private void bc_vider_Click(object sender, EventArgs e)
        {
            try
            {
                txt_id.Clear();
                txt_poids.Clear();
                txt_quantite.Text = "0";
                txt_capacité_maximale.Clear();
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

            try
            {
                cmd.CommandText = "select * from étage where quantité = 0";

                ds.Tables["étage"].Clear();

                dap.Fill(ds, "étage");

                dataGridView1.DataSource = ds.Tables["étage"];

                dataGridView1.Refresh();

            }catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                cmd.CommandText = "select * from étage where quantité = [Quantité maximale]";

                ds.Tables["étage"].Clear();

                dap.Fill(ds, "étage");

                dataGridView1.DataSource = ds.Tables["étage"];

                dataGridView1.Refresh();

            }catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                cmd.CommandText = "select * from étage where quantité between 1 and [Quantité maximale] - 1";

                ds.Tables["étage"].Clear();

                dap.Fill(ds, "étage");

                dataGridView1.DataSource = ds.Tables["étage"];

                dataGridView1.Refresh();

            }catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_capacité_maximale_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txt_capacité_maximale.Text);

            }catch
            {
                txt_capacité_maximale.Clear();
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txt_id.Text);

            }catch
            {
                txt_id.Clear();
            }
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int x = dataGridView1.SelectedCells[0].RowIndex;

                txt_id.Text = dataGridView1.Rows[x].Cells["id"].Value.ToString();
                txt_poids.Text = dataGridView1.Rows[x].Cells["poids d'étage"].Value.ToString();
                txt_quantite.Text = dataGridView1.Rows[x].Cells["quantité"].Value.ToString();
                list_cage.SelectedItem = dataGridView1.Rows[x].Cells["cage"].Value;
                txt_capacité_maximale.Text = dataGridView1.Rows[x].Cells["quantité maximale"].Value.ToString();

                bc_modifier.Enabled = true;
                bc_supprimer.Enabled = true;

            }
            catch
            {
            }
        }
    }
}

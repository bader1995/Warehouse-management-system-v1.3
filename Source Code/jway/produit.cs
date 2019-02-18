using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using KeepAutomation.Barcode.Crystal;
using System.IO;
using System.Drawing.Imaging;

namespace jway
{
    public partial class produit : Form
    {
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter dap;
        public SqlCommandBuilder cb;

        public string pos;
        public static string pas;

        public produit()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void rechercher(string valeur)
        {

            if (valeur == "")
            {
                string query = "SELECT * FROM produit";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.cnx);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            else
            {
                string query = "SELECT * FROM produit WHERE id = '" + valeur + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.cnx);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_libelle.Text != "" && txt_poids.Text != "" && txt_prix.Text != "" && list_categorie.Text != "" && list_type.Text != "" && list_cage.Text != "" && list_etage.Text != "")
                {

                    string date_sortie = "";

                    if(txt_sortie.Enabled == false)
                    {
                        date_sortie = "NULL";

                    }else
                    {
                        date_sortie = "'" + txt_sortie.Value.ToShortDateString() + "'";
                    }

                    cmd.CommandText = "update produit set [Date d'éxpiration] = '" + date_expiration.Value.ToShortDateString() + "', [Date de sortie] = " + date_sortie + ", libelle = '" + txt_libelle.Text + "', prix = '" + txt_prix.Text + "', type = ( select id from type where nom = '" + list_type.SelectedItem.ToString() + "'), catégorie = ( select id from categorie where nom =  '" + list_categorie.SelectedItem.ToString() + "'), cage = " + list_cage.SelectedItem.ToString() + ", etage = " + list_etage.SelectedItem.ToString() + ", poids = " + txt_poids.Text + ", Quantité = " + txt_quantité.Text + " where id = " + txt_id.Text;

                    cmd.ExecuteNonQuery();

                    ds.Tables["produit"].Clear();

                    cmd.CommandText = "select * from produit";

                    dap.Fill(ds, "produit");

                    dataGridView1.DataSource = ds.Tables["produit"];

                    dataGridView1.Refresh();

                    MessageBox.Show("Les information bien modifier", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Remplissez tous les champs", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (keyData == Keys.F12)
            {
                bc_imprimer.PerformClick();
                return true;
            }
            else if (keyData == (Keys.G | Keys.Control))
            {
                dataGridView1.Focus();
                
                if(dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                }

            }else if(keyData == Keys.F11)
            {
                txt_rechercher.Focus();
            }
            else if (keyData == (Keys.I | Keys.Control))
            {
                list_cage.Focus();
            }
            else if(keyData == (Keys.Tab | Keys.Control))
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

        private void produit_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ClearSelection();

                WindowState = FormWindowState.Maximized;

                this.CenterToScreen();

                cmd = new SqlCommand("select * from produit", Connection.cnx);

                dap = new SqlDataAdapter(cmd);

                ds = new DataSet();

                cb = new SqlCommandBuilder(dap);

                dap.Fill(ds, "produit");

                dataGridView1.DataSource = ds.Tables["produit"];

                dataGridView1.Refresh();


                // Remplissage de la list cage
                try
                {
                    list_cage.Items.Clear();

                    cmd.CommandText = "select * from cage";

                    cmd.Connection = Connection.cnx;

                    dap.Fill(ds, "cage");

                    foreach (DataRow xd in ds.Tables["cage"].Rows)
                    {
                        list_cage.Items.Add(xd[0]);
                    }

                }catch
                {
                }

                // Remplissage de list type
                try
                {
                    list_type.Items.Clear();

                    cmd.CommandText = "select * from type";

                    cmd.Connection = Connection.cnx;

                    dap.Fill(ds, "type");

                    foreach (DataRow xd in ds.Tables["type"].Rows)
                    {
                        list_type.Items.Add(xd[1]);
                    }

                    dataGridView1.ClearSelection();

                    bc_modifier.Enabled = false;
                    bc_supprimer.Enabled = false;

                }catch
                {
                }

            }catch
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index x1 = new index();
            x1.Show();
            this.Close();
        }

        public byte[] Convert_image_binary(Image imgs)
        {
            byte[] img = null;
            var ms = new MemoryStream();
            imgs.Save(ms, ImageFormat.Png);
            ms.Position = 0;
            BinaryReader br = new BinaryReader(ms);
            img = br.ReadBytes((int)ms.Length);
            return img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

              if(txt_libelle.Text != "" && txt_poids.Text != "" && txt_prix.Text != "" && list_categorie.Text != "" && list_type.Text != "" && list_cage.Text != "" && list_etage.Text != "")
              {
                  cmd.Parameters.Clear();

                  Image barCode = generate_barcode(txt_id.Text);

                  barCode.RotateFlip(RotateFlipType.Rotate90FlipNone);

                  byte[] barCode_byte = Convert_image_binary(barCode);

                  cmd.CommandText = "insert into produit (Id, [Date d'entrée], [Date d'éxpiration], libelle, prix, type, catégorie, cage, etage, poids, Quantité, [Code à barre]) values ('" + txt_id.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + date_expiration.Value.ToShortDateString() + "', '" + txt_libelle.Text + "', '" + txt_prix.Text + "', ( select id from type where Nom = '" + list_type.SelectedItem.ToString() + "' ), (select id from categorie where Nom = '" + list_categorie.SelectedItem.ToString() + "'), '" + list_cage.SelectedItem.ToString() + "', '" + list_etage.SelectedItem.ToString() + "', '" + txt_poids.Text + "', " + txt_quantité.Text + ", @win_picture)";

                  cmd.Parameters.AddWithValue("@win_picture", barCode_byte);

                  cmd.Connection = Connection.cnx;

                  cmd.ExecuteNonQuery();

                  dataGridView1.DataSource = null;

                  ds.Tables["produit"].Clear();

                  cmd.CommandText = "select * from produit";

                  dap.Fill(ds, "produit");

                  dataGridView1.DataSource = ds.Tables["produit"];

                  dataGridView1.Refresh();

                  MessageBox.Show("Le produit et bien ajouter.", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
              }else
              {
                  MessageBox.Show("Remplissez tous les champs!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }

            }catch (Exception ex)
            {
                MessageBox.Show("Problem d'insertion : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string x = dataGridView1.SelectedCells[0].Value.ToString();

                cmd.CommandText = "delete from produit where id = " + x;

                cmd.ExecuteNonQuery();

                ds.Tables["produit"].Clear();

                cmd.CommandText = "select * from produit";

                dap.Fill(ds, "produit");

                dataGridView1.DataSource = ds.Tables["produit"];

                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem de suppression de produit : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from produit where id like " + txt_rechercher.Text;

            ds.Tables["produit"].Clear();

            dap.Fill(ds, "produit");

            if(ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Le produit exist", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }else
            {
                MessageBox.Show("Le produit n'exist pas!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //Clearing all the fields

                txt_id.Clear();
                txt_libelle.Clear();
                txt_poids.Clear();
                txt_prix.Clear();
                list_categorie.SelectedIndex = -1;
                list_etage.SelectedIndex = -1;
                list_cage.SelectedIndex = -1;
                list_etage.SelectedIndex = -1;
                txt_quantité.Text = "";
                dataGridView1.ClearSelection();
                bc_modifier.Enabled = false;
                bc_supprimer.Enabled = false;

            }catch(Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void list_type_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                // Filling the categorie list

                list_categorie.Items.Clear();
                list_categorie.Text = "";

                try
                {
                    ds.Tables["categorie"].Clear();

                }catch
                {
                }

                cmd.CommandText = "select * from categorie where type = ( select id from type where nom = '" + list_type.SelectedItem.ToString() + "')";

                cmd.Connection = Connection.cnx;

                dap.Fill(ds, "categorie");

                list_categorie.Items.Clear();

                foreach (DataRow xd in ds.Tables["categorie"].Rows)
                {
                    list_categorie.Items.Add(xd[1]);
                }

            }catch
            {
            }

        }

        private void list_type_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void list_cage_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                list_etage.Items.Clear();
                list_etage.Text = "";

                try
                {
                    ds.Tables["étage"].Clear();

                }
                catch
                {
                }

                cmd.CommandText = "select * from étage where cage = " + list_cage.SelectedItem.ToString();

                cmd.Connection = Connection.cnx;

                dap.Fill(ds, "étage");

                list_etage.Items.Clear();

                foreach (DataRow xd in ds.Tables["étage"].Rows)
                {
                    list_etage.Items.Add(xd[0]);
                }

            }catch
            {
            }
        }

        public Image generate_barcode(string BarCodeValue)
        {
            BarCode barcode = new BarCode();
            barcode.Symbology = KeepAutomation.Barcode.Symbology.Code39;
            barcode.CodeToEncode = BarCodeValue;
            barcode.ChecksumEnabled = true;
            barcode.X = 1;
            barcode.Y = 50;
            barcode.BarCodeWidth = 100;
            barcode.BarCodeHeight = 70;
            barcode.Orientation = KeepAutomation.Barcode.Orientation.Degree90;
            barcode.BarcodeUnit = KeepAutomation.Barcode.BarcodeUnit.Pixel;
            barcode.DPI = 72;
            barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Gif;
            return barcode.generateBarcodeToBitmap();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
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
            catch
            {
            }
        }

        private void bc_imprimer_Click(object sender, EventArgs e)
        {

            try
            {
                int p = dataGridView1.SelectedCells[0].RowIndex;

                pos = dataGridView1.Rows[p].Cells[0].Value.ToString();

                pas = pos;

                if (p != -1)
                {
                    TicketProduit tr = new TicketProduit();

                    tr.Show();
                }
                else
                {
                    MessageBox.Show("Selectioner un produit!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch
            {
                MessageBox.Show("Problem : Selectioner un produit!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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

        private void txt_prix_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(txt_prix.Text);

            }catch
            {
                txt_prix.Clear();
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

        private void txt_quantité_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txt_quantité.Text);

            }catch
            {
                txt_quantité.Clear();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int xm = dataGridView1.SelectedCells[0].RowIndex;

                txt_id.Text = dataGridView1.Rows[xm].Cells["Id"].Value.ToString();

                if (dataGridView1.Rows[xm].Cells["Date de sortie"].Value.ToString() != "")
                {
                    txt_sortie.Value = (DateTime)(dataGridView1.Rows[xm].Cells["Date de sortie"].Value);
                }

                date_expiration.Value = (DateTime)dataGridView1.Rows[xm].Cells["Date d'éxpiration"].Value;

                txt_libelle.Text = dataGridView1.Rows[xm].Cells["Libelle"].Value.ToString();
                txt_prix.Text = dataGridView1.Rows[xm].Cells["Prix"].Value.ToString();
                txt_poids.Text = dataGridView1.Rows[xm].Cells["poids"].Value.ToString();
                list_cage.SelectedItem = dataGridView1.Rows[xm].Cells["cage"].Value;
                list_etage.SelectedItem = dataGridView1.Rows[xm].Cells["etage"].Value;
                txt_quantité.Text = dataGridView1.Rows[xm].Cells["quantité"].Value.ToString();

                string type = dataGridView1.Rows[xm].Cells[6].Value.ToString();

                string categorie = dataGridView1.Rows[xm].Cells[7].Value.ToString();

                cmd.CommandText = "select Nom from type where id = " + type;

                ds.Tables["type"].Clear();

                dap.Fill(ds, "type");

                list_type.SelectedItem = ds.Tables["type"].Rows[0]["Nom"];

                cmd.CommandText = "select Nom from categorie where id = " + categorie;

                ds.Tables["categorie"].Clear();

                dap.Fill(ds, "categorie");

                list_categorie.SelectedItem = ds.Tables["categorie"].Rows[0]["Nom"];

                bc_modifier.Enabled = true;
                bc_supprimer.Enabled = true;

                cmd.CommandText = "select [Code à barre] from produit where id = " + dataGridView1.Rows[xm].Cells["Id"].Value.ToString(); ;

                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ms = new MemoryStream(img);

                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
            }
        }

        private void txt_rechercher_Enter(object sender, EventArgs e)
        {
        }

        private void txt_rechercher_MouseLeave(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_sortie.Enabled == false)
            {
                txt_sortie.Enabled = true;

            }else
            {
                txt_sortie.Enabled = false;
            }
        }
    }
}

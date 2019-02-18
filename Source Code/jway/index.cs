using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace jway
{
    public partial class index : Form
    {

        public static SqlConnection cnx;

        public index()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                btn_cage.PerformClick();
                return true;

            }else if(keyData == (Keys.F2))
            {
                btn_etage.PerformClick();
                return true;

            }else if(keyData == (Keys.F3))
            {
                btn_type.PerformClick();
                return true;

            }else if(keyData == (Keys.F4))
            {
                btn_catégorie.PerformClick();
                return true;

            }else if(keyData == (Keys.F5))
            {
                btn_produit.PerformClick();
                return true;
            
            }else if(keyData == (Keys.Escape))
            {
                btn_deconnecter.PerformClick();
                return true;
            
            }else if(keyData == (Keys.F12))
            {
                if(lbl_admin.Visible == true)
                {
                    admin ad = new admin();
                    ad.Show();
                    this.Hide();
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.CenterToScreen();

                cnx = Connection.cnx;

                if (login.user == "Admin")
                {
                    lbl_admin.Visible = true;

                }else
                {
                    lbl_profil.Visible = true;
                }

                lbl_nom.Text = login.nom;

            }catch(Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cage x = new cage();
            x.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            produit p1 = new produit();
            p1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            catégorie c2 = new catégorie();
            c2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            type t1 = new type();
            t1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            etage et = new etage();
            et.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.jway.ma");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TicketProduit td = new TicketProduit();
            td.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void lbl_admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin am = new admin();
            am.Show();
            this.Hide();
        }

        private void exporterLesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.Filter = "CSV File|*.csv";
                saveFileDialog1.FileName = "Produits";
                var lines = new List<string>();
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("select Id, [Date d'éxpiration], [Date d'entrée], [Date de sortie], [Libelle], [Prix], [Type], [Catégorie], [Cage], [Etage], [Poids], [Quantité] from produit", cnx);

                SqlDataAdapter dap = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                dap.Fill(ds, "produit");

                dt = ds.Tables["produit"];

                string[] columnNames = dt.Columns.Cast<DataColumn>().
                                      Select(column => column.ColumnName).
                                      ToArray();

                var header = string.Join(",", columnNames);
                lines.Add(header);

                var valueLines = dt.AsEnumerable()
                                   .Select(row => string.Join(",", row.ItemArray));
                lines.AddRange(valueLines);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog1.FileName, lines, Encoding.UTF8);
                    MessageBox.Show("Les produits et bien exporter", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }catch(Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void lbl_profil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profil ps = new Profil();
            ps.Show();
        }
    }
}

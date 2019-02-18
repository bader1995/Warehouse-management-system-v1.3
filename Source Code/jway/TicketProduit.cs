using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jway
{
    public partial class TicketProduit : Form
    {

        public SqlCommand cmd;
        public jwayDataSet ds;
        public SqlDataAdapter dap;

        public TicketProduit()
        {
            InitializeComponent();
        }

        private void TicketProduit_Load(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Maximized;

                this.CenterToScreen();

                produit x = new produit();

                cmd = new SqlCommand("select Id, [Date d'éxpiration], [Date d'entrée], Libelle, Prix, [Code à barre], ( select nom from type where id = Type ) as Type, ( select nom from categorie where id = Catégorie ) as Catégorie, Cage, Etage, Poids from produit where id = '" + produit.pas + "'", Connection.cnx);

                ds = new jwayDataSet();

                dap = new SqlDataAdapter(cmd);

                dap.Fill(ds, "produit");

                CrystalReport1 cr = new CrystalReport1();

                cr.SetDataSource(ds.Tables["produit"]);

                crystalReportViewer1.ReportSource = cr;

                crystalReportViewer1.Refresh();

            }catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

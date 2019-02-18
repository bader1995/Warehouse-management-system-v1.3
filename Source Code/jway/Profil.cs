using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;

namespace jway
{
    public partial class Profil : Form
    {
        public SqlCommand cmd;
        public SqlDataAdapter dap;
        public DataSet ds;

        public Profil()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                btn_modifier.PerformClick();
                return true;

            }else if(keyData == (Keys.Escape))
            {
                this.Hide();
            }

            return base.ProcessCmdKey(ref msg, keyData);

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

        private void Profil_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = Connection.cnx;
            ds = new DataSet();
            dap = new SqlDataAdapter(cmd);

            cmd.CommandText = "select cin, nom, prénom, [e-mail], [mot de passe], [date de registration] from utilisateurs where cin = '" + login.id + "'";

            dap.Fill(ds, "utilisateurs");

            txt_cin.Text = ds.Tables["utilisateurs"].Rows[0][0].ToString();
            txt_nom.Text = ds.Tables["utilisateurs"].Rows[0][1].ToString();
            txt_prenom.Text = ds.Tables["utilisateurs"].Rows[0][2].ToString();
            txt_email.Text = ds.Tables["utilisateurs"].Rows[0][3].ToString();
            txt_mot_passe.Text = ds.Tables["utilisateurs"].Rows[0][4].ToString();
            date_registration.Text = ds.Tables["utilisateurs"].Rows[0][5].ToString();

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(txt_mot_passe.Text == txt_confirmation.Text)
                {
                    cmd.CommandText = "update utilisateurs set nom = @nom, prénom = @prénom, [e-mail] = @email, [mot de passe] = @mot_de_passe where cin = @cin";

                    cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = txt_nom.Text;
                    cmd.Parameters.Add("@prénom", SqlDbType.VarChar).Value = txt_prenom.Text;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_email.Text;
                    cmd.Parameters.Add("@mot_de_passe", SqlDbType.VarChar).Value = Base64Encode(txt_mot_passe.Text);
                    cmd.Parameters.Add("@cin", SqlDbType.VarChar).Value = txt_cin.Text;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Les informations est bien modifier!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Problem de modification : les mot de passe n'est pas identique!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Problem de modification : " + ex.Message, "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

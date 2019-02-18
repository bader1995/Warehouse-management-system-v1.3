using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jway
{
    public partial class verification : Form
    {
        public verification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "jwork123@")
            {
                Connection cd = new Connection();
                cd.Show();
                this.Hide();

            }else
            {
                MessageBox.Show("Mot de passe et incorrect!", "Jwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                button1.PerformClick();
                return true;

            }else if(keyData == (Keys.Escape))
            {
                this.Hide();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void verification_Load(object sender, EventArgs e)
        {
        }
    }
}

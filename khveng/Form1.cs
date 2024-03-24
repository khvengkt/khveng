using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khveng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtpsw.Text == "admin")
            {
                MessageBox.Show("ចូលប្រើប្រពន្ធជោគជ័យ");
            }
            else
            {
                MessageBox.Show("ចូលប្រើប្រពន្ធបរាជ័យ");
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtpsw.Focus();
            }
        }

        private void txtpsw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnlogin.PerformClick();
            }
        }
    }
}

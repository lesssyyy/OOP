using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZBANK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "lester" && tbxPassword.Text == "abc123")
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
                tbxUsername.Clear();
                tbxPassword.Clear();
            }
        }

        private void cbxShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxShowpass.Checked)
            {
                tbxPassword.PasswordChar = '\0';
            }
            else if (!cbxShowpass.Checked)
            {
                tbxPassword.PasswordChar = '*';
            }
        }
    }
}

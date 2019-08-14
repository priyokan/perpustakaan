using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace perpus
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnExit.BringToFront();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^[a-z0-9]+[@]+[a-z]+[.]+[a-z]{2,5}$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtEmail, "email invalid");
            }

            if(txtEmail.Text == string.Empty)
            {
                txtEmail.Text = "masukan email...";
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEmail.Text == "masukan email...")
            {
                txtEmail.Text = null;
            }
        }


        private void Txtpassword_Leave_1(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.PasswordChar = char.Parse("\0");
                txtpassword.Text = "masukan password...";
            }
        }

        private void Txtpassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txtpassword.Text == "masukan password...")
            {
                txtpassword.Text = null;
            }
        }

        private void Txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Txtpassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtpassword.Text != "masukan password...")
            {         
                txtpassword.PasswordChar = '*';
            }
        }
    }
}

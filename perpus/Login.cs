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

        public static string nama;
        DataClasses1DataContext db = new DataClasses1DataContext();
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

        private void email_validation()
        {

            string pattern = "^[a-z0-9]+[@]+[a-z]+[.]+[a-z]{2,5}$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtEmail, "email invalid");
                return;
            }

        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            email_validation();
            if (txtEmail.Text == string.Empty)
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
            errorProvider1.Clear();
            errorProvider2.Clear();
            lblWrongpass.Visible = false; 
            email_validation();
            var login = (from a in db.employees
                         where a.email == txtEmail.Text &&
                         a.password == txtpassword.Text
                         select a).FirstOrDefault();
            if (login!=null)
            {
                nama = login.name;
                if(login.role == "admin")
                {
                    adminMenu adminMEnu = new adminMenu();
                    adminMEnu.Show();
                    this.Hide();
                }
                else if(login.role == "officer")
                {
                    formofficer officerForm = new formofficer();
                    officerForm.Show();
                    this.Hide();
                }
            }
            else if (txtEmail.Text == "masukan email..." && txtpassword.Text == "masukan password...")
            {
                errorProvider1.SetError(txtEmail, "email harus di isi");
                errorProvider2.SetError(txtpassword, "password haurs di isi");
            }
            else if (txtpassword.Text == "masukan password...")
            {                
                errorProvider2.SetError(txtpassword, "password haurs di isi");
            }
            else if (txtEmail.Text == "masukan email...")
            {
                errorProvider1.SetError(txtEmail, "email harus di isi");                
            }
            else
            {
                lblWrongpass.Visible = true;
            }
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

        private void Linkmember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            memberForm member = new memberForm();
            member.Show();
            this.Hide();
        }
    }
}

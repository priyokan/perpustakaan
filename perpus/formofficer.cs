using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perpus
{
    public partial class formofficer : Form
    {
        public formofficer()
        {
            InitializeComponent();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void Formofficer_Load(object sender, EventArgs e)
        {
            lblnama.Text = Login.nama;
        }
    }
}

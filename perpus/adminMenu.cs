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
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            lblnama.Text = Login.nama;
            manageKaryawan1.BringToFront();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageKaryawan1_Load(object sender, EventArgs e)
        {

        }

        private void BtnManageBuku_Click(object sender, EventArgs e)
        {
            btnactive.Location = btnManageBuku.Location;
            manageBuku1.BringToFront();
        }

        private void BtnManagekaryawan_Click(object sender, EventArgs e)
        {
            btnactive.Location = btnManagekaryawan.Location;
            manageKaryawan1.BringToFront();
        }

        private void BtnManageMember_Click(object sender, EventArgs e)
        {
            btnactive.Location = btnManageMember.Location;
        }

        private void BtnMasterDenda_Click(object sender, EventArgs e)
        {
            btnactive.BringToFront();
            btnactive.Location = btnMasterDenda.Location;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            btnactive.Location = btnReport.Location;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void ManageBuku1_Load(object sender, EventArgs e)
        {

        }
    }
}

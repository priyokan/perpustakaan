using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perpus
{
    public partial class manageBuku : UserControl
    {
        public manageBuku()
        {
            InitializeComponent();
        }

        private void PanelManageBuku_Click(object sender, EventArgs e)
        {
        }

        private void PanelManageType_Click(object sender, EventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            panelActive.Location = panelManageBuku.Location;
        }

        private void Label4_Click_1(object sender, EventArgs e)
        {
            panelActive.Location = panelManageType.Location;
        }

        private void PanelManageBuku_Click_1(object sender, EventArgs e)
        {
            panelActive.Location = panelManageBuku.Location;
            typeBook1.Visible = false;
            manBook1.Visible = true;
            manBook1.BringToFront();
        }

        private void PanelManageType_Click_1(object sender, EventArgs e)
        {
            panelActive.Location = panelManageType.Location;
            typeBook1.Visible = true;
            manBook1.Visible = false;
            typeBook1.BringToFront();
        }

        private void ManageBuku_Load(object sender, EventArgs e)
        {

        }
    }
}

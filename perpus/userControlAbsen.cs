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
    public partial class userControlAbsen : UserControl
    {
        public userControlAbsen()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonClick;

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControlAbsen_Load(object sender, EventArgs e)
        {

        }

        private void TxtNIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtNIS.Text == "Masukan NIS...")
            {
                txtNIS.Text = "";
            }
            
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNIS_Leave(object sender, EventArgs e)
        {
            if(txtNIS.Text == "")
            {
                txtNIS.Text = "Masukan NIS...";
            }
        }

        private void Btnmasuk_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            lblNama.Visible = false;
            if (txtNIS.Text == "Masukan NIS...")
            {
                label1.Visible = false;
                lblNama.Visible = false;
            }
            else
            {
                var log = (from a in db.members
                           where a.nis == Convert.ToInt32(txtNIS.Text)
                           select a).FirstOrDefault();
                if (log != null)
                {
                    lblNama.ForeColor = System.Drawing.Color.SeaGreen;
                    lblNama.Text = log.nama;
                    label1.Visible = true;
                    lblNama.Visible = true;
                }
                else
                {
                    lblNama.ForeColor = System.Drawing.Color.Red;
                    lblNama.Text = "Maaf, NIS anda tidak ditemukan.";
                    lblNama.Visible = true;
                }
            }
        }

        private void TxtNIS_Enter(object sender, EventArgs e)
        {
            label1.Visible = false;
            lblNama.Visible = false;
        }
    }
}

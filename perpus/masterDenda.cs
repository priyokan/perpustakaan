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
    public partial class masterDenda : UserControl
    {
        public masterDenda()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void loadMasterDenda()
        {

            int id = 1;
            fine masdenda = new fine();
            masdenda = db.fines.Single(x => x.fine_id == id);
            txtdenda.Text = masdenda.fine1.ToString();


            txtToMoney();
            panel1.Visible = false;
            btnSave.Enabled = true;
        }

        string money;

        private void txtToMoney()
        {
            money = txtdenda.Text;
            txtdenda.Text = string.Format("Rp. {0:N}", Convert.ToInt64(txtdenda.Text));
        }

        private void MasterDenda_Load(object sender, EventArgs e)
        {
            loadMasterDenda();
        }

        private void Txtdenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void Txtdenda_Leave(object sender, EventArgs e)
        {
            txtToMoney();
        }

        private void Txtdenda_Enter(object sender, EventArgs e)
        {
            txtdenda.Text = money;
        }


        private void MasterDenda_VisibleChanged(object sender, EventArgs e)
        {
            loadMasterDenda();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            panel1.Visible = true;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btnyes_Click(object sender, EventArgs e)
        {
            fine fin = new fine();
            fin = db.fines.Single(x => x.fine_id == 1);
            fin.fine1 = Convert.ToInt32(money);
            db.SubmitChanges();
            loadMasterDenda();
        }

        private void Btnclosesave_Click(object sender, EventArgs e)
        {
            loadMasterDenda();
        }
    }
}

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
    public partial class ucLoaning : UserControl
    {
        public ucLoaning()
        {
            InitializeComponent();
        }

        private void loadLoaning()
        {
            try
            {
                this.bookTableAdapter.FillBy(this.perpusDataSet2.book);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void UcLoaning_Load(object sender, EventArgs e)
        {
            loadLoaning();
        }

        private void TxtTotalTambah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void TxtCari_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.bookTableAdapter.FillBy1(this.perpusDataSet2.book, txtCari.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

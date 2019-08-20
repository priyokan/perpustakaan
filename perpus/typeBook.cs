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
    public partial class typeBook : UserControl
    {
        public typeBook()
        {
            InitializeComponent();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {

        }

        private void loadTable()
        {
            try
            {
                this.typeTableAdapter.FillBy(this.perpusDataSet.type);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void TypeBook_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
        

        }

        private void TxtCari_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.typeTableAdapter.FillBy1(this.perpusDataSet.type, txtCari.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class manBook : UserControl
    {
        public manBook()
        {
            InitializeComponent();
        }

        private void loadCombo()
        {
            try
            {
                this.typeTableAdapter.FillBy(this.perpusDataSet1.type);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public void loadManbook()
        {
            loadCombo();

            try
            {
                this.bookTableAdapter.FillBy(this.perpusDataSet1.book);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void ManBook_Load(object sender, EventArgs e)
        {
            loadManbook();
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            panelTambah.Location = btnTambah.Location;
            panelTambah.Visible = true;
            panelEdit.Visible = false;
            panelDelete.Visible = false;
        }

        private void BtnCloseTambah_Click(object sender, EventArgs e)
        {
            panelTambah.Visible = false;
        }

        private void FillByToolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            panelEdit.Location = btnEdit.Location;
            panelEdit.Visible = true;
            panelTambah.Visible = false;
            panelDelete.Visible = false;
        }

        private void Btncloseedit_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            panelDelete.Location = btncloseDelete.Location;
            panelDelete.Visible = true;
            panelEdit.Visible = false;
            panelTambah.Visible = false;
        }

        private void BtncloseDelete_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
        }

        private void ComboType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtCari.Text = comboType.SelectedValue.ToString();
        }
    }
}

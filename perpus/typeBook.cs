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

        DataClasses1DataContext db = new DataClasses1DataContext();
        int ID;

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            type typeBook = new type();
            typeBook.type_name = txttype.Text;
            db.types.InsertOnSubmit(typeBook);
            db.SubmitChanges();
            loadTable();
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

            txttype.Text = "";

            btnEdit.Enabled = false;
            btnHapus.Enabled = false;

            errorProvider1.Clear();
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            type typeBook = new type();
            typeBook = db.types.Single(x => x.type_id == ID);
            typeBook.type_name = txttype.Text;
            db.SubmitChanges();
            loadTable();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            type typeBook = new type();
            typeBook = db.types.Single(x => x.type_id == ID);            
            db.types.DeleteOnSubmit(typeBook);
            db.SubmitChanges();
            loadTable();
        }
    }
}

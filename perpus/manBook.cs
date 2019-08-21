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

        private void inputValidation()
        {
            if(txtjudulTambah.Text == "")
            {
                errorProvider1.SetError(txtjudulTambah, "judul harus di isi");
            }
            if (comboType.Text == "")
            {
                errorProvider2.SetError(comboType, "type harus di isi");
            }
            if (txtTotalTambah.Text == "")
            {
                errorProvider3.SetError(txtTotalTambah, "total harus di isi");
            }
            if (txtPictambah.Text == "")
            {
                errorProvider4.SetError(btnSrcTambah, "picture harus di isi");
            }

            if (txteditjudul.Text == "")
            {
                errorProvider1.SetError(txteditjudul, "judul harus di isi");
            }
            if (comboEdittype.Text == "")
            {
                errorProvider2.SetError(comboEdittype, "type harus di isi");
            }
            if (txtedittotal.Text == "")
            {
                errorProvider3.SetError(txtedittotal, "total harus di isi");
            }
            if (txtpicedit.Text == "")
            {
                errorProvider4.SetError(btnsrcedit, "picture harus di isi");
            }
        }

        public void loadManbook()
        {
            loadCombo();

            panelDelete.Visible = false;
            panelEdit.Visible = false;
            panelTambah.Visible = false;

            btnEdit.Enabled = false;
            btnHapus.Enabled = false;

            txteditjudul.Text = "";
            txtedittotal.Text = "";
            txtjudulTambah.Text = "";
            txtpicedit.Text = "";
            txtPictambah.Text = "";
            txtTotalTambah.Text = "";
            comboEdittype.Text = "";
            comboType.Text = "";

            try
            {
                this.bookTableAdapter.FillBy(this.perpusDataSet1.book);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


            for (int i = 0; i < dataGridbook.RowCount; i++)
            {
                type tBook = new type();
                tBook = db.types.Single(x => x.type_id == Convert.ToInt32(dataGridbook.Rows[i].Cells[3].Value));
                dataGridbook.Rows[i].Cells[2].Value = tBook.type_name;
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
            loadManbook();
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
            loadManbook();
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
            loadManbook();
        }

        private void TxtTotalTambah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ComboType_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = true;           
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        int ID;

        private void BtnSaveTambah_Click(object sender, EventArgs e)
        {
            if(txtjudulTambah.Text != "" && txtPictambah.Text != ""
                && comboType.Text != ""&& txtTotalTambah.Text != "")
            {
                book msBook = new book();
                msBook.book_title = txtjudulTambah.Text;
                msBook.book_type = Convert.ToInt32(comboType.SelectedValue);
                msBook.books_on_the_rack = Convert.ToInt32(txtTotalTambah.Text);
                msBook.books_borrowed = 0;
                msBook.total_books = Convert.ToInt32(txtTotalTambah.Text);
                msBook.photo_book = txtPictambah.Text;
                db.books.InsertOnSubmit(msBook);
                db.SubmitChanges();
                loadManbook();
            }
            else
            {
                inputValidation();
            }
        }

        private void BtnSrcTambah_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files(*.jpg,*.png,*.jpeg)|*.jpg;*.png;*.jpeg;";            
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtPictambah.Text = open.FileName;
                picTambah.ImageLocation = open.FileName;
            }
        }

        private void Btnsrcedit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            if(open.ShowDialog() == DialogResult.OK)
            {
                picedit.ImageLocation = open.FileName;
                txtpicedit.Text = open.FileName;
            }
        }

        private void DataGridbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ro = dataGridbook.CurrentRow;
            ID = Convert.ToInt32(ro.Cells[0].Value);
            txteditjudul.Text = ro.Cells[1].Value.ToString();
            comboEdittype.SelectedValue = ro.Cells[3].Value.ToString();
            txtedittotal.Text = ro.Cells[6].Value.ToString();
            txtpicedit.Text = ro.Cells[7].Value.ToString();

            lblhapus.Text = ro.Cells[1].Value.ToString();

            picedit.ImageLocation = txtpicedit.Text;

            btnHapus.Enabled = true;
            btnEdit.Enabled = true;

        }

        private void Btnsimpanedit_Click(object sender, EventArgs e)
        {
            if (txteditjudul.Text != "" && txtpicedit.Text != ""
                 && comboEdittype.Text != "" && txtedittotal.Text != "")
            {
                book Book = new book();
                Book = db.books.Single(x => x.book_id == ID);
                Book.book_title = txteditjudul.Text;
                Book.book_type = Convert.ToInt32(comboEdittype.SelectedValue);
                Book.total_books = Convert.ToInt32(txtedittotal.Text);
                Book.books_on_the_rack = Convert.ToInt32(txtedittotal.Text) - Book.books_borrowed;
                Book.photo_book = txtpicedit.Text;
                db.SubmitChanges();
                loadManbook();
            }
            else
            {
                inputValidation();
            }
          
        }
    }
}

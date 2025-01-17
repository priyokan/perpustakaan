﻿using System;
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

        private void inputValidation()
        {
            errorProvider1.Clear();
            if(txttype.Text == "")
            {
                errorProvider1.SetError(txttype, "cannot null");
            }
        }

        public void loadTableType()
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
            loadTableType();
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

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if(txttype.Text != "")
            {
                type typeBook = new type();
                typeBook.type_name = txttype.Text;
                db.types.InsertOnSubmit(typeBook);
                db.SubmitChanges();
                loadTableType();
            }
            else
            {
                inputValidation();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (txttype.Text != "")
            {
                type typeBook = new type();
                typeBook = db.types.Single(x => x.type_id == ID);
                typeBook.type_name = txttype.Text;
                db.SubmitChanges();
                loadTableType();
            }
            else
            {
                inputValidation();
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            type typeBook = new type();
            typeBook = db.types.Single(x => x.type_id == ID);
            db.types.DeleteOnSubmit(typeBook);
            db.SubmitChanges();
            loadTableType();
        }

        private void DataGridtypebook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ro = dataGridtypebook.CurrentRow;
            ID = Convert.ToInt32(ro.Cells[0].Value);
            txttype.Text = ro.Cells[1].Value.ToString();
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }
    }
}

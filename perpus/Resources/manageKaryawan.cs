using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace perpus.Resources
{
    public partial class manageKaryawan : UserControl
    {
        public manageKaryawan()
        {
            InitializeComponent();
        }

        int ID;
        Boolean emailValid;

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void txtValidation()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();

            errorProvider1.Clear();
            if (txtnama.Text == "")
            {
                errorProvider1.SetError(txtnama, "Nama Harus di isi");
            }
            if (txtemail.Text == "")
            {
                errorProvider2.SetError(txtemail, "Email Harus di isi");
            }
            if (txtpassword.Text == "")
            {
                errorProvider3.SetError(txtpassword, "Password Harus di isi");
            }
            if (comborole.Text == "")
            {
                errorProvider4.SetError(comborole, "Role Harus di isi");
            }
        }

        private void load()
        {
            try
            {
                this.employeeTableAdapter.FillBy2(this.perpusDataSet.employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            txtnama.Text = null;
            txtemail.Text = null;
            txtpassword.Text = null;
            comborole.Text = null;
            ID = 0;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;

            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
        }

        private void ManageKaryawan_Load(object sender, EventArgs e)
        {
            load();  
        }


        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void FillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void TxtCari_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                this.employeeTableAdapter.FillBy1(this.perpusDataSet.employee, txtCari.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void DataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ro = dataGridEmployee.CurrentRow;
            txtnama.Text = ro.Cells[1].Value.ToString();
            txtemail.Text = ro.Cells[2].Value.ToString();
            txtpassword.Text = ro.Cells[3].Value.ToString();
            comborole.Text = ro.Cells[4].Value.ToString();
            ID = Convert.ToInt32( ro.Cells[0].Value);

            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if( txtnama.Text != "" && txtemail.Text != "" 
                && txtpassword.Text != "" && comborole.Text != "" && emailValid==true)
            {
                employee employ = new employee();
                employ.name = txtnama.Text;
                employ.email = txtemail.Text;
                employ.password = txtpassword.Text;
                employ.role = comborole.Text;
                db.employees.InsertOnSubmit(employ);
                db.SubmitChanges();
                load();
            }
            else
            {
                txtValidation();
            }
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (txtnama.Text != "" && txtemail.Text != ""
                && txtpassword.Text != "" && comborole.Text != "" && emailValid == true)
            {
                employee employe = new employee();
                employe = db.employees.Single(x => x.user_id == ID);
                employe.name = txtnama.Text;
                employe.email = txtemail.Text;
                employe.password = txtemail.Text;
                employe.role = comborole.Text;
                db.SubmitChanges();
                load();
            }
            else
            {
                txtValidation();
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            employee employ = new employee();
            employ = db.employees.Single(x => x.user_id == ID);
            db.employees.DeleteOnSubmit(employ);
            db.SubmitChanges();
            load();
        }

        private void Txtemail_Leave(object sender, EventArgs e)
        {
            string pattern = "^[a-z0-9]+@+([a-z]+[.])+[a-z]{2,5}$";
            if(Regex.IsMatch(txtemail.Text , pattern)){
                errorProvider2.Clear();
                emailValid = true;
            }
            else
            {
                errorProvider2.SetError(txtemail, "Email Invlaid");
                emailValid = false;
            }
        }
    }
}

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

namespace perpus
{
    public partial class ucmanageMember : UserControl
    {
        public ucmanageMember()
        {
            InitializeComponent();
        }

        int ID;
        DataClasses1DataContext db = new DataClasses1DataContext();
        private string getDate()
        {
            DateTimePicker date = new DateTimePicker();
            string today = date.Value.ToString();
            return today; 
        }

        private void loadTable()
        {
            try
            {
                this.memberTableAdapter.FillBy(this.perpusDataSet2.member);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void loadManMember()
        {
            loadTable();

            txtnama.Text = "";
            txtemail.Text = "";
            txthandphone.Text = "";
            txtPic.Text = "";
            picture.ImageLocation = null;

            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();

            panelCetakKartu.Enabled = false;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
        }
        private void inputValidation()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();

            if(txtnama.Text == "")
            {
                errorProvider1.SetError(txtnama, "nama harus diisi");
            }
            if (txtemail.Text == "")
            {
                errorProvider2.SetError(txtemail, "email harus diisi");
            }
            if (txthandphone.Text == "")
            {
                errorProvider3.SetError(txthandphone, "handphone harus diisi");
            }
            if (txtPic.Text == "")
            {
                errorProvider4.SetError(btnSrc, "photo harus diisi");
            }
        }


        private void UcmanageMember_Load(object sender, EventArgs e)
        {
            panelActive.Location = panelBtnManageMember.Location;
            loadManMember();
        }

        private void Txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Label4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void TxtCari_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.memberTableAdapter.FillBy1(this.perpusDataSet2.member, txtCari.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if(txtnama.Text != ""&&txtemail.Text !=""&&txthandphone.Text!="" && txtPic.Text != "")
            {
                member memm = new member();
                memm.nama = txtnama.Text;
                memm.email = txtemail.Text;
                memm.handphone = txthandphone.Text;
                memm.joindate = Convert.ToDateTime(getDate());
                memm.pohoto = txtPic.Text;
                db.members.InsertOnSubmit(memm);
                db.SubmitChanges();
                loadManMember();
            }
            else
            {
                inputValidation();
            }
        }

        private void DataGridMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridMember.CurrentRow;
            ID = Convert.ToInt32(row.Cells[0].Value);
            txtnama.Text = row.Cells[1].Value.ToString();
            txtemail.Text = row.Cells[2].Value.ToString();
            txthandphone.Text = row.Cells[3].Value.ToString();
            txtPic.Text = row.Cells[5].Value.ToString();
            picture.ImageLocation= row.Cells[5].Value.ToString();

            ucCetakKartu.ID = ID;
            panelCetakKartu.Enabled = true;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }

        private void BtnSrc_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files(*.jpg,*.png,*.jpeg)|*.jpg;*.png;*.jpeg";
            if(open.ShowDialog() == DialogResult.OK)
            {
                txtPic.Text = open.FileName;
                picture.ImageLocation = open.FileName;
            }

        }

        private void FillByToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void FillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (txtnama.Text != "" && txtemail.Text != "" && txthandphone.Text != "" && txtPic.Text != "")
            {
                member memm = new member();
                memm = db.members.Single(x => x.nis == ID);
                memm.nama = txtnama.Text;
                memm.email = txtemail.Text;
                memm.handphone = txthandphone.Text;
                memm.joindate = Convert.ToDateTime(getDate());
                memm.pohoto = txtPic.Text;
                db.SubmitChanges();
                loadManMember();
            }
            else
            {
                inputValidation();
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (txtnama.Text != "" && txtemail.Text != "" && txthandphone.Text != "" && txtPic.Text !="")
            {
                member memm = new member();
                memm = db.members.Single(x => x.nis == ID);
                db.members.DeleteOnSubmit(memm);
                db.SubmitChanges();
                loadManMember();
            }
            else
            {
                inputValidation();
            }
        }

        private void Txtemail_Leave(object sender, EventArgs e)
        {
            string pattern = "^[a-z0-9]+@+([a-z]+[.])+[a-z]{2,5}$";
            if (Regex.IsMatch(txtemail.Text, pattern))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(txtemail, "email invalid");
            }
        }

        private void PanelCetakKartu_Click(object sender, EventArgs e)
        {
            panelActive.Location = panelCetakKartu.Location;
            ucCetakKartu1.Visible = true;
        }

        private void PanelBtnManageMember_Click(object sender, EventArgs e)
        {
            panelActive.Location = panelBtnManageMember.Location;
            ucCetakKartu1.Visible = false;
            loadManMember();
        }
    }
}

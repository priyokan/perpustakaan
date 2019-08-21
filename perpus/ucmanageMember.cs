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
                this.memberTableAdapter.FillBy(this.perpusDataSet1.member);
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

            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
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
        }


        private void UcmanageMember_Load(object sender, EventArgs e)
        {
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

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void TxtCari_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.memberTableAdapter.FillBy1(this.perpusDataSet1.member, txtCari.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if(txtnama.Text != ""&&txtemail.Text !=""&&txthandphone.Text!="")
            {
                member memm = new member();
                memm.nama = txtnama.Text;
                memm.email = txtemail.Text;
                memm.handphone = txthandphone.Text;
                memm.joindate = Convert.ToDateTime(getDate());
                db.members.InsertOnSubmit(memm);
                db.SubmitChanges();
                loadManMember();
            }
            else
            {

            }
        }
    }
}

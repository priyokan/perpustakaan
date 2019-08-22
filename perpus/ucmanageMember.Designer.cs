namespace perpus
{
    partial class ucmanageMember
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelActive = new System.Windows.Forms.Panel();
            this.panelCetakKartu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBtnManageMember = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txthandphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridMember = new System.Windows.Forms.DataGridView();
            this.nisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pohotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perpusDataSet2 = new perpus.perpusDataSet2();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSrc = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.namaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.namaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.perpusDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new perpus.perpusDataSet2TableAdapters.memberTableAdapter();
            this.ucCetakKartu1 = new perpus.ucCetakKartu();
            this.panelCetakKartu.SuspendLayout();
            this.panelBtnManageMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpusDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perpusDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActive
            // 
            this.panelActive.BackColor = System.Drawing.Color.Goldenrod;
            this.panelActive.Location = new System.Drawing.Point(16, 22);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(10, 70);
            this.panelActive.TabIndex = 31;
            // 
            // panelCetakKartu
            // 
            this.panelCetakKartu.BackColor = System.Drawing.Color.SeaGreen;
            this.panelCetakKartu.Controls.Add(this.label3);
            this.panelCetakKartu.Controls.Add(this.label4);
            this.panelCetakKartu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCetakKartu.Location = new System.Drawing.Point(284, 22);
            this.panelCetakKartu.Name = "panelCetakKartu";
            this.panelCetakKartu.Size = new System.Drawing.Size(237, 70);
            this.panelCetakKartu.TabIndex = 30;
            this.panelCetakKartu.Click += new System.EventHandler(this.PanelCetakKartu_Click);
            this.panelCetakKartu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label4_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Form Management type buku";
            this.label3.Click += new System.EventHandler(this.PanelCetakKartu_Click);
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label4_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cetak kartu anggota";
            this.label4.Click += new System.EventHandler(this.PanelCetakKartu_Click);
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label4_MouseClick);
            // 
            // panelBtnManageMember
            // 
            this.panelBtnManageMember.BackColor = System.Drawing.Color.Teal;
            this.panelBtnManageMember.Controls.Add(this.label2);
            this.panelBtnManageMember.Controls.Add(this.label1);
            this.panelBtnManageMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBtnManageMember.Location = new System.Drawing.Point(32, 22);
            this.panelBtnManageMember.Name = "panelBtnManageMember";
            this.panelBtnManageMember.Size = new System.Drawing.Size(232, 70);
            this.panelBtnManageMember.TabIndex = 29;
            this.panelBtnManageMember.Click += new System.EventHandler(this.PanelBtnManageMember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Form Management member";
            this.label2.Click += new System.EventHandler(this.PanelBtnManageMember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Member";
            this.label1.Click += new System.EventHandler(this.PanelBtnManageMember_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Location = new System.Drawing.Point(281, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Cari :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel6.Location = new System.Drawing.Point(334, 134);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 2);
            this.panel6.TabIndex = 48;
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(336, 117);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(258, 17);
            this.txtCari.TabIndex = 47;
            this.txtCari.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCari_KeyUp);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Crimson;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHapus.Location = new System.Drawing.Point(830, 406);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(85, 35);
            this.btnHapus.TabIndex = 46;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(732, 406);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 35);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambah.Location = new System.Drawing.Point(632, 406);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(85, 35);
            this.btnTambah.TabIndex = 44;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(713, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 40;
            // 
            // txthandphone
            // 
            this.txthandphone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txthandphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txthandphone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthandphone.Location = new System.Drawing.Point(713, 206);
            this.txthandphone.MaxLength = 14;
            this.txthandphone.Name = "txthandphone";
            this.txthandphone.Size = new System.Drawing.Size(200, 16);
            this.txthandphone.TabIndex = 39;
            this.txthandphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpassword_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(629, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Handphone";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(713, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 37;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(713, 174);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 16);
            this.txtemail.TabIndex = 36;
            this.txtemail.Leave += new System.EventHandler(this.Txtemail_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(629, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(713, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 34;
            // 
            // txtnama
            // 
            this.txtnama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnama.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.Location = new System.Drawing.Point(713, 140);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(200, 16);
            this.txtnama.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(629, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nama";
            // 
            // dataGridMember
            // 
            this.dataGridMember.AllowUserToAddRows = false;
            this.dataGridMember.AllowUserToDeleteRows = false;
            this.dataGridMember.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMember.AutoGenerateColumns = false;
            this.dataGridMember.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nisDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.handphoneDataGridViewTextBoxColumn,
            this.joindateDataGridViewTextBoxColumn,
            this.pohotoDataGridViewTextBoxColumn});
            this.dataGridMember.DataSource = this.memberBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMember.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMember.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridMember.Location = new System.Drawing.Point(37, 140);
            this.dataGridMember.Name = "dataGridMember";
            this.dataGridMember.ReadOnly = true;
            this.dataGridMember.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridMember.RowHeadersVisible = false;
            this.dataGridMember.Size = new System.Drawing.Size(558, 344);
            this.dataGridMember.TabIndex = 31;
            this.dataGridMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMember_CellClick);
            // 
            // nisDataGridViewTextBoxColumn
            // 
            this.nisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nisDataGridViewTextBoxColumn.DataPropertyName = "nis";
            this.nisDataGridViewTextBoxColumn.HeaderText = "nis";
            this.nisDataGridViewTextBoxColumn.Name = "nisDataGridViewTextBoxColumn";
            this.nisDataGridViewTextBoxColumn.ReadOnly = true;
            this.nisDataGridViewTextBoxColumn.Width = 52;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // handphoneDataGridViewTextBoxColumn
            // 
            this.handphoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.handphoneDataGridViewTextBoxColumn.DataPropertyName = "handphone";
            this.handphoneDataGridViewTextBoxColumn.HeaderText = "handphone";
            this.handphoneDataGridViewTextBoxColumn.Name = "handphoneDataGridViewTextBoxColumn";
            this.handphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.handphoneDataGridViewTextBoxColumn.Width = 106;
            // 
            // joindateDataGridViewTextBoxColumn
            // 
            this.joindateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.joindateDataGridViewTextBoxColumn.DataPropertyName = "joindate";
            this.joindateDataGridViewTextBoxColumn.HeaderText = "joindate";
            this.joindateDataGridViewTextBoxColumn.Name = "joindateDataGridViewTextBoxColumn";
            this.joindateDataGridViewTextBoxColumn.ReadOnly = true;
            this.joindateDataGridViewTextBoxColumn.Width = 84;
            // 
            // pohotoDataGridViewTextBoxColumn
            // 
            this.pohotoDataGridViewTextBoxColumn.DataPropertyName = "pohoto";
            this.pohotoDataGridViewTextBoxColumn.HeaderText = "pohoto";
            this.pohotoDataGridViewTextBoxColumn.Name = "pohotoDataGridViewTextBoxColumn";
            this.pohotoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pohotoDataGridViewTextBoxColumn.Visible = false;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.perpusDataSet2;
            // 
            // perpusDataSet2
            // 
            this.perpusDataSet2.DataSetName = "perpusDataSet2";
            this.perpusDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // btnSrc
            // 
            this.btnSrc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSrc.FlatAppearance.BorderSize = 0;
            this.btnSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSrc.Location = new System.Drawing.Point(880, 369);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(34, 20);
            this.btnSrc.TabIndex = 64;
            this.btnSrc.Text = "...";
            this.btnSrc.UseVisualStyleBackColor = false;
            this.btnSrc.Click += new System.EventHandler(this.BtnSrc_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Location = new System.Drawing.Point(713, 387);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 2);
            this.panel5.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(629, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Photo";
            // 
            // txtPic
            // 
            this.txtPic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPic.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPic.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPic.Location = new System.Drawing.Point(713, 371);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(161, 16);
            this.txtPic.TabIndex = 62;
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(713, 237);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(200, 126);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 60;
            this.picture.TabStop = false;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(956, 25);
            this.fillByToolStrip.TabIndex = 65;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.FillByToolStripButton_Click_1);
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namaToolStripLabel,
            this.namaToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(956, 25);
            this.fillBy1ToolStrip.TabIndex = 66;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // namaToolStripLabel
            // 
            this.namaToolStripLabel.Name = "namaToolStripLabel";
            this.namaToolStripLabel.Size = new System.Drawing.Size(40, 22);
            this.namaToolStripLabel.Text = "nama:";
            // 
            // namaToolStripTextBox
            // 
            this.namaToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.namaToolStripTextBox.Name = "namaToolStripTextBox";
            this.namaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.FillBy1ToolStripButton_Click_1);
            // 
            // perpusDataSet2BindingSource
            // 
            this.perpusDataSet2BindingSource.DataSource = this.perpusDataSet2;
            this.perpusDataSet2BindingSource.Position = 0;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // ucCetakKartu1
            // 
            this.ucCetakKartu1.Location = new System.Drawing.Point(0, 117);
            this.ucCetakKartu1.Name = "ucCetakKartu1";
            this.ucCetakKartu1.Size = new System.Drawing.Size(975, 408);
            this.ucCetakKartu1.TabIndex = 67;
            this.ucCetakKartu1.Visible = false;
            // 
            // ucmanageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelActive);
            this.Controls.Add(this.ucCetakKartu1);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnSrc);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txthandphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridMember);
            this.Controls.Add(this.panelCetakKartu);
            this.Controls.Add(this.panelBtnManageMember);
            this.Name = "ucmanageMember";
            this.Size = new System.Drawing.Size(956, 525);
            this.Load += new System.EventHandler(this.UcmanageMember_Load);
            this.panelCetakKartu.ResumeLayout(false);
            this.panelCetakKartu.PerformLayout();
            this.panelBtnManageMember.ResumeLayout(false);
            this.panelBtnManageMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpusDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perpusDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.Panel panelCetakKartu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelBtnManageMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txthandphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridMember;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private perpusDataSet2 perpusDataSet2;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource perpusDataSet2BindingSource;
        private perpusDataSet2TableAdapters.memberTableAdapter memberTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel namaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox namaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pohotoDataGridViewTextBoxColumn;
        private ucCetakKartu ucCetakKartu1;
    }
}

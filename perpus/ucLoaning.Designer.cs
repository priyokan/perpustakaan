namespace perpus
{
    partial class ucLoaning
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBtnManageMember = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perpusDataSet2 = new perpus.perpusDataSet2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridtypebook = new System.Windows.Forms.DataGridView();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksontherackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksborrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalbooksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photobookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.judul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bookTableAdapter = new perpus.perpusDataSet2TableAdapters.bookTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtjudulTambah = new System.Windows.Forms.TextBox();
            this.txtTotalTambah = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.memberTableAdapter = new perpus.perpusDataSet2TableAdapters.memberTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.titleToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.titleToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panelBtnManageMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpusDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtypebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBtnManageMember
            // 
            this.panelBtnManageMember.BackColor = System.Drawing.Color.Teal;
            this.panelBtnManageMember.Controls.Add(this.label2);
            this.panelBtnManageMember.Controls.Add(this.label1);
            this.panelBtnManageMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBtnManageMember.Location = new System.Drawing.Point(0, 22);
            this.panelBtnManageMember.Name = "panelBtnManageMember";
            this.panelBtnManageMember.Size = new System.Drawing.Size(232, 70);
            this.panelBtnManageMember.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Form layanan peminjaman";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(81, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peminjaman";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.DataSource = this.memberBindingSource;
            this.comboBox1.DisplayMember = "nama";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(417, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 26);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "nama";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(417, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 2);
            this.panel1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Member :";
            // 
            // dataGridtypebook
            // 
            this.dataGridtypebook.AllowUserToAddRows = false;
            this.dataGridtypebook.AllowUserToDeleteRows = false;
            this.dataGridtypebook.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridtypebook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridtypebook.AutoGenerateColumns = false;
            this.dataGridtypebook.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridtypebook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridtypebook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridtypebook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridtypebook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridtypebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtypebook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookidDataGridViewTextBoxColumn,
            this.booktitleDataGridViewTextBoxColumn,
            this.booktypeDataGridViewTextBoxColumn,
            this.booksontherackDataGridViewTextBoxColumn,
            this.booksborrowedDataGridViewTextBoxColumn,
            this.totalbooksDataGridViewTextBoxColumn,
            this.photobookDataGridViewTextBoxColumn});
            this.dataGridtypebook.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridtypebook.DataSource = this.bookBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridtypebook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridtypebook.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridtypebook.Location = new System.Drawing.Point(48, 132);
            this.dataGridtypebook.Name = "dataGridtypebook";
            this.dataGridtypebook.ReadOnly = true;
            this.dataGridtypebook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridtypebook.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridtypebook.RowHeadersVisible = false;
            this.dataGridtypebook.Size = new System.Drawing.Size(319, 343);
            this.dataGridtypebook.TabIndex = 35;
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "book_id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "book_id";
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            this.bookidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookidDataGridViewTextBoxColumn.Visible = false;
            // 
            // booktitleDataGridViewTextBoxColumn
            // 
            this.booktitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.booktitleDataGridViewTextBoxColumn.DataPropertyName = "book_title";
            this.booktitleDataGridViewTextBoxColumn.HeaderText = "Judul";
            this.booktitleDataGridViewTextBoxColumn.Name = "booktitleDataGridViewTextBoxColumn";
            this.booktitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booktypeDataGridViewTextBoxColumn
            // 
            this.booktypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.booktypeDataGridViewTextBoxColumn.DataPropertyName = "book_type";
            this.booktypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.booktypeDataGridViewTextBoxColumn.Name = "booktypeDataGridViewTextBoxColumn";
            this.booktypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booksontherackDataGridViewTextBoxColumn
            // 
            this.booksontherackDataGridViewTextBoxColumn.DataPropertyName = "books_on_the_rack";
            this.booksontherackDataGridViewTextBoxColumn.HeaderText = "books_on_the_rack";
            this.booksontherackDataGridViewTextBoxColumn.Name = "booksontherackDataGridViewTextBoxColumn";
            this.booksontherackDataGridViewTextBoxColumn.ReadOnly = true;
            this.booksontherackDataGridViewTextBoxColumn.Visible = false;
            // 
            // booksborrowedDataGridViewTextBoxColumn
            // 
            this.booksborrowedDataGridViewTextBoxColumn.DataPropertyName = "books_borrowed";
            this.booksborrowedDataGridViewTextBoxColumn.HeaderText = "books_borrowed";
            this.booksborrowedDataGridViewTextBoxColumn.Name = "booksborrowedDataGridViewTextBoxColumn";
            this.booksborrowedDataGridViewTextBoxColumn.ReadOnly = true;
            this.booksborrowedDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalbooksDataGridViewTextBoxColumn
            // 
            this.totalbooksDataGridViewTextBoxColumn.DataPropertyName = "total_books";
            this.totalbooksDataGridViewTextBoxColumn.HeaderText = "total_books";
            this.totalbooksDataGridViewTextBoxColumn.Name = "totalbooksDataGridViewTextBoxColumn";
            this.totalbooksDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalbooksDataGridViewTextBoxColumn.Visible = false;
            // 
            // photobookDataGridViewTextBoxColumn
            // 
            this.photobookDataGridViewTextBoxColumn.DataPropertyName = "photo_book";
            this.photobookDataGridViewTextBoxColumn.HeaderText = "photo_book";
            this.photobookDataGridViewTextBoxColumn.Name = "photobookDataGridViewTextBoxColumn";
            this.photobookDataGridViewTextBoxColumn.ReadOnly = true;
            this.photobookDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.perpusDataSet2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.judul,
            this.Type,
            this.qty});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(634, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(319, 343);
            this.dataGridView1.TabIndex = 36;
            // 
            // judul
            // 
            this.judul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.judul.HeaderText = "Judul";
            this.judul.Name = "judul";
            this.judul.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.HeaderText = "qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Location = new System.Drawing.Point(54, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 54;
            this.label7.Text = "Cari :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel6.Location = new System.Drawing.Point(107, 125);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 2);
            this.panel6.TabIndex = 53;
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(109, 108);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(258, 17);
            this.txtCari.TabIndex = 52;
            this.txtCari.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCari_KeyUp);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(973, 25);
            this.fillByToolStrip.TabIndex = 55;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.FillByToolStripButton_Click);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(431, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 2);
            this.panel2.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(385, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Judul";
            // 
            // txtjudulTambah
            // 
            this.txtjudulTambah.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtjudulTambah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtjudulTambah.Enabled = false;
            this.txtjudulTambah.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjudulTambah.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtjudulTambah.Location = new System.Drawing.Point(431, 136);
            this.txtjudulTambah.Name = "txtjudulTambah";
            this.txtjudulTambah.Size = new System.Drawing.Size(183, 16);
            this.txtjudulTambah.TabIndex = 62;
            // 
            // txtTotalTambah
            // 
            this.txtTotalTambah.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalTambah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalTambah.Enabled = false;
            this.txtTotalTambah.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTambah.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTotalTambah.Location = new System.Drawing.Point(431, 165);
            this.txtTotalTambah.Name = "txtTotalTambah";
            this.txtTotalTambah.Size = new System.Drawing.Size(183, 16);
            this.txtTotalTambah.TabIndex = 67;
            this.txtTotalTambah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTotalTambah_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(385, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Total";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Location = new System.Drawing.Point(431, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 2);
            this.panel4.TabIndex = 68;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Crimson;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHapus.Location = new System.Drawing.Point(511, 198);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(103, 35);
            this.btnHapus.TabIndex = 70;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambah.Location = new System.Drawing.Point(388, 198);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(105, 35);
            this.btnTambah.TabIndex = 69;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripLabel,
            this.titleToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(973, 25);
            this.fillBy1ToolStrip.TabIndex = 71;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // titleToolStripLabel
            // 
            this.titleToolStripLabel.Name = "titleToolStripLabel";
            this.titleToolStripLabel.Size = new System.Drawing.Size(30, 22);
            this.titleToolStripLabel.Text = "title:";
            // 
            // titleToolStripTextBox
            // 
            this.titleToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.titleToolStripTextBox.Name = "titleToolStripTextBox";
            this.titleToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.FillBy1ToolStripButton_Click);
            // 
            // ucLoaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalTambah);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtjudulTambah);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridtypebook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panelBtnManageMember);
            this.Name = "ucLoaning";
            this.Size = new System.Drawing.Size(973, 525);
            this.Load += new System.EventHandler(this.UcLoaning_Load);
            this.panelBtnManageMember.ResumeLayout(false);
            this.panelBtnManageMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpusDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtypebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBtnManageMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridtypebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksontherackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksborrowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalbooksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photobookDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private perpusDataSet2 perpusDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn judul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private perpusDataSet2TableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtjudulTambah;
        private System.Windows.Forms.TextBox txtTotalTambah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private perpusDataSet2TableAdapters.memberTableAdapter memberTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel titleToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox titleToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}

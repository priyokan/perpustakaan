namespace perpus
{
    partial class userControlAbsen
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
            this.txtNIS = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmasuk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNIS
            // 
            this.txtNIS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIS.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIS.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtNIS.Location = new System.Drawing.Point(291, 155);
            this.txtNIS.Name = "txtNIS";
            this.txtNIS.Size = new System.Drawing.Size(268, 31);
            this.txtNIS.TabIndex = 0;
            this.txtNIS.Text = "Masukan NIS...";
            this.txtNIS.Enter += new System.EventHandler(this.TxtNIS_Enter);
            this.txtNIS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNIS_KeyPress);
            this.txtNIS.Leave += new System.EventHandler(this.TxtNIS_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(291, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 2);
            this.panel1.TabIndex = 1;
            // 
            // btnmasuk
            // 
            this.btnmasuk.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmasuk.FlatAppearance.BorderSize = 0;
            this.btnmasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmasuk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmasuk.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnmasuk.Location = new System.Drawing.Point(557, 155);
            this.btnmasuk.Name = "btnmasuk";
            this.btnmasuk.Size = new System.Drawing.Size(86, 31);
            this.btnmasuk.TabIndex = 2;
            this.btnmasuk.Text = "Masuk";
            this.btnmasuk.UseVisualStyleBackColor = false;
            this.btnmasuk.Click += new System.EventHandler(this.Btnmasuk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(297, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selamat datang";
            this.label1.Visible = false;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblNama.Location = new System.Drawing.Point(391, 198);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(49, 13);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "[name]";
            this.lblNama.Visible = false;
            this.lblNama.Click += new System.EventHandler(this.Label2_Click);
            // 
            // userControlAbsen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmasuk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNIS);
            this.Name = "userControlAbsen";
            this.Size = new System.Drawing.Size(907, 466);
            this.Load += new System.EventHandler(this.UserControlAbsen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNIS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmasuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNama;
    }
}

namespace perpus
{
    partial class adminMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMasterDenda = new System.Windows.Forms.Button();
            this.btnactive = new System.Windows.Forms.Panel();
            this.lblnama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnManageMember = new System.Windows.Forms.Button();
            this.btnManageBuku = new System.Windows.Forms.Button();
            this.btnManagekaryawan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.manageBuku1 = new perpus.manageBuku();
            this.manageKaryawan1 = new perpus.Resources.manageKaryawan();
            this.ucmanageMember1 = new perpus.ucmanageMember();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnclose);
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1257, 33);
            this.panel4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(582, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Admin";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclose.Location = new System.Drawing.Point(1209, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(47, 24);
            this.btnclose.TabIndex = 14;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnMasterDenda);
            this.panel1.Controls.Add(this.btnactive);
            this.panel1.Controls.Add(this.lblnama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnManageMember);
            this.panel1.Controls.Add(this.btnManageBuku);
            this.panel1.Controls.Add(this.btnManagekaryawan);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(-1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 562);
            this.panel1.TabIndex = 13;
            // 
            // btnMasterDenda
            // 
            this.btnMasterDenda.BackColor = System.Drawing.Color.Transparent;
            this.btnMasterDenda.FlatAppearance.BorderSize = 0;
            this.btnMasterDenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMasterDenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterDenda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterDenda.ForeColor = System.Drawing.Color.White;
            this.btnMasterDenda.Location = new System.Drawing.Point(13, 290);
            this.btnMasterDenda.Name = "btnMasterDenda";
            this.btnMasterDenda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMasterDenda.Size = new System.Drawing.Size(200, 43);
            this.btnMasterDenda.TabIndex = 22;
            this.btnMasterDenda.Text = "Master Denda";
            this.btnMasterDenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterDenda.UseVisualStyleBackColor = false;
            this.btnMasterDenda.Click += new System.EventHandler(this.BtnMasterDenda_Click);
            // 
            // btnactive
            // 
            this.btnactive.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnactive.Location = new System.Drawing.Point(13, 143);
            this.btnactive.Name = "btnactive";
            this.btnactive.Size = new System.Drawing.Size(3, 43);
            this.btnactive.TabIndex = 21;
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnama.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblnama.Location = new System.Drawing.Point(26, 54);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(66, 18);
            this.lblnama.TabIndex = 20;
            this.lblnama.Text = "[Nama]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Selamat datang :";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(14, 339);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(200, 43);
            this.btnReport.TabIndex = 18;
            this.btnReport.Text = "Laporan";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnManageMember
            // 
            this.btnManageMember.BackColor = System.Drawing.Color.Transparent;
            this.btnManageMember.FlatAppearance.BorderSize = 0;
            this.btnManageMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnManageMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMember.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMember.ForeColor = System.Drawing.Color.White;
            this.btnManageMember.Location = new System.Drawing.Point(14, 241);
            this.btnManageMember.Name = "btnManageMember";
            this.btnManageMember.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageMember.Size = new System.Drawing.Size(200, 43);
            this.btnManageMember.TabIndex = 17;
            this.btnManageMember.Text = "Manage member";
            this.btnManageMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMember.UseVisualStyleBackColor = false;
            this.btnManageMember.Click += new System.EventHandler(this.BtnManageMember_Click);
            // 
            // btnManageBuku
            // 
            this.btnManageBuku.BackColor = System.Drawing.Color.Transparent;
            this.btnManageBuku.FlatAppearance.BorderSize = 0;
            this.btnManageBuku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnManageBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBuku.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBuku.ForeColor = System.Drawing.Color.White;
            this.btnManageBuku.Location = new System.Drawing.Point(14, 192);
            this.btnManageBuku.Name = "btnManageBuku";
            this.btnManageBuku.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageBuku.Size = new System.Drawing.Size(200, 43);
            this.btnManageBuku.TabIndex = 16;
            this.btnManageBuku.Text = "Manage buku";
            this.btnManageBuku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBuku.UseVisualStyleBackColor = false;
            this.btnManageBuku.Click += new System.EventHandler(this.BtnManageBuku_Click);
            // 
            // btnManagekaryawan
            // 
            this.btnManagekaryawan.BackColor = System.Drawing.Color.Transparent;
            this.btnManagekaryawan.FlatAppearance.BorderSize = 0;
            this.btnManagekaryawan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnManagekaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagekaryawan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagekaryawan.ForeColor = System.Drawing.Color.White;
            this.btnManagekaryawan.Location = new System.Drawing.Point(14, 143);
            this.btnManagekaryawan.Name = "btnManagekaryawan";
            this.btnManagekaryawan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManagekaryawan.Size = new System.Drawing.Size(200, 43);
            this.btnManagekaryawan.TabIndex = 15;
            this.btnManagekaryawan.Text = "Manage karyawan";
            this.btnManagekaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagekaryawan.UseVisualStyleBackColor = false;
            this.btnManagekaryawan.Click += new System.EventHandler(this.BtnManagekaryawan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(14, 488);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 43);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // manageBuku1
            // 
            this.manageBuku1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.manageBuku1.Location = new System.Drawing.Point(225, 39);
            this.manageBuku1.Name = "manageBuku1";
            this.manageBuku1.Size = new System.Drawing.Size(956, 525);
            this.manageBuku1.TabIndex = 15;
            this.manageBuku1.Load += new System.EventHandler(this.ManageBuku1_Load);
            // 
            // manageKaryawan1
            // 
            this.manageKaryawan1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.manageKaryawan1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.manageKaryawan1.Location = new System.Drawing.Point(225, 39);
            this.manageKaryawan1.Name = "manageKaryawan1";
            this.manageKaryawan1.Size = new System.Drawing.Size(976, 525);
            this.manageKaryawan1.TabIndex = 14;
            this.manageKaryawan1.Load += new System.EventHandler(this.ManageKaryawan1_Load);
            // 
            // ucmanageMember1
            // 
            this.ucmanageMember1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucmanageMember1.Location = new System.Drawing.Point(225, 39);
            this.ucmanageMember1.Name = "ucmanageMember1";
            this.ucmanageMember1.Size = new System.Drawing.Size(956, 525);
            this.ucmanageMember1.TabIndex = 16;
            this.ucmanageMember1.Load += new System.EventHandler(this.UcmanageMember1_Load);
            // 
            // adminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1209, 591);
            this.Controls.Add(this.ucmanageMember1);
            this.Controls.Add(this.manageBuku1);
            this.Controls.Add(this.manageKaryawan1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "adminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnManageMember;
        private System.Windows.Forms.Button btnManageBuku;
        private System.Windows.Forms.Button btnManagekaryawan;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel btnactive;
        private System.Windows.Forms.Button btnMasterDenda;
        private Resources.manageKaryawan manageKaryawan1;
        private manageBuku manageBuku1;
        private ucmanageMember ucmanageMember1;
    }
}
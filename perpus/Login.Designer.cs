﻿namespace perpus
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkmember = new System.Windows.Forms.LinkLabel();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblWrongpass = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(170, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtEmail.Location = new System.Drawing.Point(89, 153);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 31);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "masukan email...";
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(68, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(68, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 1);
            this.panel2.TabIndex = 4;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Teal;
            this.btnlogin.Location = new System.Drawing.Point(68, 322);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(271, 43);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(371, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 24);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 33);
            this.panel4.TabIndex = 11;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Nirmala UI", 11.25F);
            this.txtpassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtpassword.Location = new System.Drawing.Point(89, 223);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(253, 20);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Text = "masukan password...";
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtpassword_KeyDown);
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpassword_KeyPress_1);
            this.txtpassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtpassword_KeyUp);
            this.txtpassword.Leave += new System.EventHandler(this.Txtpassword_Leave_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // linkmember
            // 
            this.linkmember.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.linkmember.AutoSize = true;
            this.linkmember.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.linkmember.LinkColor = System.Drawing.Color.Teal;
            this.linkmember.Location = new System.Drawing.Point(169, 409);
            this.linkmember.Name = "linkmember";
            this.linkmember.Size = new System.Drawing.Size(71, 13);
            this.linkmember.TabIndex = 12;
            this.linkmember.TabStop = true;
            this.linkmember.Text = "Member Form";
            this.linkmember.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linkmember_LinkClicked);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // lblWrongpass
            // 
            this.lblWrongpass.AutoSize = true;
            this.lblWrongpass.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongpass.ForeColor = System.Drawing.Color.Red;
            this.lblWrongpass.Location = new System.Drawing.Point(128, 269);
            this.lblWrongpass.Name = "lblWrongpass";
            this.lblWrongpass.Size = new System.Drawing.Size(157, 13);
            this.lblWrongpass.TabIndex = 13;
            this.lblWrongpass.Text = "Maaf, akun tidak ditemukan";
            this.lblWrongpass.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::perpus.Properties.Resources.icons8_password_filled_50px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(59, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 24);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::perpus.Properties.Resources.icons8_email_filled_50px_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(59, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 24);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(411, 487);
            this.Controls.Add(this.lblWrongpass);
            this.Controls.Add(this.linkmember);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel linkmember;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label lblWrongpass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


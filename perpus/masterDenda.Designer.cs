namespace perpus
{
    partial class masterDenda
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
            this.panelBtnManageMember = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtdenda = new System.Windows.Forms.TextBox();
            this.panelSave = new System.Windows.Forms.Panel();
            this.btnyes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBtnManageMember.SuspendLayout();
            this.panelSave.SuspendLayout();
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
            this.panelBtnManageMember.TabIndex = 30;
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(197, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 2);
            this.panel2.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(130, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "Denda :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(440, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "/bulan";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(506, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 29);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtdenda
            // 
            this.txtdenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtdenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdenda.ForeColor = System.Drawing.Color.DimGray;
            this.txtdenda.Location = new System.Drawing.Point(200, 262);
            this.txtdenda.MaxLength = 14;
            this.txtdenda.Name = "txtdenda";
            this.txtdenda.Size = new System.Drawing.Size(237, 20);
            this.txtdenda.TabIndex = 40;
            this.txtdenda.Enter += new System.EventHandler(this.Txtdenda_Enter);
            this.txtdenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdenda_KeyPress);
            this.txtdenda.Leave += new System.EventHandler(this.Txtdenda_Leave);
            // 
            // panelSave
            // 
            this.panelSave.BackColor = System.Drawing.Color.DimGray;
            this.panelSave.Controls.Add(this.label4);
            this.panelSave.Controls.Add(this.btnyes);
            this.panelSave.Location = new System.Drawing.Point(506, 282);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(222, 29);
            this.panelSave.TabIndex = 41;
            this.panelSave.Visible = false;
            // 
            // btnyes
            // 
            this.btnyes.BackColor = System.Drawing.Color.DimGray;
            this.btnyes.FlatAppearance.BorderSize = 0;
            this.btnyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyes.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnyes.Location = new System.Drawing.Point(177, 0);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(43, 29);
            this.btnyes.TabIndex = 40;
            this.btnyes.Text = "ya";
            this.btnyes.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Simpan perubahan?";
            // 
            // masterDenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.txtdenda);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelBtnManageMember);
            this.Name = "masterDenda";
            this.Size = new System.Drawing.Size(956, 525);
            this.Load += new System.EventHandler(this.MasterDenda_Load);
            this.VisibleChanged += new System.EventHandler(this.MasterDenda_VisibleChanged);
            this.panelBtnManageMember.ResumeLayout(false);
            this.panelBtnManageMember.PerformLayout();
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBtnManageMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtdenda;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnyes;
    }
}

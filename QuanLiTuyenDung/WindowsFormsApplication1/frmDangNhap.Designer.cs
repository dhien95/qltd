namespace WindowsFormsApplication1
{
    partial class frmDangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTTDN = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoatDN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTTDN);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 244);
            this.panel1.TabIndex = 6;
            // 
            // lblTTDN
            // 
            this.lblTTDN.AutoSize = true;
            this.lblTTDN.Location = new System.Drawing.Point(176, 23);
            this.lblTTDN.Name = "lblTTDN";
            this.lblTTDN.Size = new System.Drawing.Size(118, 15);
            this.lblTTDN.TabIndex = 12;
            this.lblTTDN.Text = "Thông tin đăng nhập";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(179, 75);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(170, 22);
            this.txtUser.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(105, 75);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(68, 15);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "UserName:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(110, 122);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(63, 15);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(179, 122);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(170, 22);
            this.txtPass.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDangNhap);
            this.panel2.Controls.Add(this.btnThoatDN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 82);
            this.panel2.TabIndex = 7;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(90, 27);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(102, 29);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoatDN
            // 
            this.btnThoatDN.Location = new System.Drawing.Point(264, 27);
            this.btnThoatDN.Name = "btnThoatDN";
            this.btnThoatDN.Size = new System.Drawing.Size(102, 29);
            this.btnThoatDN.TabIndex = 3;
            this.btnThoatDN.Text = "Thoát";
            this.btnThoatDN.UseVisualStyleBackColor = true;
            this.btnThoatDN.Click += new System.EventHandler(this.btnThoatDN_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 244);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTTDN;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoatDN;
    }
}


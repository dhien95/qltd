namespace WindowsFormsApplication1
{
    partial class frmQLNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNV));
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.pnlTaiKhoan = new System.Windows.Forms.Panel();
            this.lblLoiNhac = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tblTTTK = new System.Windows.Forms.Label();
            this.pnlDSNV = new System.Windows.Forms.Panel();
            this.lblDSNV = new System.Windows.Forms.Label();
            this.lvwDSNV = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlTieuDe.SuspendLayout();
            this.pnlTaiKhoan.SuspendLayout();
            this.pnlDSNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.MediumOrchid;
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Controls.Add(this.flowLayoutPanel1);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(808, 66);
            this.pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(348, 21);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(121, 24);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "TÀI KHOẢN";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(440, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnXuLy
            // 
            this.btnXuLy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuLy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXuLy.Enabled = false;
            this.btnXuLy.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnXuLy.FlatAppearance.BorderSize = 5;
            this.btnXuLy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXuLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLy.Location = new System.Drawing.Point(68, 212);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(143, 44);
            this.btnXuLy.TabIndex = 2;
            this.btnXuLy.Text = "Xử Lý TK";
            this.btnXuLy.UseVisualStyleBackColor = false;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            this.btnXuLy.Paint += new System.Windows.Forms.PaintEventHandler(this.btnXuLy_Paint);
            // 
            // pnlTaiKhoan
            // 
            this.pnlTaiKhoan.BackColor = System.Drawing.Color.White;
            this.pnlTaiKhoan.Controls.Add(this.lblLoiNhac);
            this.pnlTaiKhoan.Controls.Add(this.btnThoat);
            this.pnlTaiKhoan.Controls.Add(this.cboRole);
            this.pnlTaiKhoan.Controls.Add(this.btnXuLy);
            this.pnlTaiKhoan.Controls.Add(this.lblRole);
            this.pnlTaiKhoan.Controls.Add(this.txtPass);
            this.pnlTaiKhoan.Controls.Add(this.txtUser);
            this.pnlTaiKhoan.Controls.Add(this.lblPass);
            this.pnlTaiKhoan.Controls.Add(this.lblUser);
            this.pnlTaiKhoan.Controls.Add(this.tblTTTK);
            this.pnlTaiKhoan.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTaiKhoan.Location = new System.Drawing.Point(535, 66);
            this.pnlTaiKhoan.Name = "pnlTaiKhoan";
            this.pnlTaiKhoan.Size = new System.Drawing.Size(273, 337);
            this.pnlTaiKhoan.TabIndex = 2;
            // 
            // lblLoiNhac
            // 
            this.lblLoiNhac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoiNhac.AutoSize = true;
            this.lblLoiNhac.Location = new System.Drawing.Point(65, 137);
            this.lblLoiNhac.Name = "lblLoiNhac";
            this.lblLoiNhac.Size = new System.Drawing.Size(172, 13);
            this.lblLoiNhac.TabIndex = 13;
            this.lblLoiNhac.Text = "Lời nhắc: mật khẩu mặc định 1234";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnThoat.FlatAppearance.BorderSize = 5;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::WindowsFormsApplication1.Properties.Resources.exit1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(68, 271);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 44);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            this.btnThoat.Paint += new System.Windows.Forms.PaintEventHandler(this.btnThoat_Paint);
            // 
            // cboRole
            // 
            this.cboRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(68, 164);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(180, 21);
            this.cboRole.TabIndex = 12;
            this.cboRole.SelectionChangeCommitted += new System.EventHandler(this.cboRole_SelectionChangeCommitted);
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(32, 167);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "Role";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Location = new System.Drawing.Point(68, 111);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(180, 20);
            this.txtPass.TabIndex = 10;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Location = new System.Drawing.Point(68, 66);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(180, 20);
            this.txtUser.TabIndex = 9;
            // 
            // lblPass
            // 
            this.lblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(8, 114);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(3, 69);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 13);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User name";
            // 
            // tblTTTK
            // 
            this.tblTTTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblTTTK.AutoSize = true;
            this.tblTTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTTTK.Location = new System.Drawing.Point(52, 21);
            this.tblTTTK.Name = "tblTTTK";
            this.tblTTTK.Size = new System.Drawing.Size(169, 20);
            this.tblTTTK.TabIndex = 4;
            this.tblTTTK.Text = "Thông tin Tài Khoản";
            // 
            // pnlDSNV
            // 
            this.pnlDSNV.BackColor = System.Drawing.Color.DarkGray;
            this.pnlDSNV.Controls.Add(this.lblDSNV);
            this.pnlDSNV.Controls.Add(this.lvwDSNV);
            this.pnlDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDSNV.Location = new System.Drawing.Point(0, 66);
            this.pnlDSNV.Name = "pnlDSNV";
            this.pnlDSNV.Size = new System.Drawing.Size(535, 337);
            this.pnlDSNV.TabIndex = 3;
            // 
            // lblDSNV
            // 
            this.lblDSNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDSNV.AutoSize = true;
            this.lblDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSNV.Location = new System.Drawing.Point(142, 15);
            this.lblDSNV.Name = "lblDSNV";
            this.lblDSNV.Size = new System.Drawing.Size(210, 24);
            this.lblDSNV.TabIndex = 6;
            this.lblDSNV.Text = "Danh sách Nhân viên\r\n";
            // 
            // lvwDSNV
            // 
            this.lvwDSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDSNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lvwDSNV.FullRowSelect = true;
            this.lvwDSNV.Location = new System.Drawing.Point(52, 56);
            this.lvwDSNV.Name = "lvwDSNV";
            this.lvwDSNV.Size = new System.Drawing.Size(429, 225);
            this.lvwDSNV.TabIndex = 0;
            this.lvwDSNV.UseCompatibleStateImageBehavior = false;
            this.lvwDSNV.SelectedIndexChanged += new System.EventHandler(this.lvwDSNV_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(808, 403);
            this.Controls.Add(this.pnlDSNV);
            this.Controls.Add(this.pnlTaiKhoan);
            this.Controls.Add(this.pnlTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmQLNV_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.pnlTaiKhoan.ResumeLayout(false);
            this.pnlTaiKhoan.PerformLayout();
            this.pnlDSNV.ResumeLayout(false);
            this.pnlDSNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlTaiKhoan;
        private System.Windows.Forms.Label tblTTTK;
        private System.Windows.Forms.Panel pnlDSNV;
        private System.Windows.Forms.ListView lvwDSNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Label lblDSNV;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblLoiNhac;
    }
}
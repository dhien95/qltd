namespace WindowsFormsApplication1
{
    partial class frmQLViTriTuyenDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLViTriTuyenDung));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTenVT = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.cboTenViTri = new System.Windows.Forms.ComboBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.rtxtQuyenLoi = new System.Windows.Forms.RichTextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblQuyenLoi = new System.Windows.Forms.Label();
            this.lblYeuCau = new System.Windows.Forms.Label();
            this.rtxtYeuCau = new System.Windows.Forms.RichTextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(178, 30);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(259, 24);
            this.lblTieuDe.TabIndex = 19;
            this.lblTieuDe.Text = "Quản lý Vị Trí Tuyển Dụng";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnThoat.FlatAppearance.BorderSize = 5;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::WindowsFormsApplication1.Properties.Resources.exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(430, 16);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 43);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.Paint += new System.Windows.Forms.PaintEventHandler(this.btnThoat_Paint);
            // 
            // btnXuLy
            // 
            this.btnXuLy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXuLy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXuLy.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnXuLy.FlatAppearance.BorderSize = 5;
            this.btnXuLy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXuLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLy.Image = global::WindowsFormsApplication1.Properties.Resources.themVT_button;
            this.btnXuLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLy.Location = new System.Drawing.Point(90, 17);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(133, 43);
            this.btnXuLy.TabIndex = 20;
            this.btnXuLy.Text = "Xử lý";
            this.btnXuLy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuLy.UseVisualStyleBackColor = false;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            this.btnXuLy.Paint += new System.Windows.Forms.PaintEventHandler(this.btnXuLy_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 84);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnXuLy);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 634);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 72);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.lblTenVT);
            this.panel3.Controls.Add(this.lblSoLuong);
            this.panel3.Controls.Add(this.lblDiaDiem);
            this.panel3.Controls.Add(this.cboTenViTri);
            this.panel3.Controls.Add(this.lblLuong);
            this.panel3.Controls.Add(this.rtxtQuyenLoi);
            this.panel3.Controls.Add(this.lblMoTa);
            this.panel3.Controls.Add(this.lblQuyenLoi);
            this.panel3.Controls.Add(this.lblYeuCau);
            this.panel3.Controls.Add(this.rtxtYeuCau);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.rtxtMoTa);
            this.panel3.Controls.Add(this.txtDiaDiem);
            this.panel3.Controls.Add(this.txtLuong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 550);
            this.panel3.TabIndex = 25;
            // 
            // lblTenVT
            // 
            this.lblTenVT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenVT.AutoSize = true;
            this.lblTenVT.Location = new System.Drawing.Point(129, 16);
            this.lblTenVT.Name = "lblTenVT";
            this.lblTenVT.Size = new System.Drawing.Size(54, 13);
            this.lblTenVT.TabIndex = 0;
            this.lblTenVT.Text = "Tên Vị trí:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(129, 58);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(56, 13);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(129, 98);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(94, 13);
            this.lblDiaDiem.TabIndex = 2;
            this.lblDiaDiem.Text = "Địa điểm làm việc:";
            // 
            // cboTenViTri
            // 
            this.cboTenViTri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTenViTri.FormattingEnabled = true;
            this.cboTenViTri.Location = new System.Drawing.Point(239, 8);
            this.cboTenViTri.Name = "cboTenViTri";
            this.cboTenViTri.Size = new System.Drawing.Size(276, 21);
            this.cboTenViTri.TabIndex = 22;
            this.cboTenViTri.SelectionChangeCommitted += new System.EventHandler(this.cboTenViTri_SelectionChangeCommitted);
            // 
            // lblLuong
            // 
            this.lblLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(129, 142);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(40, 13);
            this.lblLuong.TabIndex = 3;
            this.lblLuong.Text = "Lương:";
            // 
            // rtxtQuyenLoi
            // 
            this.rtxtQuyenLoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxtQuyenLoi.Location = new System.Drawing.Point(92, 425);
            this.rtxtQuyenLoi.Name = "rtxtQuyenLoi";
            this.rtxtQuyenLoi.Size = new System.Drawing.Size(488, 111);
            this.rtxtQuyenLoi.TabIndex = 18;
            this.rtxtQuyenLoi.Text = "";
            // 
            // lblMoTa
            // 
            this.lblMoTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(52, 239);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(37, 13);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // lblQuyenLoi
            // 
            this.lblQuyenLoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuyenLoi.AutoSize = true;
            this.lblQuyenLoi.Location = new System.Drawing.Point(35, 475);
            this.lblQuyenLoi.Name = "lblQuyenLoi";
            this.lblQuyenLoi.Size = new System.Drawing.Size(54, 13);
            this.lblQuyenLoi.TabIndex = 17;
            this.lblQuyenLoi.Text = "Quyền lợi:";
            // 
            // lblYeuCau
            // 
            this.lblYeuCau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYeuCau.AutoSize = true;
            this.lblYeuCau.Location = new System.Drawing.Point(40, 356);
            this.lblYeuCau.Name = "lblYeuCau";
            this.lblYeuCau.Size = new System.Drawing.Size(50, 13);
            this.lblYeuCau.TabIndex = 6;
            this.lblYeuCau.Text = "Yêu cầu:";
            // 
            // rtxtYeuCau
            // 
            this.rtxtYeuCau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxtYeuCau.Location = new System.Drawing.Point(92, 308);
            this.rtxtYeuCau.Name = "rtxtYeuCau";
            this.rtxtYeuCau.Size = new System.Drawing.Size(488, 111);
            this.rtxtYeuCau.TabIndex = 15;
            this.rtxtYeuCau.Text = "";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.Location = new System.Drawing.Point(241, 51);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(274, 20);
            this.txtSoLuong.TabIndex = 9;
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxtMoTa.Location = new System.Drawing.Point(92, 191);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(488, 111);
            this.rtxtMoTa.TabIndex = 14;
            this.rtxtMoTa.Text = "";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaDiem.Location = new System.Drawing.Point(241, 93);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(274, 20);
            this.txtDiaDiem.TabIndex = 10;
            // 
            // txtLuong
            // 
            this.txtLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLuong.Location = new System.Drawing.Point(241, 135);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(274, 20);
            this.txtLuong.TabIndex = 12;
            // 
            // frmQLViTriTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(615, 706);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLViTriTuyenDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Vị Trí Tuyển Dụng";
            this.Load += new System.EventHandler(this.frmQLViTriTuyenDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTenVT;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.ComboBox cboTenViTri;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.RichTextBox rtxtQuyenLoi;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblQuyenLoi;
        private System.Windows.Forms.Label lblYeuCau;
        private System.Windows.Forms.RichTextBox rtxtYeuCau;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtLuong;
    }
}
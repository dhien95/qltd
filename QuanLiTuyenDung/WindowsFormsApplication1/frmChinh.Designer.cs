namespace WindowsFormsApplication1
{
    partial class frmChinh
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlDSUV = new System.Windows.Forms.Panel();
            this.lblTongUV = new System.Windows.Forms.Label();
            this.txtTongUV = new System.Windows.Forms.TextBox();
            this.lblDSUV = new System.Windows.Forms.Label();
            this.lvwDSUV = new System.Windows.Forms.ListView();
            this.pnlXuLy = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDeXuatUV = new System.Windows.Forms.Button();
            this.btnChuyenDanhSach = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboKinhNghiem = new System.Windows.Forms.ComboBox();
            this.lblKinhNghiem = new System.Windows.Forms.Label();
            this.btnXemYeuCau = new System.Windows.Forms.Button();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.BtnLocUV = new System.Windows.Forms.Button();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.lblViTri = new System.Windows.Forms.Label();
            this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.cboTrinhDo = new System.Windows.Forms.ComboBox();
            this.cboVTTD = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlDSUV.SuspendLayout();
            this.pnlXuLy.SuspendLayout();
            this.pnlLoc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMenu.Controls.Add(this.pnlDSUV);
            this.pnlMenu.Controls.Add(this.pnlXuLy);
            this.pnlMenu.Controls.Add(this.pnlLoc);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(849, 495);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlDSUV
            // 
            this.pnlDSUV.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDSUV.Controls.Add(this.lblTongUV);
            this.pnlDSUV.Controls.Add(this.txtTongUV);
            this.pnlDSUV.Controls.Add(this.lblDSUV);
            this.pnlDSUV.Controls.Add(this.lvwDSUV);
            this.pnlDSUV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDSUV.Location = new System.Drawing.Point(0, 104);
            this.pnlDSUV.Name = "pnlDSUV";
            this.pnlDSUV.Size = new System.Drawing.Size(849, 292);
            this.pnlDSUV.TabIndex = 4;
            // 
            // lblTongUV
            // 
            this.lblTongUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongUV.AutoSize = true;
            this.lblTongUV.Location = new System.Drawing.Point(699, 266);
            this.lblTongUV.Name = "lblTongUV";
            this.lblTongUV.Size = new System.Drawing.Size(81, 13);
            this.lblTongUV.TabIndex = 21;
            this.lblTongUV.Text = "Tổng Ứng viên:";
            // 
            // txtTongUV
            // 
            this.txtTongUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongUV.Location = new System.Drawing.Point(786, 258);
            this.txtTongUV.Name = "txtTongUV";
            this.txtTongUV.Size = new System.Drawing.Size(45, 20);
            this.txtTongUV.TabIndex = 20;
            // 
            // lblDSUV
            // 
            this.lblDSUV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDSUV.AutoSize = true;
            this.lblDSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSUV.Location = new System.Drawing.Point(341, 16);
            this.lblDSUV.Name = "lblDSUV";
            this.lblDSUV.Size = new System.Drawing.Size(170, 20);
            this.lblDSUV.TabIndex = 1;
            this.lblDSUV.Text = "Danh sách Ứng viên";
            // 
            // lvwDSUV
            // 
            this.lvwDSUV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDSUV.CheckBoxes = true;
            this.lvwDSUV.FullRowSelect = true;
            this.lvwDSUV.GridLines = true;
            this.lvwDSUV.Location = new System.Drawing.Point(23, 49);
            this.lvwDSUV.Name = "lvwDSUV";
            this.lvwDSUV.Size = new System.Drawing.Size(808, 203);
            this.lvwDSUV.TabIndex = 0;
            this.lvwDSUV.UseCompatibleStateImageBehavior = false;
            this.lvwDSUV.View = System.Windows.Forms.View.Details;
            // 
            // pnlXuLy
            // 
            this.pnlXuLy.BackColor = System.Drawing.SystemColors.Control;
            this.pnlXuLy.Controls.Add(this.btnLuu);
            this.pnlXuLy.Controls.Add(this.btnDeXuatUV);
            this.pnlXuLy.Controls.Add(this.btnChuyenDanhSach);
            this.pnlXuLy.Controls.Add(this.btnXoa);
            this.pnlXuLy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlXuLy.Location = new System.Drawing.Point(0, 396);
            this.pnlXuLy.Name = "pnlXuLy";
            this.pnlXuLy.Size = new System.Drawing.Size(849, 99);
            this.pnlXuLy.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(427, 31);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 56);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDeXuatUV
            // 
            this.btnDeXuatUV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeXuatUV.AutoSize = true;
            this.btnDeXuatUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeXuatUV.Location = new System.Drawing.Point(61, 31);
            this.btnDeXuatUV.Name = "btnDeXuatUV";
            this.btnDeXuatUV.Size = new System.Drawing.Size(119, 57);
            this.btnDeXuatUV.TabIndex = 15;
            this.btnDeXuatUV.Text = "Đề Xuất Ứng Viên";
            this.btnDeXuatUV.UseVisualStyleBackColor = true;
            this.btnDeXuatUV.Click += new System.EventHandler(this.btnDeXuatUV_Click);
            // 
            // btnChuyenDanhSach
            // 
            this.btnChuyenDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyenDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenDanhSach.Location = new System.Drawing.Point(659, 31);
            this.btnChuyenDanhSach.Name = "btnChuyenDanhSach";
            this.btnChuyenDanhSach.Size = new System.Drawing.Size(145, 56);
            this.btnChuyenDanhSach.TabIndex = 18;
            this.btnChuyenDanhSach.Text = "Xem Danh Sách Đề Cử";
            this.btnChuyenDanhSach.UseVisualStyleBackColor = true;
            this.btnChuyenDanhSach.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(536, 31);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 57);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pnlLoc
            // 
            this.pnlLoc.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLoc.Controls.Add(this.groupBox1);
            this.pnlLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoc.Location = new System.Drawing.Point(0, 0);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Size = new System.Drawing.Size(849, 104);
            this.pnlLoc.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cboKinhNghiem);
            this.groupBox1.Controls.Add(this.lblKinhNghiem);
            this.groupBox1.Controls.Add(this.btnXemYeuCau);
            this.groupBox1.Controls.Add(this.lblTrinhDo);
            this.groupBox1.Controls.Add(this.BtnLocUV);
            this.groupBox1.Controls.Add(this.lblNgoaiNgu);
            this.groupBox1.Controls.Add(this.lblViTri);
            this.groupBox1.Controls.Add(this.cboNgoaiNgu);
            this.groupBox1.Controls.Add(this.cboTrinhDo);
            this.groupBox1.Controls.Add(this.cboVTTD);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 86);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc";
            // 
            // cboKinhNghiem
            // 
            this.cboKinhNghiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboKinhNghiem.FormattingEnabled = true;
            this.cboKinhNghiem.Location = new System.Drawing.Point(513, 21);
            this.cboKinhNghiem.Name = "cboKinhNghiem";
            this.cboKinhNghiem.Size = new System.Drawing.Size(124, 21);
            this.cboKinhNghiem.TabIndex = 14;
            this.cboKinhNghiem.SelectedIndexChanged += new System.EventHandler(this.cboKinhNghiem_SelectedIndexChanged);
            // 
            // lblKinhNghiem
            // 
            this.lblKinhNghiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKinhNghiem.AutoSize = true;
            this.lblKinhNghiem.Location = new System.Drawing.Point(510, 5);
            this.lblKinhNghiem.Name = "lblKinhNghiem";
            this.lblKinhNghiem.Size = new System.Drawing.Size(68, 13);
            this.lblKinhNghiem.TabIndex = 13;
            this.lblKinhNghiem.Text = "Kinh nghiệm:";
            // 
            // btnXemYeuCau
            // 
            this.btnXemYeuCau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXemYeuCau.Enabled = false;
            this.btnXemYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemYeuCau.Location = new System.Drawing.Point(48, 48);
            this.btnXemYeuCau.Name = "btnXemYeuCau";
            this.btnXemYeuCau.Size = new System.Drawing.Size(144, 32);
            this.btnXemYeuCau.TabIndex = 12;
            this.btnXemYeuCau.Text = "Xem Yêu cầu";
            this.btnXemYeuCau.UseVisualStyleBackColor = true;
            this.btnXemYeuCau.Click += new System.EventHandler(this.btnXemYeuCau_Click);
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(225, 5);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(51, 13);
            this.lblTrinhDo.TabIndex = 11;
            this.lblTrinhDo.Text = "Trình Độ:";
            // 
            // BtnLocUV
            // 
            this.BtnLocUV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLocUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLocUV.Location = new System.Drawing.Point(664, 21);
            this.BtnLocUV.Name = "BtnLocUV";
            this.BtnLocUV.Size = new System.Drawing.Size(74, 23);
            this.BtnLocUV.TabIndex = 10;
            this.BtnLocUV.Text = "Lọc";
            this.BtnLocUV.UseVisualStyleBackColor = true;
            this.BtnLocUV.Click += new System.EventHandler(this.BtnLocUV_Click);
            // 
            // lblNgoaiNgu
            // 
            this.lblNgoaiNgu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgoaiNgu.AutoSize = true;
            this.lblNgoaiNgu.Location = new System.Drawing.Point(371, 5);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new System.Drawing.Size(59, 13);
            this.lblNgoaiNgu.TabIndex = 9;
            this.lblNgoaiNgu.Text = "Ngoại ngữ:";
            // 
            // lblViTri
            // 
            this.lblViTri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(45, 5);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(36, 13);
            this.lblViTri.TabIndex = 3;
            this.lblViTri.Text = "Vị Trí:";
            // 
            // cboNgoaiNgu
            // 
            this.cboNgoaiNgu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboNgoaiNgu.FormattingEnabled = true;
            this.cboNgoaiNgu.Location = new System.Drawing.Point(363, 21);
            this.cboNgoaiNgu.Name = "cboNgoaiNgu";
            this.cboNgoaiNgu.Size = new System.Drawing.Size(134, 21);
            this.cboNgoaiNgu.TabIndex = 2;
            // 
            // cboTrinhDo
            // 
            this.cboTrinhDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTrinhDo.FormattingEnabled = true;
            this.cboTrinhDo.Location = new System.Drawing.Point(219, 21);
            this.cboTrinhDo.Name = "cboTrinhDo";
            this.cboTrinhDo.Size = new System.Drawing.Size(124, 21);
            this.cboTrinhDo.TabIndex = 1;
            this.cboTrinhDo.SelectionChangeCommitted += new System.EventHandler(this.cboTrinhDo_SelectionChangeCommitted);
            // 
            // cboVTTD
            // 
            this.cboVTTD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboVTTD.FormattingEnabled = true;
            this.cboVTTD.Location = new System.Drawing.Point(48, 21);
            this.cboVTTD.Name = "cboVTTD";
            this.cboVTTD.Size = new System.Drawing.Size(144, 21);
            this.cboVTTD.TabIndex = 0;
            this.cboVTTD.SelectedIndexChanged += new System.EventHandler(this.cmbVTTD_SelectedIndexChanged);
            this.cboVTTD.SelectionChangeCommitted += new System.EventHandler(this.cmbVTTD_SelectionChangeCommitted);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(868, 440);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 41);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Location = new System.Drawing.Point(855, 41);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(102, 35);
            this.btnDoiMK.TabIndex = 18;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(969, 495);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pnlMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmChinh";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlDSUV.ResumeLayout(false);
            this.pnlDSUV.PerformLayout();
            this.pnlXuLy.ResumeLayout(false);
            this.pnlXuLy.PerformLayout();
            this.pnlLoc.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.Button BtnLocUV;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.ComboBox cboNgoaiNgu;
        private System.Windows.Forms.ComboBox cboTrinhDo;
        private System.Windows.Forms.ComboBox cboVTTD;
        private System.Windows.Forms.Panel pnlXuLy;
        private System.Windows.Forms.Button btnDeXuatUV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChuyenDanhSach;
        private System.Windows.Forms.ComboBox cboKinhNghiem;
        private System.Windows.Forms.Label lblKinhNghiem;
        private System.Windows.Forms.Button btnXemYeuCau;
        private System.Windows.Forms.Panel pnlDSUV;
        private System.Windows.Forms.Label lblDSUV;
        private System.Windows.Forms.ListView lvwDSUV;
        private System.Windows.Forms.Label lblTongUV;
        private System.Windows.Forms.TextBox txtTongUV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDoiMK;
    }
}
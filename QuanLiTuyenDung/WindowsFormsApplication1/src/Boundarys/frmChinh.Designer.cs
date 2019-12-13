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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.lvwDSUV = new System.Windows.Forms.ListView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnuNhanUV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyUV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemUVDeCu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapNhatKetQuaPV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemUVTrungTuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_VTTD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemVTTD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPheDuyetUV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyLichPV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaoTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.grbLoc = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblDoiMatKhau = new System.Windows.Forms.Label();
            this.cboKinhNghiem = new System.Windows.Forms.ComboBox();
            this.btnXemYeuCau = new System.Windows.Forms.Button();
            this.BtnLocUV = new System.Windows.Forms.Button();
            this.lblKinhNghiem = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.lblViTri = new System.Windows.Forms.Label();
            this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.cboTrinhDo = new System.Windows.Forms.ComboBox();
            this.cboVTTD = new System.Windows.Forms.ComboBox();
            this.lblDSUV = new System.Windows.Forms.Label();
            this.pnlDSUV = new System.Windows.Forms.Panel();
            this.lblTongUV = new System.Windows.Forms.Label();
            this.txtTongUV = new System.Windows.Forms.TextBox();
            this.pnlXuLy = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDeXuatUV = new System.Windows.Forms.Button();
            this.btnChuyenDS = new System.Windows.Forms.Button();
            this.btnHuyDC = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblQuyen = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.grbLoc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDSUV.SuspendLayout();
            this.pnlXuLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwDSUV
            // 
            this.lvwDSUV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDSUV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lvwDSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDSUV.FullRowSelect = true;
            this.lvwDSUV.GridLines = true;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            this.lvwDSUV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvwDSUV.Location = new System.Drawing.Point(85, 63);
            this.lvwDSUV.Name = "lvwDSUV";
            this.lvwDSUV.Size = new System.Drawing.Size(930, 226);
            this.lvwDSUV.TabIndex = 22;
            this.lvwDSUV.UseCompatibleStateImageBehavior = false;
            this.lvwDSUV.View = System.Windows.Forms.View.Details;
            this.lvwDSUV.DoubleClick += new System.EventHandler(this.lvwDSUV_DoubleClick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.MediumOrchid;
            this.menu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanUV,
            this.mnuQuanLyUV,
            this.mnuQL_VTTD,
            this.mnuPheDuyetUV,
            this.mnuQuanLyLichPV,
            this.mnuQLNhanVien});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1100, 24);
            this.menu.TabIndex = 19;
            this.menu.Text = "menuStrip1";
            // 
            // mnuNhanUV
            // 
            this.mnuNhanUV.Checked = true;
            this.mnuNhanUV.CheckOnClick = true;
            this.mnuNhanUV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuNhanUV.ForeColor = System.Drawing.Color.White;
            this.mnuNhanUV.Image = global::WindowsFormsApplication1.Properties.Resources.mailbox_message_received_2_icon;
            this.mnuNhanUV.Name = "mnuNhanUV";
            this.mnuNhanUV.Size = new System.Drawing.Size(206, 20);
            this.mnuNhanUV.Text = "Nhận Danh Sách Ứng Viên";
            this.mnuNhanUV.Click += new System.EventHandler(this.mnuNhanUV_Click);
            // 
            // mnuQuanLyUV
            // 
            this.mnuQuanLyUV.Checked = true;
            this.mnuQuanLyUV.CheckOnClick = true;
            this.mnuQuanLyUV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuQuanLyUV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXemUVDeCu,
            this.mnuCapNhatKetQuaPV,
            this.mnuXemUVTrungTuyen});
            this.mnuQuanLyUV.ForeColor = System.Drawing.Color.White;
            this.mnuQuanLyUV.Image = global::WindowsFormsApplication1.Properties.Resources._042_list_view_512;
            this.mnuQuanLyUV.Name = "mnuQuanLyUV";
            this.mnuQuanLyUV.Size = new System.Drawing.Size(153, 20);
            this.mnuQuanLyUV.Text = "Quản Lý Ứng Viên";
            // 
            // mnuXemUVDeCu
            // 
            this.mnuXemUVDeCu.Image = global::WindowsFormsApplication1.Properties.Resources.DeCu1;
            this.mnuXemUVDeCu.Name = "mnuXemUVDeCu";
            this.mnuXemUVDeCu.Size = new System.Drawing.Size(263, 22);
            this.mnuXemUVDeCu.Text = "Xem Ứng Viên Đề Cử";
            this.mnuXemUVDeCu.Click += new System.EventHandler(this.mnuXemUVDeCu_Click);
            // 
            // mnuCapNhatKetQuaPV
            // 
            this.mnuCapNhatKetQuaPV.Image = global::WindowsFormsApplication1.Properties.Resources.Update;
            this.mnuCapNhatKetQuaPV.Name = "mnuCapNhatKetQuaPV";
            this.mnuCapNhatKetQuaPV.Size = new System.Drawing.Size(263, 22);
            this.mnuCapNhatKetQuaPV.Text = "Cập Nhật Kết Quả Phỏng Vấn";
            this.mnuCapNhatKetQuaPV.Click += new System.EventHandler(this.mnuCapNhatKetQuaPV_Click);
            // 
            // mnuXemUVTrungTuyen
            // 
            this.mnuXemUVTrungTuyen.Image = global::WindowsFormsApplication1.Properties.Resources.PheDuyet1;
            this.mnuXemUVTrungTuyen.Name = "mnuXemUVTrungTuyen";
            this.mnuXemUVTrungTuyen.Size = new System.Drawing.Size(263, 22);
            this.mnuXemUVTrungTuyen.Text = "Xem Ứng Viên Trúng Tuyển";
            this.mnuXemUVTrungTuyen.Click += new System.EventHandler(this.mnuXemUVTrungTuyen_Click);
            // 
            // mnuQL_VTTD
            // 
            this.mnuQL_VTTD.Checked = true;
            this.mnuQL_VTTD.CheckOnClick = true;
            this.mnuQL_VTTD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuQL_VTTD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXemVTTD,
            this.mnuThemVT});
            this.mnuQL_VTTD.ForeColor = System.Drawing.Color.White;
            this.mnuQL_VTTD.Image = global::WindowsFormsApplication1.Properties.Resources.job;
            this.mnuQL_VTTD.Name = "mnuQL_VTTD";
            this.mnuQL_VTTD.Size = new System.Drawing.Size(205, 20);
            this.mnuQL_VTTD.Text = "Quản Lý Vị Trí Tuyển Dụng";
            // 
            // mnuXemVTTD
            // 
            this.mnuXemVTTD.Image = global::WindowsFormsApplication1.Properties.Resources._042_list_view_5121;
            this.mnuXemVTTD.Name = "mnuXemVTTD";
            this.mnuXemVTTD.Size = new System.Drawing.Size(221, 22);
            this.mnuXemVTTD.Text = "Xem Vị Trí Tuyển Dụng";
            this.mnuXemVTTD.Click += new System.EventHandler(this.mnuXemVTTD_Click);
            // 
            // mnuThemVT
            // 
            this.mnuThemVT.Image = global::WindowsFormsApplication1.Properties.Resources.ThemVT;
            this.mnuThemVT.Name = "mnuThemVT";
            this.mnuThemVT.Size = new System.Drawing.Size(221, 22);
            this.mnuThemVT.Text = "Thêm Vị Trí";
            this.mnuThemVT.Click += new System.EventHandler(this.mnuThemVT_Click);
            // 
            // mnuPheDuyetUV
            // 
            this.mnuPheDuyetUV.ForeColor = System.Drawing.Color.White;
            this.mnuPheDuyetUV.Image = global::WindowsFormsApplication1.Properties.Resources.PheDuyet;
            this.mnuPheDuyetUV.Name = "mnuPheDuyetUV";
            this.mnuPheDuyetUV.Size = new System.Drawing.Size(165, 20);
            this.mnuPheDuyetUV.Text = "Phê Duyệt Ứng Viên";
            this.mnuPheDuyetUV.Click += new System.EventHandler(this.mnuPheDuyetUV_Click);
            // 
            // mnuQuanLyLichPV
            // 
            this.mnuQuanLyLichPV.ForeColor = System.Drawing.Color.White;
            this.mnuQuanLyLichPV.Image = global::WindowsFormsApplication1.Properties.Resources.Manage_Celandar;
            this.mnuQuanLyLichPV.Name = "mnuQuanLyLichPV";
            this.mnuQuanLyLichPV.Size = new System.Drawing.Size(194, 20);
            this.mnuQuanLyLichPV.Text = "Quản Lý Lịch Phỏng Vấn";
            this.mnuQuanLyLichPV.Click += new System.EventHandler(this.mnuQuanLyLichPV_Click);
            // 
            // mnuQLNhanVien
            // 
            this.mnuQLNhanVien.BackColor = System.Drawing.Color.MediumOrchid;
            this.mnuQLNhanVien.Checked = true;
            this.mnuQLNhanVien.CheckOnClick = true;
            this.mnuQLNhanVien.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuQLNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaoTaiKhoan,
            this.mnuHuyTaiKhoan});
            this.mnuQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.mnuQLNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLNhanVien.Image")));
            this.mnuQLNhanVien.Name = "mnuQLNhanVien";
            this.mnuQLNhanVien.Size = new System.Drawing.Size(159, 20);
            this.mnuQLNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // mnuTaoTaiKhoan
            // 
            this.mnuTaoTaiKhoan.Image = global::WindowsFormsApplication1.Properties.Resources.ThemTK;
            this.mnuTaoTaiKhoan.Name = "mnuTaoTaiKhoan";
            this.mnuTaoTaiKhoan.Size = new System.Drawing.Size(169, 22);
            this.mnuTaoTaiKhoan.Text = "Tạo Tài Khoản";
            this.mnuTaoTaiKhoan.Click += new System.EventHandler(this.mnuTaoTaiKhoan_Click);
            // 
            // mnuHuyTaiKhoan
            // 
            this.mnuHuyTaiKhoan.Image = global::WindowsFormsApplication1.Properties.Resources.XoaTK1;
            this.mnuHuyTaiKhoan.Name = "mnuHuyTaiKhoan";
            this.mnuHuyTaiKhoan.Size = new System.Drawing.Size(169, 22);
            this.mnuHuyTaiKhoan.Text = "Hủy Tài Khoản";
            this.mnuHuyTaiKhoan.Click += new System.EventHandler(this.mnuHuyTaiKhoan_Click);
            // 
            // grbLoc
            // 
            this.grbLoc.BackColor = System.Drawing.Color.Gray;
            this.grbLoc.Controls.Add(this.panel1);
            this.grbLoc.Controls.Add(this.cboKinhNghiem);
            this.grbLoc.Controls.Add(this.btnXemYeuCau);
            this.grbLoc.Controls.Add(this.BtnLocUV);
            this.grbLoc.Controls.Add(this.lblKinhNghiem);
            this.grbLoc.Controls.Add(this.lblTrinhDo);
            this.grbLoc.Controls.Add(this.lblNgoaiNgu);
            this.grbLoc.Controls.Add(this.lblViTri);
            this.grbLoc.Controls.Add(this.cboNgoaiNgu);
            this.grbLoc.Controls.Add(this.cboTrinhDo);
            this.grbLoc.Controls.Add(this.cboVTTD);
            this.grbLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLoc.Location = new System.Drawing.Point(0, 24);
            this.grbLoc.Name = "grbLoc";
            this.grbLoc.Size = new System.Drawing.Size(1100, 109);
            this.grbLoc.TabIndex = 23;
            this.grbLoc.TabStop = false;
            this.grbLoc.Text = "Lọc";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblQuyen);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.lblTenNV);
            this.panel1.Controls.Add(this.lblDoiMatKhau);
            this.panel1.Location = new System.Drawing.Point(907, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 109);
            this.panel1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.user_name;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDangXuat.FlatAppearance.BorderSize = 3;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Image = global::WindowsFormsApplication1.Properties.Resources.exit;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(44, 76);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(114, 26);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            this.btnDangXuat.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDangXuat_Paint);
            // 
            // lblTenNV
            // 
            this.lblTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(54, 18);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(70, 16);
            this.lblTenNV.TabIndex = 17;
            this.lblTenNV.Text = "Nhân Viên";
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDoiMatKhau
            // 
            this.lblDoiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoiMatKhau.AutoSize = true;
            this.lblDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMatKhau.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDoiMatKhau.Location = new System.Drawing.Point(66, 50);
            this.lblDoiMatKhau.Name = "lblDoiMatKhau";
            this.lblDoiMatKhau.Size = new System.Drawing.Size(70, 13);
            this.lblDoiMatKhau.TabIndex = 18;
            this.lblDoiMatKhau.Text = "Đổi mật khẩu";
            this.lblDoiMatKhau.Click += new System.EventHandler(this.lblDoiMatKhau_Click_1);
            this.lblDoiMatKhau.MouseLeave += new System.EventHandler(this.lblDoiMatKhau_MouseLeave);
            this.lblDoiMatKhau.MouseHover += new System.EventHandler(this.lblDoiMatKhau_MouseHover);
            // 
            // cboKinhNghiem
            // 
            this.cboKinhNghiem.FormattingEnabled = true;
            this.cboKinhNghiem.Location = new System.Drawing.Point(618, 39);
            this.cboKinhNghiem.Name = "cboKinhNghiem";
            this.cboKinhNghiem.Size = new System.Drawing.Size(148, 24);
            this.cboKinhNghiem.TabIndex = 14;
            // 
            // btnXemYeuCau
            // 
            this.btnXemYeuCau.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXemYeuCau.Enabled = false;
            this.btnXemYeuCau.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnXemYeuCau.FlatAppearance.BorderSize = 5;
            this.btnXemYeuCau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXemYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemYeuCau.ForeColor = System.Drawing.Color.Black;
            this.btnXemYeuCau.Image = global::WindowsFormsApplication1.Properties.Resources.XemYeuCau;
            this.btnXemYeuCau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemYeuCau.Location = new System.Drawing.Point(54, 67);
            this.btnXemYeuCau.Name = "btnXemYeuCau";
            this.btnXemYeuCau.Size = new System.Drawing.Size(144, 35);
            this.btnXemYeuCau.TabIndex = 12;
            this.btnXemYeuCau.Text = "Xem Yêu cầu";
            this.btnXemYeuCau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemYeuCau.UseVisualStyleBackColor = false;
            this.btnXemYeuCau.Click += new System.EventHandler(this.btnXemYeuCau_Click);
            this.btnXemYeuCau.Paint += new System.Windows.Forms.PaintEventHandler(this.btnXemYeuCau_Paint);
            // 
            // BtnLocUV
            // 
            this.BtnLocUV.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnLocUV.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnLocUV.FlatAppearance.BorderSize = 5;
            this.BtnLocUV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnLocUV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLocUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLocUV.ForeColor = System.Drawing.Color.Black;
            this.BtnLocUV.Image = global::WindowsFormsApplication1.Properties.Resources.loc;
            this.BtnLocUV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLocUV.Location = new System.Drawing.Point(790, 34);
            this.BtnLocUV.Name = "BtnLocUV";
            this.BtnLocUV.Size = new System.Drawing.Size(87, 33);
            this.BtnLocUV.TabIndex = 10;
            this.BtnLocUV.Text = "Lọc";
            this.BtnLocUV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLocUV.UseVisualStyleBackColor = false;
            this.BtnLocUV.Click += new System.EventHandler(this.BtnLocUV_Click);
            this.BtnLocUV.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnLocUV_Paint);
            // 
            // lblKinhNghiem
            // 
            this.lblKinhNghiem.AutoSize = true;
            this.lblKinhNghiem.Location = new System.Drawing.Point(615, 18);
            this.lblKinhNghiem.Name = "lblKinhNghiem";
            this.lblKinhNghiem.Size = new System.Drawing.Size(83, 16);
            this.lblKinhNghiem.TabIndex = 13;
            this.lblKinhNghiem.Text = "Kinh nghiệm:";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(271, 18);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(61, 16);
            this.lblTrinhDo.TabIndex = 11;
            this.lblTrinhDo.Text = "Trình Độ:";
            // 
            // lblNgoaiNgu
            // 
            this.lblNgoaiNgu.AutoSize = true;
            this.lblNgoaiNgu.Location = new System.Drawing.Point(443, 18);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new System.Drawing.Size(73, 16);
            this.lblNgoaiNgu.TabIndex = 9;
            this.lblNgoaiNgu.Text = "Ngoại ngữ:";
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(51, 18);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(42, 16);
            this.lblViTri.TabIndex = 3;
            this.lblViTri.Text = "Vị Trí:";
            // 
            // cboNgoaiNgu
            // 
            this.cboNgoaiNgu.FormattingEnabled = true;
            this.cboNgoaiNgu.Location = new System.Drawing.Point(446, 39);
            this.cboNgoaiNgu.Name = "cboNgoaiNgu";
            this.cboNgoaiNgu.Size = new System.Drawing.Size(148, 24);
            this.cboNgoaiNgu.TabIndex = 2;
            // 
            // cboTrinhDo
            // 
            this.cboTrinhDo.FormattingEnabled = true;
            this.cboTrinhDo.Location = new System.Drawing.Point(274, 39);
            this.cboTrinhDo.Name = "cboTrinhDo";
            this.cboTrinhDo.Size = new System.Drawing.Size(148, 24);
            this.cboTrinhDo.TabIndex = 1;
            // 
            // cboVTTD
            // 
            this.cboVTTD.FormattingEnabled = true;
            this.cboVTTD.Location = new System.Drawing.Point(54, 39);
            this.cboVTTD.Name = "cboVTTD";
            this.cboVTTD.Size = new System.Drawing.Size(196, 24);
            this.cboVTTD.TabIndex = 0;
            this.cboVTTD.SelectedIndexChanged += new System.EventHandler(this.cboVTTD_SelectedIndexChanged);
            this.cboVTTD.SelectionChangeCommitted += new System.EventHandler(this.cboVTTD_SelectionChangeCommitted);
            // 
            // lblDSUV
            // 
            this.lblDSUV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDSUV.AutoSize = true;
            this.lblDSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSUV.Location = new System.Drawing.Point(433, 21);
            this.lblDSUV.Name = "lblDSUV";
            this.lblDSUV.Size = new System.Drawing.Size(170, 20);
            this.lblDSUV.TabIndex = 1;
            this.lblDSUV.Text = "Danh sách Ứng viên";
            // 
            // pnlDSUV
            // 
            this.pnlDSUV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDSUV.BackColor = System.Drawing.Color.White;
            this.pnlDSUV.Controls.Add(this.lblTongUV);
            this.pnlDSUV.Controls.Add(this.lvwDSUV);
            this.pnlDSUV.Controls.Add(this.txtTongUV);
            this.pnlDSUV.Controls.Add(this.lblDSUV);
            this.pnlDSUV.Location = new System.Drawing.Point(0, 132);
            this.pnlDSUV.Name = "pnlDSUV";
            this.pnlDSUV.Size = new System.Drawing.Size(1100, 332);
            this.pnlDSUV.TabIndex = 24;
            // 
            // lblTongUV
            // 
            this.lblTongUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongUV.AutoSize = true;
            this.lblTongUV.Location = new System.Drawing.Point(883, 306);
            this.lblTongUV.Name = "lblTongUV";
            this.lblTongUV.Size = new System.Drawing.Size(81, 13);
            this.lblTongUV.TabIndex = 34;
            this.lblTongUV.Text = "Tổng Ứng viên:";
            // 
            // txtTongUV
            // 
            this.txtTongUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongUV.Location = new System.Drawing.Point(973, 303);
            this.txtTongUV.Name = "txtTongUV";
            this.txtTongUV.ReadOnly = true;
            this.txtTongUV.Size = new System.Drawing.Size(42, 20);
            this.txtTongUV.TabIndex = 33;
            // 
            // pnlXuLy
            // 
            this.pnlXuLy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlXuLy.BackColor = System.Drawing.SystemColors.Control;
            this.pnlXuLy.Controls.Add(this.btnLuu);
            this.pnlXuLy.Controls.Add(this.btnDeXuatUV);
            this.pnlXuLy.Controls.Add(this.btnChuyenDS);
            this.pnlXuLy.Controls.Add(this.btnHuyDC);
            this.pnlXuLy.Location = new System.Drawing.Point(0, 461);
            this.pnlXuLy.Name = "pnlXuLy";
            this.pnlXuLy.Size = new System.Drawing.Size(1100, 92);
            this.pnlXuLy.TabIndex = 26;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLuu.FlatAppearance.BorderSize = 5;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::WindowsFormsApplication1.Properties.Resources.nut_save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(530, 23);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 47);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnLuu.Paint += new System.Windows.Forms.PaintEventHandler(this.btnLuu_Paint);
            // 
            // btnDeXuatUV
            // 
            this.btnDeXuatUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeXuatUV.AutoSize = true;
            this.btnDeXuatUV.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeXuatUV.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDeXuatUV.FlatAppearance.BorderSize = 5;
            this.btnDeXuatUV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeXuatUV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeXuatUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeXuatUV.ForeColor = System.Drawing.Color.Black;
            this.btnDeXuatUV.Image = global::WindowsFormsApplication1.Properties.Resources.decu_button;
            this.btnDeXuatUV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeXuatUV.Location = new System.Drawing.Point(85, 23);
            this.btnDeXuatUV.Name = "btnDeXuatUV";
            this.btnDeXuatUV.Size = new System.Drawing.Size(152, 47);
            this.btnDeXuatUV.TabIndex = 15;
            this.btnDeXuatUV.Text = "Đề Xuất Ứng Viên";
            this.btnDeXuatUV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeXuatUV.UseVisualStyleBackColor = false;
            this.btnDeXuatUV.Click += new System.EventHandler(this.btnDeXuatUV_Click);
            this.btnDeXuatUV.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDeXuatUV_Paint);
            // 
            // btnChuyenDS
            // 
            this.btnChuyenDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyenDS.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChuyenDS.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnChuyenDS.FlatAppearance.BorderSize = 5;
            this.btnChuyenDS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnChuyenDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenDS.ForeColor = System.Drawing.Color.Black;
            this.btnChuyenDS.Image = global::WindowsFormsApplication1.Properties.Resources.Change1;
            this.btnChuyenDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenDS.Location = new System.Drawing.Point(852, 23);
            this.btnChuyenDS.Name = "btnChuyenDS";
            this.btnChuyenDS.Size = new System.Drawing.Size(163, 47);
            this.btnChuyenDS.TabIndex = 18;
            this.btnChuyenDS.Text = "Chuyển DS Đề cử";
            this.btnChuyenDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChuyenDS.UseVisualStyleBackColor = false;
            this.btnChuyenDS.Click += new System.EventHandler(this.btnChuyenDS_Click);
            this.btnChuyenDS.Paint += new System.Windows.Forms.PaintEventHandler(this.btnChuyenDS_Paint);
            // 
            // btnHuyDC
            // 
            this.btnHuyDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyDC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHuyDC.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnHuyDC.FlatAppearance.BorderSize = 5;
            this.btnHuyDC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHuyDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDC.ForeColor = System.Drawing.Color.Black;
            this.btnHuyDC.Image = global::WindowsFormsApplication1.Properties.Resources.huyDeCu_button;
            this.btnHuyDC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyDC.Location = new System.Drawing.Point(672, 23);
            this.btnHuyDC.Name = "btnHuyDC";
            this.btnHuyDC.Size = new System.Drawing.Size(110, 47);
            this.btnHuyDC.TabIndex = 16;
            this.btnHuyDC.Text = "Hủy Đề cử";
            this.btnHuyDC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyDC.UseVisualStyleBackColor = false;
            this.btnHuyDC.Click += new System.EventHandler(this.btnHuyDC_Click);
            this.btnHuyDC.Paint += new System.Windows.Forms.PaintEventHandler(this.btnHuyDC_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblQuyen.Location = new System.Drawing.Point(3, 34);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(45, 16);
            this.lblQuyen.TabIndex = 20;
            this.lblQuyen.Text = "quyền";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 547);
            this.Controls.Add(this.pnlXuLy);
            this.Controls.Add(this.pnlDSUV);
            this.Controls.Add(this.grbLoc);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.grbLoc.ResumeLayout(false);
            this.grbLoc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDSUV.ResumeLayout(false);
            this.pnlDSUV.PerformLayout();
            this.pnlXuLy.ResumeLayout(false);
            this.pnlXuLy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanUV;
        private System.Windows.Forms.ToolStripMenuItem mnuPheDuyetUV;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTaoTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuHuyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_VTTD;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyUV;
        private System.Windows.Forms.ToolStripMenuItem mnuXemUVDeCu;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhatKetQuaPV;
        private System.Windows.Forms.ToolStripMenuItem mnuThemVT;
        private System.Windows.Forms.GroupBox grbLoc;
        private System.Windows.Forms.ComboBox cboKinhNghiem;
        private System.Windows.Forms.Button btnXemYeuCau;
        private System.Windows.Forms.Button BtnLocUV;
        private System.Windows.Forms.Label lblKinhNghiem;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.ComboBox cboNgoaiNgu;
        private System.Windows.Forms.ComboBox cboTrinhDo;
        private System.Windows.Forms.ComboBox cboVTTD;
        private System.Windows.Forms.Label lblDSUV;
        private System.Windows.Forms.Panel pnlDSUV;
        private System.Windows.Forms.Label lblTongUV;
        private System.Windows.Forms.TextBox txtTongUV;
        private System.Windows.Forms.Panel pnlXuLy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDeXuatUV;
        private System.Windows.Forms.Button btnChuyenDS;
        private System.Windows.Forms.Button btnHuyDC;
        private System.Windows.Forms.ListView lvwDSUV;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem mnuXemUVTrungTuyen;
        private System.Windows.Forms.ToolStripMenuItem mnuXemVTTD;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyLichPV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblDoiMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuyen;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApplication1
{
    public partial class frmChinh : Form
    {
        src.Controlers.ctrlGUI ctrGUI = new src.Controlers.ctrlGUI();
        src.Controlers.ctrlDeXuat ctrQLTD = new src.Controlers.ctrlDeXuat();
        List<src.Entitys.clsUngVien> dsLoc = new List<src.Entitys.clsUngVien>();
        List<src.Entitys.clsUngVien> dsDeCu = new List<src.Entitys.clsUngVien>();
        //public src.Entitys.clsTaiKhoan taikhoan;

        //2 trang thai cua lvwDSUV
        private enum TrangThai { DSLoc, DSDC }
        private TrangThai tt = TrangThai.DSLoc;
        private string tenNV;
        public src.Entitys.clsTaiKhoan taiKhoan = null;

        public frmChinh(string tenNV)
        {
            InitializeComponent();
            this.tenNV = tenNV;
        
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            #region Hien thi form theo quyen
            HienThiFormTheoQuyen();
            lblTenNV.Text = tenNV;
            
            #endregion

            #region Set trang thai ban dau cua form
            //tắt 
            lvwDSUV.CheckBoxes = false;
            btnDeXuatUV.Enabled = false;
            btnXemYeuCau.Enabled = false;
            btnChuyenDS.Enabled = false;
            //set trạng thái ban đầu là: DSLoc
            tt = TrangThai.DSLoc;
            An_button(tt);
            #endregion

            #region load dsuv chua duoc de cu len lvwDSUV
            //get dsuv chua duoc de cu tu DB     
            
            List<src.Entitys.clsUngVien> dsUV = ctrGUI.getDSUngVienChuaDeCu();
            LoadToListView(dsUV);
            //so luong ung vien
            txtTongUV.Text = lvwDSUV.Items.Count.ToString();
            #endregion

            #region Load data len combobox
            //Combobox vi tri tuyen dung
            //cboVTTD.DataSource = db.tblVITRI_TDs;
            List<src.Entitys.clsViTriTuyenDung> lstVT = ctrGUI.GetVitriTuyenDung();
            cboVTTD.DataSource = lstVT;
            cboVTTD.DisplayMember = "_StrTenViTri";
            cboVTTD.ValueMember = "_MaVT";
            cboVTTD.SelectedIndex = -1;


            //Combobox trinh do
            List<string> lstTD = ctrGUI.GetTrinhDo();
            lstTD.Insert(0, "<Tất cả danh mục>");
            cboTrinhDo.DataSource = lstTD;
            cboTrinhDo.DisplayMember = "TrinhDoHocVan";
            cboTrinhDo.SelectedIndex = 0;

            //Combobox Ngoai ngu
            List<string> lstNN = ctrGUI.GetNgoaiNgu();
            lstNN.Insert(0, "<Tất cả danh mục>");
            cboNgoaiNgu.DataSource = lstNN;
            cboNgoaiNgu.DisplayMember = "NgoaiNgu";
            cboNgoaiNgu.SelectedIndex = 0;

            ////Combobox kinh nghiem
            cboKinhNghiem.Items.Add("<Tất cả danh mục>");
            cboKinhNghiem.Items.Add("Chưa có kinh nghiệm");
            cboKinhNghiem.Items.Add("Dưới 1 năm");
            cboKinhNghiem.Items.Add("Trên 1 năm");
            cboKinhNghiem.Items.Add("Trên 3 năm");
            cboKinhNghiem.Items.Add("Trên 5 năm");
            cboKinhNghiem.SelectedIndex = 0;

            #endregion
        }





        private void HienThiFormTheoQuyen()
        {
            if (taiKhoan._MaRole == 1)
            {
                lblQuyen.Text = "admin";
            }
            else if(taiKhoan._MaRole == 2) // nhân viên
            {
                lblQuyen.Text = "nhân viên";
                mnuPheDuyetUV.Visible = false;
                mnuQLNhanVien.Visible = false;
                mnuQuanLyLichPV.Visible = false;
            }

        }



        private void TieuDeLvwDSUV()
        {
            lvwDSUV.View = View.Details;
            lvwDSUV.FullRowSelect = true;
            lvwDSUV.GridLines = true;
            lvwDSUV.Columns.Add("Mã", 50);
            lvwDSUV.Columns.Add("Họ và Tên", 180);
            lvwDSUV.Columns.Add("Giới Tính", 65);
            lvwDSUV.Columns.Add("Ngày Sinh", 120);
            lvwDSUV.Columns.Add("CMND", 110);
            lvwDSUV.Columns.Add("Email", 180);
            lvwDSUV.Columns.Add("Số Điện Thoại", 100);
            lvwDSUV.Columns.Add("Trình Độ", 120);
            lvwDSUV.Columns.Add("Ngoại Ngữ", 120);
            lvwDSUV.Columns.Add("Năm Kinh Nghiệm", 100);

        }


        
        private void mnuHuyTK_Click(object sender, EventArgs e)
        {
            frmQLNV frmQLNV = new frmQLNV();
            frmQLNV.Size = new Size(1000, 600);
            frmQLNV.check = false;
            //this.Visible = false;
            frmQLNV.ShowDialog();
        }



        private void mnuTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQLNV frmQLNV = new frmQLNV();

            //frmQLNV.MdiParent = this;
            frmQLNV.Size = new Size(1000, 500);
            frmQLNV.check = true;
            ///this.Visible = false;
            frmQLNV.ShowDialog();
        }

        private void mnuHuyTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQLNV frmQLNV = new frmQLNV();

            frmQLNV.Size = new Size(1000, 500);
            frmQLNV.check = false;
            //this.Visible = false;
            frmQLNV.ShowDialog();
        }

        private void mnuThemVT_Click(object sender, EventArgs e)
        {
            frmQLViTriTuyenDung frmQLVT = new frmQLViTriTuyenDung();
            //frmQLVT.MdiParent = this;
            //this.Visible = false;
            frmQLVT.ShowDialog();
            frmChinh_Load(sender, e);
        }

        private void BtnLocUV_Click(object sender, EventArgs e)
        {
            lvwDSUV.CheckBoxes = true;
            if (cboVTTD.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn một vị trí tuyển dụng!!");
            }
            else
            {
                dsLoc = ctrQLTD.TimKiemTheoViTri((int)cboVTTD.SelectedValue);
                if (cboTrinhDo.SelectedIndex != 0)//dang chọn 1 vi tri loc??? 
                {
                    var x = cboTrinhDo.SelectedValue.ToString();
                    dsLoc = ctrQLTD.LocTheoTrinhDo(dsLoc, x);
                }
                if (cboNgoaiNgu.SelectedIndex != 0)//dang chọn 1 vi tri loc???
                {
                    var y = cboNgoaiNgu.SelectedValue.ToString();
                    dsLoc = ctrQLTD.LocTheoNgoaiNgu(dsLoc, y);
                }
                if (cboKinhNghiem.SelectedIndex != 0)//dang chọn 1 vi tri loc???
                {
                    var z = cboKinhNghiem.SelectedItem.ToString();
                    dsLoc = ctrQLTD.LocTheoNamKinhNghiem(dsLoc, z);
                }

                LoadToListView(dsLoc);
                txtTongUV.Text = lvwDSUV.Items.Count.ToString();
                btnDeXuatUV.Enabled = true;
                btnChuyenDS.Enabled = true;
                if (dsLoc.Count == 0)
                {
                    MessageBox.Show("Không có ứng viên nào thỏa mãn điều kiện lọc!");
                }
            }

        }
        private void LoadToListView(List<src.Entitys.clsUngVien> dsLoc)
        {
            lvwDSUV.Clear();
            TieuDeLvwDSUV();
            ListViewItem lvi = null;
            foreach (var uv in dsLoc)
            {
                lvi = new ListViewItem(new String[] {uv._MaUV.ToString(), uv._StrTenUV, uv._GioiTinh == true ? "Nam": "Nữ",
                    uv._NgaySinh.ToString("dd'/'MM'/'yyyy"), uv._StrCMND.ToString(), uv._StrEmail, uv._StrSDT, uv._StrTrinhDo, uv._StrNgoaiNgu, uv._SoNam_KinhNghiem.ToString()});
                lvwDSUV.Items.Add(lvi);
                lvi.Tag = uv;
            }
            txtTongUV.Text = dsLoc.Count.ToString();
        }

        private void lvwDSUV_DoubleClick(object sender, EventArgs e)
        {
            //xóa dấu check
            lvwDSUV.SelectedItems[0].Checked = false;

            var ungvien = lvwDSUV.SelectedItems[0].Tag;
            string tenUV = ((src.Entitys.clsUngVien)ungvien)._StrTenUV;
            string strYeuCau = null;
            string batchCV = ((src.Entitys.clsUngVien)ungvien)._StrCV;
            frmChiTiet frmCT = new frmChiTiet(frmChiTiet.TrangThai.XemCV, tenUV, strYeuCau, batchCV);
            frmCT.ShowDialog();
        }

        private void cboVTTD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboVTTD.SelectedItem != null)
            {
                btnXemYeuCau.Enabled = true;
            }
        }

        private void An_button(TrangThai tt)
        {
            if (tt == TrangThai.DSLoc) // Trạng Thái danh sách lọc
            {
                this.btnLuu.Visible = false;
                this.btnChuyenDS.Visible = true;
                this.btnHuyDC.Visible = false;
                this.btnDeXuatUV.Visible = true;
                this.BtnLocUV.Enabled = true;

                this.cboTrinhDo.Visible = true;
                this.lblTrinhDo.Visible = true;
                this.cboNgoaiNgu.Visible = true;
                this.lblNgoaiNgu.Visible = true;
                this.cboKinhNghiem.Visible = true;
                this.lblKinhNghiem.Visible = true;
                this.BtnLocUV.Visible = true;
                this.lblDSUV.Text = "Danh Sách Ứng Viên";
                this.btnChuyenDS.Text = "Chuyển DS Đề cử";

            }
            else// Trạng Thái danh sách đề cử
            {
                this.btnLuu.Visible = true;
                this.btnChuyenDS.Visible = true;
                this.btnHuyDC.Visible = true;
                this.btnDeXuatUV.Visible = false;
                this.BtnLocUV.Enabled = false;

                this.cboTrinhDo.Visible = false;
                this.lblTrinhDo.Visible = false;
                this.cboNgoaiNgu.Visible = false;
                this.lblNgoaiNgu.Visible = false;
                this.cboKinhNghiem.Visible = false;
                this.lblKinhNghiem.Visible = false;
                this.BtnLocUV.Visible = false;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Đề Cử";
                this.btnChuyenDS.Text = "Chuyển DS Ứng viên";

            }
        }

        private void btnXemYeuCau_Click(object sender, EventArgs e)
        {
            var vitri = cboVTTD.SelectedItem;
            string tenVT = ((src.Entitys.clsViTriTuyenDung)vitri)._StrTenViTri;
            string strYeuCau = ((src.Entitys.clsViTriTuyenDung)vitri)._StrYeuCau;
            string pathCV = null;
            frmChiTiet frmCT = new frmChiTiet(frmChiTiet.TrangThai.XemYeuCau, tenVT, strYeuCau, pathCV);
            frmCT.ShowDialog();
        }


        private void btnChuyenDS_Click(object sender, EventArgs e)
        {
            //Hiện tại đang ở trạng thái đề cử    
            if (tt == TrangThai.DSDC)
            {
                tt = TrangThai.DSLoc;
                An_button(tt);
                LoadToListView(dsLoc);
            }
            else//Hiện tại đang ở trạng thái lọc
            {
                tt = TrangThai.DSDC;
                An_button(tt);

                //gọi hàm vị trí đg 
                cboVTTD_SelectedIndexChanged(sender, e);
            }

        }

        private void btnDeXuatUV_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn đề cử các ứng viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //Đồng ý đề cử
            if (kq == DialogResult.OK)
            {
                int count = 0;
                foreach (ListViewItem lvi in lvwDSUV.Items)
                {
                    //chuyen danh sach cac item đc chon
                    if (lvi.Checked == true)
                    {
                        count++;
                        var uv = lvi.Tag;
                        src.Entitys.clsUngVien uvTemp = ((src.Entitys.clsUngVien)uv);
                        ctrQLTD.ChuyenDSUV(dsLoc, dsDeCu, uvTemp);
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("Hãy chọn ít nhất một ứng viên để đề cử", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    LoadToListView(dsLoc);

                }
            }

        }

        private void btnHuyDC_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (ListViewItem item in lvwDSUV.Items)
            {
                if (item.Checked == true)
                {
                    src.Entitys.clsUngVien uvTemp = ((src.Entitys.clsUngVien)item.Tag);
                    ctrQLTD.ChuyenDSUV(dsDeCu, dsLoc, uvTemp);
                    LoadToListView(dsDeCu);
                    dem++;
                }
            }
            if(dem  == 0)
                MessageBox.Show("Bạn chưa chọn ứng viên hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void mnuPheDuyetUV_Click(object sender, EventArgs e)
        {
            //open form
            frmXemDuyetUV frmxemDuyet = new frmXemDuyetUV();
            frmxemDuyet.ttForm = frmXemDuyetUV.TrangThaiForm.PheDuyet;

            // frmxemDuyet.An_button(frmXemDuyetUV.TrangThaiLV.DSDC);
            frmxemDuyet.ShowDialog();
        }

        

        
        private void cboVTTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Đang ở trạng thái đề cử
            if (tt == TrangThai.DSDC)
            {
                int maVT = (int)cboVTTD.SelectedValue;
                List<src.Entitys.clsUngVien> ds = ctrQLTD.LocUV_theoVitri(dsDeCu, maVT);
                LoadToListView(ds);

            }
        }

        src.Services.connVTTD_UngVien connVT_UV = new src.Services.connVTTD_UngVien();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(dsDeCu.Count > 0)
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn cập nhật lại toàn bộ danh sách các ứng viên đề cử này?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (kq == DialogResult.OK)
                {
                    //cập nhật danh sách lưu lên database

                    if (!connVT_UV.UpdateTrangThaiDeCu(dsDeCu))
                    {
                        MessageBox.Show("Cập nhật không thành công!\nHãy lưu lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Đã cập nhật thành công");
                        //Xoa tai danh sach de cu
                        dsDeCu.Clear();
                        dsLoc.Clear();
                        //Tro ve Trang Thai Loc
                        tt = TrangThai.DSLoc;
                        //An_button(tt);
                        //btnDeXuatUV.Enabled = false;
                        //btnChuyenDS.Enabled = false;
                        //cboVTTD.SelectedIndex = -1;
                        //List<clsUngVienUngTuyen> dsUV = ctrGUI.getDSUngVienChuaDeCu();
                        //LoadToListView(dsUV);
                        lvwDSUV.Clear();
                        frmChinh_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Danh Sách Đề Cử rỗng!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        

        

        //private void mnuXoaVT_Click(object sender, EventArgs e)
        //{
        //    frmQLViTriTuyenDung frmQLVT = new frmQLViTriTuyenDung();
        //    frmQLVT.ttf = frmQLViTriTuyenDung.TrangThaiForm.XoaVT;
        //    frmQLVT.ShowDialog();
        //    frmChinh_Load(sender, e);
        //}


        private void lblDoiMatKhau_Click(object sender, EventArgs e)
        {
            src.Boundarys.frmDoiMatKhau frmDoiMatKhau = new src.Boundarys.frmDoiMatKhau(taiKhoan._StrUsername);
            frmDoiMatKhau.ShowDialog();
        }

        private void mnuNhanUV_Click(object sender, EventArgs e)
        {
            src.Boundarys.frmNhanUV frmNhan = new src.Boundarys.frmNhanUV();
            frmNhan.ShowDialog();

        }

      

        private void mnuXemUVTrungTuyen_Click(object sender, EventArgs e)
        {
            frmXemDuyetUV frmxemDuyet = new frmXemDuyetUV();
            frmxemDuyet.ttForm = frmXemDuyetUV.TrangThaiForm.XemUVTrungTuyen;
            frmxemDuyet.ShowDialog();
        }

        private void mnuXemVTTD_Click(object sender, EventArgs e)
        {
            frmQLViTriTuyenDung frmQLVT = new frmQLViTriTuyenDung();
            frmQLVT.ttf = frmQLViTriTuyenDung.TrangThaiForm.XemVT;
            frmQLVT.ShowDialog();
        }

        private void mnuQuanLyLichPV_Click(object sender, EventArgs e)
        {
            frmXemDuyetUV frmxemDuyet = new frmXemDuyetUV();
            frmxemDuyet.ttForm = frmXemDuyetUV.TrangThaiForm.QuanLyLich;
            frmxemDuyet.ShowDialog();
        }

        private void mnuXemUVDeCu_Click(object sender, EventArgs e)
        {
            frmXemDuyetUV frmxemDuyet = new frmXemDuyetUV();
            frmxemDuyet.ttForm = frmXemDuyetUV.TrangThaiForm.XemDeCu;
            frmxemDuyet.ShowDialog();
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn cập nhật lại toàn bộ danh sách các ứng viên đề cử này?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(kq == DialogResult.OK)
                this.Close();
        }

        private void mnuCapNhatKetQuaPV_Click(object sender, EventArgs e)
        {
            frmXemDuyetUV frmxemDuyet = new frmXemDuyetUV();
            frmxemDuyet.ttForm = frmXemDuyetUV.TrangThaiForm.CapNhatKetQuaPV;
            frmxemDuyet.ShowDialog();
        }

        private void mnuXoaUngVien_Click(object sender, EventArgs e)
        {
            frmXemDuyetUV frmxemDuyet = new frmXemDuyetUV();
            frmxemDuyet.ttForm = frmXemDuyetUV.TrangThaiForm.XoaUngVien;
            frmxemDuyet.ShowDialog();
        }

        private void BtnLocUV_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, BtnLocUV.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnXemYeuCau_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnXemYeuCau.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnDeXuatUV_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnDeXuatUV.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnLuu_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnLuu.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnHuyDC_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnHuyDC.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnChuyenDS_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnChuyenDS.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnDangXuat_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnDangXuat.ClientRectangle,
            SystemColors.ControlLightLight, 1, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 1, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDoiMatKhau_Click_1(object sender, EventArgs e)
        {
            src.Boundarys.frmDoiMatKhau frmDoiMK = new src.Boundarys.frmDoiMatKhau(taiKhoan._StrUsername);
            frmDoiMK.ShowDialog();

        }

        private void lblDoiMatKhau_MouseHover(object sender, EventArgs e)
        {
           lblDoiMatKhau.Font = new Font("Arial",10,FontStyle.Underline);
        }

        private void lblDoiMatKhau_MouseLeave(object sender, EventArgs e)
        {
            lblDoiMatKhau.Font = new Font("Arial", 8, FontStyle.Underline);
        }
    }
}









using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmXemDuyetUV : Form
    {
        src.Controlers.ctrlGUI ctrGUI = new src.Controlers.ctrlGUI();
        src.Controlers.ctrlDeXuat ctrDC = new src.Controlers.ctrlDeXuat();
        src.Controlers.ctrlPheDuyet ctrPD = new src.Controlers.ctrlPheDuyet();
        src.Controlers.ctrlQLLichPV ctrQLlich = new src.Controlers.ctrlQLLichPV();
        src.Controlers.ctrlQLUngVien ctrQLUV = new src.Controlers.ctrlQLUngVien();
        src.Controlers.ctrlQLLichPV ctrDatLich = new src.Controlers.ctrlQLLichPV();
        // src.Services.connLichPV cnnLichPV = new src.Services.connLichPV();
        src.Services.connLichPV_UngVien cnnLichPV_UV = new src.Services.connLichPV_UngVien();

        src.Services.connVTTD_UngVien cnnVT_UV = new src.Services.connVTTD_UngVien();

        List<src.Entitys.clsUngVien> dsDeCu = new List<src.Entitys.clsUngVien>();
        List<src.Entitys.clsUngVien> dsPD = new List<src.Entitys.clsUngVien>();
        List<src.Entitys.clsUngVien> dsUV = null;
        public enum TrangThaiForm
        {
            PheDuyet,
            XemDeCu,
            QuanLyLich,
            CapNhatKetQuaPV,
            XemUVTrungTuyen,
            XoaUngVien
        }
        public TrangThaiForm ttForm;

        public void Set_TrangThaiForm(TrangThaiForm tt)
        {
            if (ttForm == TrangThaiForm.PheDuyet) // Chức năng phê duyệt ứng viên  
            {
                chkXemUVTheoLich.Visible = false;
                lblLichPV.Visible = false;
                cboLichPV.Visible = false;
                lvwDSUV.CheckBoxes = false;
                lblDSUV.Text = "Danh Sách Ứng Viên Đề Cử";
                btnXuLy1.Enabled = false;
                btnLuu.Visible = false;
                btnXuLy2.Enabled = false;
                btnHuy.Visible = false;
                //lvwDSUV.CheckBoxes = true;
            }
            else if (ttForm == TrangThaiForm.XemDeCu) // Chức năng Xem DSUV Đề cử
            {
                chkXemUVTheoLich.Visible = false;
                lblLichPV.Visible = false;
                cboLichPV.Visible = false;
                lvwDSUV.CheckBoxes = false;
                lblDSUV.Text = "Danh Sách Ứng Viên Đề Cử";
                btnXuLy1.Visible = false;
                btnLuu.Visible = false;
                btnXuLy2.Visible = false;
                btnHuy.Visible = false;
                //lvwDSUV.CheckBoxes = false;
                btnThoat.Anchor = AnchorStyles.Bottom & AnchorStyles.Right;

            }
            else if (ttForm == TrangThaiForm.QuanLyLich) // Chức năng Đặt lịch
            {
                chkXemUVTheoLich.Visible = false;
                lblLichPV.Visible = true;
                cboLichPV.Visible = true;
                cboLichPV.Enabled = false;
                lvwDSUV.CheckBoxes = false;
                lblDSUV.Text = "Danh Sách Ứng Viên Chưa Có Lịch";
                btnXuLy1.Visible = true;
                btnXuLy1.Text = "Đặt Lịch Mới";
                btnXuLy2.Visible = true;
                btnXuLy2.Text = "Thêm Vào Lịch Cũ";
                btnXuLy2.Enabled = false;
                btnLuu.Visible = false;
                btnHuy.Visible = false;
                //lvwDSUV.CheckBoxes = true;
                //pnlPheDuyet.Visible = true;
            }
            else if (ttForm == TrangThaiForm.CapNhatKetQuaPV) // chức năng Cap Nhat Ket Qua PV
            {
                chkXemUVTheoLich.Visible = false;
                lblLichPV.Visible = true;
                cboLichPV.Visible = true;
                cboLichPV.Enabled = false;
                lvwDSUV.CheckBoxes = false;
                lblDSUV.Text = "Danh Sách Ứng Viên Theo Lịch";
                btnXuLy1.Visible = true;
                btnXuLy1.Text = "Cập Nhật Kết Quả Phỏng Vấn";
                btnXuLy2.Visible = false;
                btnLuu.Visible = false;
                btnHuy.Visible = false;
                // lvwDSUV.CheckBoxes = true;
            }
            else //(ttForm== TrangThaiForm.XemUVTrungTuyen) chức năng Xem DSUV Trúng tuyển
            {
                chkXemUVTheoLich.Visible = false;
                lblLichPV.Visible = false;
                cboLichPV.Visible = false;
                lvwDSUV.CheckBoxes = false;
                lblDSUV.Text = "Danh Sách Ứng Viên Trúng Tuyển";
                btnXuLy1.Visible = false;
                btnXuLy2.Visible = false;
                btnLuu.Visible = false;
                btnHuy.Visible = false;
                //lvwDSUV.CheckBoxes = false;
            }

        }

        #region Xu Li Form
        private void TieuDeLvwDSUV()
        {
            lvwDSUV.Clear();
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
        private void LoadToListView(List<src.Entitys.clsUngVien> dsLoc)
        {
            TieuDeLvwDSUV();
            //lvwDSUV.Items.Clear();
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
        #endregion

        public frmXemDuyetUV()
        {
            InitializeComponent();

        }



        public enum TrangThaiLV { DSDC, DSPD }
        public TrangThaiLV tt;
        public void An_button(TrangThaiLV tt)
        {
            if (tt == TrangThaiLV.DSDC)
            {
                this.cboVTTD.Enabled = true;
                this.btnLuu.Visible = false;
                this.btnXuLy2.Visible = true;
                this.btnHuy.Visible = false;
                this.btnXuLy1.Visible = true;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Đề Cử";
                this.btnXuLy2.Text = "Chuyển DS Phê Duyệt";
            }
            else
            {
                this.cboVTTD.Enabled = false;
                this.btnLuu.Visible = true;
                this.btnXuLy2.Visible = true;
                this.btnHuy.Visible = true;
                this.btnXuLy1.Visible = false;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Phê Duyệt";
                this.btnXuLy2.Text = "Chuyển DS Đề Cử";

            }
        }
        private void ChuyenTrangThai(TrangThaiLV tt)
        {
            if (tt == TrangThaiLV.DSDC)
            {
                this.btnLuu.Visible = false;
                this.btnXuLy2.Visible = false;
                this.btnHuy.Visible = false;
                this.btnXuLy1.Visible = true;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Đề Cử";

            }
            else
            {
                this.btnLuu.Visible = true;
                this.btnXuLy2.Visible = true;
                this.btnHuy.Visible = true;
                this.btnXuLy1.Visible = false;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Phê Duyệt";


            }
        }

        public void frmXemDuyetUV_Load(object sender, EventArgs e)
        {
            Set_TrangThaiForm(ttForm);
            if (ttForm == TrangThaiForm.PheDuyet)
            {
                tt = TrangThaiLV.DSDC;
                An_button(tt);
            }

            //Load DL cho combobox VTTD
            List<src.Entitys.clsViTriTuyenDung> lstVT = ctrGUI.GetVitriTuyenDung();
            cboVTTD.DataSource = lstVT;
            cboVTTD.DisplayMember = "_StrTenViTri";
            cboVTTD.ValueMember = "_MaVT";
            cboVTTD.SelectedIndex = -1;


            //Load DL cho combobox LichPV
            //if (ttForm==TrangThaiForm.CapNhatKetQuaPV || ttForm == TrangThaiForm.QuanLyLich)
            //{
            //    List<src.Entitys.clsLichPhongVan> lstLich = ctrQLlich.GetLichPVTheoViTri((int)cboVTTD.SelectedValue);
            //    cboLichPV.DataSource = lstLich;
            //    cboLichPV.DisplayMember = "_ThoiGian";
            //    cboLichPV.ValueMember = "_MaLich";
            //    cboLichPV.SelectedIndex = -1;
            //}


            //Load DL cho listview
            GetDLChoListView();

        }

        public void GetDLChoListView()
        {
            if (ttForm == TrangThaiForm.QuanLyLich)
            {
                List<src.Entitys.clsUngVien> dsUVPheDuyet = ctrGUI.GetUVPheDuyetChuaCoLich();
                LoadToListView(dsUVPheDuyet);
            }
            else if (ttForm == TrangThaiForm.XemDeCu)
            {
                dsUV = ctrGUI.GetUngVienDeCu();
                LoadToListView(dsUV);

            }
            else if (ttForm == TrangThaiForm.PheDuyet)
            {
                dsUV = ctrGUI.GetUngVienDeCuChuaPheDuyet();
                LoadToListView(dsUV);
            }
            else if (ttForm == TrangThaiForm.XemUVTrungTuyen)
            {
                dsUV = ctrGUI.GetUVTrungTuyen();
                LoadToListView(dsUV);
            }
            else // (ttForm == TrangThaiForm.CapNhatKetQuaPV)
            {
                dsUV = ctrGUI.GetUVChuaCapNhatKQPV();
                LoadToListView(dsUV);
            }

        }

        public void ChuyenDS()
        {
            if (btnXuLy2.Text == "Chuyển DS Đề Cử")
            {
                tt = TrangThaiLV.DSDC;
            }
            else
            {
                tt = TrangThaiLV.DSPD;
            }
            //chuyen trang thai danh sach
            if (tt == TrangThaiLV.DSDC)
            {
                An_button(tt);
                LoadToListView(dsDeCu);
                tt = TrangThaiLV.DSPD;
            }
            else
            {
                An_button(tt);
                LoadToListView(dsPD);
                tt = TrangThaiLV.DSDC;
            }
        }


        private void cboVTTD_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //var item = cboVTTD.SelectedItem;
            //int ma = ((src.Entitys.clsViTriTuyenDung)item)._MaVT;
            int ma = (int)cboVTTD.SelectedValue;
            //Get DL cho cboLichPV
            List<src.Entitys.clsLichPhongVan> lstLich = ctrQLlich.GetLichPVTheoViTri(ma);
            cboLichPV.DataSource = lstLich;
            cboLichPV.DisplayMember = "_ThoiGian";
            cboLichPV.ValueMember = "_MaLich";
            cboLichPV.SelectedIndex = -1;

            if (ttForm == TrangThaiForm.QuanLyLich)
            {
                btnXuLy1.Enabled = true;
                btnXuLy2.Enabled = false;
                cboLichPV.Enabled = true;
                lvwDSUV.CheckBoxes = true;
                chkXemUVTheoLich.Visible = false;
                lblDSUV.Text = "Danh Sách Ứng Viên Chưa Có Lịch";
                List<src.Entitys.clsUngVien> dsUVPD = ctrQLlich.GetUVPDChuaCoLichTheoViTri(ma);
                LoadToListView(dsUVPD);
            }
            else if (ttForm == TrangThaiForm.PheDuyet)
            {
                dsDeCu.Clear();
                dsDeCu = ctrPD.TimKiemUVDeCuChuaPDTheoViTri(ma);
                LoadToListView(dsDeCu);
                btnXuLy1.Enabled = true;
                btnXuLy2.Enabled = true;
                lvwDSUV.CheckBoxes = true;

            }
            else if (ttForm == TrangThaiForm.XemDeCu)
            {
                dsUV = ctrQLUV.TimKiemUVDeCuTheoViTri(ma);
                LoadToListView(dsUV);
            }
            else if (ttForm == TrangThaiForm.XemUVTrungTuyen)
            {
                dsUV = ctrQLUV.TimKiemUVTrungTuyenTheoViTri(ma);
                LoadToListView(dsUV);
            }
            else if (ttForm == TrangThaiForm.CapNhatKetQuaPV)
            {

                cboLichPV.Enabled = true;
                lvwDSUV.CheckBoxes = true;

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (ListViewItem item in lvwDSUV.Items)
            {
                if (item.Checked == true)
                {
                    dem++;
                    var uv = item.Tag;
                    var uvTemp = ((src.Entitys.clsUngVien)uv);
                    ctrDC.ChuyenDSUV(dsPD, dsDeCu, uvTemp);
                    LoadToListView(dsPD);
                }
            }
            if (dem == 0)
                MessageBox.Show("Bạn chưa chọn ứng viên hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void PheDuyet()
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn phê duyệt các ứng viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                        ctrDC.ChuyenDSUV(dsDeCu, dsPD, uvTemp);
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("Hãy chọn ít nhất một ứng viên để đề cử");
                }
                else
                {
                    LoadToListView(dsDeCu);
                    cboVTTD.Enabled = false;

                }
            }
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            cboVTTD.Enabled = true;
            if (dsPD.Count() == 0)
            {
                MessageBox.Show("Không có ứng viên nào để lưu!");
            }
            else
            {
                if (cnnVT_UV.UpdateTrangThaiPD(dsPD))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsDeCu.Clear();
                    dsPD.Clear();
                    ttForm = TrangThaiForm.PheDuyet;
                    tt = TrangThaiLV.DSDC;
                    frmXemDuyetUV_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!\nHãy lưu lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXuLy1_Click(object sender, EventArgs e)
        {
            if (ttForm == TrangThaiForm.PheDuyet)
            {
                PheDuyet();
            }
            else if (ttForm == TrangThaiForm.QuanLyLich)
            {
                if (cboVTTD.SelectedItem != null)
                {
                    var vitri = cboVTTD.SelectedItem;
                    string tenvttd = ((src.Entitys.clsViTriTuyenDung)vitri)._StrTenViTri;
                    List<src.Entitys.clsUngVien> dsUVPV = GetDSUV();
                    if (count == 0)
                    {
                        MessageBox.Show("Hãy chọn các ứng viên cho việc đặt lịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        frmLichPhongVan frmLichPV = new frmLichPhongVan(tenvttd, dsUVPV);
                        frmLichPV.ShowDialog();
                        frmXemDuyetUV_Load(sender, e);

                    }

                }
                else
                    MessageBox.Show("Hãy chọn vị trí tuyển dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (ttForm == TrangThaiForm.CapNhatKetQuaPV)
            {
                count = 0;
                List<src.Entitys.clsUngVien> lstLich = new List<src.Entitys.clsUngVien>();

                int maVT = (int)cboVTTD.SelectedValue;
                int maLich = (int)cboLichPV.SelectedValue;

                foreach (ListViewItem item in lvwDSUV.Items)
                {
                    if (item.Checked == true)
                    {
                        count++;
                        //src.Entitys.clsUngVien uv = new src.Entitys.clsUngVien();
                        var uv = (src.Entitys.clsUngVien)item.Tag;
                        cnnLichPV_UV.CapNhatKQPV(maVT, maLich, uv._MaUV);
                    }
                }
                if (count > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hãy chọn ít nhất một ứng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        int count;
        private void btnXuLy2_Click(object sender, EventArgs e)
        {
            if (ttForm == TrangThaiForm.PheDuyet) // btnPheDuyet
            {
                ChuyenDS();
            }
            else if (ttForm == TrangThaiForm.QuanLyLich) // btnThemVaoLich
            {

                var vitri = cboVTTD.SelectedItem;
                string tenvttd = ((src.Entitys.clsViTriTuyenDung)vitri)._StrTenViTri;
                List<src.Entitys.clsUngVien> dsUVPV = GetDSUV();
                if (count == 0)
                {
                    MessageBox.Show("Hãy chọn các ứng viên cho việc đặt lịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmLichPhongVan frmLichPV = new frmLichPhongVan(tenvttd, dsUVPV);
                    DialogResult dr = MessageBox.Show("Thư mời phỏng vấn sẽ được gửi đến tất cả các ứng viên." + "\nNếu muốn kiểm tra lại thông tin lịch phỏng vấn" + "\n=> Vui lòng bấm Cancel!",
                        "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        frmLichPhongVan frmL = new frmLichPhongVan(tenvttd, dsUVPV);
                        var lich = (src.Entitys.clsLichPhongVan)cboLichPV.SelectedItem;

                        string mess = frmL.CapNhatMail(tenvttd, lich._ThoiGian.ToString("hh:mm tt"), lich._ThoiGian.ToString("dd/MM/yyyy"), lich._StrDiaDiem);
                        frmL.GuiMail(mess);

                        int ma = lich._MaLich;
                        cnnLichPV_UV.ThemLichPV_UngVien(dsUVPV, ma);
                        frmXemDuyetUV_Load(sender, e);
                    }
                }

            }
        }


        public List<src.Entitys.clsUngVien> GetDSUV()
        {
            count = 0;
            List<src.Entitys.clsUngVien> lstUVPV = new List<src.Entitys.clsUngVien>();

            foreach (ListViewItem item in lvwDSUV.Items)
            {
                if (item.Checked == true)
                {
                    count++;
                    src.Entitys.clsUngVien uv = new src.Entitys.clsUngVien();
                    uv = (src.Entitys.clsUngVien)item.Tag;
                    lstUVPV.Add(uv);
                }
            }
            return lstUVPV;


        }

        private void cboLichPV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboLichPV.SelectedItem != null)
            {
                if (ttForm == TrangThaiForm.QuanLyLich)
                {
                    chkXemUVTheoLich.Visible = true;
                    btnXuLy2.Enabled = true;
                    btnXuLy1.Enabled = false;

                }
                else if (ttForm == TrangThaiForm.CapNhatKetQuaPV)
                {
                    btnXuLy1.Enabled = true;
                    dsUV = ctrQLUV.TimKiemUVPVChuaCapNhatTheoLich((int)cboVTTD.SelectedValue, (int)cboLichPV.SelectedValue);
                    LoadToListView(dsUV);
                }
            }

        }

        private void btnXuLy1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnXuLy1.ClientRectangle,
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

        private void btnHuy_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnHuy.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnXuLy2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnXuLy2.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnThoat_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnThoat.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkXemUVTheoLich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXemUVTheoLich.Checked)
            {
                lvwDSUV.CheckBoxes = false;
                lblDSUV.Text = "Danh Sách Ứng Viên Đã Có Lịch";
                btnXuLy1.Enabled = false;
                btnXuLy2.Enabled = false;
                var lst = ctrQLUV.TimKiemUVTheoViTri_Lich((int)cboVTTD.SelectedValue, (int)cboLichPV.SelectedValue);
                LoadToListView(lst);
            }
            else
            {
                lvwDSUV.CheckBoxes = true;
                lblDSUV.Text = "Danh Sách Ứng Viên Chưa Có Lịch";
                btnXuLy1.Enabled = true;
                btnXuLy2.Enabled = true;
                var lst = ctrQLlich.GetUVPDChuaCoLichTheoViTri((int)cboVTTD.SelectedValue);
                LoadToListView(lst);
            }
        }
    }
}

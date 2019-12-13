using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmChinh : Form
    {

        //chuyen trang thai cho Form
        private enum TrangThai { DSLoc, DSDC }
        private TrangThai tt;

        //database
        public DataQuanLiTuyenDungDataContext db;
       
        public frmChinh()
        {
            InitializeComponent();
            db = new DataQuanLiTuyenDungDataContext();
        }

        private void mnuNhan_Click(object sender, EventArgs e)
        {
            frmNhanDSUV frmNhan = new frmNhanDSUV();
            frmNhan.kiemtraNhanUV = true;
            frmNhan.ShowDialog();
        }

        private void mnuGuiTinTD_Click(object sender, EventArgs e)
        {
            frmNhanDSUV frmNhan = new frmNhanDSUV();
            frmNhan.kiemtraNhanUV = false;
            frmNhan.ShowDialog();
        }

        private void mnuPheDuyetUV_Click(object sender, EventArgs e)
        {
            frmPheDuyetUV frmPD = new frmPheDuyetUV();
            frmPD.WindowState = FormWindowState.Maximized;
            frmPD.ShowDialog();

        }


        private void mnuTaoTK_Click(object sender, EventArgs e)
        {
            frmQLNV frmQLNV = new frmQLNV();
            frmQLNV.Size = new Size(1000, 600);
            frmQLNV.check = true;
            frmQLNV.ShowDialog();

        }

        private void mnuHuyTK_Click(object sender, EventArgs e)
        {
            frmQLNV frmQLNV = new frmQLNV();
            frmQLNV.Size = new Size(1000, 600);
            frmQLNV.check = false;
            frmQLNV.ShowDialog();

        }

        private void btnXemYeuCau_Click(object sender, EventArgs e)
        {

        }

        //private void BtnLocUV_Click(object sender, EventArgs e)
        //{
        //    //loc ung vien
        //    Loc_UV(cboVTTD.SelectedValue.ToString(), cboTrinhDo.SelectedValue.ToString(), cboNgoaiNgu.SelectedValue.ToString(),
        //        int.Parse(cboKinhNghiem.SelectedValue.ToString()));

        //    //load du lieu len listview
        //    //Load_toListView();

        //}

        private void btnDoiMK_Click(object sender, EventArgs e)
        {

        }

        private void btnDeXuatUV_Click(object sender, EventArgs e)
        {
            tt = TrangThai.DSDC;
            an_button(tt);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            an_button(TrangThai.DSLoc);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        
        private void an_button(TrangThai tt)
        {
            if (tt == TrangThai.DSLoc)
            {
                this.btnLuu.Visible = false;
                this.btnChuyenDanhSach.Visible = true;
                this.btnXoa.Visible = false;
                this.btnDeXuatUV.Visible = true;
                this.btnChuyenDanhSach.Text = "Xem Danh Sách Đề Cử";
                this.lblDSUV.Text = "Danh Sách Ứng Viên";
            }
            else
            {
                this.btnLuu.Visible = true;
                this.btnChuyenDanhSach.Visible = true;
                this.btnXoa.Visible = true;
                this.btnDeXuatUV.Visible = false;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Đề Cử";
                this.btnChuyenDanhSach.Text = "Xem Danh Sách Ứng Viên";
            }
        }
        private void LoadDB_ToListview(List<tblUNGVIEN> dsUV)
        {
            ListViewItem lvi = null;
            foreach (tblUNGVIEN uv in dsUV)
            {
                //do du lieu len listview
                lvi = new ListViewItem(new String[] {uv.MaUV.ToString(), uv.TenUV, uv.GioiTinh, uv.NgaySinh.ToString(), uv.CMND.ToString(), uv.Email, 
                    uv.SDT, uv.TrinhDoHV, uv.NgoaiNgu, uv.SoNamKN.ToString()});
                lvwDSUV.Items.Add(lvi);
                //lvwDSUV.tag();

                ////luu du lieu vao lop UNGVIEN
                //UNGVIEN temp = new UNGVIEN(uv.CMND, uv.HoTen, uv.GioiTinh == "Nam" ? true : false, DateTime.Parse(uv.NgaySinh.ToString()),
                //    uv.Email, uv.SDT, uv.TrinhDoHocVan, uv.NgoaiNgu, int.Parse(uv.SoNamKN.ToString()), uv.MaVT);

            }
        }
        private void frmChinh_Load(object sender, EventArgs e)
        {

            //tắt 
            btnDeXuatUV.Enabled = false;
            //thay đổi trạng thái
            tt = TrangThai.DSLoc;
            an_button(tt);

            
            //DSUNGVIEN = new List<UNGVIEN>();

            //load dữ liệu lên lsv  
            var query = (from UV in db.tblUNGVIENs
                         join V in db.tblVTTD_UNGTUYENs on UV.MaUV equals V.MaUV_UV
                         where V.TrangThaiDC ==  false
                         select UV).Distinct().ToList();
 //                        select new { UV.MaUV, UV.TenUV, UV.GioiTinh, UV.NgaySinh, UV.CMND, UV.Email, UV.SDT, UV.TrinhDoHV, UV.NgoaiNgu, UV.SoNamKN })
 //                        .Distinct().ToList();

            List<tblUNGVIEN> dsUV = query;
            lvwDSUV.Columns.Add("Mã", 70);
            lvwDSUV.Columns.Add("Họ và Tên", 180);
            lvwDSUV.Columns.Add("Giới Tính", 70);
            lvwDSUV.Columns.Add("Ngày Sinh", 120);
            lvwDSUV.Columns.Add("CMND", 70);
            lvwDSUV.Columns.Add("Email", 180);
            lvwDSUV.Columns.Add("Số Điện Thoại", 100);
            lvwDSUV.Columns.Add("Trình Độ", 120);
            lvwDSUV.Columns.Add("Ngoại Ngữ", 120);
            lvwDSUV.Columns.Add("Năm Kinh Nghiệm", 100);

            LoadDB_ToListview(dsUV);

            //so luong ung vien
            txtTongUV.Text = lvwDSUV.Items.Count.ToString();
            

            //Combobox vi tri tuyen dung
            btnXemYeuCau.Enabled = false; 
            cboVTTD.DataSource = db.tblVITRI_TDs; 
            cboVTTD.DisplayMember = "TenVT";
            cboVTTD.ValueMember = "MaVT";
            cboVTTD.SelectedIndex = -1;


            //Combobox trinh do
            var temp = (from uv in db.tblUNGVIENs
                        select uv.TrinhDoHV).Distinct().ToList();
            temp.Insert(0, "<Tất cả>");
            cboTrinhDo.DataSource = temp;
            cboTrinhDo.DisplayMember = "TrinhDoHocVan";

            //Combobox Ngoai ngu
            temp = (from td in db.tblUNGVIENs
                     select td.NgoaiNgu).Distinct().ToList();
            temp.Insert(0, "<Tất cả danh mục>");
            cboNgoaiNgu.DataSource = temp;
            cboNgoaiNgu.DisplayMember = "NgoaiNgu";

            ////Combobox kinh nghiem
            cboKinhNghiem.Items.Add("Không cần kinh nghiệm");
            cboKinhNghiem.Items.Add("Trên 1 năm");
            cboKinhNghiem.Items.Add("Trên 3 năm");
            cboKinhNghiem.Items.Add("Trên 5 năm");

           

            
        }

        private void cmbVTTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        private void cmbVTTD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnXemYeuCau.Enabled = true;
            MessageBox.Show(cboVTTD.SelectedValue.ToString());
            
        }

        private void cboTrinhDo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show(cboTrinhDo.SelectedValue.ToString());
        }

        private void BtnLocUV_Click(object sender, EventArgs e)
        {
            btnDeXuatUV.Enabled = true;
        }

        private void cboKinhNghiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cboKinhNghiem.SelectedIndex.ToString());
        }



        #region HamXuLy
        DanhSachUngVien dsloc = new DanhSachUngVien();
       
        //ung vien hien tai deu la ung vien ung tuyen
        void Load_DanhSach_VaoListview(DanhSachUngVien ds)
        {

            foreach(UngVienUngTuyen uv in lvwDSUV.Items)
            {
                ListViewItem item = new ListViewItem(new String[]{uv._MaUV.ToString(), uv._StrTenUV, uv._GioiTinh == true? "Nam" : "Nữ",
                uv._NgaySinh.ToString("dd/mm/yyy"), })
            }
        
        }



        #endregion


        //loc ung vien theo dieu kien
        //private void Loc_UV(string viTri, string trinhDo, string ngoaiNgu, int soNam_kn)
        //{
        //    //xoa du lieu danh sach loc
        //    DSLoc._DS.Clear();

        //    //Danh sach ung vien loc moi          
        //    int n = DSUV._DS.Count;
        //    for (int i = 0; i < n; i++) 
        //    {
        //        if(DSUV._DS[i].MaVT == viTri && DSUV._DS[i].StrTrinhDo == trinhDo && DSUV._DS[i].StrNgoaiNgu == ngoaiNgu 
        //            && DSUV._DS[i].SoNam_KinhNghiem == soNam_kn )
        //        {
        //            DSLoc._DS.Add(DSUV._DS[i]);
        //        }
        //    }

        }

        //private void Load_toListView(List<UNGVIEN> ds)
        //{
        //    //xoa danh sach cu
        //    lvwDSUV.Items.Clear();


        //    //load danh sach moi
        //    ListViewItem lvi = null;
        //    foreach (UNGVIEN uv in ds)
        //    {
        //        lvi = new ListViewItem(new String[] {uv.StrCMND, uv.StrHoTen, uv.GioiTinh == true ? "Nam" : "Nữ",
        //            uv.NgaySinh.ToString(), uv.StrEmail, uv.StrSDT, uv.StrTrinhDo, uv.StrNgoaiNgu, uv.SoNam_KinhNghiem.ToString()});
        //        lvwDSUV.Items.Add(lvi);

        //        abstractUNGVIEN temp = new UngVienUngTuyen("123", "abc", true, DateTime.Parse("15/1/2019"), "email ne", "0909", "dai hoc"
        //            , "tao co ngoai ngu", 5, new int[] {1, 2}, new List<bool>{false, false});

           
        //        abstractUNGVIEN temp1 = new UngVienPheDuyet();

        //        DANHSACH_UNGVIEN DSnhung_thang_duoc_phe_duyet = new DANHSACH_UNGVIEN();
                  

        //        DSnhung_thang_duoc_phe_duyet.themungvien()

        //        List<UngVienPheDuyet> lst123 = new List<UngVienPheDuyet>();

        //    }

            
            //DSLoc = DSUV.LocUV();
        }

        



  


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DanhSachUngVien
    {
        public DataQuanLiTuyenDungDataContext db;
        List<AbsUngVien> lstUV;

        public List<AbsUngVien> _LstUV
        {
            get { return lstUV; }
            set { lstUV = value; }
        }


        public DanhSachUngVien()
        { 
            lstUV = new List<AbsUngVien>();
        }
        public DanhSachUngVien(List<AbsUngVien> lst)
        {
            this.lstUV = new List<AbsUngVien>(lst);
        }

        //public void Get_DSChuaDuocDeCu()
        //{
        //    var query = (from U in db.tblUNGVIENs
        //                 join V in db.tblVTTD_UNGTUYENs on U.MaUV equals V.MaUV_UV
        //                 where V.TrangThaiDC == false
        //                 select new { U, V }).Distinct().ToList();
        //    this.lstUV.Clear();
        //    foreach (var uv in query)
        //    {
        //        lstUV.Add(new UngVienUngTuyen(uv.U.MaUV, uv.U.TenUV, uv.U.GioiTinh.ToString() == "Nam" ? true : false,
        //            DateTime.Parse(uv.U.NgaySinh.ToString()), uv.U.Email, uv.U.CMND.ToString(), uv.U.SDT, uv.U.TrinhDoHV, uv.U.NgoaiNgu,
        //            (int)uv.U.SoNamKN, (int)uv.U.ID_NV, uv.U.CV.ToString(), uv.V.MaVT_VT, (bool)uv.V.TrangThaiDC, (bool)uv.V.TrangThaiPD));
        //    }

        //}


        public List<AbsUngVien> LocTheoViTri_UVUT(int mavt)
        {
            //lay danh sach tren DB
            var query = (from U in db.tblUNGVIENs
                         join V in db.tblVTTD_UNGTUYENs on U.MaUV equals V.MaUV_UV
                         where V.TrangThaiDC ==  false && V.MaVT_VT == mavt
                         select new{U,V}).Distinct().ToList();


            //do danh sach loc tu DB vao ds
            List<AbsUngVien> temp = new List<AbsUngVien>();
            foreach(var uv in query)
            {
                temp.Add(new UngVienUngTuyen(uv.U.MaUV,uv.U.TenUV, uv.U.GioiTinh.ToString() == "Nam"? true : false, 
                    DateTime.Parse(uv.U.NgaySinh.ToString()), uv.U.Email, uv.U.CMND.ToString(), uv.U.SDT,uv.U.TrinhDoHV,uv.U.NgoaiNgu,
                    (int)uv.U.SoNamKN, (int)uv.U.ID_NV, uv.U.CV.ToString(), uv.V.MaVT_VT, (bool)uv.V.TrangThaiDC, (bool)uv.V.TrangThaiPD));
            }
            return temp;

        }

        public List<AbsUngVien> LocTheoViTri_UVPD(int mavt)
        {
            var query = (from U in db.tblUNGVIENs
                         join V in db.tblVTTD_UNGTUYENs on U.MaUV equals V.MaUV_UV
                         where V.TrangThaiPD == true && V.MaVT_VT == mavt
                         select new { U, V }).Distinct().ToList();

            List<AbsUngVien> temp = new List<AbsUngVien>();
            foreach (var uv in query)
            {
                temp.Add(new UngVienPhongVan(uv.U.MaUV, uv.U.TenUV, uv.U.GioiTinh.ToString() == "Nam" ? true : false,
                    DateTime.Parse(uv.U.NgaySinh.ToString()), uv.U.Email, uv.U.CMND.ToString(), uv.U.SDT, uv.U.TrinhDoHV, uv.U.NgoaiNgu,
                    (int)uv.U.SoNamKN, (int)uv.U.ID_NV, uv.U.CV.ToString(), uv.V.MaVT_VT, new LichPhongVan()));
            }
            return temp;

        }

        
    }


}

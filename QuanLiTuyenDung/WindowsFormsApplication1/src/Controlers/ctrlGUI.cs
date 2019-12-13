using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Controlers
{
    public class ctrlGUI : Services.connDB
    {
        public ctrlGUI()
        {
            db.Connection.Open();
        }
        public List<src.Entitys.clsUngVien> getDSUngVienChuaDeCu()
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();
            var query = (from u in db.tblUNGVIENs
                         join v in db.tblVTTD_UNGTUYENs on u.MaUV equals v.MaUV_UV
                         where v.TrangThaiDC == false
                         select new { u, v }).Distinct().ToList();
            foreach (var uv in query)
            {

                lstUV.Add(new src.Entitys.clsUngVien((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV, (int)uv.v.MaVT_VT));
            }
            return lstUV;
        }
        public List<src.Entitys.clsViTriTuyenDung> GetVitriTuyenDung()
        {

            var query = (from VT in db.tblVITRI_TDs
                         select VT).ToList();

            List<src.Entitys.clsViTriTuyenDung> lst_Vttd = new List<src.Entitys.clsViTriTuyenDung>();

            foreach (var item in query)
            {
                src.Entitys.clsViTriTuyenDung vt = new src.Entitys.clsViTriTuyenDung((int)item.MaVT, item.TenVT, (int)item.SoLuong, item.DiaDiemLV, item.MoTa, item.YeuCau, item.QuyenLoi, item.Luong);
                lst_Vttd.Add(vt);
            }
            return lst_Vttd;
        }

        public List<string> GetTrinhDo()
        {
            var query = (from UV in db.tblUNGVIENs
                         select UV.TrinhDoHV).Distinct().ToList();
            List<string> lstTD = new List<string>();
            foreach (var item in query)
            {
                lstTD.Add(item);
            }
            return lstTD;
        }
        public List<string> GetNgoaiNgu()
        {
            var query = (from UV in db.tblUNGVIENs
                         select UV.NgoaiNgu).Distinct().ToList();
            List<string> lstNN = new List<string>();
            foreach (var item in query)
            {
                lstNN.Add(item);
            }
            return lstNN;
        }

        public List<src.Entitys.clsUngVien> GetUngVienDeCu()
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();
            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.TrangThaiDC == true).Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new src.Entitys.clsUngVien((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV, (int)uv.v.MaVT_VT));
            }
            return lstUV;
        }

        public List<src.Entitys.clsUngVien> GetUngVienDeCuChuaPheDuyet()
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();
            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.TrangThaiDC == true && uv.v.TrangThaiPD == false).Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new src.Entitys.clsUngVien((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV, (int)uv.v.MaVT_VT));
            }
            return lstUV;
        }

        public List<src.Entitys.clsUngVien> GetUVPheDuyetChuaCoLich()
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();
            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.TrangThaiPD == true && !db.tblLICHPV_UNGVIENs.Any(l => uv.u.MaUV == l.MaUV_UV))
                .Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new src.Entitys.clsUngVien((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV, (int)uv.v.MaVT_VT));
            }
            return lstUV;
        }

        public List<src.Entitys.clsUngVien> GetUVTrungTuyen()
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();
            var query = db.tblUNGVIENs
                .Join(db.tblLICHPV_UNGVIENs, u => u.MaUV, l => l.MaUV_UV, (u, l) => new { u,l}).Where(ul=> ul.l.KetQuaPV==true)
                .Distinct().ToList();
            foreach (var item in query)
            {
                lstUV.Add(new src.Entitys.clsUngVien((int)item.u.MaUV, item.u.TenUV, item.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(item.u.NgaySinh.ToString()), item.u.Email, item.u.CMND.ToString(), item.u.SDT, item.u.TrinhDoHV, 
                        item.u.NgoaiNgu, (int)item.u.SoNamKN, item.u.CV, (int)item.l.MaVT_VT));
            }
            return lstUV;
        }

        public List<src.Entitys.clsUngVien> GetUVChuaCapNhatKQPV()
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();
            var query = db.tblUNGVIENs.Join(db.tblLICHPV_UNGVIENs, u => u.MaUV, l => l.MaUV_UV, (u, l) => new { u, l }).Where(ul => ul.l.KetQuaPV == null)
                .Distinct().ToList();
            foreach (var ul in query)
            {
                lstUV.Add(new src.Entitys.clsUngVien((int)ul.u.MaUV, ul.u.TenUV, ul.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(ul.u.NgaySinh.ToString()), ul.u.Email, ul.u.CMND.ToString(), ul.u.SDT, ul.u.TrinhDoHV, ul.u.NgoaiNgu,
                        (int)ul.u.SoNamKN, ul.u.CV, (int)ul.l.MaVT_VT));
            }
            return lstUV;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Controlers
{
    class ctrlQLUngVien : Services.connDB
    {
        public ctrlQLUngVien()
        {
            db.Connection.Open();
        }

        public List<src.Entitys.clsUngVien> TimKiemUVDeCuTheoViTri(int maVT)
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();
            //get nhung ung vien co vi tri = maVT va TTDC = true
            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.MaVT_VT == maVT && uv.v.TrangThaiDC == true).Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new src.Entitys.clsUngVien((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV, (int)uv.v.MaVT_VT));
            }
            return lstUV;
        }

        public List<src.Entitys.clsUngVien> TimKiemUVTrungTuyenTheoViTri(int ma)
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();
            var query = db.tblUNGVIENs
                .Join(db.tblLICHPV_UNGVIENs, u => u.MaUV, l => l.MaUV_UV, (u, l) => new { u, l })
                .Where(ul => ul.l.KetQuaPV == true && ul.l.MaVT_VT == ma)
                .Distinct().ToList();
            foreach (var item in query)
            {
                lstUV.Add(new src.Entitys.clsUngVien((int)item.u.MaUV, item.u.TenUV, item.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(item.u.NgaySinh.ToString()), item.u.Email, item.u.CMND.ToString(), item.u.SDT, item.u.TrinhDoHV,
                        item.u.NgoaiNgu, (int)item.u.SoNamKN, item.u.CV, (int)item.l.MaVT_VT));
            }
            return lstUV;
        }

        public List<src.Entitys.clsUngVien> TimKiemUVPVChuaCapNhatTheoLich(int maVT, int maL)
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();

            var query = db.tblUNGVIENs.Join(db.tblLICHPV_UNGVIENs, u => u.MaUV, l => l.MaUV_UV, (u, l) => new { u, l })
                .Where(ul => ul.l.KetQuaPV == null && ul.l.MaVT_VT == maVT && ul.l.MaLich_L == maL)
                .Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new src.Entitys.clsUngVien((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV, (int)uv.l.MaVT_VT));
            }
            return lstUV;
        }

        public List<src.Entitys.clsUngVien> TimKiemUVTheoViTri_Lich(int maVT, int maL)
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();

            var query = db.tblUNGVIENs.Join(db.tblLICHPV_UNGVIENs, u => u.MaUV, l => l.MaUV_UV, (u, l) => new { u, l })
                .Where(ul => ul.l.MaVT_VT == maVT && ul.l.MaLich_L == maL)
                .Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new src.Entitys.clsUngVien((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV, (int)uv.l.MaVT_VT));
            }
            return lstUV;
        }

    }
}

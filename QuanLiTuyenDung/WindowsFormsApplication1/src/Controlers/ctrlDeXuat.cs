
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1.src.Controlers
{
    public class ctrlDeXuat : src.Services.connDB
    {
        public ctrlDeXuat()
        {
            db.Connection.Open();
        }
        //Byte[] nhap_bye(Byte[] a)
        //{
        //    Byte[] b = null;
        //    for (int i = 0; i < a.Count(); i++)
        //    {
        //        b[i] = a[i];
        //    }
        //    return b;
        //}
        public List<src.Entitys.clsUngVien> TimKiemTheoViTri(int maVT)
        {

            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();
            //get nhung ung vien co vi tri = maVT va TTDC = false
            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.MaVT_VT == maVT && uv.v.TrangThaiDC == false).Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new src.Entitys.clsUngVien((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV, (int)uv.v.MaVT_VT));
            }
            return lstUV;
        }


        public List<src.Entitys.clsUngVien> LocTheoTrinhDo(List<src.Entitys.clsUngVien> lstUV_TK, string trinhDoHV)
        {
            List<src.Entitys.clsUngVien> dsLoc = new List<src.Entitys.clsUngVien>();
            foreach (var i in lstUV_TK)
            {
                if (i._StrTrinhDo == trinhDoHV)
                {
                    dsLoc.Add(i);
                }
            }
            return dsLoc;
        }

        public List<src.Entitys.clsUngVien> LocTheoNgoaiNgu(List<src.Entitys.clsUngVien> lstUV_TK, string ngoaiNgu)
        {
            List<src.Entitys.clsUngVien> dsLoc = new List<src.Entitys.clsUngVien>();
            foreach (var i in lstUV_TK)
            {
                if (i._StrNgoaiNgu == ngoaiNgu)
                {
                    dsLoc.Add(i);
                }
            }
            return dsLoc;
        }

        public List<src.Entitys.clsUngVien> LocTheoNamKinhNghiem(List<src.Entitys.clsUngVien> lstUV_TK, string namKinhNghiem)
        {
            int soNam = -1;
            List<src.Entitys.clsUngVien> dsLoc = new List<src.Entitys.clsUngVien>();
            if (namKinhNghiem == "Chưa có kinh nghiệm")//namKN = 0
            {
                soNam = 0;
                foreach (var i in lstUV_TK)
                {
                    if (i._SoNam_KinhNghiem == soNam)
                    {
                        dsLoc.Add(i);
                    }
                }
            }
            else if (namKinhNghiem == "Dưới 1 năm")//namKN = 1
            {
                soNam = 1;
                foreach (var i in lstUV_TK)
                {
                    if (i._SoNam_KinhNghiem == soNam)
                    {
                        dsLoc.Add(i);
                    }
                }
            }
            else if (namKinhNghiem == "Trên 5 năm")//namKN > 5
            {
                soNam = 5;
                foreach (var i in lstUV_TK)
                {
                    if (i._SoNam_KinhNghiem > soNam)
                    {
                        dsLoc.Add(i);
                    }
                }
            }
            else if (namKinhNghiem == "Trên 3 năm")//namKN > 3
            {
                soNam = 3;
                foreach (var i in lstUV_TK)
                {
                    if (i._SoNam_KinhNghiem > soNam)
                    {
                        dsLoc.Add(i);
                    }
                }
            }
            else if (namKinhNghiem == "Trên 1 năm") // namKN > 1
            {
                soNam = 1;
                foreach (var i in lstUV_TK)
                {
                    if (i._SoNam_KinhNghiem > soNam)
                    {
                        dsLoc.Add(i);
                    }
                }
            }
            
            return dsLoc;
        }


        public void ChuyenDSUV(List<src.Entitys.clsUngVien> dsNguon, List<src.Entitys.clsUngVien> dsDich, src.Entitys.clsUngVien uvChuyen)
        {
            //clsUngVienUngTuyen uv = new clsUngVienUngTuyen();
            //uv = uvChuyen;
            dsDich.Add(uvChuyen);
            dsNguon.Remove(uvChuyen);
        }
        public List<src.Entitys.clsUngVien> LocUV_theoVitri(List<src.Entitys.clsUngVien> dsUV, int maVT)
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();
            foreach (src.Entitys.clsUngVien item in dsUV)
            {
                if (item._MaVT == maVT)
                    lstUV.Add(new Entitys.clsUngVien(item));
            }
            return lstUV;
        }
    }
}

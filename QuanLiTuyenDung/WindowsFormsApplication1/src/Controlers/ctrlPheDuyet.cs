using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Controlers
{
    public class ctrlPheDuyet : Services.connDB
    {
        public ctrlPheDuyet()
        {
            db.Connection.Open();
        }


        


        public List<src.Entitys.clsUngVien> TimKiemUVDeCuChuaPDTheoViTri(int maVT)
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();
            //get nhung ung vien co vi tri = maVT va TTDC = true
            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.MaVT_VT == maVT && uv.v.TrangThaiDC == true && uv.v.TrangThaiPD == false).Distinct().ToList();
            foreach (var uv in query)
            {
                lstUV.Add(new src.Entitys.clsUngVien((int)uv.u.MaUV, uv.u.TenUV, uv.u.GioiTinh.ToString() == "Nam" ? true : false,
                        DateTime.Parse(uv.u.NgaySinh.ToString()), uv.u.Email, uv.u.CMND.ToString(), uv.u.SDT, uv.u.TrinhDoHV, uv.u.NgoaiNgu,
                        (int)uv.u.SoNamKN, uv.u.CV, (int)uv.v.MaVT_VT));
            }
            return lstUV;
        }




    }
}


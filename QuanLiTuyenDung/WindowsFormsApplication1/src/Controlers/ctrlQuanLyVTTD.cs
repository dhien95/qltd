using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Controlers
{
    class ctrlQuanLyVTTD : Services.connDB
    {
        public ctrlQuanLyVTTD()
        {
            db.Connection.Open();
        }

        public List<src.Entitys.clsViTriTuyenDung> GetViTriTuyenDung()
        {
            List<src.Entitys.clsViTriTuyenDung> lstVT = new List<src.Entitys.clsViTriTuyenDung>();
            var query = db.tblVITRI_TDs.Select(vt => vt).Distinct().ToList();
            foreach (var item in query)
            {
                src.Entitys.clsViTriTuyenDung vt = new src.Entitys.clsViTriTuyenDung((int)item.MaVT, item.TenVT, (int)item.SoLuong, item.DiaDiemLV, item.MoTa, item.YeuCau, item.QuyenLoi, item.Luong);
                lstVT.Add(vt);
            }
            return lstVT;
        }
        public List<string> GetTenVT(List<src.Entitys.clsViTriTuyenDung> lstVT)
        {
            List<string> lstTenVT = new List<string>();
            foreach (var item in lstVT)
            {
                lstTenVT.Add(item._StrTenViTri);
            }
            return lstTenVT;
        }
    }
}

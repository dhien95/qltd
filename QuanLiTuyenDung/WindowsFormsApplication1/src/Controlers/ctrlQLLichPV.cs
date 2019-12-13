using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace WindowsFormsApplication1.src.Controlers
{
    class ctrlQLLichPV : src.Services.connDB
    {
        public ctrlQLLichPV()
        {
            db.Connection.Open();
        }


        public void GuiMailTuDong(string from, string to, string subject, string message)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("dqphuog@gmail.com", "dqphuong@1234");
            client.Send(mess);

        }
        
        public int GetMaLich(DateTime tg)
        {
            int ma;
            var query = db.tblLICH_PVs.Where(l => l.ThoiGian == tg).Select(l => l.MaLich).FirstOrDefault();
            ma = (int)query;
            return ma;
        }

        public List<src.Entitys.clsLichPhongVan> GetLichPVTheoViTri(int ma)
        {
            List<src.Entitys.clsLichPhongVan> lstLich = new List<src.Entitys.clsLichPhongVan>();
            var query = db.tblLICHPV_UNGVIENs.Where(lv => lv.MaVT_VT == ma)
                .Join(db.tblLICH_PVs, lv => lv.MaLich_L, l => l.MaLich, (lv, l) => new { l })
                .Distinct().ToList();
            foreach (var item in query)
            {
                src.Entitys.clsLichPhongVan lich = new src.Entitys.clsLichPhongVan(item.l.MaLich, item.l.ThoiGian, item.l.DiaDiem);
                lstLich.Add(lich);
            }
            return lstLich;
        }

        public List<src.Entitys.clsUngVien> GetUVPDChuaCoLichTheoViTri(int maVT)
        {
            List<src.Entitys.clsUngVien> lstUV = new List<src.Entitys.clsUngVien>();

            var query = db.tblUNGVIENs.Join(db.tblVTTD_UNGTUYENs, u => u.MaUV, v => v.MaUV_UV, (u, v) => new { u, v })
                .Where(uv => uv.v.MaVT_VT == maVT && uv.v.TrangThaiPD == true && 
                !db.tblLICHPV_UNGVIENs.Any(l => uv.u.MaUV == l.MaUV_UV)).Distinct().ToList();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApplication1.src.Services
{
    class connDBWeb : connDB
    {
        public src.DAOs.DB_WEB1.DataWebTD1DataContext dbWeb = new DAOs.DB_WEB1.DataWebTD1DataContext();
        public connDBWeb()
        {
            db.Connection.Open();
        }

        public src.DAOs.DB_QLTD.tblUNGVIEN TaoUngVien(src.DAOs.DB_WEB1.UNGVIEN item)
        {
            src.DAOs.DB_QLTD.tblUNGVIEN uv = new DAOs.DB_QLTD.tblUNGVIEN();
            uv.TenUV = item.TenUV;
            uv.CMND = item.CMND;
            uv.GioiTinh = item.GioiTinh;
            uv.NgaySinh = item.NgaySinh;
            uv.SDT = item.SDT;
            uv.Email = item.Email;
            uv.CV = item.CV.ToString();
            uv.NgoaiNgu = item.NgoaiNgu;
            uv.TrinhDoHV = item.TrinhDoHV;
            uv.SoNamKN = item.SoNamKN;
            return uv;
        }

        public int GetDLUngVien()
        {
            dbWeb.Connection.Open();
            int count = 0;
            var viTri = db.tblVITRI_TDs.Select(t => new { t.MaVT, t.TenVT }).ToList();
            
            foreach (var vt in viTri)
            {               
                var query = dbWeb.UNGVIENs.Where(u => (dbWeb.VTTD_UNGTUYENs
                .Join(dbWeb.VITRITUYENDUNGs, v_u => v_u.MaVT_VT, v => v.MaVT, (v_u, v) => new { v_u, v }))
                .Where(uvvt=>uvvt.v.TenVT==vt.TenVT)
                .Any(item => item.v_u.MaUV_UV == u.MaUV)).Distinct().ToList();

                foreach (var item in query)
                {
                    var check = db.tblUNGVIENs.Where(u => u.CMND == item.CMND).FirstOrDefault();
                    if (check == null)
                    {
                        var uv = TaoUngVien(item);
                        db.tblUNGVIENs.InsertOnSubmit(uv);
                        db.SubmitChanges();
                        count++;

                        var maU = db.tblUNGVIENs.Select(u => u.MaUV)
                            .Where(u => !db.tblVTTD_UNGTUYENs
                            .Any(v => v.MaUV_UV == u)).Distinct().ToList();

                        foreach (var ma in maU)
                        {
                            src.DAOs.DB_QLTD.tblVTTD_UNGTUYEN v_u = new DAOs.DB_QLTD.tblVTTD_UNGTUYEN();
                            v_u.MaUV_UV = ma;
                            v_u.MaVT_VT = vt.MaVT;
                            v_u.TrangThaiDC = false;
                            db.tblVTTD_UNGTUYENs.InsertOnSubmit(v_u);
                            count++;
                        }
                        db.SubmitChanges();
                    }
                    else
                    {
                        var temp = db.tblVTTD_UNGTUYENs.Where(v => v.MaVT_VT == vt.MaVT).FirstOrDefault();
                        if (temp == null)
                        {
                            src.DAOs.DB_QLTD.tblVTTD_UNGTUYEN v_u = new DAOs.DB_QLTD.tblVTTD_UNGTUYEN();
                            v_u.MaUV_UV = check.MaUV;
                            v_u.MaVT_VT = vt.MaVT;
                            v_u.TrangThaiDC = false;
                            db.tblVTTD_UNGTUYENs.InsertOnSubmit(v_u);
                            count++;
                            db.SubmitChanges();
                        }
                    }
                }
            }
            return count;
        }
        

    }

}



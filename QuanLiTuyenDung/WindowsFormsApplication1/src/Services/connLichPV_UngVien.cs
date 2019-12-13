using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Services
{
    class connLichPV_UngVien: connDB
    {
        public connLichPV_UngVien()
        {
            db.Connection.Open();
        }

        public void ThemLichPV_UngVien(List<src.Entitys.clsUngVien> lstUV, int maLich)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;

                foreach (var item in lstUV)
                {
                    DAOs.DB_QLTD.tblLICHPV_UNGVIEN lpv = new DAOs.DB_QLTD.tblLICHPV_UNGVIEN();
                    lpv.MaLich_L = maLich;
                    lpv.MaUV_UV = item._MaUV;
                    lpv.MaVT_VT = item._MaVT;
                    db.tblLICHPV_UNGVIENs.InsertOnSubmit(lpv);
                    
                }
                db.SubmitChanges();
                db.Transaction.Commit();
                
            }
            catch(Exception ex)
            {
                db.Transaction.Rollback();
                throw new Exception(ex.ToString());

            }
        }

        public bool CapNhatKQPV(int maVT, int maLich, int maUV)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;
                var query = db.tblLICHPV_UNGVIENs.Where(l => l.MaLich_L == maLich && l.MaUV_UV == maUV && l.MaVT_VT == maVT).FirstOrDefault();
                if (query != null)
                {
                    query.KetQuaPV = true;
                }
                
                db.SubmitChanges();
                db.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                db.Transaction.Rollback();
                throw new Exception(ex.ToString());

            }
        }

    }
}

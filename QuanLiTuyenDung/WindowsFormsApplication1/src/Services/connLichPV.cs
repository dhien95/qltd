using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Services
{
    class connLichPV : connDB
    {
        public connLichPV()
        {
            db.Connection.Open();
        }

        public bool ThemLichPV(src.Entitys.clsLichPhongVan lpv)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;

                DAOs.DB_QLTD.tblLICH_PV lichPV = new DAOs.DB_QLTD.tblLICH_PV();
                lichPV.ThoiGian = lpv._ThoiGian;
                lichPV.DiaDiem = lpv._StrDiaDiem;
                
                db.tblLICH_PVs.InsertOnSubmit(lichPV);
                db.SubmitChanges();

                db.Transaction.Commit();
                return true;
            }
            catch
            {
                db.Transaction.Rollback();
                return false;
            }
        }
    }
}

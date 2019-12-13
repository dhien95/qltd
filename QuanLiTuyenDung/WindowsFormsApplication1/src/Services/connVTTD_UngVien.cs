using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Services
{
    class connVTTD_UngVien : connDB
    {
        public connVTTD_UngVien()
        {
            db.Connection.Open();
        }
        public bool UpdateTrangThaiDeCu(List<src.Entitys.clsUngVien> dsuvUpdate)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;
                foreach (var item in dsuvUpdate)
                {
                    var s = db.tblVTTD_UNGTUYENs.Where(t => t.MaUV_UV == item._MaUV && t.MaVT_VT == item._MaVT).FirstOrDefault();
                    s.TrangThaiDC = true;
                    db.SubmitChanges();
                }                
                db.Transaction.Commit();
                return true;
            }
            catch
            {
                db.Transaction.Rollback();
                return false;
               
            }
        }

        public bool UpdateTrangThaiPD(List<src.Entitys.clsUngVien> dsuvUpdate)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;
                foreach (var item in dsuvUpdate)
                {
                    var s = db.tblVTTD_UNGTUYENs.Where(t => t.MaUV_UV == item._MaUV && t.MaVT_VT == item._MaVT).FirstOrDefault();
                    s.TrangThaiPD = true;
                    db.SubmitChanges();
                }
                db.Transaction.Commit();
                return true;
            }
            catch
            {
                db.Transaction.Rollback();
                return false;
            }
        }


        public bool UpdateTrangThaiDeCu_False(List<src.Entitys.clsUngVien> dsuvUpdate)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;
                foreach (var item in dsuvUpdate)
                {
                    var uv = db.tblVTTD_UNGTUYENs.Where(t => t.MaUV_UV == item._MaUV && t.MaVT_VT == item._MaVT).FirstOrDefault();
                    uv.TrangThaiDC = false;
                    uv.TrangThaiPD = false;
                    db.SubmitChanges();
                }
                db.Transaction.Commit();
                return true;
            }
            catch
            {
                db.Transaction.Rollback();
                return false;

            }
        }

        public bool UpdateTrangThaiPD_False(List<src.Entitys.clsUngVien> dsuvUpdate)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;
                foreach (var item in dsuvUpdate)
                {
                    var s = db.tblVTTD_UNGTUYENs.Where(t => t.MaUV_UV == item._MaUV && t.MaVT_VT == item._MaVT).FirstOrDefault();
                    s.TrangThaiPD = false;
                    db.SubmitChanges();
                }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Services
{
    public class connVTTD : connDB
    {
        public connVTTD()
        {
            db.Connection.Open();
        }

        public bool ThemVTTD(src.Entitys.clsViTriTuyenDung uvAdd)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;

                src.DAOs.DB_QLTD.tblVITRI_TD vt = new DAOs.DB_QLTD.tblVITRI_TD();
                //vt.MaVT = 12;
                var a = vt.TenVT = uvAdd._StrTenViTri;
                vt.SoLuong = uvAdd._SoLuong;
                vt.DiaDiemLV = uvAdd._StrDiaDiemLV;
                vt.Luong = uvAdd._MucLuong;
                vt.MoTa = uvAdd._StrMoTa;
                vt.YeuCau = uvAdd._StrYeuCau;
                vt.QuyenLoi = uvAdd._StrQuyenLoi;
                db.tblVITRI_TDs.InsertOnSubmit(vt);
                db.SubmitChanges();

                db.Transaction.Commit();
                return true;
            }
            catch
            {
                db.Transaction.Rollback();
                //throw new Exception(ex.ToString());
                return false;
            }
        }

        

        public bool XoaVTTD(int maVTDelete)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;
                
                //Xóa dữ liệu ở bảng ứng VTTD_UngTuyen
                var vt_uv = db.tblVTTD_UNGTUYENs.Where(v_u => v_u.MaVT_VT == maVTDelete).ToList();
                foreach (var item in vt_uv)
                {
                    db.tblVTTD_UNGTUYENs.DeleteOnSubmit(item);
                }

                //Xóa dữ liệu ở bảng VTTD
                var vt = db.tblVITRI_TDs.Where(v => v.MaVT == maVTDelete).FirstOrDefault();                
                db.tblVITRI_TDs.DeleteOnSubmit(vt);

                db.SubmitChanges();
                db.Transaction.Commit();
                return true;
            }
            catch
            {
                db.Transaction.Rollback();
                //throw new Exception(ex.ToString());
                return false;
            }
        }

        
    }
}

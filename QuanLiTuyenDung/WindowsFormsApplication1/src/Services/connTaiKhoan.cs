using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Services
{
    public class connTaiKhoan : connDB
    {
        public connTaiKhoan()
        {
            db.Connection.Open();
        }

        public bool ThemTaiKhoan(src.Entitys.clsTaiKhoan tkAdd)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;

                src.DAOs.DB_QLTD.tblTAIKHOAN tk = new DAOs.DB_QLTD.tblTAIKHOAN();
                //vt.MaVT = 12;
                tk.ID_NV = tkAdd._Id_NV;
                tk.Usernames = tkAdd._StrUsername;
                tk.Passwords = tkAdd._StrPassWord;
                tk.MaRole_R = tkAdd._MaRole;
                db.tblTAIKHOANs.InsertOnSubmit(tk);
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

        public bool XoaTaiKhoan(int maTKDelete)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;
                var tk = db.tblTAIKHOANs.Where(t => t.ID_NV == maTKDelete).FirstOrDefault();
                db.tblTAIKHOANs.DeleteOnSubmit(tk);
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

        public bool DoiMatKhau(string username, string newPassword)
        {
            System.Data.Common.DbTransaction suaTran = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = suaTran;
                var s = db.tblTAIKHOANs.Where(t => t.Usernames == username).FirstOrDefault();

                s.Passwords = newPassword;
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

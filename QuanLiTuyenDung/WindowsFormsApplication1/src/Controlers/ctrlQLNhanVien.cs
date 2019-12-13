using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Controlers
{
    class ctrlQLNhanVien : Services.connDB
    {
        public ctrlQLNhanVien()
        {
            db.Connection.Open();
        }

        public List<src.Entitys.clsNhanVienTuyenDung> GetDSNVChuaCoTK()
        {
            List<src.Entitys.clsNhanVienTuyenDung> lstNV = new List<src.Entitys.clsNhanVienTuyenDung>();
            var query = db.tblNHANVIENs.Where(n => !db.tblTAIKHOANs.Any(tk => n.ID == tk.ID_NV)).Distinct().ToList();
            foreach (var i in query)
            {
                src.Entitys.clsNhanVienTuyenDung nv = new src.Entitys.clsNhanVienTuyenDung();
                nv._Id_NV = i.ID.ToString();
                nv._StrHoTen_NV = i.TenNV;
                nv._StrChucVu = i.ChucVu;
                lstNV.Add(nv);
            }
            return lstNV;
        }

        public List<src.Entitys.clsNhanVienTuyenDung> GetDSNVDaCoTK()
        {
            List<src.Entitys.clsNhanVienTuyenDung> lstNV = new List<src.Entitys.clsNhanVienTuyenDung>();
            var query = db.tblNHANVIENs.Where(n => db.tblTAIKHOANs.Any(tk => n.ID == tk.ID_NV)).ToList();
            foreach (var i in query)
            {
                src.Entitys.clsNhanVienTuyenDung nv = new src.Entitys.clsNhanVienTuyenDung();
                nv._Id_NV = i.ID.ToString();
                nv._StrHoTen_NV = i.TenNV;
                nv._StrChucVu = i.ChucVu;
                lstNV.Add(nv);
            }
            return lstNV;
        }

        public List<src.Entitys.clsRole> GetDataForcboRole()
        {
            List<src.Entitys.clsRole> lstRole = new List<src.Entitys.clsRole>();
            var query = db.tblROLEs.Select(t => t).ToList();
            foreach (var item in query)
            {
                src.Entitys.clsRole r = new src.Entitys.clsRole((int)item.MaRole, item.TenRole, item.MoTa);
                lstRole.Add(r);
            }
            
            return lstRole;
        }

        public string[] GetThongTinChoTaiKhoan(int maTK)
        {
            //List<String> lstTTTK = new List<String>();
            var query = db.tblROLEs.Join(db.tblTAIKHOANs, r => r.MaRole, t => t.MaRole_R, (r, t) => new { r, t })
                        .Where(rt => rt.t.ID_NV == maTK).Select(rt => new { rt.t.ID_NV, rt.r.TenRole, rt.t.Passwords, rt.t.Usernames }).FirstOrDefault();

            string[] thongtinTK = new string[] { query.ID_NV.ToString(), query.Usernames, query.Passwords, query.TenRole };
            return thongtinTK;
        }
    }
}

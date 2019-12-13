using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TruongPhongTuyenDung : NhanVienTuyenDung
    {
        public TruongPhongTuyenDung() : base()
        {

        }

        public TruongPhongTuyenDung(int id, string hoTen, string chucVu, string quyenHan, TaiKhoan taiKhoan) : base(id, hoTen, chucVu, quyenHan, taiKhoan)
        {

        }


    }
}

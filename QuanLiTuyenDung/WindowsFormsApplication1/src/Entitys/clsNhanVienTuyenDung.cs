using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Entitys
{
   public class clsNhanVienTuyenDung
    {
        private string id_NV;
        private string strHoTen_NV;
        private string strChucVu;
        //private string strQuyenHan;
        private clsTaiKhoan tk;

        public string _Id_NV
        {
            get
            {
                return id_NV;
            }

            set
            {
                id_NV = value;
            }
        }

        public string _StrHoTen_NV
        {
            get
            {
                return strHoTen_NV;
            }

            set
            {
                strHoTen_NV = value;
            }
        }

        public string _StrChucVu
        {
            get
            {
                return strChucVu;
            }

            set
            {
                strChucVu = value;
            }
        }

        //public string _StrQuyenHan
        //{
        //    get
        //    {
        //        return strQuyenHan;
        //    }

        //    set
        //    {
        //        strQuyenHan = value;
        //    }
        //}

        protected clsTaiKhoan _Tk
        {
            get
            {
                return tk;
            }

            set
            {
                tk = value;
            }
        }

        public clsNhanVienTuyenDung()
        {
            this.id_NV = null;
            this.strHoTen_NV = null;
            this.strChucVu = null;
            //this.strQuyenHan = null;
            this.tk = null;

        }
        public clsNhanVienTuyenDung(string id, string hoTen, string chucVu, clsTaiKhoan taiKhoan)
        {
            this.id_NV = null;
            this.strHoTen_NV = hoTen;
            this.strChucVu = chucVu;
            //this.strQuyenHan = quyenHan;
            this.tk = taiKhoan;
        }
    }
}

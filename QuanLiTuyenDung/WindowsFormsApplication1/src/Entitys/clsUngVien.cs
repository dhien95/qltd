using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Entitys
{
  public  class clsUngVien
    {
        private int maUV;
        private string strTenUV;
        private bool gioiTinh; // true: Nam, false: Nữ
        private DateTime ngaySinh;
        private string strCMND;
        private string strEmail;
        private string strSDT;
        private string strTrinhDo;
        private string strNgoaiNgu;
        protected int soNam_KinhNghiem;
        private string strCV;
        private int maVT;



        //getter-setter      
        public int _MaUV
        {
            get
            {
                return maUV;
            }

            set
            {
                maUV = value;
            }
        }
        public string _StrTenUV
        {
            get
            {
                return strTenUV;
            }

            set
            {
                strTenUV = value;
            }
        }
        public DateTime _NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }
        public bool _GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }
        public string _StrEmail
        {
            get
            {
                return strEmail;
            }

            set
            {
                strEmail = value;
            }
        }
        public string _StrSDT
        {
            get
            {
                return strSDT;
            }

            set
            {
                strSDT = value;
            }
        }
        public string _StrTrinhDo
        {
            get
            {
                return strTrinhDo;
            }

            set
            {
                strTrinhDo = value;
            }
        }
        public string _StrNgoaiNgu
        {
            get
            {
                return strNgoaiNgu;
            }

            set
            {
                strNgoaiNgu = value;
            }
        }
        public int _SoNam_KinhNghiem
        {
            get
            {
                return soNam_KinhNghiem;
            }

            set
            {
                soNam_KinhNghiem = value;
            }
        }
        public string _StrCMND
        {
            get
            {
                return strCMND;
            }

            set
            {
                strCMND = value;
            }
        }
        public string _StrCV
        {
            get { return strCV; }
            set { strCV = value; }
        }
        public int _MaVT
        {
            get { return maVT; }
            set { maVT = value; }
        }



        public clsUngVien()
        {
            this.maUV = -1;
            this.strTenUV = null;
            this.ngaySinh = DateTime.Now;
            this.gioiTinh = true;
            this.strSDT = null;
            this.strEmail = null;
            this.strCMND = null;
            this.strTrinhDo = null;
            this.strNgoaiNgu = null;
            this.soNam_KinhNghiem = -1;
            this.strCV = null;
            this.maVT = -1;

        }
        public clsUngVien(int maUV, string tenUV, bool gt, DateTime ngaySinh, string email, string soCMND, string sdt, string trinhDo,
           string ngoaiNgu, int namKN, string cv, int mavitri)
        {
            this.maUV = maUV;
            this.strTenUV = tenUV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gt;
            this.strSDT = sdt;
            this.strEmail = email;
            this.strCMND = soCMND;
            this.strTrinhDo = trinhDo;
            this.strNgoaiNgu = ngoaiNgu;
            this.soNam_KinhNghiem = namKN;
            this.strCV = cv;
            this.maVT = mavitri;
        }
        public clsUngVien(src.Entitys.clsUngVien uv)
        {
            this.maUV = uv._MaUV;
            this.strTenUV = uv.strTenUV;
            this.ngaySinh = uv._NgaySinh;
            this.gioiTinh = uv._GioiTinh;
            this.strSDT = uv._StrSDT;
            this.strEmail = uv._StrEmail;
            this.strCMND = uv._StrCMND;
            this.strTrinhDo = uv._StrTrinhDo;
            this.strNgoaiNgu = uv._StrNgoaiNgu;
            this.soNam_KinhNghiem = uv._SoNam_KinhNghiem;
            this.strCV = uv._StrCV;
            this.maVT = uv._MaVT;
        }
        
    }
}

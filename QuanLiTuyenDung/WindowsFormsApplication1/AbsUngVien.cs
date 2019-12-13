using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class  AbsUngVien
    {
        protected int maUV;
        protected string strTenUV;
        protected bool gioiTinh; // true: Nam, false: Nữ
        protected DateTime ngaySinh;
        protected string strCMND;
        protected string strEmail;
        protected string strSDT;
        protected string strTrinhDo;
        protected string strNgoaiNgu;
        protected int soNam_KinhNghiem;
        protected int ID_NV;
        protected string strCV;
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
        public int _ID_NV
        {
            get
            {
                return ID_NV;
            }

            set
            {
                ID_NV = value;
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

     
   
        public AbsUngVien()
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
            this.ID_NV = -1;
            this.strCV = "";
            this.maVT = -1;
            
        }
         public AbsUngVien(int maUV, string tenUV, bool gt, DateTime ngaySinh, string email, string soCMND, string sdt, string trinhDo, 
            string ngoaiNgu, int namKN, int maNV, string cv, int mavitri)
        {
            this.maUV = maUV;
            this.strTenUV = tenUV;
            this.ngaySinh = DateTime.Now;
            this.gioiTinh = gt;
            this.strSDT = sdt;
            this.strEmail = email;
            this.strCMND = soCMND;
            this.strTrinhDo = trinhDo;
            this.strNgoaiNgu = ngoaiNgu;
            this.soNam_KinhNghiem = namKN;
            this.ID_NV = maNV;
            this.strCV = cv;
            this.maVT = mavitri;
     
        }


        //public abstract 
    }
}

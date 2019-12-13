using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ViTriTuyenDung
    {
        private int maVT;
        private string strTenViTri;
        private int soLuong;
        private string strDiaDiemLV;
        private DateTime ngayHetHan;
        private string strMoTa;
        private string strYeuCau;
        private string strQuyenLoi;

        public int _MaVT
        {
            get
            {
                return maVT;
            }

            set
            {
                maVT = value;
            }
        }

        public string _StrTenViTri
        {
            get
            {
                return strTenViTri;
            }

            set
            {
                strTenViTri = value;
            }
        }

        public int _SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public string _StrDiaDiemLV
        {
            get
            {
                return strDiaDiemLV;
            }

            set
            {
                strDiaDiemLV = value;
            }
        }

        public DateTime _NgayHetHan
        {
            get
            {
                return ngayHetHan;
            }

            set
            {
                ngayHetHan = value;
            }
        }

        public string _StrMoTa
        {
            get
            {
                return strMoTa;
            }

            set
            {
                strMoTa = value;
            }
        }

        public string _StrYeuCau
        {
            get
            {
                return strYeuCau;
            }

            set
            {
                strYeuCau = value;
            }
        }

        public string _StrQuyenLoi
        {
            get
            {
                return strQuyenLoi;
            }

            set
            {
                strQuyenLoi = value;
            }
        }

        public ViTriTuyenDung()
        {
            this.maVT = -1;
            this.strTenViTri = null;
            this.soLuong = -1;
            this.strDiaDiemLV = null;
            this.ngayHetHan = DateTime.Now;
            this.strMoTa = null;
            this.strYeuCau = null;
            this.strQuyenLoi = null;
        
        }

        public ViTriTuyenDung(int ma, string tenVT, int sl, string ddlv, DateTime ngayHH, string moTa, string yeuCau, string quyenLoi)
        {
            this.maVT = ma;
            this.strTenViTri = tenVT;
            this.soLuong = sl;
            this.strDiaDiemLV = ddlv;
            this.ngayHetHan = ngayHH;
            this.strMoTa = moTa;
            this.strYeuCau = yeuCau;
            this.strQuyenLoi = quyenLoi;
        }
    }
}

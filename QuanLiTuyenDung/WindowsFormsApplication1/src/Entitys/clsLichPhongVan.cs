using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Entitys
{
   public class clsLichPhongVan
    {
        private int maLich;
        private DateTime thoiGian;
        private string strDiaDiem;

        public int _MaLich
        {
            get
            {
                return maLich;
            }

            set
            {
                maLich = value;
            }
        }

        public DateTime _ThoiGian
        {
            get
            {
                return thoiGian;
            }

            set
            {
                thoiGian = value;
            }
        }

        public string _StrDiaDiem
        {
            get
            {
                return strDiaDiem;
            }

            set
            {
                strDiaDiem = value;
            }
        }
        public clsLichPhongVan()
        {
            this.maLich = -1;
            this.thoiGian = DateTime.Now;
            this.strDiaDiem = null;
        }

        public clsLichPhongVan(int ma, DateTime tg, string diaDiem)
        {
            this.maLich = ma;
            this.thoiGian = tg;
            this.strDiaDiem = diaDiem;
        }
        public clsLichPhongVan(clsLichPhongVan lichpv)
        {
            this.maLich = lichpv._MaLich;
            this.thoiGian = lichpv._ThoiGian;
            this.strDiaDiem = lichpv._StrDiaDiem;
        }
    }
}

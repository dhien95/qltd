using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class LichPhongVan
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
        public LichPhongVan()
        {
            this.maLich = -1;
            this.thoiGian = DateTime.Now;
            this.strDiaDiem = null;

        }

        public LichPhongVan(int ma, DateTime tg, string diaDiem)
        {
            this.maLich = ma;
            this.thoiGian = tg;
            this.strDiaDiem = diaDiem;

        }
        public LichPhongVan(LichPhongVan lich)
        {
            
            this.maLich = lich._MaLich;
            this.thoiGian = lich._ThoiGian;
            this.strDiaDiem = lich._StrDiaDiem;

        }

    }
}

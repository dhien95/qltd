using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class UngVienPhongVan : AbsUngVien
    {
        private LichPhongVan lichPV;

        public LichPhongVan _LichPV
        {
            get { return lichPV; }
            set { lichPV = value; }
        }

   

        public UngVienPhongVan() : base()
        {
            this.lichPV = new LichPhongVan();
        }

        public UngVienPhongVan(int maUV, string tenUV, bool gt, DateTime ngaySinh, string email, string soCMND, string sdt, string trinhDo,
            string ngoaiNgu, int namKN , int maNV, string cv, int mavitri, LichPhongVan lichPV)
            : base( maUV,  tenUV,  gt,  ngaySinh,  email,  soCMND,  sdt,  trinhDo, 
             ngoaiNgu,  namKN,  maNV,  cv,  mavitri)
        {
            this.lichPV = new LichPhongVan(lichPV);
        }

        
    }
}

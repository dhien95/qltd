using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class UngVienUngTuyen : AbsUngVien
    {
        private bool trangThaiDeCu;
        private bool trangThaiPheDuyet;


        public bool _TrangThaiDeCu
        {
            get { return trangThaiDeCu; }
            set { trangThaiDeCu = value; }
        }
        public bool _TrangThaiPheDuyet
        {
            get { return trangThaiPheDuyet; }
            set { trangThaiPheDuyet = value; }
        }

        

        public UngVienUngTuyen() : base()
        {
            this.trangThaiDeCu = false;
            this.trangThaiPheDuyet = false;         

        }



        public UngVienUngTuyen(int maUV, string tenUV, bool gt, DateTime ngaySinh, string email, string soCMND, string sdt, string trinhDo,
            string ngoaiNgu, int namKN, int maNV, string cv, int mavitri, bool trangThaiDC, bool trangThaiPD)
            : base( maUV,  tenUV,  gt,  ngaySinh,  email,  soCMND,  sdt,  trinhDo,
             ngoaiNgu,  namKN,  maNV,  cv,  mavitri)
        {
            this.trangThaiDeCu = trangThaiDC;
            this.trangThaiPheDuyet = trangThaiPD;

        }
    }
}

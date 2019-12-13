using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TaiKhoan
    {
        private int ID_NV;
        private string strPassWord;
        private string strRole;
        

        public int _ID_NV1
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

        public string _StrPassWord
        {
            get
            {
                return strPassWord;
            }

            set
            {
                strPassWord = value;
            }
            
        }

        public string _StrRole
        {
            get
            {
                return strRole;
            }

            set
            {
                strRole = value;
            }
        }

        public TaiKhoan()
        {
            this.ID_NV = -1;
            this.strPassWord = null;
            this.strRole = null;
            
        }

        public TaiKhoan(int maNV, string pass, string role)
        {
            this.ID_NV = maNV;
            this.strPassWord = pass;
            this.strRole = role;
        }
    }
}

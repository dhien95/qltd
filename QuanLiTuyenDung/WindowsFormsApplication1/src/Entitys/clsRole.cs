using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Entitys
{
   public class clsRole
    {
        private int maRole;
        private string strTenRole;
        private string strMoTa;

        public int _MaRole
        {
            get
            {
                return maRole;
            }

            set
            {
                maRole = value;
            }
        }

        public string _StrTenRole
        {
            get
            {
                return strTenRole;
            }

            set
            {
                strTenRole = value;
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

        public clsRole()
        {
            this.maRole = -1;
            this.strTenRole = null;
            this.strMoTa = null;
        }

        public clsRole(int maR, string tenR, string moTa)
        {
            this.maRole = maR;
            this.strTenRole = tenR;
            this.strMoTa = moTa;
        }
    }
}

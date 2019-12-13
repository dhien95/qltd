using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Entitys
{
    public class clsWeb
    {
        private int maWeb;
        private string strTenWeb;
        private string strLinkWeb;

        public int _MaWeb
        {
            get
            {
                return maWeb;
            }

            set
            {
                maWeb = value;
            }
        }

        public string _StrTenWeb
        {
            get
            {
                return strTenWeb;
            }

            set
            {
                strTenWeb = value;
            }
        }

        public string _StrLinkWeb
        {
            get
            {
                return strLinkWeb;
            }

            set
            {
                strLinkWeb = value;
            }
        }

        public clsWeb()
        {
            this.maWeb = -1;
            this.strTenWeb = null;
            this.strLinkWeb = null;
        }

        public clsWeb(int ma, string ten, string link)
        {
            this.maWeb = ma;
            this.strTenWeb = ten;
            this.strLinkWeb = link;
        }
    }
}

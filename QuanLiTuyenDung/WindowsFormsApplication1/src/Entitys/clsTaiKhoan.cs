using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Entitys
{
    public class clsTaiKhoan
    {
        private int id_NV;
        private string strUsername;
        private string strPassWord;
        private int maRole;

        public int _Id_NV
        {
            get
            {
                return id_NV;
            }

            set
            {
                id_NV = value;
            }
        }

        public string _StrUsername
        {
            get
            {
                return strUsername;
            }

            set
            {
                strUsername = value;
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



        public clsTaiKhoan()
        {
            this.id_NV = -1;
            this.strUsername = null;
            this.strPassWord = null;
            this.maRole = -1;
        }

        public clsTaiKhoan(int maNV, string userN, string pass, int maR)
        {
            this.id_NV = maNV;
            this.strUsername = userN;
            this.strPassWord = pass;
            this.maRole = maR;
        }
    }
}

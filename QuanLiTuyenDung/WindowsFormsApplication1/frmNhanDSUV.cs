using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmNhanDSUV : Form
    {
        public frmNhanDSUV()
        {
            InitializeComponent();
        }

        private void btnNhanUV_Click(object sender, EventArgs e)
        {

        }

        private void btnGuiTinTD_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        public  bool kiemtraNhanUV; // true là NhanUV, false GuitinTD
        private void frmNhanDSUV_Load(object sender, EventArgs e)
        {
            if(kiemtraNhanUV == true)
            {
                this.btnGuiTinTD.Enabled = false;
                this.btnNhanUV.Enabled = true;
            }
            else
            {
                this.btnGuiTinTD.Enabled = true;
                this.btnNhanUV.Enabled = false;
            }
        }
    }
}

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
    public partial class frmPheDuyetUV : Form
    {
        public frmPheDuyetUV()
        {
            InitializeComponent();
        }

        private void btnDSDC_Click(object sender, EventArgs e)
        {
            pnlTool.Visible = true;
            btnDatLich.Enabled = false;
            tt = TrangThai.DSDC;
            ChuyenTrangThai(tt);
        }

        private void btnDSPD_Click(object sender, EventArgs e)
        {
            pnlTool.Visible = false;
            btnDatLich.Enabled = true;
           // tt = TrangThai.DSPD;
           // ChuyenTrangThai(tt);
        }

       

        

        

        

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

       


        private enum TrangThai { DSDC, DSPD}
        private TrangThai tt;
        private void ChuyenTrangThai(TrangThai tt)
        {
            if (tt == TrangThai.DSDC)
            {
                this.btnLuu.Visible = false;
                this.btnQuayLai.Visible = false;
                this.btnXoa.Visible = false;
                this.btnPheDuyetUV.Visible = true;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Đề Cử";
                
            }
            else
            {
                this.btnLuu.Visible = true;
                this.btnQuayLai.Visible = true;
                this.btnXoa.Visible = true;
                this.btnPheDuyetUV.Visible = false;
                this.lblDSUV.Text = "Danh Sách Ứng Viên Phê Duyệt";
               

            }
        }
        private void frmPheDuyetUV_Load(object sender, EventArgs e)
        {
            pnlTool.Visible = false;
            btnDatLich.Enabled = false;
        }

        private void btnPheDuyetUV_Click(object sender, EventArgs e)
        {
            tt = TrangThai.DSPD;
            ChuyenTrangThai(tt);
            

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            btnDatLich.Enabled = false;
            tt = TrangThai.DSDC;
            ChuyenTrangThai(tt);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}

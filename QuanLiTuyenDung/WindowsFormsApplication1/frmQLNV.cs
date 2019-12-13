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
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }

        private void btnTuLy_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        //check tạo hay xóa tài khoản
        public bool check; //True là tạo tài khoản, False là xóa tài khoản
        private void frmQLNV_Load(object sender, EventArgs e)
        {
            if(check == true) //Tạo tài khoản
            {
                lblTieuDe.Text = "TẠO TÀI KHOẢN";
                lblDSNV.Text = "Danh Sách Nhân Viên Chưa Có Tài Khoản";
                btnXuLy.Text = "Tạo Tài Khoản";
            }
            else // Hủy tài khoản
            {
                lblTieuDe.Text = "HỦY TÀI KHOẢN";
                lblDSNV.Text = "Danh Sách Nhân Viên Đã Có Tài Khoản";
                btnXuLy.Text = "Hủy Tài Khoản";
            }
        }
            
        }
}


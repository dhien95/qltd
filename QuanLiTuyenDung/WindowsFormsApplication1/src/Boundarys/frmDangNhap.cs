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
    public partial class frmDangNhap : Form
    {
        src.DAOs.DB_QLTD.DataQuanLiTuyenDungDataContext db = null;
        public frmDangNhap()
        {
            InitializeComponent();
            db = new src.DAOs.DB_QLTD.DataQuanLiTuyenDungDataContext();
            //this.Size = new Size(500, 500);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin Username và Password!!");
                return;
            }

            var check = KiemTraTaiKhoan(txtUser.Text, txtPass.Text);
            if (check != null) // dung tai khoan va mat khau
            {
                frmChinh frmC = new frmChinh(getTenNV(txtUser.Text));

                //ánh xạ tài khoản qa form chính
                frmC.taiKhoan = new src.Entitys.clsTaiKhoan((int)check.ID_NV, check.Usernames, check.Passwords, (int)check.MaRole_R);
           
                frmC.IsMdiContainer = true;
                this.Visible = false;
                frmC.ShowDialog();
                txtUser.Text = "";
                txtPass.Text = "";
                this.ActiveControl = txtUser;
                txtUser.Focus();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Thông tin nhập sai!!");
            }

        }


        public src.DAOs.DB_QLTD.tblTAIKHOAN KiemTraTaiKhoan(string user, string pass)
        {
            src.DAOs.DB_QLTD.tblTAIKHOAN query = db.tblTAIKHOANs.Where(t => t.Usernames == user && t.Passwords == pass).FirstOrDefault();
            //clsTaiKhoan tk = new clsTaiKhoan(query.ID, query.Usernames, query.Passwords, (int)query.MaRole);

            return query;
        }
        public string getTenNV(string user)
        {
            string ten = db.tblTAIKHOANs.Join(db.tblNHANVIENs, tk => tk.ID_NV, nv => nv.ID, (tk, nv) => new { nv, tk })
                .Where(tn => tn.tk.Usernames == user).Select(tn => tn.nv.TenNV).FirstOrDefault();
            return ten;
        }



        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtUser.Focus();

        }

        private void btnDangNhap_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnDangNhap.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.src.Boundarys
{


    public partial class frmDoiMatKhau : Form
    {
        //Database
        src.DAOs.DB_QLTD.DataQuanLiTuyenDungDataContext db = null;

        private string username;
        public frmDoiMatKhau(string username)
        {
            InitializeComponent();
            db = new src.DAOs.DB_QLTD.DataQuanLiTuyenDungDataContext();
            this.username = username;
        }


        src.Services.connTaiKhoan connTaiKhoan = new Services.connTaiKhoan();

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMKcu.Text == "" || txtMKmoi.Text == "" || txtXacNhanMK.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var check = KiemTraTaiKhoan(username, txtMKcu.Text);

                if (check != null) // Mật khẩu cũ chính xác
                {
                    //kiểm tra lỗi kí tự khoảng trắng bên trong mật khẩu mới
                    string str = " ";
                    string mkMoi = txtMKmoi.Text;
                    bool flag = mkMoi.Contains(str);
                    if (flag == true) // có tồn tại khoảng trắng
                    {
                        MessageBox.Show("Mật khẩu không được tồn tại khoảng trắng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMKmoi.Clear();
                        txtMKmoi.Focus();
                        txtXacNhanMK.Clear();
                        return;
                    }
                    else // không tồn tại khoảng trắng
                    {
                        if (mkMoi != txtXacNhanMK.Text) // mật khẩu xác nhận không chính xác
                        {
                            MessageBox.Show("Mật khẩu xác nhận không chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtXacNhanMK.Clear();
                            txtXacNhanMK.Focus();
                            return;
                        }
                        else // mật khẩu xác nhận chính xác
                        {
                            //cap nhat vao database
                            if (connTaiKhoan.DoiMatKhau(username, mkMoi))
                            {
                                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Đã xảy ra lỗi, cập nhật không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }

                }
                else // Mật khẩu cũ không chính xác
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác, vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKcu.Clear();
                    txtMKmoi.Clear();
                    txtXacNhanMK.Clear();

                    txtMKmoi.Focus();
                    return;
                }
            }


        }

        public src.DAOs.DB_QLTD.tblTAIKHOAN KiemTraTaiKhoan(string user, string pass)
        {
            src.DAOs.DB_QLTD.tblTAIKHOAN query = db.tblTAIKHOANs.Where(t => t.Usernames == user && t.Passwords == pass).FirstOrDefault();
            //clsTaiKhoan tk = new clsTaiKhoan(query.ID, query.Usernames, query.Passwords, (int)query.MaRole);

            return query;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked == true)
            {
                txtMKcu.UseSystemPasswordChar = false;
                txtMKmoi.UseSystemPasswordChar = false;
                txtXacNhanMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKcu.UseSystemPasswordChar = true;
                txtMKmoi.UseSystemPasswordChar = true;
                txtXacNhanMK.UseSystemPasswordChar = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnHuy.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnXacNhan_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnXacNhan.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}

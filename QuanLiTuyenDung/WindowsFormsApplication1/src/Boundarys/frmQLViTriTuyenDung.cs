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
    public partial class frmQLViTriTuyenDung : Form
    {
        src.Controlers.ctrlQuanLyVTTD ctrQLVTTD = new src.Controlers.ctrlQuanLyVTTD();
        src.Services.connVTTD cnnVTTD = new src.Services.connVTTD();

        public frmQLViTriTuyenDung()
        {
            InitializeComponent();
        }

        public enum TrangThaiForm { ThemVT, XoaVT, XemVT };
        public TrangThaiForm ttf;




        private void frmQLViTriTuyenDung_Load(object sender, EventArgs e)
        {
            SetTrangThaiForm(ttf);
            if (ttf == TrangThaiForm.XoaVT || ttf == TrangThaiForm.XemVT)
            {
                List<src.Entitys.clsViTriTuyenDung> dsVTTD = ctrQLVTTD.GetViTriTuyenDung();

                dsVTTD.Insert(0, new src.Entitys.clsViTriTuyenDung(0, "--Chọn tên Vị trí tuyển dụng--", 0, "", "", "", "", ""));
                cboTenViTri.DataSource = dsVTTD;
                cboTenViTri.DisplayMember = "_StrTenViTri";
                cboTenViTri.ValueMember = "_MaVT";
                cboTenViTri.SelectedIndex = 0;
            }
        }

        private void SetTrangThaiForm(TrangThaiForm tt)
        {
            if (ttf == TrangThaiForm.ThemVT) // chức năng Thêm VTTD
            {
                lblTieuDe.Text = "Thêm Vị Trí Tuyển Dụng";
                btnXuLy.Text = "Thêm Vị Trí";
            }
            else if (ttf == TrangThaiForm.XoaVT) // chức năng Xóa VTTD
            {
                lblTieuDe.Text = "Xóa Vị Trí Tuyển Dụng";
                btnXuLy.Text = "Xóa Vị Trí";

            }
            else //chức năng Xem VTTD
            {
                lblTieuDe.Text = "Xem Vị Trí Tuyển Dụng";
                btnXuLy.Visible = false;
            }
        }


        private void ThemVT()
        {
            if (cboTenViTri.Text == "" || txtSoLuong.Text == "" || txtLuong.Text == "" || txtDiaDiem.Text == "" || rtxtMoTa.Text == ""
                || rtxtQuyenLoi.Text == "" || rtxtYeuCau.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin cho tất cả các ô!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int outputSL;
                src.Entitys.clsViTriTuyenDung vtThem = new src.Entitys.clsViTriTuyenDung();
                vtThem._StrTenViTri = cboTenViTri.Text;

                if (int.TryParse(txtSoLuong.Text, out outputSL))
                {
                    if (outputSL < 1)
                    {
                        MessageBox.Show("Số lượng phải > 0", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    vtThem._SoLuong = outputSL;

                }
                else // nhập vào khong phải là số
                {
                    MessageBox.Show("Bạn phải nhập số trong ô số lượng", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                vtThem._StrDiaDiemLV = txtDiaDiem.Text;
                vtThem._MucLuong = txtLuong.Text;
                vtThem._StrMoTa = rtxtMoTa.Text;
                vtThem._StrQuyenLoi = rtxtQuyenLoi.Text;
                vtThem._StrYeuCau = rtxtYeuCau.Text;
                if (cnnVTTD.ThemVTTD(vtThem))
                {
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại\nHãy kiểm tra và thêm lại!");
                    this.Close();
                }
            }
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            if (ttf == TrangThaiForm.ThemVT)
            {
                ThemVT();
            }
            else if (ttf == TrangThaiForm.XoaVT)
            {
                XoaVT();
            }
        }

        private void XoaVT()
        {
            if (cboTenViTri.SelectedIndex == 0)
            {
                MessageBox.Show("Hãy chọn một vị trí muốn xóa");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Cảnh báo", "Nếu xóa các ứng viên đang ứng tuyển vào vị trí này sẽ không ứng tuyển vào vị trí nào nữa!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    if (cnnVTTD.XoaVTTD((int)cboTenViTri.SelectedValue))
                    {
                        //if (cnnVTTD.XoaVTTD())
                        //{
                        MessageBox.Show("Xóa thành công!");
                        this.Close();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Xóa thất bại!");
                        //    this.Close();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Vị trí chưa được xóa!");
                }
            }
        }

        private void cboTenViTri_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cboTenViTri.SelectedIndex != 0)
            //{
                var item = cboTenViTri.SelectedItem;
            src.Entitys.clsViTriTuyenDung vt = (src.Entitys.clsViTriTuyenDung)item;
                txtDiaDiem.Text = vt._StrDiaDiemLV;
                txtLuong.Text = vt._MucLuong;
                txtSoLuong.Text = vt._SoLuong.ToString();
                rtxtMoTa.Text = vt._StrMoTa;
                rtxtYeuCau.Text = vt._StrYeuCau;
                rtxtQuyenLoi.Text = vt._StrQuyenLoi;

            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuLy_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnXuLy.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnThoat_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnThoat.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}

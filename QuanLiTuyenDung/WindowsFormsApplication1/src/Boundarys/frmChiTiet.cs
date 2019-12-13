using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmChiTiet : Form
    {
        string noiDung;
        string path;
        private string thongTin;
        public enum TrangThai { XemYeuCau, XemCV };

        TrangThai tt;


        static Regex ConvertToUnsign_rg = null;

        public static string ConvertToUnsign(string strInput)
        {
            if (ReferenceEquals(ConvertToUnsign_rg, null))
            {
                ConvertToUnsign_rg = new Regex("p{IsCombiningDiacriticalMarks}+");
            }
            var temp = strInput.Normalize(NormalizationForm.FormD);
            return ConvertToUnsign_rg.Replace(temp, string.Empty).Replace("đ", "d").Replace("Đ", "D").ToLower();
        }

        public frmChiTiet(TrangThai trangThai, string tieuDe, string yeuCau, string pathCV)
        {
            InitializeComponent();
            tt = trangThai;
            thongTin = tieuDe;
            noiDung = yeuCau;
            path = pathCV;

        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            TrangThaiHienThi(tt);
            this.Size = new Size(700, 720);
        }

        public void TrangThaiHienThi(TrangThai tt)
        {
            txtThongTin.Text = thongTin;
            if (tt == TrangThai.XemYeuCau) //Chức năng Xem yều cầu tuyển dụng
            {
                lblThongTin.Text = "Vị trí tuyển dụng:";
                lblTieuDe.Text = "YÊU CẦU";
                axAcroCV.Visible = false;
                rtbTTChiTiet.Visible = true;
                rtbTTChiTiet.Text = noiDung;

            }
            else //Chức năng Xem CV
            {
                lblThongTin.Text = "Hồ sơ Ứng Viên";
                lblTieuDe.Text = "CV";
                axAcroCV.Visible = true;
                rtbTTChiTiet.Visible = false;
                string full_path = Path.GetFullPath(path);
                axAcroCV.src = full_path;

            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuayLai_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnQuayLai.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);

        }
    }
}

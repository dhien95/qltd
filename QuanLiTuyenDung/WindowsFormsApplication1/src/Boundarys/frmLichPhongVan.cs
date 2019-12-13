using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmLichPhongVan : Form
    {
        string tenvttd;
        List<src.Entitys.clsUngVien> dsUVPV = null;

        src.Controlers.ctrlQLLichPV ctrDatLich = new src.Controlers.ctrlQLLichPV();
        src.Services.connLichPV cnnLichPV = new src.Services.connLichPV();
        src.Services.connLichPV_UngVien cnnLichPV_UV = new src.Services.connLichPV_UngVien();

        public frmLichPhongVan(string vttd, List<src.Entitys.clsUngVien> lstUV)
        {
            InitializeComponent();
            tenvttd = vttd;
            dsUVPV = lstUV;
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (rtxtDiaDiem.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin thời gian và địa điểm phỏng vấn!");

            }
            else if (dtpThoiGian.Value <= DateTime.Now)
            {
                MessageBox.Show("Hãy chọn thời gian hợp lệ!");
            }
            else
            {
                XuLyDatLich();

            }

        }

        public string CapNhatMail(string vt, string gio, string ngay, string diaDiem)
        {
            //OpenFileDialog FileOpen = new OpenFileDialog();
            FileStream fs = new FileStream("Mail\\ThuPV.txt", FileMode.Open, FileAccess.Read);
            List<string> lstLine = new List<string>();
            //FileInfo fi = new FileInfo(@"C:\Users\DHien\Desktop\ThuPV.txt");
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                lstLine.Add(line);
            }
            fs.Close();
            lstLine.Insert(7, "- Vị trí tuyển dụng: " + vt);
            lstLine.Insert(8, "- Thời gian: " + gio + ", ngày: " + ngay);
            lstLine.Insert(9, "- Địa điểm: " + diaDiem);

            string mess = "";
            foreach (var item in lstLine)
            {
                mess += item + "\n";
                MessageBox.Show(item);
            }
            return mess;
        }

        public void GuiMail(string mess)
        {
            string body = mess;
            string mailFrom = "dqphuog@gmail.com";
            string mailTo;
            string subject = "Thư mời phỏng vấn";
            foreach (var item in dsUVPV)
            {                
                mailTo = item._StrEmail;                
                ctrDatLich.GuiMailTuDong(mailFrom, mailTo, subject, body);
            }
        }

        public void XuLyDatLich()
        {
            DialogResult dr = MessageBox.Show("Thư mời phỏng vấn sẽ được gửi đến tất cả các ứng viên." + "\nNếu muốn kiểm tra lại thông tin lịch phỏng vấn" + "\n=> Vui lòng bấm Cancel!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                src.Entitys.clsLichPhongVan lpv = new src.Entitys.clsLichPhongVan();
                lpv._ThoiGian = dtpThoiGian.Value;
                lpv._StrDiaDiem = rtxtDiaDiem.Text;

                if (cnnLichPV.ThemLichPV(lpv))
                {
                    MessageBox.Show("Thêm lịch thành công!");

                    string mess = CapNhatMail(tenvttd, dtpThoiGian.Value.ToString("hh:mm tt"), dtpThoiGian.Value.ToString("dd/MM/yyyy"), rtxtDiaDiem.Text);
                    GuiMail(mess);
                    int ma = ctrDatLich.GetMaLich(lpv._ThoiGian);
                    cnnLichPV_UV.ThemLichPV_UngVien(dsUVPV, ma);
                }
                else
                {
                    MessageBox.Show("Thêm lịch thất bại!");
                }
                this.Close();

            }
        }
        private void frmLichPhongVan_Load(object sender, EventArgs e)
        {

        }

        private void btnDatLich_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnDatLich.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}

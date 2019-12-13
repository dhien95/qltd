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


namespace WindowsFormsApplication1.src.Boundarys
{
    public partial class frmNhanUV : Form
    {
        src.Services.connDBWeb cnnWeb = new Services.connDBWeb();
        src.Controlers.ctrlNhanDSUV ctrNhan = new Controlers.ctrlNhanDSUV();

        public frmNhanUV()
        {
            InitializeComponent();

            bgwTrangThai = new BackgroundWorker();
            bgwTrangThai.WorkerReportsProgress = true;
            bgwTrangThai.WorkerSupportsCancellation = true;

            bgwTrangThai.DoWork += bgwTrangThai_DoWork;
            bgwTrangThai.ProgressChanged += bgwTrangThai_ProgressChanged;
            bgwTrangThai.RunWorkerCompleted += bgwTrangThai_RunWorkerCompleted;

        }

        private void cboTenWeb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboTenWeb.SelectedIndex != 0)
            {
                btnNhan.Enabled = true;
                var temp = cboTenWeb.SelectedItem;
                src.Entitys.clsWeb web = (src.Entitys.clsWeb)temp;
                link.Text = web._StrLinkWeb;
            }
            else
            {
                link.Text = "Link";
            }
        }

        private void frmNhanUV_Load(object sender, EventArgs e)
        {
            List<src.Entitys.clsWeb> dsWeb = ctrNhan.GetThongTinWeb();
            dsWeb.Insert(0, new Entitys.clsWeb(0, "--Chọn Website--", ""));
            cboTenWeb.DataSource = dsWeb;
            cboTenWeb.DisplayMember = "_StrTenWeb";
            cboTenWeb.ValueMember = "_MaWeb";
            cboTenWeb.SelectedIndex = 0;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (bgwTrangThai.IsBusy)
            {
                bgwTrangThai.CancelAsync();
            }
            else
            {
                pbTrangThai.Value = pbTrangThai.Minimum;
                //listView1.Items.Clear();
                bgwTrangThai.RunWorkerAsync();
            }
        }
        private void bgwTrangThai_DoWork(object sender, DoWorkEventArgs e)
        {
            int max = cnnWeb.GetDLUngVien();
            if (max == 0)
            {
                MessageBox.Show("Danh sách ứng viên rỗng");
            }
            else
            {
                pbTrangThai.Invoke((Action)(() => pbTrangThai.Maximum = max));
                for (int i = 0; i <= max; i += 5)
                {
                    bgwTrangThai.ReportProgress(i);
                    //pbTrangThai.Value = i;

                }
                bgwTrangThai.ReportProgress(max);
            }

        }

        private void bgwTrangThai_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!bgwTrangThai.CancellationPending)
            {

                pbTrangThai.PerformStep();
            }
        }

        private void bgwTrangThai_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (pbTrangThai.Value < pbTrangThai.Maximum)
            {
                lblTrangThai.Text = "Trạng thái thực hiện";

            }
            else
            {
                lblTrangThai.Text = "Hoàn thành";
                MessageBox.Show("Hoàn thành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnNhan_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnNhan.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}


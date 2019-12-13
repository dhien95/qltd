namespace WindowsFormsApplication1.src.Boundarys
{
    partial class frmNhanUV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanUV));
            this.bgwTrangThai = new System.ComponentModel.BackgroundWorker();
            this.pbTrangThai = new System.Windows.Forms.ProgressBar();
            this.cboTenWeb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenWeb = new System.Windows.Forms.Label();
            this.lblLinkWeb = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNhan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgwTrangThai
            // 
            this.bgwTrangThai.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTrangThai_DoWork);
            this.bgwTrangThai.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwTrangThai_ProgressChanged);
            this.bgwTrangThai.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwTrangThai_RunWorkerCompleted);
            // 
            // pbTrangThai
            // 
            this.pbTrangThai.Location = new System.Drawing.Point(16, 38);
            this.pbTrangThai.Name = "pbTrangThai";
            this.pbTrangThai.Size = new System.Drawing.Size(537, 59);
            this.pbTrangThai.TabIndex = 3;
            // 
            // cboTenWeb
            // 
            this.cboTenWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenWeb.FormattingEnabled = true;
            this.cboTenWeb.Location = new System.Drawing.Point(128, 16);
            this.cboTenWeb.Name = "cboTenWeb";
            this.cboTenWeb.Size = new System.Drawing.Size(244, 24);
            this.cboTenWeb.TabIndex = 6;
            this.cboTenWeb.SelectionChangeCommitted += new System.EventHandler(this.cboTenWeb_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "NHẬN DANH SÁCH ỨNG VIÊN";
            // 
            // lblTenWeb
            // 
            this.lblTenWeb.AutoSize = true;
            this.lblTenWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenWeb.Location = new System.Drawing.Point(44, 19);
            this.lblTenWeb.Name = "lblTenWeb";
            this.lblTenWeb.Size = new System.Drawing.Size(67, 16);
            this.lblTenWeb.TabIndex = 8;
            this.lblTenWeb.Text = "Tên Web:";
            // 
            // lblLinkWeb
            // 
            this.lblLinkWeb.AutoSize = true;
            this.lblLinkWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkWeb.Location = new System.Drawing.Point(43, 61);
            this.lblLinkWeb.Name = "lblLinkWeb";
            this.lblLinkWeb.Size = new System.Drawing.Size(67, 16);
            this.lblLinkWeb.TabIndex = 9;
            this.lblLinkWeb.Text = "Link Web:";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.Location = new System.Drawing.Point(124, 61);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(32, 16);
            this.link.TabIndex = 11;
            this.link.TabStop = true;
            this.link.Text = "Link";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(203, 11);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(123, 16);
            this.lblTrangThai.TabIndex = 12;
            this.lblTrangThai.Text = "Trạng thái thực hiện";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 66);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTrangThai);
            this.panel2.Controls.Add(this.pbTrangThai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 129);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNhan);
            this.panel3.Controls.Add(this.cboTenWeb);
            this.panel3.Controls.Add(this.lblTenWeb);
            this.panel3.Controls.Add(this.link);
            this.panel3.Controls.Add(this.lblLinkWeb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 116);
            this.panel3.TabIndex = 15;
            // 
            // btnNhan
            // 
            this.btnNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNhan.Enabled = false;
            this.btnNhan.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNhan.FlatAppearance.BorderSize = 5;
            this.btnNhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhan.Image = global::WindowsFormsApplication1.Properties.Resources.NhanUV;
            this.btnNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhan.Location = new System.Drawing.Point(402, 12);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(90, 34);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "Nhận";
            this.btnNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhan.UseVisualStyleBackColor = false;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            this.btnNhan.Paint += new System.Windows.Forms.PaintEventHandler(this.btnNhan_Paint);
            // 
            // frmNhanUV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 311);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhanUV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhận Danh Sách Ứng Viên";
            this.Load += new System.EventHandler(this.frmNhanUV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwTrangThai;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.ProgressBar pbTrangThai;
        private System.Windows.Forms.ComboBox cboTenWeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenWeb;
        private System.Windows.Forms.Label lblLinkWeb;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
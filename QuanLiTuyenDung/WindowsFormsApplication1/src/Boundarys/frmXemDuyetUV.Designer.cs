namespace WindowsFormsApplication1
{
    partial class frmXemDuyetUV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemDuyetUV));
            this.pnlPheDuyet = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXuLy1 = new System.Windows.Forms.Button();
            this.btnXuLy2 = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.lblTongUV = new System.Windows.Forms.Label();
            this.txtTongUV = new System.Windows.Forms.TextBox();
            this.lvwDSUV = new System.Windows.Forms.ListView();
            this.lblDSUV = new System.Windows.Forms.Label();
            this.lblLichPV = new System.Windows.Forms.Label();
            this.cboLichPV = new System.Windows.Forms.ComboBox();
            this.lblVTTD = new System.Windows.Forms.Label();
            this.cboVTTD = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkXemUVTheoLich = new System.Windows.Forms.CheckBox();
            this.pnlPheDuyet.SuspendLayout();
            this.pnlThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPheDuyet
            // 
            this.pnlPheDuyet.Controls.Add(this.btnLuu);
            this.pnlPheDuyet.Controls.Add(this.btnXuLy1);
            this.pnlPheDuyet.Controls.Add(this.btnXuLy2);
            this.pnlPheDuyet.Controls.Add(this.btnHuy);
            this.pnlPheDuyet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPheDuyet.Location = new System.Drawing.Point(0, 510);
            this.pnlPheDuyet.Name = "pnlPheDuyet";
            this.pnlPheDuyet.Size = new System.Drawing.Size(847, 77);
            this.pnlPheDuyet.TabIndex = 27;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLuu.FlatAppearance.BorderSize = 5;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::WindowsFormsApplication1.Properties.Resources.nut_save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(263, 17);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 43);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnLuu.Paint += new System.Windows.Forms.PaintEventHandler(this.btnLuu_Paint);
            // 
            // btnXuLy1
            // 
            this.btnXuLy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXuLy1.AutoSize = true;
            this.btnXuLy1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXuLy1.Enabled = false;
            this.btnXuLy1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnXuLy1.FlatAppearance.BorderSize = 5;
            this.btnXuLy1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXuLy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLy1.Image = global::WindowsFormsApplication1.Properties.Resources.decu_button1;
            this.btnXuLy1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLy1.Location = new System.Drawing.Point(46, 17);
            this.btnXuLy1.Name = "btnXuLy1";
            this.btnXuLy1.Size = new System.Drawing.Size(176, 43);
            this.btnXuLy1.TabIndex = 23;
            this.btnXuLy1.Text = "Phê Duyệt Ứng Viên";
            this.btnXuLy1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuLy1.UseVisualStyleBackColor = false;
            this.btnXuLy1.Click += new System.EventHandler(this.btnXuLy1_Click);
            this.btnXuLy1.Paint += new System.Windows.Forms.PaintEventHandler(this.btnXuLy1_Paint);
            // 
            // btnXuLy2
            // 
            this.btnXuLy2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuLy2.AutoSize = true;
            this.btnXuLy2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXuLy2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnXuLy2.FlatAppearance.BorderSize = 5;
            this.btnXuLy2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXuLy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLy2.Image = global::WindowsFormsApplication1.Properties.Resources.Change1;
            this.btnXuLy2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLy2.Location = new System.Drawing.Point(475, 17);
            this.btnXuLy2.Name = "btnXuLy2";
            this.btnXuLy2.Size = new System.Drawing.Size(185, 43);
            this.btnXuLy2.TabIndex = 26;
            this.btnXuLy2.Text = "Chuyển DS Phê Duyệt";
            this.btnXuLy2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuLy2.UseVisualStyleBackColor = false;
            this.btnXuLy2.Click += new System.EventHandler(this.btnXuLy2_Click);
            this.btnXuLy2.Paint += new System.Windows.Forms.PaintEventHandler(this.btnXuLy2_Paint);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnHuy.FlatAppearance.BorderSize = 5;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::WindowsFormsApplication1.Properties.Resources.x_button;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(369, 17);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 43);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            this.btnHuy.Paint += new System.Windows.Forms.PaintEventHandler(this.btnHuy_Paint);
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.BackColor = System.Drawing.Color.White;
            this.pnlThongTin.Controls.Add(this.lblTongUV);
            this.pnlThongTin.Controls.Add(this.txtTongUV);
            this.pnlThongTin.Controls.Add(this.lvwDSUV);
            this.pnlThongTin.Controls.Add(this.lblDSUV);
            this.pnlThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(847, 587);
            this.pnlThongTin.TabIndex = 26;
            // 
            // lblTongUV
            // 
            this.lblTongUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongUV.AutoSize = true;
            this.lblTongUV.Location = new System.Drawing.Point(624, 138);
            this.lblTongUV.Name = "lblTongUV";
            this.lblTongUV.Size = new System.Drawing.Size(81, 13);
            this.lblTongUV.TabIndex = 32;
            this.lblTongUV.Text = "Tổng Ứng viên:";
            // 
            // txtTongUV
            // 
            this.txtTongUV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongUV.Enabled = false;
            this.txtTongUV.Location = new System.Drawing.Point(714, 132);
            this.txtTongUV.Name = "txtTongUV";
            this.txtTongUV.Size = new System.Drawing.Size(42, 20);
            this.txtTongUV.TabIndex = 31;
            // 
            // lvwDSUV
            // 
            this.lvwDSUV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDSUV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lvwDSUV.CheckBoxes = true;
            this.lvwDSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDSUV.Location = new System.Drawing.Point(90, 158);
            this.lvwDSUV.Name = "lvwDSUV";
            this.lvwDSUV.Size = new System.Drawing.Size(666, 320);
            this.lvwDSUV.TabIndex = 30;
            this.lvwDSUV.UseCompatibleStateImageBehavior = false;
            this.lvwDSUV.View = System.Windows.Forms.View.Details;
            // 
            // lblDSUV
            // 
            this.lblDSUV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDSUV.AutoSize = true;
            this.lblDSUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSUV.Location = new System.Drawing.Point(321, 111);
            this.lblDSUV.Name = "lblDSUV";
            this.lblDSUV.Size = new System.Drawing.Size(205, 24);
            this.lblDSUV.TabIndex = 27;
            this.lblDSUV.Text = "Danh Sách Ứng Viên";
            this.lblDSUV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLichPV
            // 
            this.lblLichPV.AutoSize = true;
            this.lblLichPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichPV.Location = new System.Drawing.Point(355, 12);
            this.lblLichPV.Name = "lblLichPV";
            this.lblLichPV.Size = new System.Drawing.Size(35, 16);
            this.lblLichPV.TabIndex = 35;
            this.lblLichPV.Text = "Lịch:";
            // 
            // cboLichPV
            // 
            this.cboLichPV.Enabled = false;
            this.cboLichPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLichPV.FormattingEnabled = true;
            this.cboLichPV.Location = new System.Drawing.Point(396, 9);
            this.cboLichPV.Name = "cboLichPV";
            this.cboLichPV.Size = new System.Drawing.Size(145, 24);
            this.cboLichPV.TabIndex = 34;
            this.cboLichPV.SelectionChangeCommitted += new System.EventHandler(this.cboLichPV_SelectionChangeCommitted);
            // 
            // lblVTTD
            // 
            this.lblVTTD.AutoSize = true;
            this.lblVTTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVTTD.Location = new System.Drawing.Point(33, 12);
            this.lblVTTD.Name = "lblVTTD";
            this.lblVTTD.Size = new System.Drawing.Size(110, 16);
            this.lblVTTD.TabIndex = 26;
            this.lblVTTD.Text = "Vị trí Tuyển dụng:";
            // 
            // cboVTTD
            // 
            this.cboVTTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVTTD.FormattingEnabled = true;
            this.cboVTTD.Location = new System.Drawing.Point(149, 9);
            this.cboVTTD.Name = "cboVTTD";
            this.cboVTTD.Size = new System.Drawing.Size(155, 24);
            this.cboVTTD.TabIndex = 25;
            this.cboVTTD.SelectionChangeCommitted += new System.EventHandler(this.cboVTTD_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(676, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 77);
            this.panel1.TabIndex = 37;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnThoat.FlatAppearance.BorderSize = 5;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::WindowsFormsApplication1.Properties.Resources.exit1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(36, 17);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 43);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.Paint += new System.Windows.Forms.PaintEventHandler(this.btnThoat_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel2.Controls.Add(this.chkXemUVTheoLich);
            this.panel2.Controls.Add(this.lblVTTD);
            this.panel2.Controls.Add(this.cboVTTD);
            this.panel2.Controls.Add(this.lblLichPV);
            this.panel2.Controls.Add(this.cboLichPV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 102);
            this.panel2.TabIndex = 37;
            // 
            // chkXemUVTheoLich
            // 
            this.chkXemUVTheoLich.AutoSize = true;
            this.chkXemUVTheoLich.BackColor = System.Drawing.Color.White;
            this.chkXemUVTheoLich.Location = new System.Drawing.Point(396, 39);
            this.chkXemUVTheoLich.Name = "chkXemUVTheoLich";
            this.chkXemUVTheoLich.Size = new System.Drawing.Size(145, 17);
            this.chkXemUVTheoLich.TabIndex = 37;
            this.chkXemUVTheoLich.Text = "Xem Ứng Viên Theo Lịch";
            this.chkXemUVTheoLich.UseVisualStyleBackColor = false;
            this.chkXemUVTheoLich.CheckedChanged += new System.EventHandler(this.chkXemUVTheoLich_CheckedChanged);
            // 
            // frmXemDuyetUV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPheDuyet);
            this.Controls.Add(this.pnlThongTin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXemDuyetUV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Ứng Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXemDuyetUV_Load);
            this.pnlPheDuyet.ResumeLayout(false);
            this.pnlPheDuyet.PerformLayout();
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPheDuyet;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXuLy1;
        private System.Windows.Forms.Button btnXuLy2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label lblTongUV;
        private System.Windows.Forms.TextBox txtTongUV;
        private System.Windows.Forms.ListView lvwDSUV;
        private System.Windows.Forms.Label lblDSUV;
        private System.Windows.Forms.Label lblVTTD;
        private System.Windows.Forms.ComboBox cboVTTD;
        private System.Windows.Forms.Label lblLichPV;
        private System.Windows.Forms.ComboBox cboLichPV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkXemUVTheoLich;
    }
}
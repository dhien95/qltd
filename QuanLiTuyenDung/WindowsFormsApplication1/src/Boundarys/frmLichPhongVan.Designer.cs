namespace WindowsFormsApplication1
{
    partial class frmLichPhongVan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichPhongVan));
            this.rtxtDiaDiem = new System.Windows.Forms.RichTextBox();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.tblTieuDeDatLich = new System.Windows.Forms.Label();
            this.lblTG = new System.Windows.Forms.Label();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtDiaDiem
            // 
            this.rtxtDiaDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtxtDiaDiem.Location = new System.Drawing.Point(84, 133);
            this.rtxtDiaDiem.Name = "rtxtDiaDiem";
            this.rtxtDiaDiem.Size = new System.Drawing.Size(246, 53);
            this.rtxtDiaDiem.TabIndex = 38;
            this.rtxtDiaDiem.Text = "";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpThoiGian.CustomFormat = "hh:mm tt - dd/MM/yyyy";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(84, 56);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(246, 20);
            this.dtpThoiGian.TabIndex = 36;
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(81, 112);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(52, 13);
            this.lblDiaDiem.TabIndex = 35;
            this.lblDiaDiem.Text = "Địa điểm:";
            // 
            // tblTieuDeDatLich
            // 
            this.tblTieuDeDatLich.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblTieuDeDatLich.AutoSize = true;
            this.tblTieuDeDatLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTieuDeDatLich.Location = new System.Drawing.Point(138, 26);
            this.tblTieuDeDatLich.Name = "tblTieuDeDatLich";
            this.tblTieuDeDatLich.Size = new System.Drawing.Size(147, 20);
            this.tblTieuDeDatLich.TabIndex = 34;
            this.tblTieuDeDatLich.Text = "Thông tin đặt lịch";
            // 
            // lblTG
            // 
            this.lblTG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTG.AutoSize = true;
            this.lblTG.Location = new System.Drawing.Point(81, 31);
            this.lblTG.Name = "lblTG";
            this.lblTG.Size = new System.Drawing.Size(54, 13);
            this.lblTG.TabIndex = 33;
            this.lblTG.Text = "Thời gian:";
            // 
            // btnDatLich
            // 
            this.btnDatLich.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDatLich.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDatLich.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDatLich.FlatAppearance.BorderSize = 5;
            this.btnDatLich.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDatLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLich.Image = global::WindowsFormsApplication1.Properties.Resources.DatLich_button;
            this.btnDatLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatLich.Location = new System.Drawing.Point(139, 16);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(133, 35);
            this.btnDatLich.TabIndex = 37;
            this.btnDatLich.Text = "Đặt lịch";
            this.btnDatLich.UseVisualStyleBackColor = false;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            this.btnDatLich.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDatLich_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.tblTieuDeDatLich);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 73);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTG);
            this.panel2.Controls.Add(this.lblDiaDiem);
            this.panel2.Controls.Add(this.rtxtDiaDiem);
            this.panel2.Controls.Add(this.dtpThoiGian);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 295);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDatLich);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 67);
            this.panel3.TabIndex = 41;
            // 
            // frmLichPhongVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 368);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLichPhongVan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết";
            this.Load += new System.EventHandler(this.frmLichPhongVan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtxtDiaDiem;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label tblTieuDeDatLich;
        private System.Windows.Forms.Label lblTG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
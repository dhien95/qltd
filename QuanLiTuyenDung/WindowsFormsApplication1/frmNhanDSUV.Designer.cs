namespace WindowsFormsApplication1
{
    partial class frmNhanDSUV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lvwDSWeb = new System.Windows.Forms.ListView();
            this.btnNhanUV = new System.Windows.Forms.Button();
            this.btnGuiTinTD = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Controls.Add(this.lvwDSWeb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 322);
            this.panel1.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(209, 55);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(367, 24);
            this.lblTieuDe.TabIndex = 7;
            this.lblTieuDe.Text = "Danh sách các trang web Tuyển Dụng";
            // 
            // lvwDSWeb
            // 
            this.lvwDSWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDSWeb.Location = new System.Drawing.Point(77, 92);
            this.lvwDSWeb.Name = "lvwDSWeb";
            this.lvwDSWeb.Size = new System.Drawing.Size(625, 195);
            this.lvwDSWeb.TabIndex = 6;
            this.lvwDSWeb.UseCompatibleStateImageBehavior = false;
            // 
            // btnNhanUV
            // 
            this.btnNhanUV.AutoSize = true;
            this.btnNhanUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanUV.Location = new System.Drawing.Point(77, 337);
            this.btnNhanUV.Name = "btnNhanUV";
            this.btnNhanUV.Size = new System.Drawing.Size(162, 41);
            this.btnNhanUV.TabIndex = 1;
            this.btnNhanUV.Text = "Nhận Ứng Viên";
            this.btnNhanUV.UseVisualStyleBackColor = true;
            this.btnNhanUV.Click += new System.EventHandler(this.btnNhanUV_Click);
            // 
            // btnGuiTinTD
            // 
            this.btnGuiTinTD.AutoSize = true;
            this.btnGuiTinTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiTinTD.Location = new System.Drawing.Point(356, 339);
            this.btnGuiTinTD.Name = "btnGuiTinTD";
            this.btnGuiTinTD.Size = new System.Drawing.Size(162, 41);
            this.btnGuiTinTD.TabIndex = 2;
            this.btnGuiTinTD.Text = "Gửi Tin Tuyển Dụng";
            this.btnGuiTinTD.UseVisualStyleBackColor = true;
            this.btnGuiTinTD.Click += new System.EventHandler(this.btnGuiTinTD_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(635, 339);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 41);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmNhanDSUV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 390);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGuiTinTD);
            this.Controls.Add(this.btnNhanUV);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhanDSUV";
            this.Text = "Connect";
            this.Load += new System.EventHandler(this.frmNhanDSUV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.ListView lvwDSWeb;
        private System.Windows.Forms.Button btnNhanUV;
        private System.Windows.Forms.Button btnGuiTinTD;
        private System.Windows.Forms.Button btnThoat;
    }
}
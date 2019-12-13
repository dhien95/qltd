namespace WindowsFormsApplication1
{
    partial class frmChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTiet));
            this.lblThongTin = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.rtbTTChiTiet = new System.Windows.Forms.RichTextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.axAcroCV = new AxAcroPDFLib.AxAcroPDF();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroCV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(116, 13);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(54, 16);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.Text = "Tiêu đề";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuayLai.AutoSize = true;
            this.btnQuayLai.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnQuayLai.FlatAppearance.BorderSize = 5;
            this.btnQuayLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(534, 528);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(92, 37);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            this.btnQuayLai.Paint += new System.Windows.Forms.PaintEventHandler(this.btnQuayLai_Paint);
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(222, 12);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(248, 20);
            this.txtThongTin.TabIndex = 2;
            // 
            // rtbTTChiTiet
            // 
            this.rtbTTChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTTChiTiet.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTTChiTiet.Location = new System.Drawing.Point(24, 85);
            this.rtbTTChiTiet.Name = "rtbTTChiTiet";
            this.rtbTTChiTiet.Size = new System.Drawing.Size(602, 428);
            this.rtbTTChiTiet.TabIndex = 3;
            this.rtbTTChiTiet.Text = "";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(271, 46);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(91, 25);
            this.lblTieuDe.TabIndex = 4;
            this.lblTieuDe.Text = "Tiêu đề";
            // 
            // axAcroCV
            // 
            this.axAcroCV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroCV.Enabled = true;
            this.axAcroCV.Location = new System.Drawing.Point(24, 85);
            this.axAcroCV.Name = "axAcroCV";
            this.axAcroCV.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroCV.OcxState")));
            this.axAcroCV.Size = new System.Drawing.Size(602, 428);
            this.axAcroCV.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.txtThongTin);
            this.panel1.Controls.Add(this.lblThongTin);
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 79);
            this.panel1.TabIndex = 6;
            // 
            // frmChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axAcroCV);
            this.Controls.Add(this.rtbTTChiTiet);
            this.Controls.Add(this.btnQuayLai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Chi Tiết";
            this.Load += new System.EventHandler(this.frmChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroCV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.RichTextBox rtbTTChiTiet;
        private System.Windows.Forms.Label lblTieuDe;
        private AxAcroPDFLib.AxAcroPDF axAcroCV;
        private System.Windows.Forms.Panel panel1;
    }
}
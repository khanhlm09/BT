namespace PhanMemThuThapThongTinMayTinhDBS.Forms
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.tblpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblpnlHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblNameSoftware = new System.Windows.Forms.Label();
            this.tblpnlBody = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDifferent = new System.Windows.Forms.Button();
            this.btnSoftware = new System.Windows.Forms.Button();
            this.btnHardware = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenuRight = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportFile = new PhanMemThuThapThongTinMayTinhDBS.CustomControls.btnCustom();
            this.btnSaveStatistic = new PhanMemThuThapThongTinMayTinhDBS.CustomControls.btnCustom();
            this.btnLoadStatistic = new PhanMemThuThapThongTinMayTinhDBS.CustomControls.btnCustom();
            this.btnDefault = new PhanMemThuThapThongTinMayTinhDBS.CustomControls.btnCustom();
            this.btnDeleteAll = new PhanMemThuThapThongTinMayTinhDBS.CustomControls.btnCustom();
            this.btnChooseAll = new PhanMemThuThapThongTinMayTinhDBS.CustomControls.btnCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.tblpnlMain.SuspendLayout();
            this.tblpnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tblpnlBody.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlMenuRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnlMain
            // 
            this.tblpnlMain.ColumnCount = 1;
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpnlMain.Controls.Add(this.tblpnlHeader, 0, 0);
            this.tblpnlMain.Controls.Add(this.tblpnlBody, 0, 1);
            this.tblpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tblpnlMain.Name = "tblpnlMain";
            this.tblpnlMain.RowCount = 2;
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblpnlMain.Size = new System.Drawing.Size(1184, 861);
            this.tblpnlMain.TabIndex = 0;
            // 
            // tblpnlHeader
            // 
            this.tblpnlHeader.BackColor = System.Drawing.Color.White;
            this.tblpnlHeader.ColumnCount = 2;
            this.tblpnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblpnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblpnlHeader.Controls.Add(this.picLogo, 0, 0);
            this.tblpnlHeader.Controls.Add(this.lblNameSoftware, 1, 0);
            this.tblpnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlHeader.Location = new System.Drawing.Point(3, 3);
            this.tblpnlHeader.Name = "tblpnlHeader";
            this.tblpnlHeader.RowCount = 1;
            this.tblpnlHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblpnlHeader.Size = new System.Drawing.Size(1178, 80);
            this.tblpnlHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(347, 74);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblNameSoftware
            // 
            this.lblNameSoftware.AutoSize = true;
            this.lblNameSoftware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameSoftware.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.lblNameSoftware.Location = new System.Drawing.Point(356, 0);
            this.lblNameSoftware.Name = "lblNameSoftware";
            this.lblNameSoftware.Size = new System.Drawing.Size(819, 80);
            this.lblNameSoftware.TabIndex = 1;
            this.lblNameSoftware.Text = "PHẦN MỀM THU THẬP THÔNG TIN MÁY TÍNH";
            this.lblNameSoftware.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblpnlBody
            // 
            this.tblpnlBody.BackColor = System.Drawing.Color.White;
            this.tblpnlBody.ColumnCount = 2;
            this.tblpnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblpnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpnlBody.Controls.Add(this.pnlMenu, 0, 0);
            this.tblpnlBody.Controls.Add(this.pnlContent, 0, 1);
            this.tblpnlBody.Controls.Add(this.pnlMenuRight, 1, 1);
            this.tblpnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlBody.Location = new System.Drawing.Point(3, 89);
            this.tblpnlBody.Name = "tblpnlBody";
            this.tblpnlBody.RowCount = 2;
            this.tblpnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblpnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tblpnlBody.Size = new System.Drawing.Size(1178, 769);
            this.tblpnlBody.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnDifferent);
            this.pnlMenu.Controls.Add(this.btnSoftware);
            this.pnlMenu.Controls.Add(this.btnHardware);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMenu.Location = new System.Drawing.Point(3, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(877, 109);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnDifferent
            // 
            this.btnDifferent.Location = new System.Drawing.Point(327, 57);
            this.btnDifferent.Name = "btnDifferent";
            this.btnDifferent.Size = new System.Drawing.Size(140, 50);
            this.btnDifferent.TabIndex = 1;
            this.btnDifferent.Text = "KHÁC";
            this.btnDifferent.UseVisualStyleBackColor = true;
            // 
            // btnSoftware
            // 
            this.btnSoftware.Location = new System.Drawing.Point(165, 57);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(140, 50);
            this.btnSoftware.TabIndex = 1;
            this.btnSoftware.Text = "PHẦN MỀM";
            this.btnSoftware.UseVisualStyleBackColor = true;
            // 
            // btnHardware
            // 
            this.btnHardware.Location = new System.Drawing.Point(2, 57);
            this.btnHardware.Name = "btnHardware";
            this.btnHardware.Size = new System.Drawing.Size(140, 50);
            this.btnHardware.TabIndex = 1;
            this.btnHardware.Text = "PHẦN CỨNG";
            this.btnHardware.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "THIẾT LẬP THÔNG TIN THU THẬP";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlContent.Location = new System.Drawing.Point(3, 118);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(877, 648);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlMenuRight
            // 
            this.pnlMenuRight.Controls.Add(this.checkBox1);
            this.pnlMenuRight.Controls.Add(this.panel1);
            this.pnlMenuRight.Controls.Add(this.btnExportFile);
            this.pnlMenuRight.Controls.Add(this.btnSaveStatistic);
            this.pnlMenuRight.Controls.Add(this.btnLoadStatistic);
            this.pnlMenuRight.Controls.Add(this.btnDefault);
            this.pnlMenuRight.Controls.Add(this.btnDeleteAll);
            this.pnlMenuRight.Controls.Add(this.btnChooseAll);
            this.pnlMenuRight.Controls.Add(this.label1);
            this.pnlMenuRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuRight.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMenuRight.Location = new System.Drawing.Point(886, 118);
            this.pnlMenuRight.Name = "pnlMenuRight";
            this.pnlMenuRight.Size = new System.Drawing.Size(289, 648);
            this.pnlMenuRight.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(80, 488);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 23);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Nhớ thiết lập";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.panel1.Location = new System.Drawing.Point(18, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 1);
            this.panel1.TabIndex = 2;
            // 
            // btnExportFile
            // 
            this.btnExportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnExportFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnExportFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.btnExportFile.BorderRadius = 30;
            this.btnExportFile.BorderSize = 2;
            this.btnExportFile.FlatAppearance.BorderSize = 0;
            this.btnExportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportFile.ForeColor = System.Drawing.Color.White;
            this.btnExportFile.Location = new System.Drawing.Point(27, 533);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(235, 73);
            this.btnExportFile.TabIndex = 1;
            this.btnExportFile.Text = "Xuất File";
            this.btnExportFile.TextColor = System.Drawing.Color.White;
            this.btnExportFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveStatistic
            // 
            this.btnSaveStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnSaveStatistic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnSaveStatistic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.btnSaveStatistic.BorderRadius = 30;
            this.btnSaveStatistic.BorderSize = 2;
            this.btnSaveStatistic.FlatAppearance.BorderSize = 0;
            this.btnSaveStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStatistic.ForeColor = System.Drawing.Color.White;
            this.btnSaveStatistic.Location = new System.Drawing.Point(27, 402);
            this.btnSaveStatistic.Name = "btnSaveStatistic";
            this.btnSaveStatistic.Size = new System.Drawing.Size(235, 47);
            this.btnSaveStatistic.TabIndex = 1;
            this.btnSaveStatistic.Text = "Lưu thiết lập";
            this.btnSaveStatistic.TextColor = System.Drawing.Color.White;
            this.btnSaveStatistic.UseVisualStyleBackColor = false;
            // 
            // btnLoadStatistic
            // 
            this.btnLoadStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnLoadStatistic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnLoadStatistic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.btnLoadStatistic.BorderRadius = 30;
            this.btnLoadStatistic.BorderSize = 2;
            this.btnLoadStatistic.FlatAppearance.BorderSize = 0;
            this.btnLoadStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadStatistic.ForeColor = System.Drawing.Color.White;
            this.btnLoadStatistic.Location = new System.Drawing.Point(27, 315);
            this.btnLoadStatistic.Name = "btnLoadStatistic";
            this.btnLoadStatistic.Size = new System.Drawing.Size(235, 47);
            this.btnLoadStatistic.TabIndex = 1;
            this.btnLoadStatistic.Text = "Load thiết lập";
            this.btnLoadStatistic.TextColor = System.Drawing.Color.White;
            this.btnLoadStatistic.UseVisualStyleBackColor = false;
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnDefault.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnDefault.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.btnDefault.BorderRadius = 30;
            this.btnDefault.BorderSize = 2;
            this.btnDefault.FlatAppearance.BorderSize = 0;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.ForeColor = System.Drawing.Color.White;
            this.btnDefault.Location = new System.Drawing.Point(26, 234);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(235, 47);
            this.btnDefault.TabIndex = 1;
            this.btnDefault.Text = "Mặt định";
            this.btnDefault.TextColor = System.Drawing.Color.White;
            this.btnDefault.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnDeleteAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnDeleteAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.btnDeleteAll.BorderRadius = 30;
            this.btnDeleteAll.BorderSize = 2;
            this.btnDeleteAll.FlatAppearance.BorderSize = 0;
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(26, 163);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(235, 47);
            this.btnDeleteAll.TabIndex = 1;
            this.btnDeleteAll.Text = "Xóa tất cả";
            this.btnDeleteAll.TextColor = System.Drawing.Color.White;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            // 
            // btnChooseAll
            // 
            this.btnChooseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnChooseAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnChooseAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.btnChooseAll.BorderRadius = 30;
            this.btnChooseAll.BorderSize = 2;
            this.btnChooseAll.FlatAppearance.BorderSize = 0;
            this.btnChooseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseAll.ForeColor = System.Drawing.Color.White;
            this.btnChooseAll.Location = new System.Drawing.Point(26, 87);
            this.btnChooseAll.Name = "btnChooseAll";
            this.btnChooseAll.Size = new System.Drawing.Size(235, 47);
            this.btnChooseAll.TabIndex = 1;
            this.btnChooseAll.Text = "Chọn tất cả";
            this.btnChooseAll.TextColor = System.Drawing.Color.White;
            this.btnChooseAll.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(212)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "THIẾT LẬP NHANH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.tblpnlMain);
            this.Name = "frmClient";
            this.Text = "frmClient";
            this.tblpnlMain.ResumeLayout(false);
            this.tblpnlHeader.ResumeLayout(false);
            this.tblpnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tblpnlBody.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlMenuRight.ResumeLayout(false);
            this.pnlMenuRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnlMain;
        private System.Windows.Forms.TableLayoutPanel tblpnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNameSoftware;
        private System.Windows.Forms.TableLayoutPanel tblpnlBody;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlMenuRight;
        private CustomControls.btnCustom btnChooseAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.btnCustom btnExportFile;
        private CustomControls.btnCustom btnSaveStatistic;
        private CustomControls.btnCustom btnLoadStatistic;
        private CustomControls.btnCustom btnDefault;
        private CustomControls.btnCustom btnDeleteAll;
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHardware;
        private System.Windows.Forms.Button btnDifferent;
    }
}
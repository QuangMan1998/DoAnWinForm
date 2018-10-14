namespace SplashScreen
{
    partial class FormQLmuontra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLmuontra));
            this.tabQuanLy = new System.Windows.Forms.TabControl();
            this.tabMuon = new System.Windows.Forms.TabPage();
            this.btBack = new System.Windows.Forms.Button();
            this.dtgMuonSach = new System.Windows.Forms.DataGridView();
            this.gbPhieuMuon = new System.Windows.Forms.GroupBox();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTenMuon = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTra = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btTraSach = new System.Windows.Forms.Button();
            this.btBackTra = new System.Windows.Forms.Button();
            this.dtgTraSach = new System.Windows.Forms.DataGridView();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.lbMaPhieuMuon = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btTimPM = new System.Windows.Forms.Button();
            this.tabQuanLy.SuspendLayout();
            this.tabMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuonSach)).BeginInit();
            this.gbPhieuMuon.SuspendLayout();
            this.tabTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTraSach)).BeginInit();
            this.SuspendLayout();
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Controls.Add(this.tabMuon);
            this.tabQuanLy.Controls.Add(this.tabTra);
            this.tabQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuanLy.Location = new System.Drawing.Point(0, 2);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.SelectedIndex = 0;
            this.tabQuanLy.Size = new System.Drawing.Size(953, 547);
            this.tabQuanLy.TabIndex = 0;
            // 
            // tabMuon
            // 
            this.tabMuon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabMuon.Controls.Add(this.btBack);
            this.tabMuon.Controls.Add(this.btXoa);
            this.tabMuon.Controls.Add(this.btnXuat);
            this.tabMuon.Controls.Add(this.dtgMuonSach);
            this.tabMuon.Controls.Add(this.gbPhieuMuon);
            this.tabMuon.Controls.Add(this.lb1);
            this.tabMuon.Controls.Add(this.label1);
            this.tabMuon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabMuon.Location = new System.Drawing.Point(4, 29);
            this.tabMuon.Name = "tabMuon";
            this.tabMuon.Padding = new System.Windows.Forms.Padding(3);
            this.tabMuon.Size = new System.Drawing.Size(1007, 514);
            this.tabMuon.TabIndex = 0;
            this.tabMuon.Text = "MƯỢN SÁCH";
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBack.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btBack.ForeColor = System.Drawing.Color.Teal;
            this.btBack.Location = new System.Drawing.Point(20, 31);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(130, 56);
            this.btBack.TabIndex = 23;
            this.btBack.Text = "<< Quay lại";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // dtgMuonSach
            // 
            this.dtgMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMuonSach.GridColor = System.Drawing.SystemColors.Info;
            this.dtgMuonSach.Location = new System.Drawing.Point(464, 109);
            this.dtgMuonSach.Margin = new System.Windows.Forms.Padding(4);
            this.dtgMuonSach.Name = "dtgMuonSach";
            this.dtgMuonSach.Size = new System.Drawing.Size(476, 385);
            this.dtgMuonSach.TabIndex = 20;
            // 
            // gbPhieuMuon
            // 
            this.gbPhieuMuon.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gbPhieuMuon.Controls.Add(this.dtNgayTra);
            this.gbPhieuMuon.Controls.Add(this.dtNgayMuon);
            this.gbPhieuMuon.Controls.Add(this.txtTenSach);
            this.gbPhieuMuon.Controls.Add(this.txtTenMuon);
            this.gbPhieuMuon.Controls.Add(this.txtSL);
            this.gbPhieuMuon.Controls.Add(this.label5);
            this.gbPhieuMuon.Controls.Add(this.label4);
            this.gbPhieuMuon.Controls.Add(this.label3);
            this.gbPhieuMuon.Controls.Add(this.label8);
            this.gbPhieuMuon.Controls.Add(this.label2);
            this.gbPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhieuMuon.ForeColor = System.Drawing.Color.Teal;
            this.gbPhieuMuon.Location = new System.Drawing.Point(20, 109);
            this.gbPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.gbPhieuMuon.Name = "gbPhieuMuon";
            this.gbPhieuMuon.Padding = new System.Windows.Forms.Padding(4);
            this.gbPhieuMuon.Size = new System.Drawing.Size(423, 322);
            this.gbPhieuMuon.TabIndex = 19;
            this.gbPhieuMuon.TabStop = false;
            this.gbPhieuMuon.Text = "THÔNG TIN PHIẾU MƯỢN";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTra.Location = new System.Drawing.Point(14, 278);
            this.dtNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayTra.MaxDate = new System.DateTime(2309, 1, 1, 0, 0, 0, 0);
            this.dtNgayTra.MinDate = new System.DateTime(2010, 1, 25, 0, 0, 0, 0);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(392, 26);
            this.dtNgayTra.TabIndex = 10;
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(14, 207);
            this.dtNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayMuon.MaxDate = new System.DateTime(2309, 1, 1, 0, 0, 0, 0);
            this.dtNgayMuon.MinDate = new System.DateTime(2010, 1, 25, 0, 0, 0, 0);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(392, 26);
            this.dtNgayMuon.TabIndex = 9;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(11, 107);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(395, 26);
            this.txtTenSach.TabIndex = 4;
            // 
            // txtTenMuon
            // 
            this.txtTenMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMuon.Location = new System.Drawing.Point(11, 48);
            this.txtTenMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMuon.Name = "txtTenMuon";
            this.txtTenMuon.Size = new System.Drawing.Size(395, 26);
            this.txtTenMuon.TabIndex = 4;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(107, 148);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(139, 26);
            this.txtSL.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "NGÀY TRẢ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "NGÀY MƯỢN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "SỐ LƯỢNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "TÊN NGƯỜI MƯỢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN SÁCH";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb1.ForeColor = System.Drawing.Color.Teal;
            this.lb1.Location = new System.Drawing.Point(294, 17);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(411, 70);
            this.lb1.TabIndex = 17;
            this.lb1.Text = "MƯỢN SÁCH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÊN NGƯỜI MƯỢN";
            // 
            // tabTra
            // 
            this.tabTra.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabTra.Controls.Add(this.label7);
            this.tabTra.Controls.Add(this.btTraSach);
            this.tabTra.Controls.Add(this.btBackTra);
            this.tabTra.Controls.Add(this.dtgTraSach);
            this.tabTra.Controls.Add(this.txtMaPM);
            this.tabTra.Controls.Add(this.lbMaPhieuMuon);
            this.tabTra.Controls.Add(this.btTimPM);
            this.tabTra.Location = new System.Drawing.Point(4, 29);
            this.tabTra.Name = "tabTra";
            this.tabTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabTra.Size = new System.Drawing.Size(945, 514);
            this.tabTra.TabIndex = 1;
            this.tabTra.Text = "TRẢ SÁCH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(321, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(337, 70);
            this.label7.TabIndex = 25;
            this.label7.Text = "TRẢ SÁCH";
            // 
            // btTraSach
            // 
            this.btTraSach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTraSach.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTraSach.ForeColor = System.Drawing.Color.Teal;
            this.btTraSach.Location = new System.Drawing.Point(752, 420);
            this.btTraSach.Name = "btTraSach";
            this.btTraSach.Size = new System.Drawing.Size(130, 56);
            this.btTraSach.TabIndex = 24;
            this.btTraSach.Text = "Trả Sách";
            this.btTraSach.UseVisualStyleBackColor = false;
            // 
            // btBackTra
            // 
            this.btBackTra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBackTra.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btBackTra.ForeColor = System.Drawing.Color.Teal;
            this.btBackTra.Location = new System.Drawing.Point(87, 420);
            this.btBackTra.Name = "btBackTra";
            this.btBackTra.Size = new System.Drawing.Size(130, 56);
            this.btBackTra.TabIndex = 24;
            this.btBackTra.Text = "<< Quay lại";
            this.btBackTra.UseVisualStyleBackColor = false;
            // 
            // dtgTraSach
            // 
            this.dtgTraSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTraSach.Location = new System.Drawing.Point(87, 163);
            this.dtgTraSach.Name = "dtgTraSach";
            this.dtgTraSach.RowTemplate.Height = 24;
            this.dtgTraSach.Size = new System.Drawing.Size(795, 223);
            this.dtgTraSach.TabIndex = 5;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPM.Location = new System.Drawing.Point(255, 108);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(341, 36);
            this.txtMaPM.TabIndex = 2;
            // 
            // lbMaPhieuMuon
            // 
            this.lbMaPhieuMuon.AutoSize = true;
            this.lbMaPhieuMuon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaPhieuMuon.ForeColor = System.Drawing.Color.Teal;
            this.lbMaPhieuMuon.Location = new System.Drawing.Point(83, 116);
            this.lbMaPhieuMuon.Name = "lbMaPhieuMuon";
            this.lbMaPhieuMuon.Size = new System.Drawing.Size(166, 24);
            this.lbMaPhieuMuon.TabIndex = 1;
            this.lbMaPhieuMuon.Text = "Mã phiếu mượn:";
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btXoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(266, 440);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btXoa.Size = new System.Drawing.Size(109, 54);
            this.btXoa.TabIndex = 22;
            this.btXoa.Text = "XOÁ";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXuat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuat.Image = global::SplashScreen.Properties.Resources.if_common_logout_signout_exit_glyph_763291__1_;
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(78, 443);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnXuat.Size = new System.Drawing.Size(120, 51);
            this.btnXuat.TabIndex = 21;
            this.btnXuat.Text = "XUẤT";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.UseVisualStyleBackColor = false;
            // 
            // btTimPM
            // 
            this.btTimPM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTimPM.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTimPM.ForeColor = System.Drawing.Color.Teal;
            this.btTimPM.Image = ((System.Drawing.Image)(resources.GetObject("btTimPM.Image")));
            this.btTimPM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimPM.Location = new System.Drawing.Point(642, 101);
            this.btTimPM.Name = "btTimPM";
            this.btTimPM.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btTimPM.Size = new System.Drawing.Size(130, 56);
            this.btTimPM.TabIndex = 24;
            this.btTimPM.Text = "Tìm kiếm";
            this.btTimPM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimPM.UseVisualStyleBackColor = false;
            // 
            // FormQLmuontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 554);
            this.Controls.Add(this.tabQuanLy);
            this.IsMdiContainer = true;
            this.Name = "FormQLmuontra";
            this.Text = "FormQLmuontra";
            this.tabQuanLy.ResumeLayout(false);
            this.tabMuon.ResumeLayout(false);
            this.tabMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuonSach)).EndInit();
            this.gbPhieuMuon.ResumeLayout(false);
            this.gbPhieuMuon.PerformLayout();
            this.tabTra.ResumeLayout(false);
            this.tabTra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTraSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQuanLy;
        private System.Windows.Forms.TabPage tabMuon;
        private System.Windows.Forms.TabPage tabTra;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView dtgMuonSach;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox gbPhieuMuon;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTenMuon;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaPhieuMuon;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.DataGridView dtgTraSach;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btTraSach;
        private System.Windows.Forms.Button btBackTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btTimPM;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Label label8;
    }
}
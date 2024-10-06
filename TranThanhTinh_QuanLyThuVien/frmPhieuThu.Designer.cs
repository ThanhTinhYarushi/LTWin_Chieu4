namespace TranThanhTinh_QuanLyThuVien
{
    partial class frmPhieuThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lsv_PhieuThu = new System.Windows.Forms.ListView();
            this.txt_MaPhieuThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grp_PhieuThuTien = new System.Windows.Forms.GroupBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.txt_MaDocGia = new System.Windows.Forms.TextBox();
            this.txt_SoTienThu = new System.Windows.Forms.TextBox();
            this.txt_SoTienNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.grp_PhieuThuTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(414, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Thu Tiền";
            // 
            // lsv_PhieuThu
            // 
            this.lsv_PhieuThu.FullRowSelect = true;
            this.lsv_PhieuThu.GridLines = true;
            this.lsv_PhieuThu.HideSelection = false;
            this.lsv_PhieuThu.Location = new System.Drawing.Point(12, 95);
            this.lsv_PhieuThu.Name = "lsv_PhieuThu";
            this.lsv_PhieuThu.Size = new System.Drawing.Size(544, 584);
            this.lsv_PhieuThu.TabIndex = 1;
            this.lsv_PhieuThu.UseCompatibleStateImageBehavior = false;
            this.lsv_PhieuThu.View = System.Windows.Forms.View.Details;
            this.lsv_PhieuThu.SelectedIndexChanged += new System.EventHandler(this.lsv_PhieuThu_SelectedIndexChanged);
            // 
            // txt_MaPhieuThu
            // 
            this.txt_MaPhieuThu.Location = new System.Drawing.Point(145, 32);
            this.txt_MaPhieuThu.Name = "txt_MaPhieuThu";
            this.txt_MaPhieuThu.Size = new System.Drawing.Size(209, 20);
            this.txt_MaPhieuThu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Phiếu Thu";
            // 
            // grp_PhieuThuTien
            // 
            this.grp_PhieuThuTien.Controls.Add(this.pic2);
            this.grp_PhieuThuTien.Controls.Add(this.txt_MaNhanVien);
            this.grp_PhieuThuTien.Controls.Add(this.txt_MaDocGia);
            this.grp_PhieuThuTien.Controls.Add(this.txt_SoTienThu);
            this.grp_PhieuThuTien.Controls.Add(this.txt_SoTienNo);
            this.grp_PhieuThuTien.Controls.Add(this.label6);
            this.grp_PhieuThuTien.Controls.Add(this.label5);
            this.grp_PhieuThuTien.Controls.Add(this.label4);
            this.grp_PhieuThuTien.Controls.Add(this.label3);
            this.grp_PhieuThuTien.Controls.Add(this.label2);
            this.grp_PhieuThuTien.Controls.Add(this.txt_MaPhieuThu);
            this.grp_PhieuThuTien.Location = new System.Drawing.Point(562, 392);
            this.grp_PhieuThuTien.Name = "grp_PhieuThuTien";
            this.grp_PhieuThuTien.Size = new System.Drawing.Size(592, 234);
            this.grp_PhieuThuTien.TabIndex = 4;
            this.grp_PhieuThuTien.TabStop = false;
            this.grp_PhieuThuTien.Text = "Thông Tin Phiếu Thu Tiền";
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(362, 19);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(217, 197);
            this.pic2.TabIndex = 12;
            this.pic2.TabStop = false;
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.Location = new System.Drawing.Point(145, 196);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(138, 20);
            this.txt_MaNhanVien.TabIndex = 11;
            // 
            // txt_MaDocGia
            // 
            this.txt_MaDocGia.Location = new System.Drawing.Point(145, 160);
            this.txt_MaDocGia.Name = "txt_MaDocGia";
            this.txt_MaDocGia.Size = new System.Drawing.Size(138, 20);
            this.txt_MaDocGia.TabIndex = 10;
            // 
            // txt_SoTienThu
            // 
            this.txt_SoTienThu.Location = new System.Drawing.Point(145, 118);
            this.txt_SoTienThu.Name = "txt_SoTienThu";
            this.txt_SoTienThu.Size = new System.Drawing.Size(209, 20);
            this.txt_SoTienThu.TabIndex = 9;
            // 
            // txt_SoTienNo
            // 
            this.txt_SoTienNo.Location = new System.Drawing.Point(145, 74);
            this.txt_SoTienNo.Name = "txt_SoTienNo";
            this.txt_SoTienNo.Size = new System.Drawing.Size(209, 20);
            this.txt_SoTienNo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã Độc Giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Tiền Thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Tiền Nợ";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(562, 95);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(592, 291);
            this.pic1.TabIndex = 5;
            this.pic1.TabStop = false;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(562, 632);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(111, 47);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(679, 632);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(111, 47);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(796, 632);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(111, 47);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(913, 632);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(111, 47);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(1030, 632);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(111, 25);
            this.btn_Luu.TabIndex = 10;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(1030, 663);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(111, 22);
            this.btn_Huy.TabIndex = 11;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // frmPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 691);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.grp_PhieuThuTien);
            this.Controls.Add(this.lsv_PhieuThu);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuThu";
            this.Text = "Phiếu Thu Tiền";
            this.Load += new System.EventHandler(this.frmPhieuThu_Load);
            this.grp_PhieuThuTien.ResumeLayout(false);
            this.grp_PhieuThuTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsv_PhieuThu;
        private System.Windows.Forms.TextBox txt_MaPhieuThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grp_PhieuThuTien;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.TextBox txt_MaDocGia;
        private System.Windows.Forms.TextBox txt_SoTienThu;
        private System.Windows.Forms.TextBox txt_SoTienNo;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.PictureBox pic2;
    }
}
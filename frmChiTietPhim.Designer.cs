
namespace GUI
{
    partial class frmChiTietPhim
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
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.txtDienVien = new System.Windows.Forms.TextBox();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtNgayKhoiChieu = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnXemSuatChieu = new System.Windows.Forms.Button();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Location = new System.Drawing.Point(12, 23);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(336, 321);
            this.pictureBoxPoster.TabIndex = 0;
            this.pictureBoxPoster.TabStop = false;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(489, 58);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.ReadOnly = true;
            this.txtTenPhim.Size = new System.Drawing.Size(333, 22);
            this.txtTenPhim.TabIndex = 1;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(489, 104);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.ReadOnly = true;
            this.txtTheLoai.Size = new System.Drawing.Size(333, 22);
            this.txtTheLoai.TabIndex = 2;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.Location = new System.Drawing.Point(489, 152);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.ReadOnly = true;
            this.txtDaoDien.Size = new System.Drawing.Size(333, 22);
            this.txtDaoDien.TabIndex = 3;
            // 
            // txtDienVien
            // 
            this.txtDienVien.Location = new System.Drawing.Point(489, 201);
            this.txtDienVien.Name = "txtDienVien";
            this.txtDienVien.ReadOnly = true;
            this.txtDienVien.Size = new System.Drawing.Size(333, 22);
            this.txtDienVien.TabIndex = 4;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Location = new System.Drawing.Point(489, 253);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.ReadOnly = true;
            this.txtThoiLuong.Size = new System.Drawing.Size(333, 22);
            this.txtThoiLuong.TabIndex = 5;
            // 
            // txtNgayKhoiChieu
            // 
            this.txtNgayKhoiChieu.Location = new System.Drawing.Point(489, 303);
            this.txtNgayKhoiChieu.Name = "txtNgayKhoiChieu";
            this.txtNgayKhoiChieu.ReadOnly = true;
            this.txtNgayKhoiChieu.Size = new System.Drawing.Size(333, 22);
            this.txtNgayKhoiChieu.TabIndex = 6;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(489, 357);
            this.txtMoTa.MinimumSize = new System.Drawing.Size(4, 150);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(333, 150);
            this.txtMoTa.TabIndex = 7;
            // 
            // btnXemSuatChieu
            // 
            this.btnXemSuatChieu.Location = new System.Drawing.Point(617, 525);
            this.btnXemSuatChieu.Name = "btnXemSuatChieu";
            this.btnXemSuatChieu.Size = new System.Drawing.Size(115, 38);
            this.btnXemSuatChieu.TabIndex = 8;
            this.btnXemSuatChieu.Text = "Suất Chiếu";
            this.btnXemSuatChieu.UseVisualStyleBackColor = true;
            this.btnXemSuatChieu.Click += new System.EventHandler(this.btnXemSuatChieu_Click);
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(489, 18);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.ReadOnly = true;
            this.txtMaPhim.Size = new System.Drawing.Size(333, 22);
            this.txtMaPhim.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(373, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(370, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày Khởi Chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(370, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Thời Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(370, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Diễn Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(370, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Đạo Diễn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(370, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thể Loại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(370, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tên Phim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(373, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mô Tả";
            // 
            // frmChiTietPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(870, 615);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaPhim);
            this.Controls.Add(this.btnXemSuatChieu);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtNgayKhoiChieu);
            this.Controls.Add(this.txtThoiLuong);
            this.Controls.Add(this.txtDienVien);
            this.Controls.Add(this.txtDaoDien);
            this.Controls.Add(this.txtTheLoai);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.pictureBoxPoster);
            this.Name = "frmChiTietPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChiTietPhim";
            this.Load += new System.EventHandler(this.frmChiTietPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.TextBox txtDienVien;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtNgayKhoiChieu;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnXemSuatChieu;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
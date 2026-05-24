
namespace GUI
{
    partial class frmThongKe
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
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnNgay = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnTheoPhim = new System.Windows.Forms.Button();
            this.btnTheoSuatChieu = new System.Windows.Forms.Button();
            this.cbbNgayChieu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBieuDo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 184);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(886, 343);
            this.dgvThongKe.TabIndex = 0;
            // 
            // btnNgay
            // 
            this.btnNgay.Location = new System.Drawing.Point(12, 28);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(84, 35);
            this.btnNgay.TabIndex = 1;
            this.btnNgay.Text = "Ngày";
            this.btnNgay.UseVisualStyleBackColor = true;
            this.btnNgay.Click += new System.EventHandler(this.btnNgay_Click);
            // 
            // btnThang
            // 
            this.btnThang.Location = new System.Drawing.Point(12, 69);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(84, 35);
            this.btnThang.TabIndex = 2;
            this.btnThang.Text = "Tháng";
            this.btnThang.UseVisualStyleBackColor = true;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btnNam
            // 
            this.btnNam.Location = new System.Drawing.Point(12, 114);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(84, 35);
            this.btnNam.TabIndex = 3;
            this.btnNam.Text = "Năm";
            this.btnNam.UseVisualStyleBackColor = true;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnTheoPhim
            // 
            this.btnTheoPhim.Location = new System.Drawing.Point(6, 69);
            this.btnTheoPhim.Name = "btnTheoPhim";
            this.btnTheoPhim.Size = new System.Drawing.Size(110, 35);
            this.btnTheoPhim.TabIndex = 4;
            this.btnTheoPhim.Text = "Theo Phim";
            this.btnTheoPhim.UseVisualStyleBackColor = true;
            this.btnTheoPhim.Click += new System.EventHandler(this.btnTheoPhim_Click);
            // 
            // btnTheoSuatChieu
            // 
            this.btnTheoSuatChieu.Location = new System.Drawing.Point(6, 28);
            this.btnTheoSuatChieu.Name = "btnTheoSuatChieu";
            this.btnTheoSuatChieu.Size = new System.Drawing.Size(110, 35);
            this.btnTheoSuatChieu.TabIndex = 5;
            this.btnTheoSuatChieu.Text = "Theo Suất";
            this.btnTheoSuatChieu.UseVisualStyleBackColor = true;
            this.btnTheoSuatChieu.Click += new System.EventHandler(this.btnTheoSuatChieu_Click);
            // 
            // cbbNgayChieu
            // 
            this.cbbNgayChieu.FormattingEnabled = true;
            this.cbbNgayChieu.Location = new System.Drawing.Point(85, 114);
            this.cbbNgayChieu.Name = "cbbNgayChieu";
            this.cbbNgayChieu.Size = new System.Drawing.Size(117, 24);
            this.cbbNgayChieu.TabIndex = 6;
            this.cbbNgayChieu.SelectedIndexChanged += new System.EventHandler(this.cbbNgayChieu_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.groupBox1.Controls.Add(this.btnThang);
            this.groupBox1.Controls.Add(this.btnNgay);
            this.groupBox1.Controls.Add(this.btnNam);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh Thu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.groupBox2.Controls.Add(this.btnBieuDo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnTheoSuatChieu);
            this.groupBox2.Controls.Add(this.btnTheoPhim);
            this.groupBox2.Controls.Add(this.cbbNgayChieu);
            this.groupBox2.Location = new System.Drawing.Point(378, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 164);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số Lượng - Doanh Thu";
            // 
            // btnBieuDo
            // 
            this.btnBieuDo.Location = new System.Drawing.Point(234, 108);
            this.btnBieuDo.Name = "btnBieuDo";
            this.btnBieuDo.Size = new System.Drawing.Size(84, 35);
            this.btnBieuDo.TabIndex = 8;
            this.btnBieuDo.Text = "Biểu Đồ";
            this.btnBieuDo.UseVisualStyleBackColor = true;
            this.btnBieuDo.Click += new System.EventHandler(this.btnBieuDo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngày";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(886, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThongKe);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnTheoPhim;
        private System.Windows.Forms.Button btnTheoSuatChieu;
        private System.Windows.Forms.ComboBox cbbNgayChieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBieuDo;
    }
}
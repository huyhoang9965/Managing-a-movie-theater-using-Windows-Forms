
namespace GUI
{
    partial class frmBieuDo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.btnVeBieuDo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(235, 145);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(668, 363);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            // 
            // cbbLoaiThongKe
            // 
            this.cbbLoaiThongKe.FormattingEnabled = true;
            this.cbbLoaiThongKe.Location = new System.Drawing.Point(299, 58);
            this.cbbLoaiThongKe.Name = "cbbLoaiThongKe";
            this.cbbLoaiThongKe.Size = new System.Drawing.Size(322, 24);
            this.cbbLoaiThongKe.TabIndex = 4;
            // 
            // btnVeBieuDo
            // 
            this.btnVeBieuDo.Location = new System.Drawing.Point(656, 51);
            this.btnVeBieuDo.Name = "btnVeBieuDo";
            this.btnVeBieuDo.Size = new System.Drawing.Size(95, 36);
            this.btnVeBieuDo.TabIndex = 5;
            this.btnVeBieuDo.Text = "Vẽ Biểu Đồ";
            this.btnVeBieuDo.UseVisualStyleBackColor = true;
            this.btnVeBieuDo.Click += new System.EventHandler(this.btnVeBieuDo_Click);
            // 
            // frmBieuDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1125, 562);
            this.Controls.Add(this.btnVeBieuDo);
            this.Controls.Add(this.cbbLoaiThongKe);
            this.Controls.Add(this.chartDoanhThu);
            this.Name = "frmBieuDo";
            this.Text = "frmBieuDo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBieuDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.ComboBox cbbLoaiThongKe;
        private System.Windows.Forms.Button btnVeBieuDo;
    }
}
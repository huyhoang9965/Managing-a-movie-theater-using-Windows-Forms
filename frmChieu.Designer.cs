
namespace GUI
{
    partial class frmChieu
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
            this.flpSuatChieu = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpSuatChieu
            // 
            this.flpSuatChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.flpSuatChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSuatChieu.Location = new System.Drawing.Point(0, 0);
            this.flpSuatChieu.Name = "flpSuatChieu";
            this.flpSuatChieu.Size = new System.Drawing.Size(830, 481);
            this.flpSuatChieu.TabIndex = 0;
            // 
            // frmChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 481);
            this.Controls.Add(this.flpSuatChieu);
            this.Name = "frmChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChieu";
            this.Load += new System.EventHandler(this.frmChieu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSuatChieu;
    }
}

namespace GUI
{
    partial class ChiTietVe
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
            this.dgvChiTietVe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietVe
            // 
            this.dgvChiTietVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietVe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.dgvChiTietVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietVe.Location = new System.Drawing.Point(0, 0);
            this.dgvChiTietVe.Name = "dgvChiTietVe";
            this.dgvChiTietVe.RowHeadersWidth = 51;
            this.dgvChiTietVe.RowTemplate.Height = 24;
            this.dgvChiTietVe.Size = new System.Drawing.Size(800, 450);
            this.dgvChiTietVe.TabIndex = 0;
            // 
            // ChiTietVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChiTietVe);
            this.Name = "ChiTietVe";
            this.Text = "ChiTietVe";
            this.Load += new System.EventHandler(this.ChiTietVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietVe;
    }
}
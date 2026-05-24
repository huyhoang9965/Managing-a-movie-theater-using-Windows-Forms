
namespace GUI
{
    partial class frmNguoiDung
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
            this.panelChinh = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnChiTietVe = new System.Windows.Forms.Button();
            this.btnPhim = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChinh
            // 
            this.panelChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChinh.Location = new System.Drawing.Point(220, 80);
            this.panelChinh.Name = "panelChinh";
            this.panelChinh.Size = new System.Drawing.Size(833, 672);
            this.panelChinh.TabIndex = 12;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnChiTietVe);
            this.panelMenu.Controls.Add(this.btnPhim);
            this.panelMenu.Controls.Add(this.btnTrangChu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 80);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 672);
            this.panelMenu.TabIndex = 10;
            // 
            // btnChiTietVe
            // 
            this.btnChiTietVe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChiTietVe.FlatAppearance.BorderSize = 0;
            this.btnChiTietVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietVe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChiTietVe.Image = global::GUI.Properties.Resources.pngtree_ticket_ic1101;
            this.btnChiTietVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTietVe.Location = new System.Drawing.Point(0, 120);
            this.btnChiTietVe.Name = "btnChiTietVe";
            this.btnChiTietVe.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnChiTietVe.Size = new System.Drawing.Size(220, 60);
            this.btnChiTietVe.TabIndex = 5;
            this.btnChiTietVe.Text = "Vé Của Tôi";
            this.btnChiTietVe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTietVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTietVe.UseVisualStyleBackColor = true;
            this.btnChiTietVe.Click += new System.EventHandler(this.btnChiTietVe_Click);
            // 
            // btnPhim
            // 
            this.btnPhim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhim.FlatAppearance.BorderSize = 0;
            this.btnPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhim.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPhim.Image = global::GUI.Properties.Resources._4623186;
            this.btnPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhim.Location = new System.Drawing.Point(0, 60);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPhim.Size = new System.Drawing.Size(220, 60);
            this.btnPhim.TabIndex = 4;
            this.btnPhim.Text = "   Phim";
            this.btnPhim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhim.UseVisualStyleBackColor = true;
            this.btnPhim.Click += new System.EventHandler(this.btnPhim_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTrangChu.Image = global::GUI.Properties.Resources.ANHBIA_;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(220, 60);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "   Trang Chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.ForeColor = System.Drawing.Color.White;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1053, 80);
            this.panelHome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "HOME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 752);
            this.Controls.Add(this.panelChinh);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHome);
            this.Name = "frmNguoiDung";
            this.Text = "frmNguoiDung";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChinh;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPhim;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChiTietVe;
    }
}
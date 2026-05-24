
namespace GUI
{
    partial class frmRapChieu
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvRapChieu = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(73, 78);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(455, 22);
            this.txtTimKiem.TabIndex = 12;
            // 
            // dgvRapChieu
            // 
            this.dgvRapChieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRapChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRapChieu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.dgvRapChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapChieu.Location = new System.Drawing.Point(-17, 130);
            this.dgvRapChieu.Name = "dgvRapChieu";
            this.dgvRapChieu.RowHeadersWidth = 51;
            this.dgvRapChieu.RowTemplate.Height = 24;
            this.dgvRapChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRapChieu.Size = new System.Drawing.Size(975, 465);
            this.dgvRapChieu.TabIndex = 10;
            this.dgvRapChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRapChieu_CellClick);
            this.dgvRapChieu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRapChieu_CellDoubleClick);
            this.dgvRapChieu.SelectionChanged += new System.EventHandler(this.dgvRapChieu_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI.Properties.Resources.icthem2;
            this.btnThem.Location = new System.Drawing.Point(702, 65);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(53, 44);
            this.btnThem.TabIndex = 15;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI.Properties.Resources.xoa;
            this.btnXoa.Location = new System.Drawing.Point(629, 65);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(53, 44);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::GUI.Properties.Resources.timkiem1;
            this.btnTimKiem.Location = new System.Drawing.Point(553, 67);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(53, 44);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = " ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmRapChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(940, 521);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvRapChieu);
            this.Name = "frmRapChieu";
            this.Text = "frmRapChieu";
            this.Load += new System.EventHandler(this.frmRapChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapChieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvRapChieu;
    }
}
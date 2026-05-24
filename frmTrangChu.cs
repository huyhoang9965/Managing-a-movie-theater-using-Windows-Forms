using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTrangChu : Form
    {
        private List<string> filmImages = new List<string>();
        private int currentFilmImageIndex = 0;

        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

            LoadImages("Poster", filmImages);

            pictureBoxFilm.Dock = DockStyle.Fill;
            pictureBoxFilm.SizeMode = PictureBoxSizeMode.Zoom; 

            if (filmImages.Count > 0)
                pictureBoxFilm.Image = LoadImage(filmImages[currentFilmImageIndex]);

            timer1.Interval = 3000;
            timer1.Start();
        }

        private void LoadImages(string folderName, List<string> imageList)
        {
            // Đường dẫn đến thư mục chứa ảnh
            string path = Path.Combine(Application.StartupPath, folderName);

            if (Directory.Exists(path))
            {
                string[] extensions = new[] { "*.jpg", "*.jpeg", "*.png" };

                foreach (var ext in extensions)
                {
                    imageList.AddRange(Directory.GetFiles(path, ext));
                }
            }
        }

        private Image LoadImage(string filePath)
        {
            try
            {
                return Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải ảnh: {filePath}\nLỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Trả về null nếu không tải được ảnh
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (filmImages.Count > 0)
            {
                // Giải phóng tài nguyên ảnh cũ trước khi thay đổi ảnh
                if (pictureBoxFilm.Image != null)
                {
                    // Dispose ảnh cũ để giải phóng bộ nhớ
                    pictureBoxFilm.Image.Dispose();
                }

                // Tải và hiển thị ảnh tiếp theo
                pictureBoxFilm.Image = LoadImage(filmImages[currentFilmImageIndex]);

                // Cập nhật chỉ số ảnh tiếp theo (vòng qua danh sách ảnh)
                currentFilmImageIndex = (currentFilmImageIndex + 1) % filmImages.Count;
            }
        }
    }
}

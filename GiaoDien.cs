using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienDangNhap
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel_NoiDung_Paint(object sender, PaintEventArgs e)
        {
        }

        // ═══════════════════════════════════════════════════════════
        // NÚT THÚ CƯNG
        // ═══════════════════════════════════════════════════════════
        private void button1_Click(object sender, EventArgs e)
        {
            // Xóa các control cũ trong panel (nếu có)
            panel_NoiDung.Controls.Clear();

            // Tạo instance của form ThuCungGiaoDien
            ThuCungGiaoDien formThuCung = new ThuCungGiaoDien();

            // Set các thuộc tính để form hiển thị như một control
            formThuCung.TopLevel = false;
            formThuCung.FormBorderStyle = FormBorderStyle.None;
            formThuCung.Dock = DockStyle.Fill;

            // Thêm form vào panel
            panel_NoiDung.Controls.Add(formThuCung);

            // Hiển thị form
            formThuCung.Show();
        }

        // ═══════════════════════════════════════════════════════════
        // NÚT TÀI KHOẢN
        // ═══════════════════════════════════════════════════════════
        private void button6_Click(object sender, EventArgs e)
        {
            // Xóa các control cũ trong panel (nếu có)
            panel_NoiDung.Controls.Clear();

            // Tạo instance của form TrangQuanLyTaiKhoan
            TrangQuanLyTaiKhoan formTaiKhoan = new TrangQuanLyTaiKhoan();

            // Set các thuộc tính để form hiển thị như một control
            formTaiKhoan.TopLevel = false;
            formTaiKhoan.FormBorderStyle = FormBorderStyle.None;
            formTaiKhoan.Dock = DockStyle.Fill;

            // Thêm form vào panel
            panel_NoiDung.Controls.Add(formTaiKhoan);

            // Hiển thị form
            formTaiKhoan.Show();
        }
    }
}



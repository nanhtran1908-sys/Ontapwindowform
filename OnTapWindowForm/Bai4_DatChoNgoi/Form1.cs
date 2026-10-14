using System.Globalization;

namespace Bai4
{
    public partial class Form1 : Form
    {
        private const int SO_HANG = 4;
        private const int SO_COT = 5;

        // Màu trạng thái
        private readonly Color MAU_TRONG = Color.WhiteSmoke;
        private readonly Color MAU_DANG_CHON = Color.LimeGreen;
        private readonly Color MAU_DA_DAT = Color.Firebrick;

        // Giá theo khung giờ (cùng thứ tự với các mục trong cboKhungGio)
        private readonly string[] tenKhungGio = { "Sáng (100.000đ / vị trí)", "Tối (150.000đ / vị trí)" };
        private readonly decimal[] giaKhungGio = { 100000, 150000 };

        // Một vài vị trí đã có người đặt sẵn (để minh họa màu đỏ)
        private readonly int[] viTriDaDatSan = { 3, 8, 14 };

        private readonly List<Button> dsNut = new List<Button>();
        private readonly CultureInfo vn = new CultureInfo("vi-VN");

        public Form1()
        {
            InitializeComponent();
        }

        // ============ KHỞI TẠO 20 NÚT BẰNG VÒNG LẶP FOR ============
        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhungGio.Items.AddRange(tenKhungGio);
            cboKhungGio.SelectedIndex = 0;

            tlpSoDo.SuspendLayout();
            for (int i = 0; i < SO_HANG * SO_COT; i++)
            {
                int hang = i / SO_COT;
                int cot = i % SO_COT;

                Button btn = new Button();
                btn.Name = "btnViTri" + (i + 1);
                btn.Text = ((char)('A' + hang)).ToString() + (cot + 1);   // A1..D5
                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(5);
                btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Silver;
                btn.Cursor = Cursors.Hand;

                if (Array.IndexOf(viTriDaDatSan, i + 1) >= 0)
                    DatTrangThai(btn, TrangThai.DaDat);
                else
                    DatTrangThai(btn, TrangThai.Trong);

                // Gán CHUNG 1 hàm xử lý Click cho cả 20 nút
                btn.Click += ViTri_Click;

                tlpSoDo.Controls.Add(btn, cot, hang);
                dsNut.Add(btn);
            }
            tlpSoDo.ResumeLayout();

            CapNhatThongKe();
        }

        // ============ HÀM XỬ LÝ SỰ KIỆN DÙNG CHUNG ============
        private void ViTri_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;   // biết được nút nào vừa bấm nhờ tham số sender
            TrangThai tt = (TrangThai)btn.Tag;

            if (tt == TrangThai.DaDat)
            {
                MessageBox.Show($"Vị trí {btn.Text} đã có người đặt, vui lòng chọn vị trí khác.",
                    "Không thể chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Bấm lần 1: chọn (xanh) - bấm lần 2: bỏ chọn (trắng)
            DatTrangThai(btn, tt == TrangThai.Trong ? TrangThai.DangChon : TrangThai.Trong);
            CapNhatThongKe();
        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongKe();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            List<Button> dangChon = LayCacNutDangChon();
            if (dangChon.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn vị trí nào.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string danhSach = string.Join(", ", dangChon.Select(b => b.Text));
            string thongBao = "Xác nhận đặt các vị trí: " + danhSach + "\n" +
                              "Khung giờ: " + cboKhungGio.Text + "\n" +
                              "Tổng tiền: " + lblTamTinh.Text;

            if (MessageBox.Show(thongBao, "Xác nhận đặt", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Button b in dangChon) DatTrangThai(b, TrangThai.DaDat);
                CapNhatThongKe();
                MessageBox.Show("Đặt chỗ thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            foreach (Button b in LayCacNutDangChon()) DatTrangThai(b, TrangThai.Trong);
            CapNhatThongKe();
        }

        // ============ HÀM HỖ TRỢ ============
        private enum TrangThai { Trong, DangChon, DaDat }

        private void DatTrangThai(Button btn, TrangThai tt)
        {
            btn.Tag = tt;
            switch (tt)
            {
                case TrangThai.Trong:
                    btn.BackColor = MAU_TRONG;
                    btn.ForeColor = Color.Black;
                    break;
                case TrangThai.DangChon:
                    btn.BackColor = MAU_DANG_CHON;
                    btn.ForeColor = Color.White;
                    break;
                case TrangThai.DaDat:
                    btn.BackColor = MAU_DA_DAT;
                    btn.ForeColor = Color.White;
                    break;
            }
        }

        private List<Button> LayCacNutDangChon()
        {
            return dsNut.Where(b => (TrangThai)b.Tag == TrangThai.DangChon).ToList();
        }

        // Cập nhật số lượng + tạm tính tiền (realtime)
        private void CapNhatThongKe()
        {
            int soChon = LayCacNutDangChon().Count;
            decimal donGia = cboKhungGio.SelectedIndex >= 0 ? giaKhungGio[cboKhungGio.SelectedIndex] : 0;

            lblSoViTriChon.Text = soChon.ToString();
            lblTamTinh.Text = (soChon * donGia).ToString("N0", vn) + " đ";
        }
    }
}

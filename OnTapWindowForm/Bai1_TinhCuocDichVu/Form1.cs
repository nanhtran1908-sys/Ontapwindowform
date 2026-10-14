using System.Globalization;

namespace Bai1
{
    public partial class Form1 : Form
    {
        private readonly CultureInfo vn = new CultureInfo("vi-VN");

        public Form1()
        {
            InitializeComponent();
        }

        // Đọc 1 ô số. Trả về false (và báo lỗi) nếu ô trống hoặc không phải số.
        private bool DocSo(TextBox txt, string tenO, out decimal giaTri)
        {
            giaTri = 0;
            string s = txt.Text.Trim();

            if (s == "")
            {
                BaoLoi(txt, $"Vui lòng nhập \"{tenO}\".");
                return false;
            }

            // Chấp nhận 100000, 100.000 (hàng nghìn) và số thập phân 12,5 hoặc 12.5
            if (!DocSoLinhHoat(s, out giaTri))
            {
                BaoLoi(txt, $"\"{tenO}\" phải là số, không được nhập chữ.");
                return false;
            }
            return true;
        }

        private void BaoLoi(TextBox txt, string thongBao)
        {
            MessageBox.Show(thongBao, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt.Focus();
            txt.SelectAll();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!DocSo(txtDonGia, "Đơn giá dịch vụ", out decimal donGia)) return;
            if (!DocSo(txtSoLuong, "Số lượng khách", out decimal soLuong)) return;
            if (!DocSo(txtGiamGia, "Mã giảm giá (%)", out decimal giamGia)) return;

            if (donGia < 0)
            {
                BaoLoi(txtDonGia, "Đơn giá không được âm.");
                return;
            }
            if (soLuong <= 0 || soLuong != Math.Floor(soLuong))
            {
                BaoLoi(txtSoLuong, "Số lượng khách phải là số nguyên lớn hơn 0.");
                return;
            }
            if (giamGia < 0 || giamGia > 100)
            {
                BaoLoi(txtGiamGia, "Phần trăm giảm giá phải nằm trong khoảng 0 - 100.");
                return;
            }

            // Tổng tiền = (Đơn giá × Số lượng) × (100 − %Giảm) / 100
            decimal tongTien = donGia * soLuong * (100 - giamGia) / 100;
            lblTongTien.Text = tongTien.ToString("N0", vn) + " đ";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Text = "0";
            lblTongTien.Text = "0 đ";
            txtDonGia.Focus();
        }

        // Đọc số linh hoạt: chấp nhận 100000, 100.000, 1.500.000, 0,5 và 0.5
        private static bool DocSoLinhHoat(string s, out decimal ketQua)
        {
            ketQua = 0;
            s = (s ?? "").Trim().Replace(" ", "");
            if (s == "") return false;

            CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");      // 1.234,5
            CultureInfo en = CultureInfo.InvariantCulture;              // 1,234.5
            bool coCham = s.IndexOf('.') >= 0;
            bool coPhay = s.IndexOf(',') >= 0;

            if (coCham && coPhay)   // dấu nào đứng sau cùng là dấu thập phân
                return decimal.TryParse(s, NumberStyles.Number, s.LastIndexOf(',') > s.LastIndexOf('.') ? vi : en, out ketQua);
            if (coPhay)             // 0,5  -> dấu phẩy là thập phân
                return decimal.TryParse(s, NumberStyles.Number, vi, out ketQua);
            if (coCham && System.Text.RegularExpressions.Regex.IsMatch(s, @"^-?\d{1,3}(\.\d{3})+$"))
                return decimal.TryParse(s, NumberStyles.Number, vi, out ketQua);   // 100.000 -> hàng nghìn
            return decimal.TryParse(s, NumberStyles.Number, en, out ketQua);       // 0.5 hoặc 100000
        }
    }
}

using System.Globalization;

namespace Bai3
{
    public partial class Form1 : Form
    {
        private readonly CultureInfo vn = new CultureInfo("vi-VN");

        // Danh sách vật tư lưu tạm trên bộ nhớ RAM
        private readonly List<VatTu> dsVatTu = new List<VatTu>();

        public Form1()
        {
            InitializeComponent();
        }

        // ================== HÀM HỖ TRỢ ==================

        // Vẽ lại ListView từ List<VatTu>
        private void HienThiDanhSach()
        {
            lvVatTu.BeginUpdate();
            lvVatTu.Items.Clear();
            foreach (VatTu vt in dsVatTu)
            {
                ListViewItem item = new ListViewItem(vt.MaVT);
                item.SubItems.Add(vt.TenVT);
                item.SubItems.Add(vt.DonViTinh);
                item.SubItems.Add(vt.DonGia.ToString("N0", vn));
                item.Tag = vt;
                lvVatTu.Items.Add(item);
            }
            lvVatTu.EndUpdate();
            lblTongSo.Text = "Tổng số vật tư: " + dsVatTu.Count;
        }

        // Kiểm tra mã VT đã tồn tại trong ListView chưa (bỏ qua 1 dòng nếu đang cập nhật chính nó)
        private bool MaDaTonTai(string ma, ListViewItem boQua)
        {
            foreach (ListViewItem item in lvVatTu.Items)
            {
                if (item != boQua && string.Equals(item.Text, ma, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        // Đọc và kiểm tra dữ liệu trên khung nhập. Trả về null nếu dữ liệu không hợp lệ.
        private VatTu DocDuLieuNhap()
        {
            string ma = txtMaVT.Text.Trim();
            string ten = txtTenVT.Text.Trim();

            if (ma == "") { CanhBao("Vui lòng nhập Mã vật tư.", txtMaVT); return null; }
            if (ten == "") { CanhBao("Vui lòng nhập Tên vật tư.", txtTenVT); return null; }
            if (cboDonViTinh.SelectedIndex < 0) { CanhBao("Vui lòng chọn Đơn vị tính.", cboDonViTinh); return null; }

            decimal donGia;
            string s = txtDonGia.Text.Trim();
            if (!DocSoLinhHoat(s, out donGia))
            {
                CanhBao("Đơn giá nhập phải là số.", txtDonGia);
                return null;
            }
            if (donGia < 0) { CanhBao("Đơn giá không được âm.", txtDonGia); return null; }

            return new VatTu(ma, ten, cboDonViTinh.Text, donGia);
        }

        private void CanhBao(string thongBao, Control oNhap)
        {
            MessageBox.Show(thongBao, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            oNhap.Focus();
        }

        private void XoaTrangONhap()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            cboDonViTinh.SelectedIndex = -1;
            txtDonGia.Clear();
            txtMaVT.Focus();
        }

        // ================== SỰ KIỆN ==================

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            VatTu vt = DocDuLieuNhap();
            if (vt == null) return;

            if (MaDaTonTai(vt.MaVT, null))
            {
                CanhBao($"Mã vật tư \"{vt.MaVT}\" đã tồn tại trong danh sách!", txtMaVT);
                return;
            }

            dsVatTu.Add(vt);
            HienThiDanhSach();
            XoaTrangONhap();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 dòng trong danh sách để cập nhật.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem dongChon = lvVatTu.SelectedItems[0];
            VatTu moi = DocDuLieuNhap();
            if (moi == null) return;

            if (MaDaTonTai(moi.MaVT, dongChon))
            {
                CanhBao($"Mã vật tư \"{moi.MaVT}\" đã trùng với một vật tư khác!", txtMaVT);
                return;
            }

            VatTu cu = (VatTu)dongChon.Tag;
            cu.MaVT = moi.MaVT;
            cu.TenVT = moi.TenVT;
            cu.DonViTinh = moi.DonViTinh;
            cu.DonGia = moi.DonGia;

            int viTri = dongChon.Index;
            HienThiDanhSach();
            lvVatTu.Items[viTri].Selected = true;
            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 dòng cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem dongChon = lvVatTu.SelectedItems[0];
            DialogResult kq = MessageBox.Show(
                $"Bạn có chắc muốn xóa vật tư \"{dongChon.Text} - {dongChon.SubItems[1].Text}\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                dsVatTu.Remove((VatTu)dongChon.Tag);
                HienThiDanhSach();
                XoaTrangONhap();
            }
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (dsVatTu.Count == 0) return;

            DialogResult kq = MessageBox.Show("Xóa toàn bộ " + dsVatTu.Count + " vật tư trong danh sách?",
                "Xác nhận xóa toàn bộ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (kq == DialogResult.Yes)
            {
                dsVatTu.Clear();
                HienThiDanhSach();
                XoaTrangONhap();
            }
        }

        // Chọn 1 dòng -> đẩy dữ liệu ngược lại các ô nhập bên trái
        private void lvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0) return;

            VatTu vt = (VatTu)lvVatTu.SelectedItems[0].Tag;
            txtMaVT.Text = vt.MaVT;
            txtTenVT.Text = vt.TenVT;
            cboDonViTinh.SelectedItem = vt.DonViTinh;
            txtDonGia.Text = vt.DonGia.ToString("N0", vn);
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

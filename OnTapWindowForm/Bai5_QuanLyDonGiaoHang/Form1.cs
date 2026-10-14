using System.Globalization;
using System.Text;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Dùng định dạng số kiểu Việt Nam (1.000.000) cho toàn bộ form
            CultureInfo.CurrentCulture = new CultureInfo("vi-VN");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt biểu tượng lỗi của lưới vào góc trên bên phải (bên trong lưới)
            errorProvider.SetIconAlignment(dgvHangHoa, ErrorIconAlignment.TopRight);
            errorProvider.SetIconPadding(dgvHangHoa, -22);

            tmrDongHo_Tick(null, EventArgs.Empty);
            LoaiVanChuyen_CheckedChanged(null, EventArgs.Empty);

            // Dữ liệu mẫu
            ThemDong("Bàn phím cơ", 2, 1.2m, 850000);
            ThemDong("Chuột không dây", 3, 0.3m, 320000);
            TinhTongCong();
        }

        // ===================== ĐỒNG HỒ (TIMER) =====================
        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString("HH:mm:ss  dd/MM/yyyy");
        }

        private void LoaiVanChuyen_CheckedChanged(object sender, EventArgs e)
        {
            int soNgay = rdoHoaToc.Checked ? 0 : (rdoNhanh.Checked ? 2 : 5);
            dtpNgayGiao.Value = DateTime.Today.AddDays(soNgay);
        }

        // ===================== PHÍM TẮT F2 / DELETE =====================
        // ProcessCmdKey bắt phím ở cấp Form trước khi control con xử lý
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2)
            {
                ThemDongMoiTrenLuoi();
                return true;
            }

            // Chỉ xóa dòng khi đang đứng ở lưới và KHÔNG đang gõ trong ô
            if (keyData == Keys.Delete && dgvHangHoa.ContainsFocus && !dgvHangHoa.IsCurrentCellInEditMode)
            {
                XoaDongDangChon();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ThemDongMoiTrenLuoi()
        {
            dgvHangHoa.EndEdit();
            int i = dgvHangHoa.Rows.Add();
            dgvHangHoa.Focus();
            dgvHangHoa.CurrentCell = dgvHangHoa.Rows[i].Cells[colTenHang.Index];
            dgvHangHoa.BeginEdit(true);
            TinhTongCong();
        }

        private void XoaDongDangChon()
        {
            if (dgvHangHoa.CurrentRow == null) return;
            dgvHangHoa.Rows.RemoveAt(dgvHangHoa.CurrentRow.Index);   // RowsRemoved sẽ tự tính lại tổng
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            XoaDongDangChon();
        }

        // ===================== DATAGRIDVIEW =====================
        private bool LaCotSo(int cot)
        {
            return cot == colSoLuong.Index || cot == colTrongLuong.Index || cot == colDonGia.Index;
        }

        // Khi người dùng gõ xong 1 ô số: chuyển chuỗi thành decimal để lưới hiển thị đúng định dạng
        private void dgvHangHoa_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (!LaCotSo(e.ColumnIndex) || e.Value == null) return;

            decimal so;
            if (DocSo(e.Value.ToString(), out so))
            {
                e.Value = so;
                e.ParsingApplied = true;
            }
        }

        // Giá trị ô thay đổi -> kiểm tra dòng, tính lại Thành tiền và các tổng
        private void dgvHangHoa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex == colThanhTien.Index) return;

            KiemTraVaTinhDong(dgvHangHoa.Rows[e.RowIndex]);
            TinhTongCong();
        }

        private void dgvHangHoa_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TinhTongCong();
        }

        // Kiểm tra từng ô của 1 dòng, bật icon lỗi đỏ trong ô (ErrorText) nếu không hợp lệ
        private void KiemTraVaTinhDong(DataGridViewRow row)
        {
            decimal sl, tl, gia;
            bool slHopLe = KiemTraO(row.Cells[colSoLuong.Index], "Số lượng", true, out sl);
            KiemTraO(row.Cells[colTrongLuong.Index], "Trọng lượng", true, out tl);
            bool giaHopLe = KiemTraO(row.Cells[colDonGia.Index], "Đơn giá", false, out gia);

            if (slHopLe && giaHopLe && !OTrong(row.Cells[colSoLuong.Index]) && !OTrong(row.Cells[colDonGia.Index]))
                row.Cells[colThanhTien.Index].Value = sl * gia;
            else
                row.Cells[colThanhTien.Index].Value = null;
        }

        // phaiLonHon0 = true: giá trị phải > 0 ; false: chỉ cần >= 0. Ô trống không báo lỗi.
        private bool KiemTraO(DataGridViewCell cell, string ten, bool phaiLonHon0, out decimal giaTri)
        {
            giaTri = 0;
            cell.ErrorText = "";
            if (OTrong(cell)) return true;

            if (!DocSo(cell.Value, out giaTri))
            {
                cell.ErrorText = ten + " phải là số.";
                return false;
            }
            if (phaiLonHon0 && giaTri <= 0)
            {
                cell.ErrorText = ten + " phải lớn hơn 0.";
                return false;
            }
            if (!phaiLonHon0 && giaTri < 0)
            {
                cell.ErrorText = ten + " không được âm.";
                return false;
            }
            return true;
        }

        private bool OTrong(DataGridViewCell cell)
        {
            return cell.Value == null || cell.Value.ToString().Trim() == "";
        }

        // Cộng dồn và hiển thị lên StatusStrip
        private void TinhTongCong()
        {
            decimal tongSL = 0, tongTL = 0, tongTien = 0;
            bool coLoi = false;

            foreach (DataGridViewRow row in dgvHangHoa.Rows)
            {
                decimal so;
                DataGridViewCell oSL = row.Cells[colSoLuong.Index];
                DataGridViewCell oTL = row.Cells[colTrongLuong.Index];

                if (oSL.ErrorText != "" || oTL.ErrorText != "" || row.Cells[colDonGia.Index].ErrorText != "")
                    coLoi = true;

                if (oSL.ErrorText == "" && DocSo(oSL.Value, out so)) tongSL += so;
                if (oTL.ErrorText == "" && DocSo(oTL.Value, out so)) tongTL += so;
                if (DocSo(row.Cells[colThanhTien.Index].Value, out so)) tongTien += so;
            }

            lblTongSoLuong.Text = "Tổng SL: " + tongSL.ToString("N0");
            lblTongTrongLuong.Text = "Tổng TL: " + tongTL.ToString("N2") + " kg";
            lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " đ";

            // ErrorProvider cho cả lưới
            errorProvider.SetError(dgvHangHoa, coLoi ? "Có ô Số lượng / Trọng lượng / Đơn giá không hợp lệ (≤ 0 hoặc không phải số)." : "");
        }

        // ===================== NHẬP NHANH (ErrorProvider bên cạnh ô nhập) =====================
        private void txtNhapSo_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            KiemTraTextBoxSo(txt, txt == txtNhapSL ? "Số lượng" : "Trọng lượng", true);
        }

        private bool KiemTraTextBoxSo(TextBox txt, string ten, bool phaiLonHon0)
        {
            decimal so;
            string s = txt.Text.Trim();

            if (s == "")
                errorProvider.SetError(txt, "Vui lòng nhập " + ten + ".");
            else if (!DocSo(s, out so))
                errorProvider.SetError(txt, ten + " phải là số.");
            else if (phaiLonHon0 && so <= 0)
                errorProvider.SetError(txt, ten + " phải lớn hơn 0.");
            else if (!phaiLonHon0 && so < 0)
                errorProvider.SetError(txt, ten + " không được âm.");
            else
            {
                errorProvider.SetError(txt, "");
                return true;
            }
            return false;
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            bool hopLe = true;

            if (txtNhapTen.Text.Trim() == "")
            {
                errorProvider.SetError(txtNhapTen, "Vui lòng nhập tên hàng.");
                hopLe = false;
            }
            else errorProvider.SetError(txtNhapTen, "");

            hopLe &= KiemTraTextBoxSo(txtNhapSL, "Số lượng", true);
            hopLe &= KiemTraTextBoxSo(txtNhapTL, "Trọng lượng", true);
            hopLe &= KiemTraTextBoxSo(txtNhapGia, "Đơn giá", false);
            if (!hopLe) return;

            decimal sl, tl, gia;
            DocSo(txtNhapSL.Text, out sl);
            DocSo(txtNhapTL.Text, out tl);
            DocSo(txtNhapGia.Text, out gia);

            ThemDong(txtNhapTen.Text.Trim(), sl, tl, gia);
            TinhTongCong();

            txtNhapTen.Clear();
            txtNhapSL.Clear();
            txtNhapTL.Clear();
            txtNhapGia.Clear();
            foreach (Control c in new Control[] { txtNhapTen, txtNhapSL, txtNhapTL, txtNhapGia })
                errorProvider.SetError(c, "");
            txtNhapTen.Focus();
        }

        private void ThemDong(string ten, decimal sl, decimal tl, decimal gia)
        {
            int i = dgvHangHoa.Rows.Add(ten, sl, tl, gia, null);
            KiemTraVaTinhDong(dgvHangHoa.Rows[i]);
        }

        // ===================== XÁC NHẬN ĐƠN =====================
        private void btnXacNhanDon_Click(object sender, EventArgs e)
        {
            dgvHangHoa.EndEdit();
            bool hopLe = true;

            if (txtTenKH.Text.Trim() == "")
            {
                errorProvider.SetError(txtTenKH, "Vui lòng nhập họ tên khách hàng.");
                hopLe = false;
            }
            else errorProvider.SetError(txtTenKH, "");

            string sdt = txtSDT.Text.Trim();
            if (sdt.Length < 10 || !sdt.All(char.IsDigit))
            {
                errorProvider.SetError(txtSDT, "Số điện thoại phải gồm 10 - 11 chữ số.");
                hopLe = false;
            }
            else errorProvider.SetError(txtSDT, "");

            if (txtDiaChi.Text.Trim() == "")
            {
                errorProvider.SetError(txtDiaChi, "Vui lòng nhập địa chỉ giao hàng.");
                hopLe = false;
            }
            else errorProvider.SetError(txtDiaChi, "");

            if (!hopLe)
            {
                MessageBox.Show("Thông tin khách hàng chưa hợp lệ, xem các biểu tượng cảnh báo đỏ.",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Đơn hàng chưa có mặt hàng nào (nhấn F2 để thêm dòng).",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgvHangHoa.Rows)
            {
                bool thieu = OTrong(row.Cells[colTenHang.Index]) || OTrong(row.Cells[colSoLuong.Index]) ||
                             OTrong(row.Cells[colTrongLuong.Index]) || OTrong(row.Cells[colDonGia.Index]);
                bool loi = row.Cells[colSoLuong.Index].ErrorText != "" || row.Cells[colTrongLuong.Index].ErrorText != "" ||
                           row.Cells[colDonGia.Index].ErrorText != "";
                if (thieu || loi)
                {
                    dgvHangHoa.CurrentCell = row.Cells[colTenHang.Index];
                    MessageBox.Show($"Dòng {row.Index + 1} còn thiếu dữ liệu hoặc có giá trị không hợp lệ.",
                        "Kiểm tra hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string loaiVC = rdoHoaToc.Checked ? rdoHoaToc.Text : (rdoNhanh.Checked ? rdoNhanh.Text : rdoTieuChuan.Text);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Khách hàng: " + txtTenKH.Text.Trim() + " - " + sdt);
            sb.AppendLine("Địa chỉ: " + txtDiaChi.Text.Trim());
            sb.AppendLine("Vận chuyển: " + loaiVC + " - giao ngày " + dtpNgayGiao.Value.ToString("dd/MM/yyyy"));
            sb.AppendLine("Số mặt hàng: " + dgvHangHoa.Rows.Count);
            sb.AppendLine(lblTongSoLuong.Text + " | " + lblTongTrongLuong.Text);
            sb.AppendLine(lblTongTien.Text);

            MessageBox.Show(sb.ToString(), "Xác nhận đơn hàng thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ===================== HÀM ĐỌC SỐ DÙNG CHUNG =====================
        private bool DocSo(object giaTri, out decimal ketQua)
        {
            ketQua = 0;
            if (giaTri == null) return false;
            if (giaTri is decimal) { ketQua = (decimal)giaTri; return true; }
            if (giaTri is int || giaTri is double || giaTri is float || giaTri is long)
            {
                ketQua = Convert.ToDecimal(giaTri);
                return true;
            }

            return DocSoLinhHoat(giaTri.ToString(), out ketQua);
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

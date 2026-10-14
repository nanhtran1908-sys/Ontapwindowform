using System.Text;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private string duongDanAnh = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NhapLai();
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh chụp lỗi";
                ofd.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Đọc ảnh qua MemoryStream để không khóa file gốc trên ổ đĩa
                    byte[] duLieu = File.ReadAllBytes(ofd.FileName);
                    Image anhCu = picAnhLoi.Image;
                    picAnhLoi.Image = Image.FromStream(new MemoryStream(duLieu));
                    if (anhCu != null) anhCu.Dispose();

                    picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
                    duongDanAnh = ofd.FileName;
                }
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            // Kiểm tra các thông tin bắt buộc
            if (txtMaPhieu.Text.Trim() == "")
            {
                CanhBao("Vui lòng nhập Mã phiếu.", txtMaPhieu);
                return;
            }
            if (txtNguoiYeuCau.Text.Trim() == "")
            {
                CanhBao("Vui lòng nhập Người yêu cầu.", txtNguoiYeuCau);
                return;
            }
            if (cboLoaiSuCo.SelectedIndex < 0)
            {
                CanhBao("Vui lòng chọn Loại sự cố.", cboLoaiSuCo);
                return;
            }

            // Mức độ ưu tiên
            string uuTien = "Trung bình";
            if (rdoThap.Checked) uuTien = "Thấp";
            else if (rdoKhanCap.Checked) uuTien = "Khẩn cấp";

            // Thiết bị ảnh hưởng (duyệt các CheckBox)
            List<string> thietBi = new List<string>();
            foreach (CheckBox chk in new[] { chkMayTinhBan, chkLaptop, chkMayIn, chkDienThoai })
            {
                if (chk.Checked) thietBi.Add(chk.Text);
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===== TÓM TẮT PHIẾU SỰ CỐ =====");
            sb.AppendLine("Mã phiếu: " + txtMaPhieu.Text.Trim());
            sb.AppendLine("Người yêu cầu: " + txtNguoiYeuCau.Text.Trim());
            sb.AppendLine("Ngày ghi nhận: " + dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine("Mức độ ưu tiên: " + uuTien);
            sb.AppendLine("Loại sự cố: " + cboLoaiSuCo.Text);
            sb.AppendLine("Thiết bị ảnh hưởng: " + (thietBi.Count > 0 ? string.Join(", ", thietBi) : "(không chọn)"));
            sb.AppendLine("Ảnh chụp lỗi: " + (duongDanAnh != "" ? Path.GetFileName(duongDanAnh) : "(chưa đính kèm)"));

            MessageBox.Show(sb.ToString(), "Gửi yêu cầu thành công",
                MessageBoxButtons.OK,
                uuTien == "Khẩn cấp" ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            NhapLai();
        }

        private void NhapLai()
        {
            txtMaPhieu.Text = "SC" + DateTime.Now.ToString("yyMMddHHmmss");   // gợi ý mã phiếu tự động
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;
            rdoTrungBinh.Checked = true;
            cboLoaiSuCo.SelectedIndex = -1;
            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            if (picAnhLoi.Image != null)
            {
                picAnhLoi.Image.Dispose();
                picAnhLoi.Image = null;
            }
            duongDanAnh = "";
            txtNguoiYeuCau.Focus();
        }

        private void CanhBao(string thongBao, Control oNhap)
        {
            MessageBox.Show(thongBao, "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            oNhap.Focus();
        }
    }
}

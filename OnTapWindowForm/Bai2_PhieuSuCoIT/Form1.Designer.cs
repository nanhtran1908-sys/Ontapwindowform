namespace Bai2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            grpThongTin = new GroupBox();
            lblMaPhieu = new Label();
            txtMaPhieu = new TextBox();
            lblNguoiYeuCau = new Label();
            txtNguoiYeuCau = new TextBox();
            lblNgay = new Label();
            dtpNgayGhiNhan = new DateTimePicker();
            grpUuTien = new GroupBox();
            rdoThap = new RadioButton();
            rdoTrungBinh = new RadioButton();
            rdoKhanCap = new RadioButton();
            grpPhanLoai = new GroupBox();
            lblLoaiSuCo = new Label();
            cboLoaiSuCo = new ComboBox();
            lblThietBi = new Label();
            chkMayTinhBan = new CheckBox();
            chkLaptop = new CheckBox();
            chkMayIn = new CheckBox();
            chkDienThoai = new CheckBox();
            lblAnhLoi = new Label();
            picAnhLoi = new PictureBox();
            btnTaiAnh = new Button();
            btnGuiYeuCau = new Button();
            btnNhapLai = new Button();
            grpThongTin.SuspendLayout();
            grpUuTien.SuspendLayout();
            grpPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(0, 84, 166);
            lblTieuDe.Location = new Point(12, 10);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(736, 32);
            lblTieuDe.TabIndex = 10;
            lblTieuDe.Text = "PHIẾU TIẾP NHẬN SỰ CỐ IT";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // grpThongTin
            //
            grpThongTin.Controls.Add(lblMaPhieu);
            grpThongTin.Controls.Add(txtMaPhieu);
            grpThongTin.Controls.Add(lblNguoiYeuCau);
            grpThongTin.Controls.Add(txtNguoiYeuCau);
            grpThongTin.Controls.Add(lblNgay);
            grpThongTin.Controls.Add(dtpNgayGhiNhan);
            grpThongTin.Controls.Add(grpUuTien);
            grpThongTin.Location = new Point(12, 50);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(350, 270);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin phiếu";
            //
            // lblMaPhieu
            //
            lblMaPhieu.Location = new Point(15, 30);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(110, 23);
            lblMaPhieu.TabIndex = 10;
            lblMaPhieu.Text = "Mã phiếu:";
            lblMaPhieu.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtMaPhieu
            //
            txtMaPhieu.Location = new Point(130, 30);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(200, 23);
            txtMaPhieu.TabIndex = 0;
            //
            // lblNguoiYeuCau
            //
            lblNguoiYeuCau.Location = new Point(15, 65);
            lblNguoiYeuCau.Name = "lblNguoiYeuCau";
            lblNguoiYeuCau.Size = new Size(110, 23);
            lblNguoiYeuCau.TabIndex = 11;
            lblNguoiYeuCau.Text = "Người yêu cầu:";
            lblNguoiYeuCau.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtNguoiYeuCau
            //
            txtNguoiYeuCau.Location = new Point(130, 65);
            txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            txtNguoiYeuCau.Size = new Size(200, 23);
            txtNguoiYeuCau.TabIndex = 1;
            //
            // lblNgay
            //
            lblNgay.Location = new Point(15, 100);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(110, 23);
            lblNgay.TabIndex = 12;
            lblNgay.Text = "Ngày ghi nhận:";
            lblNgay.TextAlign = ContentAlignment.MiddleLeft;
            //
            // dtpNgayGhiNhan
            //
            dtpNgayGhiNhan.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayGhiNhan.Format = DateTimePickerFormat.Custom;
            dtpNgayGhiNhan.Location = new Point(130, 100);
            dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            dtpNgayGhiNhan.Size = new Size(200, 23);
            dtpNgayGhiNhan.TabIndex = 2;
            //
            // grpUuTien
            //
            grpUuTien.Controls.Add(rdoThap);
            grpUuTien.Controls.Add(rdoTrungBinh);
            grpUuTien.Controls.Add(rdoKhanCap);
            grpUuTien.Location = new Point(15, 140);
            grpUuTien.Name = "grpUuTien";
            grpUuTien.Size = new Size(315, 110);
            grpUuTien.TabIndex = 3;
            grpUuTien.TabStop = false;
            grpUuTien.Text = "Mức độ ưu tiên";
            //
            // rdoThap
            //
            rdoThap.Location = new Point(20, 25);
            rdoThap.Name = "rdoThap";
            rdoThap.Size = new Size(200, 24);
            rdoThap.TabIndex = 0;
            rdoThap.Text = "Thấp";
            rdoThap.UseVisualStyleBackColor = true;
            //
            // rdoTrungBinh
            //
            rdoTrungBinh.Checked = true;
            rdoTrungBinh.Location = new Point(20, 52);
            rdoTrungBinh.Name = "rdoTrungBinh";
            rdoTrungBinh.Size = new Size(200, 24);
            rdoTrungBinh.TabIndex = 1;
            rdoTrungBinh.TabStop = true;
            rdoTrungBinh.Text = "Trung bình";
            rdoTrungBinh.UseVisualStyleBackColor = true;
            //
            // rdoKhanCap
            //
            rdoKhanCap.ForeColor = Color.FromArgb(192, 0, 0);
            rdoKhanCap.Location = new Point(20, 79);
            rdoKhanCap.Name = "rdoKhanCap";
            rdoKhanCap.Size = new Size(200, 24);
            rdoKhanCap.TabIndex = 2;
            rdoKhanCap.Text = "Khẩn cấp";
            rdoKhanCap.UseVisualStyleBackColor = true;
            //
            // grpPhanLoai
            //
            grpPhanLoai.Controls.Add(lblLoaiSuCo);
            grpPhanLoai.Controls.Add(cboLoaiSuCo);
            grpPhanLoai.Controls.Add(lblThietBi);
            grpPhanLoai.Controls.Add(chkMayTinhBan);
            grpPhanLoai.Controls.Add(chkLaptop);
            grpPhanLoai.Controls.Add(chkMayIn);
            grpPhanLoai.Controls.Add(chkDienThoai);
            grpPhanLoai.Controls.Add(lblAnhLoi);
            grpPhanLoai.Controls.Add(picAnhLoi);
            grpPhanLoai.Controls.Add(btnTaiAnh);
            grpPhanLoai.Location = new Point(375, 50);
            grpPhanLoai.Name = "grpPhanLoai";
            grpPhanLoai.Size = new Size(373, 370);
            grpPhanLoai.TabIndex = 1;
            grpPhanLoai.TabStop = false;
            grpPhanLoai.Text = "Phân loại && Chi tiết";
            //
            // lblLoaiSuCo
            //
            lblLoaiSuCo.Location = new Point(15, 30);
            lblLoaiSuCo.Name = "lblLoaiSuCo";
            lblLoaiSuCo.Size = new Size(110, 23);
            lblLoaiSuCo.TabIndex = 10;
            lblLoaiSuCo.Text = "Loại sự cố:";
            lblLoaiSuCo.TextAlign = ContentAlignment.MiddleLeft;
            //
            // cboLoaiSuCo
            //
            cboLoaiSuCo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSuCo.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cboLoaiSuCo.Location = new Point(130, 30);
            cboLoaiSuCo.Name = "cboLoaiSuCo";
            cboLoaiSuCo.Size = new Size(225, 23);
            cboLoaiSuCo.TabIndex = 0;
            //
            // lblThietBi
            //
            lblThietBi.Location = new Point(15, 65);
            lblThietBi.Name = "lblThietBi";
            lblThietBi.Size = new Size(140, 23);
            lblThietBi.TabIndex = 11;
            lblThietBi.Text = "Thiết bị ảnh hưởng:";
            lblThietBi.TextAlign = ContentAlignment.MiddleLeft;
            //
            // chkMayTinhBan
            //
            chkMayTinhBan.Location = new Point(30, 90);
            chkMayTinhBan.Name = "chkMayTinhBan";
            chkMayTinhBan.Size = new Size(140, 24);
            chkMayTinhBan.TabIndex = 1;
            chkMayTinhBan.Text = "Máy tính bàn";
            chkMayTinhBan.UseVisualStyleBackColor = true;
            //
            // chkLaptop
            //
            chkLaptop.Location = new Point(190, 90);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(140, 24);
            chkLaptop.TabIndex = 2;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            //
            // chkMayIn
            //
            chkMayIn.Location = new Point(30, 118);
            chkMayIn.Name = "chkMayIn";
            chkMayIn.Size = new Size(140, 24);
            chkMayIn.TabIndex = 3;
            chkMayIn.Text = "Máy in";
            chkMayIn.UseVisualStyleBackColor = true;
            //
            // chkDienThoai
            //
            chkDienThoai.Location = new Point(190, 118);
            chkDienThoai.Name = "chkDienThoai";
            chkDienThoai.Size = new Size(140, 24);
            chkDienThoai.TabIndex = 4;
            chkDienThoai.Text = "Điện thoại";
            chkDienThoai.UseVisualStyleBackColor = true;
            //
            // lblAnhLoi
            //
            lblAnhLoi.Location = new Point(15, 152);
            lblAnhLoi.Name = "lblAnhLoi";
            lblAnhLoi.Size = new Size(140, 23);
            lblAnhLoi.TabIndex = 12;
            lblAnhLoi.Text = "Ảnh chụp lỗi:";
            lblAnhLoi.TextAlign = ContentAlignment.MiddleLeft;
            //
            // picAnhLoi
            //
            picAnhLoi.BackColor = Color.WhiteSmoke;
            picAnhLoi.BorderStyle = BorderStyle.FixedSingle;
            picAnhLoi.Location = new Point(15, 180);
            picAnhLoi.Name = "picAnhLoi";
            picAnhLoi.Size = new Size(340, 140);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.TabIndex = 13;
            picAnhLoi.TabStop = false;
            //
            // btnTaiAnh
            //
            btnTaiAnh.Location = new Point(235, 328);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(120, 30);
            btnTaiAnh.TabIndex = 5;
            btnTaiAnh.Text = "Tải ảnh lỗi...";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += btnTaiAnh_Click;
            //
            // btnGuiYeuCau
            //
            btnGuiYeuCau.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuiYeuCau.Location = new Point(12, 380);
            btnGuiYeuCau.Name = "btnGuiYeuCau";
            btnGuiYeuCau.Size = new Size(170, 40);
            btnGuiYeuCau.TabIndex = 2;
            btnGuiYeuCau.Text = "Gửi yêu cầu";
            btnGuiYeuCau.UseVisualStyleBackColor = true;
            btnGuiYeuCau.Click += btnGuiYeuCau_Click;
            //
            // btnNhapLai
            //
            btnNhapLai.Location = new Point(192, 380);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(170, 40);
            btnNhapLai.TabIndex = 3;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 435);
            Controls.Add(lblTieuDe);
            Controls.Add(grpThongTin);
            Controls.Add(grpPhanLoai);
            Controls.Add(btnGuiYeuCau);
            Controls.Add(btnNhapLai);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 2 - Form tiếp nhận & phân loại sự cố IT";
            Load += Form1_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpUuTien.ResumeLayout(false);
            grpPhanLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTieuDe;
        private GroupBox grpThongTin;
        private Label lblMaPhieu;
        private TextBox txtMaPhieu;
        private Label lblNguoiYeuCau;
        private TextBox txtNguoiYeuCau;
        private Label lblNgay;
        private DateTimePicker dtpNgayGhiNhan;
        private GroupBox grpUuTien;
        private RadioButton rdoThap;
        private RadioButton rdoTrungBinh;
        private RadioButton rdoKhanCap;
        private GroupBox grpPhanLoai;
        private Label lblLoaiSuCo;
        private ComboBox cboLoaiSuCo;
        private Label lblThietBi;
        private CheckBox chkMayTinhBan;
        private CheckBox chkLaptop;
        private CheckBox chkMayIn;
        private CheckBox chkDienThoai;
        private Label lblAnhLoi;
        private PictureBox picAnhLoi;
        private Button btnTaiAnh;
        private Button btnGuiYeuCau;
        private Button btnNhapLai;
    }
}

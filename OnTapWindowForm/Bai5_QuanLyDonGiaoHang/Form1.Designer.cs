namespace Bai5
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle styleSo = new DataGridViewCellStyle();
            DataGridViewCellStyle styleKg = new DataGridViewCellStyle();
            DataGridViewCellStyle styleTien = new DataGridViewCellStyle();
            DataGridViewCellStyle styleThanhTien = new DataGridViewCellStyle();
            splitMain = new SplitContainer();
            grpVanChuyen = new GroupBox();
            rdoTieuChuan = new RadioButton();
            rdoNhanh = new RadioButton();
            rdoHoaToc = new RadioButton();
            lblNgayGiao = new Label();
            dtpNgayGiao = new DateTimePicker();
            btnXacNhanDon = new Button();
            lblPhimTat = new Label();
            grpKhachHang = new GroupBox();
            lblTenKH = new Label();
            txtTenKH = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            dgvHangHoa = new DataGridView();
            colTenHang = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colTrongLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            grpNhapNhanh = new GroupBox();
            lblNhapTen = new Label();
            txtNhapTen = new TextBox();
            lblNhapSL = new Label();
            txtNhapSL = new TextBox();
            lblNhapTL = new Label();
            txtNhapTL = new TextBox();
            lblNhapGia = new Label();
            txtNhapGia = new TextBox();
            btnThemHang = new Button();
            btnXoaDong = new Button();
            statusStrip = new StatusStrip();
            lblThoiGian = new ToolStripStatusLabel();
            lblKhoangTrong = new ToolStripStatusLabel();
            lblTongSoLuong = new ToolStripStatusLabel();
            lblTongTrongLuong = new ToolStripStatusLabel();
            lblTongTien = new ToolStripStatusLabel();
            tmrDongHo = new System.Windows.Forms.Timer(components);
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            grpVanChuyen.SuspendLayout();
            grpKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            grpNhapNhanh.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            //
            // splitMain
            //
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            splitMain.Panel1.Controls.Add(lblPhimTat);
            splitMain.Panel1.Controls.Add(grpVanChuyen);
            splitMain.Panel1.Controls.Add(grpKhachHang);
            splitMain.Panel1.Padding = new Padding(8);
            splitMain.Panel1MinSize = 280;
            splitMain.Panel2.Controls.Add(dgvHangHoa);
            splitMain.Panel2.Controls.Add(grpNhapNhanh);
            splitMain.Panel2.Padding = new Padding(8);
            splitMain.Size = new Size(1004, 536);
            splitMain.SplitterDistance = 320;
            splitMain.TabIndex = 0;
            //
            // grpKhachHang
            //
            grpKhachHang.Controls.Add(lblTenKH);
            grpKhachHang.Controls.Add(txtTenKH);
            grpKhachHang.Controls.Add(lblSDT);
            grpKhachHang.Controls.Add(txtSDT);
            grpKhachHang.Controls.Add(lblDiaChi);
            grpKhachHang.Controls.Add(txtDiaChi);
            grpKhachHang.Dock = DockStyle.Top;
            grpKhachHang.Location = new Point(8, 8);
            grpKhachHang.Name = "grpKhachHang";
            grpKhachHang.Size = new Size(304, 190);
            grpKhachHang.TabIndex = 0;
            grpKhachHang.TabStop = false;
            grpKhachHang.Text = "Thông tin khách hàng";
            //
            // lblTenKH
            //
            lblTenKH.Location = new Point(12, 28);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(85, 23);
            lblTenKH.TabIndex = 10;
            lblTenKH.Text = "Họ tên:";
            lblTenKH.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtTenKH
            //
            txtTenKH.Location = new Point(100, 28);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(185, 23);
            txtTenKH.TabIndex = 0;
            //
            // lblSDT
            //
            lblSDT.Location = new Point(12, 63);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(85, 23);
            lblSDT.TabIndex = 11;
            lblSDT.Text = "Điện thoại:";
            lblSDT.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtSDT
            //
            txtSDT.Location = new Point(100, 63);
            txtSDT.MaxLength = 11;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(185, 23);
            txtSDT.TabIndex = 1;
            //
            // lblDiaChi
            //
            lblDiaChi.Location = new Point(12, 98);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(85, 23);
            lblDiaChi.TabIndex = 12;
            lblDiaChi.Text = "Địa chỉ giao:";
            lblDiaChi.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtDiaChi
            //
            txtDiaChi.Location = new Point(100, 98);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ScrollBars = ScrollBars.Vertical;
            txtDiaChi.Size = new Size(185, 75);
            txtDiaChi.TabIndex = 2;
            //
            // grpVanChuyen
            //
            grpVanChuyen.Controls.Add(rdoTieuChuan);
            grpVanChuyen.Controls.Add(rdoNhanh);
            grpVanChuyen.Controls.Add(rdoHoaToc);
            grpVanChuyen.Controls.Add(lblNgayGiao);
            grpVanChuyen.Controls.Add(dtpNgayGiao);
            grpVanChuyen.Controls.Add(btnXacNhanDon);
            grpVanChuyen.Dock = DockStyle.Top;
            grpVanChuyen.Location = new Point(8, 198);
            grpVanChuyen.Name = "grpVanChuyen";
            grpVanChuyen.Size = new Size(304, 210);
            grpVanChuyen.TabIndex = 1;
            grpVanChuyen.TabStop = false;
            grpVanChuyen.Text = "Loại vận chuyển";
            //
            // rdoTieuChuan
            //
            rdoTieuChuan.Checked = true;
            rdoTieuChuan.Location = new Point(15, 25);
            rdoTieuChuan.Name = "rdoTieuChuan";
            rdoTieuChuan.Size = new Size(270, 24);
            rdoTieuChuan.TabIndex = 0;
            rdoTieuChuan.TabStop = true;
            rdoTieuChuan.Text = "Tiêu chuẩn (3 - 5 ngày)";
            rdoTieuChuan.UseVisualStyleBackColor = true;
            rdoTieuChuan.CheckedChanged += LoaiVanChuyen_CheckedChanged;
            //
            // rdoNhanh
            //
            rdoNhanh.Location = new Point(15, 52);
            rdoNhanh.Name = "rdoNhanh";
            rdoNhanh.Size = new Size(270, 24);
            rdoNhanh.TabIndex = 1;
            rdoNhanh.Text = "Nhanh (1 - 2 ngày)";
            rdoNhanh.UseVisualStyleBackColor = true;
            rdoNhanh.CheckedChanged += LoaiVanChuyen_CheckedChanged;
            //
            // rdoHoaToc
            //
            rdoHoaToc.ForeColor = Color.FromArgb(192, 0, 0);
            rdoHoaToc.Location = new Point(15, 79);
            rdoHoaToc.Name = "rdoHoaToc";
            rdoHoaToc.Size = new Size(270, 24);
            rdoHoaToc.TabIndex = 2;
            rdoHoaToc.Text = "Hỏa tốc (trong ngày)";
            rdoHoaToc.UseVisualStyleBackColor = true;
            rdoHoaToc.CheckedChanged += LoaiVanChuyen_CheckedChanged;
            //
            // lblNgayGiao
            //
            lblNgayGiao.Location = new Point(12, 115);
            lblNgayGiao.Name = "lblNgayGiao";
            lblNgayGiao.Size = new Size(110, 23);
            lblNgayGiao.TabIndex = 10;
            lblNgayGiao.Text = "Ngày giao dự kiến:";
            lblNgayGiao.TextAlign = ContentAlignment.MiddleLeft;
            //
            // dtpNgayGiao
            //
            dtpNgayGiao.CustomFormat = "dd/MM/yyyy";
            dtpNgayGiao.Format = DateTimePickerFormat.Custom;
            dtpNgayGiao.Location = new Point(125, 115);
            dtpNgayGiao.Name = "dtpNgayGiao";
            dtpNgayGiao.Size = new Size(160, 23);
            dtpNgayGiao.TabIndex = 3;
            //
            // btnXacNhanDon
            //
            btnXacNhanDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXacNhanDon.Location = new Point(15, 155);
            btnXacNhanDon.Name = "btnXacNhanDon";
            btnXacNhanDon.Size = new Size(270, 38);
            btnXacNhanDon.TabIndex = 4;
            btnXacNhanDon.Text = "Xác nhận đơn hàng";
            btnXacNhanDon.UseVisualStyleBackColor = true;
            btnXacNhanDon.Click += btnXacNhanDon_Click;
            //
            // lblPhimTat
            //
            lblPhimTat.Dock = DockStyle.Fill;
            lblPhimTat.ForeColor = Color.DimGray;
            lblPhimTat.Location = new Point(8, 408);
            lblPhimTat.Name = "lblPhimTat";
            lblPhimTat.Padding = new Padding(4, 10, 4, 4);
            lblPhimTat.Size = new Size(304, 120);
            lblPhimTat.TabIndex = 10;
            lblPhimTat.Text = "Phím tắt:\r\n   F2       : Thêm nhanh dòng mới vào bảng\r\n   Delete : Xóa dòng đang chọn\r\n\r\nCó thể sửa trực tiếp các ô trong bảng; Thành tiền và\r\ncác tổng ở thanh trạng thái tự tính lại.";
            //
            // grpNhapNhanh
            //
            grpNhapNhanh.Controls.Add(lblNhapTen);
            grpNhapNhanh.Controls.Add(txtNhapTen);
            grpNhapNhanh.Controls.Add(lblNhapSL);
            grpNhapNhanh.Controls.Add(txtNhapSL);
            grpNhapNhanh.Controls.Add(lblNhapTL);
            grpNhapNhanh.Controls.Add(txtNhapTL);
            grpNhapNhanh.Controls.Add(lblNhapGia);
            grpNhapNhanh.Controls.Add(txtNhapGia);
            grpNhapNhanh.Controls.Add(btnThemHang);
            grpNhapNhanh.Controls.Add(btnXoaDong);
            grpNhapNhanh.Dock = DockStyle.Top;
            grpNhapNhanh.Location = new Point(8, 8);
            grpNhapNhanh.Name = "grpNhapNhanh";
            grpNhapNhanh.Size = new Size(664, 110);
            grpNhapNhanh.TabIndex = 0;
            grpNhapNhanh.TabStop = false;
            grpNhapNhanh.Text = "Nhập nhanh hàng hóa";
            //
            // lblNhapTen
            //
            lblNhapTen.Location = new Point(12, 24);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(180, 18);
            lblNhapTen.TabIndex = 10;
            lblNhapTen.Text = "Tên hàng";
            //
            // txtNhapTen
            //
            txtNhapTen.Location = new Point(12, 44);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(180, 23);
            txtNhapTen.TabIndex = 0;
            //
            // lblNhapSL
            //
            lblNhapSL.Location = new Point(210, 24);
            lblNhapSL.Name = "lblNhapSL";
            lblNhapSL.Size = new Size(80, 18);
            lblNhapSL.TabIndex = 11;
            lblNhapSL.Text = "Số lượng";
            //
            // txtNhapSL
            //
            txtNhapSL.Location = new Point(210, 44);
            txtNhapSL.Name = "txtNhapSL";
            txtNhapSL.Size = new Size(80, 23);
            txtNhapSL.TabIndex = 1;
            txtNhapSL.TextAlign = HorizontalAlignment.Right;
            txtNhapSL.TextChanged += txtNhapSo_TextChanged;
            //
            // lblNhapTL
            //
            lblNhapTL.Location = new Point(310, 24);
            lblNhapTL.Name = "lblNhapTL";
            lblNhapTL.Size = new Size(100, 18);
            lblNhapTL.TabIndex = 12;
            lblNhapTL.Text = "Trọng lượng (kg)";
            //
            // txtNhapTL
            //
            txtNhapTL.Location = new Point(310, 44);
            txtNhapTL.Name = "txtNhapTL";
            txtNhapTL.Size = new Size(90, 23);
            txtNhapTL.TabIndex = 2;
            txtNhapTL.TextAlign = HorizontalAlignment.Right;
            txtNhapTL.TextChanged += txtNhapSo_TextChanged;
            //
            // lblNhapGia
            //
            lblNhapGia.Location = new Point(420, 24);
            lblNhapGia.Name = "lblNhapGia";
            lblNhapGia.Size = new Size(110, 18);
            lblNhapGia.TabIndex = 13;
            lblNhapGia.Text = "Đơn giá";
            //
            // txtNhapGia
            //
            txtNhapGia.Location = new Point(420, 44);
            txtNhapGia.Name = "txtNhapGia";
            txtNhapGia.Size = new Size(110, 23);
            txtNhapGia.TabIndex = 3;
            txtNhapGia.TextAlign = HorizontalAlignment.Right;
            //
            // btnThemHang
            //
            btnThemHang.Location = new Point(550, 30);
            btnThemHang.Name = "btnThemHang";
            btnThemHang.Size = new Size(100, 30);
            btnThemHang.TabIndex = 4;
            btnThemHang.Text = "Thêm vào bảng";
            btnThemHang.UseVisualStyleBackColor = true;
            btnThemHang.Click += btnThemHang_Click;
            //
            // btnXoaDong
            //
            btnXoaDong.Location = new Point(550, 66);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(100, 30);
            btnXoaDong.TabIndex = 5;
            btnXoaDong.Text = "Xóa dòng (Del)";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            //
            // dgvHangHoa
            //
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.AllowUserToDeleteRows = false;
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangHoa.BackgroundColor = Color.White;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Columns.AddRange(new DataGridViewColumn[] { colTenHang, colSoLuong, colTrongLuong, colDonGia, colThanhTien });
            dgvHangHoa.Dock = DockStyle.Fill;
            dgvHangHoa.Location = new Point(8, 118);
            dgvHangHoa.MultiSelect = false;
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 30;
            dgvHangHoa.Size = new Size(664, 410);
            dgvHangHoa.TabIndex = 1;
            dgvHangHoa.CellParsing += dgvHangHoa_CellParsing;
            dgvHangHoa.CellValueChanged += dgvHangHoa_CellValueChanged;
            dgvHangHoa.RowsRemoved += dgvHangHoa_RowsRemoved;
            //
            // colTenHang
            //
            colTenHang.FillWeight = 34F;
            colTenHang.HeaderText = "Tên hàng";
            colTenHang.Name = "colTenHang";
            //
            // colSoLuong
            //
            styleSo.Alignment = DataGridViewContentAlignment.MiddleRight;
            styleSo.Format = "N0";
            colSoLuong.DefaultCellStyle = styleSo;
            colSoLuong.FillWeight = 14F;
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.Name = "colSoLuong";
            //
            // colTrongLuong
            //
            styleKg.Alignment = DataGridViewContentAlignment.MiddleRight;
            styleKg.Format = "N2";
            colTrongLuong.DefaultCellStyle = styleKg;
            colTrongLuong.FillWeight = 16F;
            colTrongLuong.HeaderText = "Trọng lượng (kg)";
            colTrongLuong.Name = "colTrongLuong";
            //
            // colDonGia
            //
            styleTien.Alignment = DataGridViewContentAlignment.MiddleRight;
            styleTien.Format = "N0";
            colDonGia.DefaultCellStyle = styleTien;
            colDonGia.FillWeight = 17F;
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.Name = "colDonGia";
            //
            // colThanhTien
            //
            styleThanhTien.Alignment = DataGridViewContentAlignment.MiddleRight;
            styleThanhTien.BackColor = Color.FromArgb(240, 248, 255);
            styleThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            styleThanhTien.Format = "N0";
            colThanhTien.DefaultCellStyle = styleThanhTien;
            colThanhTien.FillWeight = 19F;
            colThanhTien.HeaderText = "Thành tiền (tự tính)";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            //
            // statusStrip
            //
            statusStrip.Items.AddRange(new ToolStripItem[] { lblThoiGian, lblKhoangTrong, lblTongSoLuong, lblTongTrongLuong, lblTongTien });
            statusStrip.Location = new Point(0, 536);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1004, 25);
            statusStrip.TabIndex = 1;
            //
            // lblThoiGian
            //
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(150, 20);
            lblThoiGian.Text = "--:--:--";
            //
            // lblKhoangTrong
            //
            lblKhoangTrong.Name = "lblKhoangTrong";
            lblKhoangTrong.Spring = true;
            //
            // lblTongSoLuong
            //
            lblTongSoLuong.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblTongSoLuong.Name = "lblTongSoLuong";
            lblTongSoLuong.Text = "Tổng SL: 0";
            //
            // lblTongTrongLuong
            //
            lblTongTrongLuong.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblTongTrongLuong.Name = "lblTongTrongLuong";
            lblTongTrongLuong.Text = "Tổng TL: 0 kg";
            //
            // lblTongTien
            //
            lblTongTien.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(192, 0, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Text = "Tổng tiền: 0 đ";
            //
            // tmrDongHo
            //
            tmrDongHo.Enabled = true;
            tmrDongHo.Interval = 1000;
            tmrDongHo.Tick += tmrDongHo_Tick;
            //
            // errorProvider
            //
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 561);
            Controls.Add(splitMain);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(900, 520);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5 - Bảng điều khiển quản lý đơn giao hàng";
            Load += Form1_Load;
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            grpVanChuyen.ResumeLayout(false);
            grpKhachHang.ResumeLayout(false);
            grpKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            grpNhapNhanh.ResumeLayout(false);
            grpNhapNhanh.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitMain;
        private GroupBox grpKhachHang;
        private Label lblTenKH;
        private TextBox txtTenKH;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private GroupBox grpVanChuyen;
        private RadioButton rdoTieuChuan;
        private RadioButton rdoNhanh;
        private RadioButton rdoHoaToc;
        private Label lblNgayGiao;
        private DateTimePicker dtpNgayGiao;
        private Button btnXacNhanDon;
        private Label lblPhimTat;
        private GroupBox grpNhapNhanh;
        private Label lblNhapTen;
        private TextBox txtNhapTen;
        private Label lblNhapSL;
        private TextBox txtNhapSL;
        private Label lblNhapTL;
        private TextBox txtNhapTL;
        private Label lblNhapGia;
        private TextBox txtNhapGia;
        private Button btnThemHang;
        private Button btnXoaDong;
        private DataGridView dgvHangHoa;
        private DataGridViewTextBoxColumn colTenHang;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colTrongLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblThoiGian;
        private ToolStripStatusLabel lblKhoangTrong;
        private ToolStripStatusLabel lblTongSoLuong;
        private ToolStripStatusLabel lblTongTrongLuong;
        private ToolStripStatusLabel lblTongTien;
        private System.Windows.Forms.Timer tmrDongHo;
        private ErrorProvider errorProvider;
    }
}

namespace Bai4
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
            tlpSoDo = new TableLayoutPanel();
            grpThongKe = new GroupBox();
            lblKhungGio = new Label();
            cboKhungGio = new ComboBox();
            lblSoChonTieuDe = new Label();
            lblSoViTriChon = new Label();
            lblTamTinhTieuDe = new Label();
            lblTamTinh = new Label();
            lblChuThichTrong = new Label();
            lblChuThichChon = new Label();
            lblChuThichDaDat = new Label();
            btnXacNhan = new Button();
            btnHuyChon = new Button();
            grpThongKe.SuspendLayout();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(0, 84, 166);
            lblTieuDe.Location = new Point(12, 10);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(470, 32);
            lblTieuDe.TabIndex = 10;
            lblTieuDe.Text = "SƠ ĐỒ CHỌN VỊ TRÍ / BÀN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // tlpSoDo  (4 hàng x 5 cột, các Button được sinh bằng code trong Form1_Load)
            //
            tlpSoDo.BackColor = Color.FromArgb(245, 245, 245);
            tlpSoDo.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            tlpSoDo.ColumnCount = 5;
            tlpSoDo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpSoDo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpSoDo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpSoDo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpSoDo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpSoDo.Location = new Point(12, 50);
            tlpSoDo.Name = "tlpSoDo";
            tlpSoDo.Padding = new Padding(4);
            tlpSoDo.RowCount = 4;
            tlpSoDo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpSoDo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpSoDo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpSoDo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpSoDo.Size = new Size(470, 340);
            tlpSoDo.TabIndex = 0;
            //
            // grpThongKe
            //
            grpThongKe.Controls.Add(lblKhungGio);
            grpThongKe.Controls.Add(cboKhungGio);
            grpThongKe.Controls.Add(lblSoChonTieuDe);
            grpThongKe.Controls.Add(lblSoViTriChon);
            grpThongKe.Controls.Add(lblTamTinhTieuDe);
            grpThongKe.Controls.Add(lblTamTinh);
            grpThongKe.Controls.Add(lblChuThichTrong);
            grpThongKe.Controls.Add(lblChuThichChon);
            grpThongKe.Controls.Add(lblChuThichDaDat);
            grpThongKe.Location = new Point(495, 44);
            grpThongKe.Name = "grpThongKe";
            grpThongKe.Size = new Size(260, 260);
            grpThongKe.TabIndex = 1;
            grpThongKe.TabStop = false;
            grpThongKe.Text = "Thống kê";
            //
            // lblKhungGio
            //
            lblKhungGio.Location = new Point(15, 28);
            lblKhungGio.Name = "lblKhungGio";
            lblKhungGio.Size = new Size(230, 20);
            lblKhungGio.TabIndex = 10;
            lblKhungGio.Text = "Khung giờ:";
            //
            // cboKhungGio
            //
            cboKhungGio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhungGio.Location = new Point(15, 50);
            cboKhungGio.Name = "cboKhungGio";
            cboKhungGio.Size = new Size(230, 23);
            cboKhungGio.TabIndex = 0;
            cboKhungGio.SelectedIndexChanged += cboKhungGio_SelectedIndexChanged;
            //
            // lblSoChonTieuDe
            //
            lblSoChonTieuDe.Location = new Point(15, 88);
            lblSoChonTieuDe.Name = "lblSoChonTieuDe";
            lblSoChonTieuDe.Size = new Size(130, 26);
            lblSoChonTieuDe.TabIndex = 11;
            lblSoChonTieuDe.Text = "Số vị trí đang chọn:";
            lblSoChonTieuDe.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblSoViTriChon
            //
            lblSoViTriChon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSoViTriChon.ForeColor = Color.ForestGreen;
            lblSoViTriChon.Location = new Point(150, 88);
            lblSoViTriChon.Name = "lblSoViTriChon";
            lblSoViTriChon.Size = new Size(95, 26);
            lblSoViTriChon.TabIndex = 12;
            lblSoViTriChon.Text = "0";
            lblSoViTriChon.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblTamTinhTieuDe
            //
            lblTamTinhTieuDe.Location = new Point(15, 120);
            lblTamTinhTieuDe.Name = "lblTamTinhTieuDe";
            lblTamTinhTieuDe.Size = new Size(100, 26);
            lblTamTinhTieuDe.TabIndex = 13;
            lblTamTinhTieuDe.Text = "Tạm tính tiền:";
            lblTamTinhTieuDe.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblTamTinh
            //
            lblTamTinh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTamTinh.ForeColor = Color.FromArgb(192, 0, 0);
            lblTamTinh.Location = new Point(115, 120);
            lblTamTinh.Name = "lblTamTinh";
            lblTamTinh.Size = new Size(130, 26);
            lblTamTinh.TabIndex = 14;
            lblTamTinh.Text = "0 đ";
            lblTamTinh.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblChuThichTrong
            //
            lblChuThichTrong.BackColor = Color.WhiteSmoke;
            lblChuThichTrong.BorderStyle = BorderStyle.FixedSingle;
            lblChuThichTrong.Location = new Point(15, 160);
            lblChuThichTrong.Name = "lblChuThichTrong";
            lblChuThichTrong.Size = new Size(230, 26);
            lblChuThichTrong.TabIndex = 15;
            lblChuThichTrong.Text = "Trống";
            lblChuThichTrong.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblChuThichChon
            //
            lblChuThichChon.BackColor = Color.LimeGreen;
            lblChuThichChon.BorderStyle = BorderStyle.FixedSingle;
            lblChuThichChon.ForeColor = Color.White;
            lblChuThichChon.Location = new Point(15, 191);
            lblChuThichChon.Name = "lblChuThichChon";
            lblChuThichChon.Size = new Size(230, 26);
            lblChuThichChon.TabIndex = 16;
            lblChuThichChon.Text = "Đang chọn";
            lblChuThichChon.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblChuThichDaDat
            //
            lblChuThichDaDat.BackColor = Color.Firebrick;
            lblChuThichDaDat.BorderStyle = BorderStyle.FixedSingle;
            lblChuThichDaDat.ForeColor = Color.White;
            lblChuThichDaDat.Location = new Point(15, 222);
            lblChuThichDaDat.Name = "lblChuThichDaDat";
            lblChuThichDaDat.Size = new Size(230, 26);
            lblChuThichDaDat.TabIndex = 17;
            lblChuThichDaDat.Text = "Đã có người đặt / Đã khóa";
            lblChuThichDaDat.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnXacNhan
            //
            btnXacNhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXacNhan.Location = new Point(495, 315);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(260, 36);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận đặt";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            //
            // btnHuyChon
            //
            btnHuyChon.Location = new Point(495, 355);
            btnHuyChon.Name = "btnHuyChon";
            btnHuyChon.Size = new Size(260, 36);
            btnHuyChon.TabIndex = 3;
            btnHuyChon.Text = "Hủy chọn tất cả";
            btnHuyChon.UseVisualStyleBackColor = true;
            btnHuyChon.Click += btnHuyChon_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 405);
            Controls.Add(lblTieuDe);
            Controls.Add(tlpSoDo);
            Controls.Add(grpThongKe);
            Controls.Add(btnXacNhan);
            Controls.Add(btnHuyChon);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 4 - Sơ đồ chọn vị trí / Đặt bàn hẹn giờ";
            Load += Form1_Load;
            grpThongKe.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTieuDe;
        private TableLayoutPanel tlpSoDo;
        private GroupBox grpThongKe;
        private Label lblKhungGio;
        private ComboBox cboKhungGio;
        private Label lblSoChonTieuDe;
        private Label lblSoViTriChon;
        private Label lblTamTinhTieuDe;
        private Label lblTamTinh;
        private Label lblChuThichTrong;
        private Label lblChuThichChon;
        private Label lblChuThichDaDat;
        private Button btnXacNhan;
        private Button btnHuyChon;
    }
}

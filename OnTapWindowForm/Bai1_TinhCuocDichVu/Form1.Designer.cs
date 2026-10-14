namespace Bai1
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
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblGiamGia = new Label();
            txtGiamGia = new TextBox();
            lblTongTienTieuDe = new Label();
            lblTongTien = new Label();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(0, 84, 166);
            lblTieuDe.Location = new Point(20, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(400, 32);
            lblTieuDe.TabIndex = 10;
            lblTieuDe.Text = "TÍNH CƯỚC DỊCH VỤ";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblDonGia
            //
            lblDonGia.Location = new Point(30, 68);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(150, 23);
            lblDonGia.TabIndex = 11;
            lblDonGia.Text = "Đơn giá dịch vụ (đ):";
            lblDonGia.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtDonGia
            //
            txtDonGia.Location = new Point(190, 68);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(220, 23);
            txtDonGia.TabIndex = 0;
            txtDonGia.TextAlign = HorizontalAlignment.Right;
            //
            // lblSoLuong
            //
            lblSoLuong.Location = new Point(30, 106);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(150, 23);
            lblSoLuong.TabIndex = 12;
            lblSoLuong.Text = "Số lượng khách:";
            lblSoLuong.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtSoLuong
            //
            txtSoLuong.Location = new Point(190, 106);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(220, 23);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.TextAlign = HorizontalAlignment.Right;
            //
            // lblGiamGia
            //
            lblGiamGia.Location = new Point(30, 144);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(150, 23);
            lblGiamGia.TabIndex = 13;
            lblGiamGia.Text = "Mã giảm giá (%):";
            lblGiamGia.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtGiamGia
            //
            txtGiamGia.Location = new Point(190, 144);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(220, 23);
            txtGiamGia.TabIndex = 2;
            txtGiamGia.Text = "0";
            txtGiamGia.TextAlign = HorizontalAlignment.Right;
            //
            // lblTongTienTieuDe
            //
            lblTongTienTieuDe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTienTieuDe.Location = new Point(30, 190);
            lblTongTienTieuDe.Name = "lblTongTienTieuDe";
            lblTongTienTieuDe.Size = new Size(150, 30);
            lblTongTienTieuDe.TabIndex = 14;
            lblTongTienTieuDe.Text = "Tổng thanh toán:";
            lblTongTienTieuDe.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblTongTien
            //
            lblTongTien.BackColor = Color.FromArgb(235, 245, 255);
            lblTongTien.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(192, 0, 0);
            lblTongTien.Location = new Point(190, 190);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(220, 30);
            lblTongTien.TabIndex = 15;
            lblTongTien.Text = "0 đ";
            lblTongTien.TextAlign = ContentAlignment.MiddleRight;
            //
            // btnTinhTien
            //
            btnTinhTien.Location = new Point(190, 240);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(105, 34);
            btnTinhTien.TabIndex = 3;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            //
            // btnLamMoi
            //
            btnLamMoi.Location = new Point(305, 240);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(105, 34);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            //
            // Form1
            //
            AcceptButton = btnTinhTien;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 300);
            Controls.Add(lblTieuDe);
            Controls.Add(lblDonGia);
            Controls.Add(txtDonGia);
            Controls.Add(lblSoLuong);
            Controls.Add(txtSoLuong);
            Controls.Add(lblGiamGia);
            Controls.Add(txtGiamGia);
            Controls.Add(lblTongTienTieuDe);
            Controls.Add(lblTongTien);
            Controls.Add(btnTinhTien);
            Controls.Add(btnLamMoi);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 1 - Máy tính cước dịch vụ & Giảm giá";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Label lblGiamGia;
        private TextBox txtGiamGia;
        private Label lblTongTienTieuDe;
        private Label lblTongTien;
        private Button btnTinhTien;
        private Button btnLamMoi;
    }
}

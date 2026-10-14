namespace Bai3
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
            grpNhapLieu = new GroupBox();
            lblMaVT = new Label();
            txtMaVT = new TextBox();
            lblTenVT = new Label();
            txtTenVT = new TextBox();
            lblDonVi = new Label();
            cboDonViTinh = new ComboBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            btnThemMoi = new Button();
            btnCapNhat = new Button();
            btnXoaDong = new Button();
            btnXoaToanBo = new Button();
            grpDanhSach = new GroupBox();
            lvVatTu = new ListView();
            colMaVT = new ColumnHeader();
            colTenVT = new ColumnHeader();
            colDonVi = new ColumnHeader();
            colDonGia = new ColumnHeader();
            lblTongSo = new Label();
            grpNhapLieu.SuspendLayout();
            grpDanhSach.SuspendLayout();
            SuspendLayout();
            //
            // grpNhapLieu
            //
            grpNhapLieu.Controls.Add(lblMaVT);
            grpNhapLieu.Controls.Add(txtMaVT);
            grpNhapLieu.Controls.Add(lblTenVT);
            grpNhapLieu.Controls.Add(txtTenVT);
            grpNhapLieu.Controls.Add(lblDonVi);
            grpNhapLieu.Controls.Add(cboDonViTinh);
            grpNhapLieu.Controls.Add(lblDonGia);
            grpNhapLieu.Controls.Add(txtDonGia);
            grpNhapLieu.Controls.Add(btnThemMoi);
            grpNhapLieu.Controls.Add(btnCapNhat);
            grpNhapLieu.Controls.Add(btnXoaDong);
            grpNhapLieu.Controls.Add(btnXoaToanBo);
            grpNhapLieu.Location = new Point(12, 12);
            grpNhapLieu.Name = "grpNhapLieu";
            grpNhapLieu.Size = new Size(300, 340);
            grpNhapLieu.TabIndex = 0;
            grpNhapLieu.TabStop = false;
            grpNhapLieu.Text = "Thông tin vật tư";
            //
            // lblMaVT
            //
            lblMaVT.Location = new Point(15, 30);
            lblMaVT.Name = "lblMaVT";
            lblMaVT.Size = new Size(90, 23);
            lblMaVT.TabIndex = 10;
            lblMaVT.Text = "Mã vật tư:";
            lblMaVT.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtMaVT
            //
            txtMaVT.CharacterCasing = CharacterCasing.Upper;
            txtMaVT.Location = new Point(110, 30);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(170, 23);
            txtMaVT.TabIndex = 0;
            //
            // lblTenVT
            //
            lblTenVT.Location = new Point(15, 68);
            lblTenVT.Name = "lblTenVT";
            lblTenVT.Size = new Size(90, 23);
            lblTenVT.TabIndex = 11;
            lblTenVT.Text = "Tên vật tư:";
            lblTenVT.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtTenVT
            //
            txtTenVT.Location = new Point(110, 68);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(170, 23);
            txtTenVT.TabIndex = 1;
            //
            // lblDonVi
            //
            lblDonVi.Location = new Point(15, 106);
            lblDonVi.Name = "lblDonVi";
            lblDonVi.Size = new Size(90, 23);
            lblDonVi.TabIndex = 12;
            lblDonVi.Text = "Đơn vị tính:";
            lblDonVi.TextAlign = ContentAlignment.MiddleLeft;
            //
            // cboDonViTinh
            //
            cboDonViTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonViTinh.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDonViTinh.Location = new Point(110, 106);
            cboDonViTinh.Name = "cboDonViTinh";
            cboDonViTinh.Size = new Size(170, 23);
            cboDonViTinh.TabIndex = 2;
            //
            // lblDonGia
            //
            lblDonGia.Location = new Point(15, 144);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(90, 23);
            lblDonGia.TabIndex = 13;
            lblDonGia.Text = "Đơn giá nhập:";
            lblDonGia.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtDonGia
            //
            txtDonGia.Location = new Point(110, 144);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(170, 23);
            txtDonGia.TabIndex = 3;
            txtDonGia.TextAlign = HorizontalAlignment.Right;
            //
            // btnThemMoi
            //
            btnThemMoi.Location = new Point(15, 195);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(128, 36);
            btnThemMoi.TabIndex = 4;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            //
            // btnCapNhat
            //
            btnCapNhat.Location = new Point(152, 195);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(128, 36);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            //
            // btnXoaDong
            //
            btnXoaDong.Location = new Point(15, 240);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(128, 36);
            btnXoaDong.TabIndex = 6;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            //
            // btnXoaToanBo
            //
            btnXoaToanBo.ForeColor = Color.FromArgb(192, 0, 0);
            btnXoaToanBo.Location = new Point(152, 240);
            btnXoaToanBo.Name = "btnXoaToanBo";
            btnXoaToanBo.Size = new Size(128, 36);
            btnXoaToanBo.TabIndex = 7;
            btnXoaToanBo.Text = "Xóa toàn bộ";
            btnXoaToanBo.UseVisualStyleBackColor = true;
            btnXoaToanBo.Click += btnXoaToanBo_Click;
            //
            // grpDanhSach
            //
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.Controls.Add(lvVatTu);
            grpDanhSach.Controls.Add(lblTongSo);
            grpDanhSach.Location = new Point(325, 12);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(480, 340);
            grpDanhSach.TabIndex = 1;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách vật tư";
            //
            // lvVatTu
            //
            lvVatTu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvVatTu.Columns.AddRange(new ColumnHeader[] { colMaVT, colTenVT, colDonVi, colDonGia });
            lvVatTu.FullRowSelect = true;
            lvVatTu.GridLines = true;
            lvVatTu.HideSelection = false;
            lvVatTu.Location = new Point(12, 25);
            lvVatTu.MultiSelect = false;
            lvVatTu.Name = "lvVatTu";
            lvVatTu.Size = new Size(456, 280);
            lvVatTu.TabIndex = 0;
            lvVatTu.UseCompatibleStateImageBehavior = false;
            lvVatTu.View = View.Details;
            lvVatTu.SelectedIndexChanged += lvVatTu_SelectedIndexChanged;
            //
            // colMaVT
            //
            colMaVT.Text = "Mã VT";
            colMaVT.Width = 80;
            //
            // colTenVT
            //
            colTenVT.Text = "Tên VT";
            colTenVT.Width = 180;
            //
            // colDonVi
            //
            colDonVi.Text = "Đơn vị tính";
            colDonVi.Width = 80;
            //
            // colDonGia
            //
            colDonGia.Text = "Đơn giá";
            colDonGia.TextAlign = HorizontalAlignment.Right;
            colDonGia.Width = 110;
            //
            // lblTongSo
            //
            lblTongSo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTongSo.Location = new Point(12, 310);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(300, 23);
            lblTongSo.TabIndex = 10;
            lblTongSo.Text = "Tổng số vật tư: 0";
            lblTongSo.TextAlign = ContentAlignment.MiddleLeft;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 364);
            Controls.Add(grpNhapLieu);
            Controls.Add(grpDanhSach);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(833, 403);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 3 - Quản lý danh mục vật tư / linh kiện";
            grpNhapLieu.ResumeLayout(false);
            grpNhapLieu.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpNhapLieu;
        private Label lblMaVT;
        private TextBox txtMaVT;
        private Label lblTenVT;
        private TextBox txtTenVT;
        private Label lblDonVi;
        private ComboBox cboDonViTinh;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Button btnThemMoi;
        private Button btnCapNhat;
        private Button btnXoaDong;
        private Button btnXoaToanBo;
        private GroupBox grpDanhSach;
        private ListView lvVatTu;
        private ColumnHeader colMaVT;
        private ColumnHeader colTenVT;
        private ColumnHeader colDonVi;
        private ColumnHeader colDonGia;
        private Label lblTongSo;
    }
}

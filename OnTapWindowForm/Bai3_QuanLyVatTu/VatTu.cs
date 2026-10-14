namespace Bai3
{
    // Lớp đối tượng Vật tư - danh sách được lưu tạm trên RAM (List<VatTu>)
    public class VatTu
    {
        public string MaVT { get; set; }
        public string TenVT { get; set; }
        public string DonViTinh { get; set; }
        public decimal DonGia { get; set; }

        public VatTu(string maVT, string tenVT, string donViTinh, decimal donGia)
        {
            MaVT = maVT;
            TenVT = tenVT;
            DonViTinh = donViTinh;
            DonGia = donGia;
        }
    }
}

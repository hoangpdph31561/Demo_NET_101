namespace ThiThu
{
    internal class NhanVienXuatSac : NhanVien
    {
        private string hoaHong;
        public NhanVienXuatSac()
        {

        }

        public NhanVienXuatSac(int id, string ten, double doanhThu, string hoaHong) : base(id, ten, doanhThu)
        {
            this.hoaHong = hoaHong;
        }

        public string HoaHong { get => hoaHong; set => hoaHong = value; }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"{hoaHong}");
        }
    }
}

namespace ThiThu
{
    internal class NhanVien
    {
        private int id;
        private string ten;
        private double doanhThu;
        public NhanVien()
        {

        }

        public NhanVien(int id, string ten, double doanhThu)
        {
            this.id = id;
            this.ten = ten;
            this.doanhThu = doanhThu;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public double DoanhThu { get => doanhThu; set => doanhThu = value; }
        public virtual void InThongTin()
        {
            Console.WriteLine($"{id} | {ten} | {doanhThu}");
        }
    }
}

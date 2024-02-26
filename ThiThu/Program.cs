using System.Text;

namespace ThiThu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            NhanVien nv = new NhanVien();
            Menu();
        }
        static void Menu()
        {
            int chon;
            QLNV quanLy = new QLNV();
            do
            {
                Console.WriteLine("1. Nhập");
                Console.WriteLine("2. Xuất");
                Console.WriteLine("3. Xuất danh sách các nhân viên có doanh thu theo khoảng do người dùng nhập");
                Console.WriteLine("4. Tìm nhân viên theo mã ");
                Console.WriteLine("5. Kế thừa");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("Chọn menu:");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        Console.WriteLine("Thoát");
                        Environment.Exit(0);
                        break;
                    case 1:
                        quanLy.Nhap();
                        break;
                    case 2:
                        quanLy.Xuat();
                        break;
                    case 3:
                        quanLy.XuatDanhSachTheoYeuCau();
                        break;
                    case 4:

                        break;
                    case 5:
                        quanLy.KeThua();
                        break;
                    default:
                        Console.WriteLine("Sai chương trình");
                        break;
                }

            } while (chon != 0);
        }
    }
}

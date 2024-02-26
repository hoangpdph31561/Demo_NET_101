namespace ThiThu
{
    internal class QLNV
    {
        List<NhanVien> lstNhanVien;
        string input;
        public QLNV()
        {
            lstNhanVien = new List<NhanVien>()
            {
                new NhanVien(1, "Hoàng", 13.5),
                new NhanVien(2, "Quang", 13.4),
                new NhanVien(4, "Quân", 20.4)
            };
        }
        private string GetInput(string input)
        {
            Console.WriteLine($"Xin mời nhập {input}");
            return Console.ReadLine();
        }
        public void Nhap()
        {
            do
            {
                NhanVien nv = new();
                Console.WriteLine("Nhập ID");
                nv.Id = Convert.ToInt32(Console.ReadLine());
                nv.Ten = GetInput("tên nhân viên");
                Console.WriteLine("Nhập doanh thu");
                nv.DoanhThu = Convert.ToDouble(Console.ReadLine());
                lstNhanVien.Add(nv);

            CheckInputContinue:
                Console.WriteLine("Bạn có nhập tiếp không");
                input = Console.ReadLine();
                if (String.Compare(input, "có", true) != 0 && String.Compare(input, "không", true) != 0)
                {
                    Console.WriteLine("Chỉ được nhập có hoặc không");
                    goto CheckInputContinue;
                }
            } while (String.Compare(input, "có", true) == 0);
        }
        private bool CheckCount()
        {
            if (lstNhanVien.Count == 0)
            {
                Console.WriteLine("Không có danh sách");
                return false;
            }
            return true;
        }
        public void Xuat()
        {
            if (CheckCount())
            {
                foreach (var item in lstNhanVien)
                {
                    item.InThongTin();
                }
            }
        }
        public void XuatDanhSachTheoYeuCau()
        {
            double min, max;
        CheckMinMax:
            Console.WriteLine("Nhập khoảng min");
            min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập khoảng max");
            max = Convert.ToDouble(Console.ReadLine());
            if (min > max || min < 0 || max < 0)
            {
                Console.WriteLine("Min max sai");
                goto CheckMinMax;
            }

            if (CheckCount())
            {
                bool isExist = false;
                foreach (var item in lstNhanVien)
                {
                    if (item.DoanhThu >= min && item.DoanhThu <= max)
                    {
                        item.InThongTin();
                        isExist = true;
                    }
                }
                if (!isExist)
                {
                    Console.WriteLine("Không có nhân viên nào thỏa mãn");
                }
            }
        }
        public void KeThua()
        {
            NhanVienXuatSac xuatSac = new NhanVienXuatSac(1, "H", 200, "90");
            xuatSac.InThongTin();
        }
        public void TimTheoMa()
        {
            int id;
            Console.WriteLine("Mời bạn nhập ID cần tìm");
            id = Convert.ToInt32(Console.ReadLine());
            if (CheckCount())
            {
                bool isExist = false;
                foreach (var item in lstNhanVien)
                {
                    if (item.Id == id)
                    {
                        item.InThongTin();
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    Console.WriteLine("Không tìm được ID đã nhập");
                }
            }
        }

    }
}

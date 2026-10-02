using System;

namespace AutoSpeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyPhuongTien quanLy = new QuanLyPhuongTien();

            try
            {
                OTo oTo = new OTo(
                    "OT001",
                    "Toyota",
                    1850,
                    1000000000m,
                    5,
                    2000);

                XeMay xeMay = new XeMay(
                    "XM001",
                    "Honda",
                    2023,
                    50000000m,
                    150);

                quanLy.AddPhuongTien(oTo);
                quanLy.AddPhuongTien(xeMay);

                Console.WriteLine("===== DANH SÁCH PHƯƠNG TIỆN =====");
                quanLy.DisplayAll();

                Console.WriteLine("===== PHƯƠNG TIỆN CÓ GIÁ LĂN BÁNH CAO NHẤT =====");

                PhuongTien? max = quanLy.FindMaxGiaLanBanh();

                if (max != null)
                {
                    Console.WriteLine(max.GetInfo());
                    Console.WriteLine($"Giá lăn bánh: {max.TinhGiaLanBanh():N0} VNĐ");
                }

                Console.WriteLine();
                Console.WriteLine("===== TÌM KIẾM THEO TÊN HÃNG =====");

                var ketQua = quanLy.SearchByName("Honda");

                foreach (PhuongTien pt in ketQua)
                {
                    Console.WriteLine(pt.GetInfo());
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
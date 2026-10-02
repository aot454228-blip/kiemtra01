using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoSpeed
{
    public class QuanLyPhuongTien
    {
        private List<PhuongTien> danhSach = new List<PhuongTien>();

        public void AddPhuongTien(PhuongTien pt)
        {
            danhSach.Add(pt);
        }

        public void DisplayAll()
        {
            foreach (PhuongTien pt in danhSach)
            {
                Console.WriteLine(pt.GetInfo());
                Console.WriteLine($"Giá lăn bánh: {pt.TinhGiaLanBanh():N0} VNĐ");
                Console.WriteLine("-----------------------------------");
            }
        }

        public PhuongTien? FindMaxGiaLanBanh()
        {
            return danhSach
                .OrderByDescending(pt => pt.TinhGiaLanBanh())
                .FirstOrDefault();
        }

        public List<PhuongTien> SearchByName(string keyword)
        {
            return danhSach
                .Where(pt => pt.TenHang.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
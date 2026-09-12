using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b12
    {
        static void Main1(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số ngày trễ hạn trả sách: ");
            uint soNgayTre = uint.Parse(Console.ReadLine());
            if (soNgayTre >= 1 && soNgayTre <= 3)
            {
                Console.WriteLine("Tiền phạt: " + (soNgayTre * 5, 000) + " VNĐ");
            }
            else if (soNgayTre >= 4 && soNgayTre <= 7)
            {
                Console.WriteLine("Tiền phạt: " + (soNgayTre * 10, 000) + " VNĐ");

            }
            else
            {
                Console.WriteLine("Tiền phạt: " + (soNgayTre * 20, 000) + " VNĐ");
                Console.WriteLine("Cảnh báo: Tài khoản thư viện của bạn bị tạm khóa 30 ngày.");
            }
        }
    }
}

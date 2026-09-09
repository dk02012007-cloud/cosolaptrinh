using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b05
    {
        static void Main5(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double sokm;
            bool ketqua;
            do
            {
                Console.Write("Nhập số km = ");
                string input = Console.ReadLine();
                ketqua = double.TryParse(input, out sokm);
                if (!ketqua || sokm <= 0)
                {
                    Console.WriteLine("Số km không hợp lệ. Vui lòng nhập lại.");
                }
            } while (!ketqua || sokm <= 0);
            double tongTien;
            if (sokm <= 1)
            {
                tongTien = 15000;
            }
            else if (sokm <= 10)
            {
                tongTien = 15000 + (sokm - 1) * 12000;
            }
            else
            {
                tongTien = 15000 + 9 * 12000 + (sokm - 10) * 10000;
            }
            double khuyenmai;
            if (sokm > 30)
            {
                khuyenmai = tongTien * 0.1; // Giảm 10% nếu số km > 30
            }
            else
            {
                Console.WriteLine("Bạn không có khuyến mãi vì đi dưới 30km.");
                khuyenmai = 0;
            }
            double thanhtien = tongTien - khuyenmai;
            Console.WriteLine($"Tổng tiền trước giảm là: {tongTien:N0} VND");
            Console.WriteLine($"Số tiền được giảm (10%) là : {khuyenmai:N0} VND");
            Console.WriteLine($"Thành tiền sau giảm là: {thanhtien:N0} VND");


        }       


        }
    }
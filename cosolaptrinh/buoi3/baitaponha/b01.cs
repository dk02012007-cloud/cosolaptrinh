using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b01
    {
        
        static void Main1(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập độ tuổi của bạn: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Nhập giờ xem bạn muốn xem phim (0-23): ");
            int hour = int.Parse(Console.ReadLine());
            if (age > 60 || age < 12)
            {
                Console.WriteLine("Giá vé của bạn là 50.000VND");
            }
            else if (hour < 17)
            {
                Console.WriteLine("Giá vé của bạn là 80.000VND");
            }
            else
                {
                    Console.WriteLine("Giá vé của bạn là 110.000VND");
                }
        }
    }

}

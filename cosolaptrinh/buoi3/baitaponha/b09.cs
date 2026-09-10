using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b09
    {
        static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập DRL: ");
            double drl = Convert.ToDouble(Console.ReadLine());

            if (gpa >= 3.6 && drl >= 90)
            {
                Console.WriteLine("Kết quả: Học bổng Xuất sắc (Mức 100%)");
            }
            else if (gpa >= 3.2 && drl >= 80)
            {
                string lyDo = "";
                if (gpa >= 3.6 && drl < 90)
                {
                    lyDo = " (Do DRL < 90)";
                }
                else if (gpa < 3.6 && drl >= 90)
                {
                    lyDo = " (Do GPA < 3.6)";
                }

                Console.WriteLine($"Kết quả: Học bổng Khá/Giỏi (Mức 50%){lyDo}");
            }
            else
            {
                Console.WriteLine("Kết quả: Không đạt học bổng");
            }
        }
    }
}
    


using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace cosolaptrinh.buoi4.homework4
{
    internal class ex6trongsilde
    {
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            bool isValid = false;
            double sum = 0;
            do
            {
                Console.Write("Nhập vào một số nguyên dương n: ");
                isValid = int.TryParse(Console.ReadLine(), out n);
                if (!isValid || n <= 0)
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
                }
            } while (!isValid || n <= 0);
            for (int i = 1; i <= n; i++)
            {
             sum += 1.0 / i; // nếu không để kiểu 1.0 thì sẽ bị lỗi chia nguyên
            }
            Console.WriteLine($"Tổng các số hạng là: {sum:F3}");    

        }
    }
}

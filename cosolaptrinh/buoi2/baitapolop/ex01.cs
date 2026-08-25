using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi2.baitapolop
{
    internal class ex01
    {
        static void Main(string[] args)
        {
            // surface= 4 * pi * radius squared
            // volume= 4 / 3 * pi* radius cubed
            Console.Write("Nhap vao ban kinh hinh cau:");
            double radius = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Ban kinh hinh cau: {radius}");
            Console.WriteLine(  $"Dien tich mat cau: {surface:f2}");
            Console.WriteLine($"The tich hinh cau: {volume:f2}");
        }
    }
}

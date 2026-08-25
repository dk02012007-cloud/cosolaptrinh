using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi2.baitapolop
{
    internal class ex
    {
        static void Main1(string[] args)
        {
            // kelvin = celsius + 273
            // fahrenheit = celsius * 18 / 10 + 32
            Console.Write("Nhap vao do Celsius:");
            float celsius = float.Parse(Console.ReadLine());
            float kelvin = celsius + 273;
            float fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine($"{celsius} C = {kelvin} K = {fahrenheit} F");

        }
    }
    }
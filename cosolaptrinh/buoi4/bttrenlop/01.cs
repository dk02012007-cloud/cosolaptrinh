using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace cosolaptrinh.buoi4.bttrenlop
{
    internal class _01
    {
        public static void Main1(string[] args)
        {/*
            //pettern 1
            Console.Write("Nhap so hang n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(); // Xuong hang
            }*/



            // pettern 2
            /* Console.Write("Nhap so hang n: ");
             int n = int.Parse(Console.ReadLine());

             int val = 1; // Biến đếm số liên tục
             for (int i = 1; i <= n; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write(val + " ");
                     val++;
                 }
                 Console.WriteLine();
             }
*/



            // pettern 3   
            int n = int.Parse(Console.ReadLine());

            int val = 1;
            for (int i = 1; i <= n; i++) // vòng lặp cho từng hàng 
            {
                // In khoảng trắng tạo lề tam giác cân  
                for (int s = 1; s <= n - i; s++)
                {
                    Console.Write(" ");
                }

                // In các số của hàng
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(val + " ");
                    val++;
                }
                Console.WriteLine();







                /* Console.Write("nhập số n:");
                 int n = int.Parse(Console.ReadLine());
                 for (int i = 1; i <= n; i++)
                 {
                     for (int j =1; j <= i; j++)
                     {
                         Console.Write("*");
                     }
                     Console.WriteLine();
                 }*/




            }
        }
    }
}

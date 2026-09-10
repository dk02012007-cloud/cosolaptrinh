using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b10
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal sotien;
            string mamuondoi;

            Console.Write("Số tiền = ");
            sotien = decimal.Parse(Console.ReadLine());
            do
            {
                Console.Write("mã ngoại tệ bạn muốn đổi = ");
               mamuondoi  = Console.ReadLine().Trim().ToLower();

                if ( mamuondoi != "usd" && mamuondoi != "eur" && mamuondoi != "jpy" )
                {
                    Console.WriteLine("Mã ngoại tệ không hợp lệ. Vui lòng nhập lại.");
                }
            } while ( mamuondoi != "usd" && mamuondoi != "eur" && mamuondoi != "jpy" );


            switch (mamuondoi)
            {
                case "usd":
                    Console.WriteLine("Số tiền sau quy đổi = " + (sotien/25.400m).ToString("F2") + " USD");
                    break;
                case "eur":
                    Console.WriteLine("Số tiền sau quy đổi = " + (sotien/29.500m).ToString("F2") + " EUR");
                    break;
                case "jpy":
                    Console.WriteLine("Số tiền sau quy đổi = " + (sotien/20.000m).ToString("F2") + " JPY");
                    break;
            }

                

        }


    }
}

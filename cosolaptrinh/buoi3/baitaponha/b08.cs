using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b08
    {
        static void Main8(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bạn vui lòng nhập car hoặc bike ");
            Console.WriteLine("thời gian là 1 nếu từ 6h đến 18h ");
            Console.WriteLine("thời gian là 2 nếu từ 18h đến 6h ");
            bool ketqua;
            int thoigian;
            Console.Write("Loại xe = ");
            string loaixe = Console.ReadLine().Trim().ToUpper();
            do
            {
                Console.Write("Thời gian = ");
                string input = Console.ReadLine();
                ketqua = int.TryParse(input, out thoigian);
                if (!ketqua || thoigian != 1 && thoigian != 2)
                {
                    Console.WriteLine("Thời gian chỉ nhận giá trị 1 hoặc 2.Xin bạn vui lòng nhập lại.");
                }
            } while (!ketqua || thoigian != 1 && thoigian != 2);
            if (loaixe == "CAR")
            {
                switch (thoigian)
                {
                    case 1:
                        Console.WriteLine("Giá tiền là 30,000 VND");
                        break;
                    case 2:
                        Console.WriteLine("Giá tiền là 60,000 VND");
                        break;
                }
            }
            else
            {
                switch (thoigian)
                {
                    case 1:
                        Console.WriteLine("Giá tiền là 5,000 VND");
                        break;
                    case 2:
                        Console.WriteLine("Giá tiền là 10,000 VND");
                        break;
                }   
            }
        }
    }
}

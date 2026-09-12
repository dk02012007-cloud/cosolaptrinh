using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b15
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int nam;
            bool ketqua;
            Console.Write("Nhập tháng: ");
            int thang = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhập năm: ");
                string input = Console.ReadLine();
                ketqua = int.TryParse(input, out nam);
                if (!ketqua || nam <= 0)
                {
                    Console.WriteLine("Năm không hợp lệ. Vui lòng nhập lại.");
                }

            } while (!ketqua || nam <= 0);
            string ngayTrongThang = "";
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                   ngayTrongThang = "có 31 ngày";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    ngayTrongThang = "có 30 ngày";
                    break;
                case 2:
                    if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
                    {
                        ngayTrongThang = "có 29 ngày (Năm nhuận)";
                    }
                    else
                    {
                        ngayTrongThang = "có 28 ngày";
                    }
                    break;
            }
            Console.WriteLine($"Tháng {thang} năm {nam} {ngayTrongThang}");

        }   
    }
    
}



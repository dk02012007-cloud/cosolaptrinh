using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b04
    {
        static void Main(string[] args)
        {
            /*  -Khách hàng bấm phím từ 0 đến 4:
    -1: Gặp tổng đài viên tư vấn thẻ.
   - -2: Tra cứu số dư tài khoản.
   - -3: Báo khóa thẻ  hẩn cấp.
   - -4: Tra cứu tỷ giá ngoại tệ.
   - -0: Quay lại menu chính.*/
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding =Encoding.UTF8;
            Console.WriteLine("Khách hàng bấm phím từ 0 đến 4:");
            Console.WriteLine(" -1: Gặp tổng đài viên tư vấn thẻ.");
            Console.WriteLine(" -2: Tra cứu số dư tài khoản.");
            Console.WriteLine(" -3: Báo khóa thẻ  hẩn cấp.");
            Console.WriteLine(" -4: Tra cứu tỷ giá ngoại tệ.");
            Console.WriteLine(" -0: Quay lại menu chính.");
            int phim;
            bool ketqua;
            do
            {
                Console.Write("Phím bấm = ");
                string input = Console.ReadLine();
                ketqua = int.TryParse(input, out phim);
                if (ketqua == true && phim >= 0 && phim <= 4)
                {
                    switch (phim)
                    {
                        case 1:
                            Console.WriteLine("Gặp tổng đài viên tư vấn thẻ.");
                            break;
                        case 2:
                            Console.WriteLine("Tra cứu số dư tài khoản.");
                            break;
                        case 3:
                            Console.WriteLine("Báo khóa thẻ  hẩn cấp.");
                            break;
                        case 4:
                            Console.WriteLine("Tra cứu tỷ giá ngoại tệ.");
                            break;
                        case 0:
                            Console.WriteLine("Quay lại menu chính.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Phím bấm không hợp lệ. Vui lòng nhập lại từ 0 đến 4.");
                }



            } while (!ketqua || phim < 0 || phim > 4);
        }
    }
}

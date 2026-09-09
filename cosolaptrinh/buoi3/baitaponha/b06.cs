using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b06
    {
        static void Main6(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int trangthai;
            bool ketqua;
            do
            {
                Console.Write("Trạng thái = ");
                string input = Console.ReadLine();
                ketqua = int.TryParse(input, out trangthai);
                if (ketqua && trangthai >= 1 && trangthai <= 5)
                {
                    switch (trangthai)
                    {
                        case 1:
                            Console.WriteLine("Chờ xác nhận thanh toán."); break;
                        case 2:
                            Console.WriteLine("Đang đóng gói và bàn giao đơn vị vận chuyển."); break;
                        case 3:
                            Console.WriteLine("Đơn hàng đang trên đường giao đến bạn."); break;
                        case 4:
                            Console.WriteLine("Đơn hàng đã hoàn thành. Cảm ơn bạn!"); break;
                        case 5:
                            Console.WriteLine("Đơn hàng đã hủy. Xuất phiếu hoàn tiền."); break;
                    }
                }
                else
                {
                    Console.WriteLine("bạn nhập sai rồi, vui lòng nhập lại từ 1 đến 5");
                }

            }while (!ketqua || trangthai < 1 || trangthai > 5);
        }
    }
}

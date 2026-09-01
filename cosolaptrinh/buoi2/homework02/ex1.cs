using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi2.homework02
{
    internal class ex1
    {
        static void Main1(string[] args)
        {
         
                Console.Write("Nhap chi so dien cu (kWh): ");
                int chiSoCu = int.Parse(Console.ReadLine());
            
                Console.Write("Nhap chi so dien moi (kWh): ");
            int chiSoMoi = int.Parse(Console.ReadLine());
            if (chiSoMoi < chiSoCu)
            {
                // Nếu chỉ số mới nhỏ hơn chỉ số cũ -> Báo lỗi
                Console.WriteLine("Chi so moi phai lon hon chi so cu!");

            }
            else
            {
                // 1. Số điện tiêu thụ = 1520 - 1250 = 270 kWh
                int soKwh = chiSoMoi - chiSoCu;

                int bac1 = 0, bac2 = 0, bac3 = 0, bac4 = 0, bac5 = 0;

                if (soKwh <= 50)
                {
                    bac1 = soKwh;
                }
                else if (soKwh <= 100)
                {
                    bac1 = 50;
                    bac2 = soKwh - 50;
                }
                else if (soKwh <= 200)
                {
                    bac1 = 50;
                    bac2 = 50;
                    bac3 = soKwh - 100;
                }
                else if (soKwh <= 300)
                {
                    bac1 = 50;
                    bac2 = 50;
                    bac3 = 100;
                    bac4 = soKwh - 200; // 270 - 200 = 70 kWh
                }
                else
                {
                    bac1 = 50;
                    bac2 = 50;
                    bac3 = 100;
                    bac4 = 100;
                    bac5 = soKwh - 300;
                }

                // 2. Tính tiền điện chưa thuế
                // 50*1806 + 50*1866 + 100*2167 + 70*2729 = 636,650
                decimal tienChuaThue = (bac1 * 1806m) + (bac2 * 1866m) + (bac3 * 2167m) + (bac4 * 2729m) + (bac5 * 3050m);

                // 3. Tính thuế VAT 8% và làm tròn hàng đơn vị
                // 636,650 * 0.08 = 50,932
                decimal thueVat = Math.Round(tienChuaThue * 0.08m);

                // 4. Tổng thanh toán
                // 636,650 + 50,932 = 687,582
                decimal tongThanhToan = tienChuaThue + thueVat;

                // In ra kết quả
                Console.WriteLine($"So dien tieu thu: {soKwh} kWh");
                Console.WriteLine($"Tien dien chua thue: {tienChuaThue:#,##0} VNĐ");
                Console.WriteLine($"Thue VAT (8%): {thueVat:#,##0} VNĐ");
                Console.WriteLine($"Tong thanh toan: {tongThanhToan:#,##0} VNĐ");
            }         
        }
    }

}
    

        
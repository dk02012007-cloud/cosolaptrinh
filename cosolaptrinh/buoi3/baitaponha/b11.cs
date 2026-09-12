using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b11
    {
        static void Main1(string[] args)
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Số kWh = ");
        double kwh = double.Parse(Console.ReadLine());

        double tongTien = 0;
        string chiTiet = "";

        if (kwh <= 50)
        {
            tongTien = kwh* 1806;
            chiTiet = $"{kwh}*1806 = {tongTien:N0}";
        }
        else if (kwh <= 100)
        {
            double t1 = 50 * 1806;
    double t2 = (kwh - 50) * 1866;
    tongTien = t1 + t2;
            chiTiet = $"50*1806 + {kwh - 50}*1866 = {t1:N0} + {t2:N0}";
        }
        else
        {
              double t1 = 50 * 1806;
              double t2 = 50 * 1866;
              double t3 = (kwh - 100) * 2167;
                  tongTien = t1 + t2 + t3;
         chiTiet = $"50*1806 + 50*1866 + {kwh - 100}*2167 = {t1:N0} + {t2:N0} + {t3:N0}";
         }

Console.WriteLine($"Tổng tiền điện phải thanh toán: {tongTien:N0} VNĐ");
Console.WriteLine($"(Chi tiết: {chiTiet})");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi2.homework02
{
    internal class ex7
    {
        static void Main8(string[] args)
        {
          
                Console.WriteLine("--- INPUT ---");
                Console.Write("Quãng đường (km): ");
                double distance = double.Parse(Console.ReadLine());

                Console.Write("Mức tiêu hao (L/100km): ");
                double consumption = double.Parse(Console.ReadLine());

                Console.Write("Giá xăng (VNĐ/Lít): ");
                decimal fuelPrice = decimal.Parse(Console.ReadLine());

                Console.Write("Số người đi: ");
                int peopleCount = int.Parse(Console.ReadLine());

                // 1. Tính tổng số lít xăng cần dùng (double)
                double totalLiters = (distance / 100.0) * consumption;

                // 2. Tính tổng chi phí tiền xăng (Ép totalLiters sang decimal để nhân với giá tiền)
                decimal totalCost = (decimal)totalLiters * fuelPrice;

                // 3. Tính chi phí trung bình mỗi người
                decimal rawCostPerPerson = totalCost / peopleCount;

                // 4. Làm tròn lên hàng nghìn VNĐ gần nhất bằng Math.Ceiling
                // Mẹo: Chia cho 1000 -> Làm tròn lên -> Nhân lại với 1000
                double roundedThousand = Math.Ceiling((double)rawCostPerPerson / 1000.0);
                decimal finalCostPerPerson = (decimal)roundedThousand * 1000m;

                // 5. Xuất kết quả định dạng
                Console.WriteLine("--- OUTPUT ---");
                Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {totalLiters:F2} Lít");
                Console.WriteLine($"Tổng chi phí xăng dầu: {totalCost:N0} VNĐ");
                Console.WriteLine($"Chi phí mỗi người: {finalCostPerPerson:N0} VNĐ");
            }
        }
    }



        
      

    
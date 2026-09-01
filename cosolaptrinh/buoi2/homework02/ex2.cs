using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi2.homework02
{
    internal class ex2
    {
        static void Main2(string[] args)
        {
         Console.WriteLine("--- INPUT ---");

                // 1. Nhập chiều cao và cân nặng
                Console.Write("Chiều cao (m): ");
                double height = double.Parse(Console.ReadLine());

                Console.Write("Cân nặng (kg): ");
                double weight = double.Parse(Console.ReadLine());

                // 2. Tính chỉ số BMI
                double bmi = weight / Math.Pow(height, 2);

                // 3. Phân loại tình trạng sức khỏe theo chuẩn WHO Châu Á
                string status = "";
                if (bmi < 18.5)
                {
                    status = "Gầy (Thiếu cân)";
                }
                else if (bmi < 23.0)
                {
                    status = "Bình thường (Lý tưởng)";
                }
                else if (bmi < 25.0)
                {
                    status = "Thừa cân (Tiền béo phì)";
                }
                else
                {
                    status = "Béo phì";
                }

                // 4. Tính dải cân nặng lý tưởng
                double minWeight = 18.5 * Math.Pow(height, 2);
                double maxWeight = 22.9 * Math.Pow(height, 2);

                // 5. Xuất kết quả
                Console.WriteLine("--- OUTPUT ---");
                Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2}");
                Console.WriteLine($"Phân loại sức khỏe: {status}");
                Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {minWeight:F2} kg đến {maxWeight:F2} kg.");

                Console.ReadLine();
            
        }
    }
}
    


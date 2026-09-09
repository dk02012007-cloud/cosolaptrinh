using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b07
    {
        static void Main7(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float chieucao;
            float cannang;
            bool ketqua1;
            bool ketqua2;
            do
            {
                Console.Write("Nhập chiều cao (m): ");
                string input1 = Console.ReadLine();
                ketqua1 = float.TryParse(input1, out chieucao);
                Console.Write("Nhập cân nặng (kg): ");
                string input2 = Console.ReadLine();
                ketqua2 = float.TryParse(input2, out cannang);
                if (!ketqua1 || !ketqua2)
                {
                    Console.WriteLine("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập lại.");
                }

            } while (!ketqua1 || !ketqua2);
            float bmi = cannang / (float)Math.Pow(chieucao, 2); //(float)Math.Pow(chieucao, 2) để ép kiểu vì math nó trả về double
            if (bmi < 18.5)
            {
                Console.WriteLine($"BMI: {bmi:F2} - Đánh giá: Gầy - Nên bổ sung dinh dưỡng.");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine($"BMI: {bmi:F2} - Đánh giá: Cân đối - Tiếp tục duy trì.");
            }
            else if (bmi>=25 && bmi < 30)
            {
                Console.WriteLine($"BMI: {bmi:F2} - Đánh giá: Thừa cân - Cần giảm cân.");
            }
            else
            {
                Console.WriteLine($"BMI: {bmi:F2} - Đánh giá: Béo phì - Cần giảm cân và tập luyện.");
            }
        }
    }
}

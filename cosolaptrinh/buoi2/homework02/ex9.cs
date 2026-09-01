using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi2.homework02
{
    internal class ex9
    {
        static void Main9(string[] args)
        {
         
                Console.WriteLine("--- INPUT ---");
                Console.Write("Lương Gross (VNĐ): ");
                // Giả định người dùng nhập số nguyên, ví dụ: 25000000
                decimal gross = decimal.Parse(Console.ReadLine());

                Console.Write("Số người phụ thuộc: ");
                int dependents = int.Parse(Console.ReadLine());

                // 1. Tính tổng các khoản giảm trừ bảo hiểm (10.5%)
                decimal insurance = gross * 0.105m;

                // 2. Tính thu nhập chịu thuế
                decimal personalDeduction = 11000000m; // Giảm trừ bản thân
                decimal dependentDeduction = 4400000m * dependents; // Giảm trừ người phụ thuộc

                decimal taxableIncome = gross - insurance - personalDeduction - dependentDeduction;

                // Kiểm tra điều kiện: Nếu thu nhập chịu thuế <= 0 thì gán bằng 0
                if (taxableIncome < 0)
                {
                    taxableIncome = 0;
                }

                // 3. Tính thuế Thu nhập cá nhân (TNCN) theo biểu thuế lũy tiến 7 bậc
                decimal tax = 0;
                if (taxableIncome > 0)
                {
                    if (taxableIncome <= 5000000m)
                    {
                        tax = taxableIncome * 0.05m;
                    }
                    else if (taxableIncome <= 10000000m)
                    {
                        tax = (5000000m * 0.05m) + ((taxableIncome - 5000000m) * 0.10m);
                    }
                    else if (taxableIncome <= 18000000m)
                    {
                        tax = (5000000m * 0.05m) + (5000000m * 0.10m) + ((taxableIncome - 10000000m) * 0.15m);
                    }
                    else if (taxableIncome <= 32000000m)
                    {
                        tax = (5000000m * 0.05m) + (5000000m * 0.10m) + (8000000m * 0.15m) + ((taxableIncome - 18000000m) * 0.20m);
                    }
                    else if (taxableIncome <= 52000000m)
                    {
                        tax = (5000000m * 0.05m) + (5000000m * 0.10m) + (8000000m * 0.15m) + (14000000m * 0.20m) + ((taxableIncome - 32000000m) * 0.25m);
                    }
                    else if (taxableIncome <= 80000000m)
                    {
                        tax = (5000000m * 0.05m) + (5000000m * 0.10m) + (8000000m * 0.15m) + (14000000m * 0.20m) + (20000000m * 0.25m) + ((taxableIncome - 52000000m) * 0.30m);
                    }
                    else
                    {
                        // Bậc 7: Trên 80 triệu
                        tax = (5000000m * 0.05m) + (5000000m * 0.10m) + (8000000m * 0.15m) + (14000000m * 0.20m) + (20000000m * 0.25m) + (28000000m * 0.30m) + ((taxableIncome - 80000000m) * 0.35m);
                    }
                }

                // 4. Tính lương Net thực nhận
                decimal netSalary = gross - insurance - tax;

                // 5. In kết quả với định dạng số phân cách hàng nghìn (N0)
                Console.WriteLine("--- OUTPUT ---");
                Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {insurance:N0} VNĐ");
                Console.WriteLine($"Thu nhập chịu thuế: {taxableIncome:N0} VNĐ");
                Console.WriteLine($"Thuế TNCN phải nộp: {tax:N0} VNĐ");
                Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {netSalary:N0} VNĐ");
            }
        }
    }

    


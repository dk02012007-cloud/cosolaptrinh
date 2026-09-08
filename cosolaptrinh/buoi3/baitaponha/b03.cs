using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class b03
    {
        static void Main3(string[]args) 
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Số dư = ");
            decimal sodu = decimal.Parse(Console.ReadLine());
            long sotienrut;
            do
            {
                Console.WriteLine("số tiền rút = ");
                sotienrut = long.Parse(Console.ReadLine());
                if (sotienrut <= 0)
                {
                    Console.WriteLine("số tiền rút phải lớn hơn 0");
                }
                else if (sotienrut % 50000 != 0)
                {
                    Console.WriteLine("số tiền rút phải là bội số của 50.000");
                }
                else if (sotienrut > sodu)
                {
                    Console.WriteLine("số tiền rút không được vượt quá số dư");
                }
                else if (sotienrut > 5000000)
                {
                    Console.WriteLine("số tiền rút không được vượt quá 5.000.000");
                }




            } while (sotienrut <= 0 || sotienrut % 50000 != 0 || sotienrut > sodu || sotienrut > 5000000);
            decimal soduconlai= sodu - sotienrut;
            Console.WriteLine($"Giao dịch thành công. Số dư còn lại là: {soduconlai:N0} VND"); // N0 để 





        }
    }
}

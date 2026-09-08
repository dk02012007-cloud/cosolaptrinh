using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace cosolaptrinh.buoi3
{
    internal class exatclass
    {
        static void Main1(string[] args)
        {
            /* Console.Write("nhap so thu nhat:");
             double a = double.Parse(Console.ReadLine());
             Console.Write("nhap so thu hai:");
             double b = double.Parse(Console.ReadLine());
             double c = a + b;
             double d = a - b;
             double e = a * b;
             double f = a / b;
             Console.WriteLine(c);
             Console.WriteLine(d);
             Console.WriteLine(e);
             Console.WriteLine(f);
 */







            /* do
             {
                 int y;
                 Console.Write($"nhap gia tri cua y(so nguyen): ");
                 string input = Console.ReadLine();
                 bool ketqua = int.TryParse(input, out y);
                 if (ketqua == true && (y <= 5 && y >= -5))
                 { 
                     int x = y * y + 2 * y + 1;
                     Console.WriteLine(x);
                     break;

                 }
                 else
                 {
                     Console.WriteLine("Gia tri nhap vao khong hop le. Vui long nhap lai.");
                 }
             } while (true);*/

            Console.Write("Nhap 1 ky tu: ");
            char c = Console.ReadLine()[0];
            int ascii_of_a = (int)c; 
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine("Ky tu vua nhap la nguyen am.");
            }
            else if (c >= 97 && c <= 122)
            {
                Console.WriteLine("Ky tu vua nhap la phu am .");
            }
            else if (ascii_of_a >=48 && ascii_of_a <= 57)
            {
                Console.WriteLine("Ky tu vua nhap la so.");
            }
            else
            {
                Console.WriteLine("Ky tu vua nhap la ky tu dac biet.");
            }






        }
    }
}

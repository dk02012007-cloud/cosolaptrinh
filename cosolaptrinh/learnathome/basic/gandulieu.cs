using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.learnathome.basic
{
    internal class gandulieu
    {
        static void Main01(string[] args)
        {
            Console.WriteLine("Day la bài hoc o nha (lan1)!");

            // day la lenh de noi lien ket qua ra man hinh console

            Console.Write("Toi da");
            Console.Write("  ");
            Console.Write("noi lien dong voi nhau");
            Console.WriteLine(" ");
            Console.WriteLine("this is the first line.");
            Console.WriteLine("this is the second line.");
            Console.Write("this is");
            Console.Write(" the");
            Console.Write(" third line.");

            // đây là các lệnh gán dữ liệu 

            string firstName = "Man";
            Console.WriteLine(firstName);
            firstName = " dang ";
            Console.WriteLine(firstName);
            firstName = " hoc lap trinh";
            Console.WriteLine(firstName);
            var message = 4.567;
            Console.WriteLine(message);

            // đây là lệnh nối các kết quả bằng nhiều cách khác nhau

            string chaoHoi = "Hello";
            Console.Write(chaoHoi);
            Console.Write(",");
            Console.Write(" ");
            var message1 = "Minh Man!";
            Console.Write(message1);
            Console.Write(" ");
            Console.Write("You have 3 messages in your inbox,");
            Console.Write(" ");
            Console.Write("The temperature is ");
            var x = 37; Console.Write(x);
            Console.Write(" celsius");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            // next is string concactenation using escape sequences
            Console.WriteLine("Hello\nWorld"); // \n is a new line escape sequence
            Console.WriteLine("Hello\tWorld"); // \t is a tab(4 spaces) escape sequence

            Console.WriteLine("Hello \"World\"!"); // dấu \ cho ta biết nếu ký tự nào đi sau lungư nó sẽ biến thành chuỗi

            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.Write("\nOutput Directory:\t");
            Console.WriteLine(@"c:\Invoices"); //@ dùng để in ra nguyên cahracter string

            Console.WriteLine(@"    c:\source\repos    
                      (this is where your code goes)");

            // nối chuỗi bằng cách dùng dấu +   
            string firstName1 = "Minh Man";
            string lastName = "Pham";
            string fullName = lastName + " " + firstName1;
            Console.WriteLine(fullName);
            // method 2
            Console.WriteLine(lastName + " " + firstName1);

            // nối chuỗi bằng cách dùng dấu $ {}
            string fullName2 = $"{lastName} {firstName1}";
            Console.WriteLine(fullName2);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            int version = 11;
            string updateText = "Update to Windows";
            Console.WriteLine($"{updateText} {version}!");

            // sử dụng $ và @ chung dòng, kh cần sử dụng \ hay + để nối chuỗi   
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine($"Decimal quotient: {decimalQuotient}");
            int value1 = 0;
            value1 = value1 + 8;
            value1 += 10;
            Console.WriteLine(value1);



        }
    }
}
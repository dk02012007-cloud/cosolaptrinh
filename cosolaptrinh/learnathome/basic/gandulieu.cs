using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.learnathome.basic
{
    internal class gandulieu
    {
        static void Main(string[] args)
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
            Console.WriteLine("\nOutput Directory:\t");


        }
    }
}
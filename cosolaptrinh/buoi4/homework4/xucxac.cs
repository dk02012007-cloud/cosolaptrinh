using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace cosolaptrinh.buoi4.homework4
{
    internal class xucxac
    {
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("""
                              _______.
                   ______    | .   . |\
                  /     /\   |   .   |.\
                 /  '  /  \  | .   . |.'|
                /_____/. . \ |_______|.'|
                \ . . \    /  \ ' .   \'|
                 \ . . \  /    \____'__\|
                  \_____\/      
                """);
            Console.WriteLine("Chào mừng bạn đến với trò chơi Xí ngầu!");
            Console.WriteLine("-----------THỂ LỆ CHƠI NHƯ SAU:-----------");
            Console.WriteLine("1. Người chơi đặt cược vào Tài(từ 3-10) thì chọn \"t\" hoặc Xĩu(từ 11-18) thì chọn \"x\"");
            Console.WriteLine("2. Nếu đoán đúng bạn sẽ nhận lại được số tiền cược và 0.95% tiền thắng");
            Console.WriteLine("3. Nếu xúc xắc gieo ra 3 con giống nhau và bạn chọn đúng thì bạn sẽ nhận được 600% số tiền cược");
            Console.WriteLine("4. Nếu bạn đoán sai, bạn sẽ mất số tiền cược");
            Console.WriteLine("5. Trò chơi sẽ tiếp tục cho đến khi bạn quyết định dừng lại (chọn \"q\" )");
            Dice_game();
        }
        public static void Dice_game()
        {
            long tienhientai = 10000000; //giả sử người chơi có 10 triệu đồng
            int solanchoi = 0;
            int solanthua = 0;
            int solamdacbiet = 0;
            bool continuePlay = true; // giả sử chơi tiếp và đặt ở ngoài vòng lặp do while 
            string choice = "";
            do
            {
                if (tienhientai <= 5000)
                {
                    Console.WriteLine("\n--------------------------------------------------");
                    Console.WriteLine($"Số tiền hiện tại ({tienhientai}đ) không đủ 5000đ để đặt cược!");
                    Console.WriteLine("Hệ thống tự động dừng trò chơi.");
                    break; // Lệnh break này thuộc vòng lặp LỚN nên sẽ thoát thẳng ra bảng tổng kết!
                }
                // -----------------------------------------------
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write($"Bạn có {tienhientai}.  Bạn muốn cược bao nhiêu: ");
                long tiendatcuoc = 0;
                do
                {
                    bool ketqua = long.TryParse(Console.ReadLine(), out tiendatcuoc);
                    if (ketqua && tiendatcuoc <= tienhientai && tiendatcuoc >= 5000) 
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Không hợp lệ.Số tiền bạn đặt cược không vượt quá {tienhientai}");
                        Console.WriteLine("hoặc số tiền đặt cược phải lớn hơn 5000");
                        Console.Write("Bạn đặt bao nhiêu: ");
                    }

                } while (true); // dùng true để lập vô hạn cho đến khi người dùng nhập đúng gặp break mới thoát được khỏi lệnh 

                // gieo 3 con xí ngầu 
                Random random = new Random();
                int rice1 = random.Next(1, 7); // kiểu như [1;7)
                int rice2 = random.Next(1, 7);
                int rice3 = random.Next(1, 7);
                int sum = rice1 + rice2 + rice3;
                
                do
                {
                    Console.Write("Mời bạn lựa chọn Tài(t) hay Xĩu(x): ");
                    choice = Console.ReadLine()?.Trim().ToUpper();
                    if (choice == "T" || choice == "X")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn \"t\" hoặc \"x\" ");
                    }
                } while (true);


                // Kiểm tra kết quả 
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine($"Kết quả gieo xí ngầu: {rice1} + {rice2} + {rice3} = {sum}");
                if (choice == "T" && sum == 18)
                {
                    solanchoi++;
                    tienhientai += tiendatcuoc * 6;
                    Console.WriteLine($"Chúc mừng bạn đã được giải đặc biệt trị giá: {tiendatcuoc * 6} ");
                    Console.WriteLine($"Tổng số tiền hiện tại: {tienhientai}");
                }
                else if (choice == "X" && sum == 3)
                {
                    solanchoi++;
                    tienhientai += tiendatcuoc * 6;
                    Console.WriteLine($"Chúc mừng bạn đã được giải đặc biệt trị giá: {tiendatcuoc * 6} ");
                    Console.WriteLine($"Tổng số tiền hiện tại: {tienhientai}");
                }
                else if ((choice == "T" && sum >= 11 && sum <= 17) || (choice == "X" && sum >= 4 && sum <= 10))
                {
                    solanchoi++;
                    tienhientai += (long)(tiendatcuoc * 0.95);
                    Console.WriteLine($"Chúc mừng bạn đã thắng! Bạn nhận được: {(long)(tiendatcuoc * 0.95)}");
                    Console.WriteLine($"Tổng số tiền hiện tại: {tienhientai}");
                }
                else
                {
                    solanchoi++;
                    solanthua++;
                    tienhientai -= tiendatcuoc;
                    Console.WriteLine($"Rất tiếc, bạn đã thua! Bạn mất: {tiendatcuoc}");
                    Console.WriteLine($"Tổng số tiền hiện tại: {tienhientai}");
                }
                // ở đây nếu đặt bool continuePlay ở đây thì không có tác dụng vì nó đang nằm trong vòng do while ở dòng số 44) 
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Bạn có muốn tiếp tục chơi tiếp không ");

                    Console.Write("Bấm phím \"y\" để tiếp tục hoặc phím \"q\" để thoát: ");
                    string input = Console.ReadLine().ToLower();
                    if (input == "y")
                    {
                        continuePlay = true;
                        break;
                    }
                    else if (input == "q")
                    {
                        continuePlay = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn \"y\" hoặc \"q\" ");
                    }
                } while (true);



                } while (continuePlay);
            // khi kết thúc trò chơi, máy sẽ thông báo tổng số tiền thắng hoặc thua của người chơi.
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Cảm ơn bạn đã chơi. Trò chơi kết thúc.");
            Console.WriteLine($"Số lần chơi: {solanchoi}");
            Console.WriteLine($"Số lần thắng: {solanchoi - solanthua}");
            Console.WriteLine();
            Console.WriteLine($"Số lần thua: {solanthua}");

        }
    }
    }

















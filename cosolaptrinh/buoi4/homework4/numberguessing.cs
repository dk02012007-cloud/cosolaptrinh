using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace cosolaptrinh.buoi4.homework4
{
    internal class numberguessing
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=====WELCOM TO THE NUMBER GUESSING GAME===== ");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Thể lệ chơi như sau:");
            Console.WriteLine("- Người chơi có 100000 VNĐ vốn ban đầu");
            Console.WriteLine("- Mỗi vòng chơi, người chơi sẽ nhập số tiền cược (tối thiểu 1000đ, tối đa số tiền hiện có)");
            Console.WriteLine("- Người chơi chọn cấp độ khó khăn (dễ, trung bình, khó)");
            Console.WriteLine("- Tùy vào cấp độ, người chơi sẽ có số lần đoán khác nhau tương ứng 7,5,3 lần");
            Console.WriteLine("- Nếu đoán đúng, người chơi sẽ nhận được tiền thưởng theo tỷ lệ 0.5,2,4 tương ứng");
            Console.WriteLine("- Trò chơi sẽ kết thúc khi người chơi chọn không chơi nữa hoặc số tiền còn lại 0 đồng .");
            guessing();
        }
        public static void guessing()
        {
            double currentMoney = 100000; // Cho sẵn người chơi 100000đ vốn ban đầu
            int soLanChoi = 0;
            int soLanThua = 0;
            bool continuePlay = true; // giả sử chơi tiếp và đặt ở ngoài vòng lặp do while
            int level;

            /// quay số 
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // sinh số ngẫu nhiên từ 1 đến 100
            do
            {
                if (currentMoney <= 0)
                {
                    Console.WriteLine("\n--------------------------------------------------");
                    Console.WriteLine($"Số tiền hiện tại ({currentMoney}đ) không đủ để đặt cược!");
                    Console.WriteLine("Hệ thống tự động dừng trò chơi.");
                    break; // Lệnh break này thuộc vòng lặp LỚN nên sẽ thoát thẳng ra bảng tổng kết!
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine($"Số tiền hiện tại: {currentMoney}đ");
                Console.Write("Bạn muốn đặt cược bao nhiêu: ");
                double tienDatCuoc = 0;
                do
                {
                    bool ketqua = double.TryParse(Console.ReadLine().Trim(), out tienDatCuoc);
                    if (ketqua && tienDatCuoc >= 1000 && tienDatCuoc <= currentMoney)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Số tiền đặt cược không hợp lệ. Vui lòng nhập lại: ");
                    }
                } while (true);

                // chọn cấp độ chơi
                bool ketquachon;
                do
                {
                    Console.Write("Select a difficulty level (1-Easy, 2-Medium, 3-Hard): ");
                    ketquachon = int.TryParse(Console.ReadLine().Trim(), out level);
                    if (ketquachon && level >= 1 && level <= 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cấp độ không hợp lệ. Vui lòng chọn lại.");
                    }
                } while (!ketquachon || level < 1 || level > 3);
                int maxAttempts = 0; // số lần đoán tối đa
                double rewardRatio = 0; // tỷ lệ thưởng
                switch (level)
                {
                    case 1:
                        maxAttempts = 7;
                        rewardRatio = 0.5;
                        break;
                    case 2:
                        maxAttempts = 5;
                        rewardRatio = 2;
                        break;
                    case 3:
                        maxAttempts = 3;
                        rewardRatio = 4;
                        break;
                }





                bool isWin = false; // Dùng để lát nữa cập nhật tiền thưởng 


                Console.WriteLine($"Một số ngầu nhiên đã được quay ra.Bạn có {maxAttempts} lần đoán.");
                int guess;
                bool ketquachonso;
                // dùng for để lặp số lần đoán 
                for (int attempt = 1; attempt <= maxAttempts; attempt++)
                {
                    Console.Write($"Lần đoán {attempt}/{maxAttempts}, số bạn lựa chọn là: ");
                    do // đây là dùng theo cách do while
                    {
                        ketquachonso = int.TryParse(Console.ReadLine().Trim(), out guess);

                        if (ketquachonso && guess > 0 && guess <= 100)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Số bạn nhập không hợp lệ. Vui lòng nhập lại!");
                        }
                    } while (!ketquachonso || guess <= 0 || guess > 100);




                    // có thể dùng cách dưới thay cho do while ở dòng 102 - 114 
                    // còn đây là dùng cho cách if kết hợp continue để nếu sai thì không chạy code bên dưới mà quay ngược lên trên 
                    /* if (!int.TryParse(Console.ReadLine().Trim(),out guess))
                     {
                         Console.WriteLine("Số bạn nhập không hợp lệ. Vui lòng nhập lại!");
                         attempt--; // dùng để trừ đi 1 attempt nếu lỡ có nhập sai thì quay lê trên for attempt bị +1 thì ở đây sẽ -1 đi
                         continue; 
                     }*/



                    // kết quá
                    if (guess == secretNumber)
                    {
                        isWin = true;
                        Console.WriteLine($"Congratulations, you guessed correctly : {secretNumber}");
                        break;
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Số bạn đoán nhỏ hơn secretnumber");
                    }
                    else
                    {
                        Console.WriteLine("Số bạn đoán lớn hơn secretnumber");
                    }
                }
                // cập nhật tiền thưởng
                if (isWin)
                {
                    currentMoney += (rewardRatio*tienDatCuoc);
                    Console.WriteLine($"Tiền hiện tại của bạn là:{currentMoney}");
                }
                else
                {
                    currentMoney -= tienDatCuoc;
                    Console.WriteLine($"Bạn thua tiền hiện tại của bạn là: {currentMoney}");
                }
                while (currentMoney < 1000)
                {
                    Console.WriteLine("Bạn không đủ tiền");     
                    return;
                }

                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Bạn muốn tiếp tục (nhấn phím \"c\" hoặc dừng chơi \"q\"): ");
                    string input = Console.ReadLine().Trim().ToLower();
                    if (input == "c")
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
                        Console.WriteLine("Lựa chọn không hợp lệ. Chỉ nhận chữ \"c\" hoặc \"k\"");
                    }

                } while (true);
            } while (continuePlay);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Cảm ơn bạn đã chơi, tiền hiện tại của bạn là {currentMoney}đ");
            Console.ReadKey();
        }

    }
}

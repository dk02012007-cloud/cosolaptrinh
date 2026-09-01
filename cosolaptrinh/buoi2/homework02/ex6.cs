using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace cosolaptrinh.buoi2.homework02
{
    internal class ex6
    {
        static void Main6(string[] args)
        {
                Console.WriteLine("--- INPUT ---");
                Console.Write("Nhập họ tên thô: ");
                string rawName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(rawName))
                {
                    Console.WriteLine("Tên không hợp lệ!");
                    return;
                }

                // 1. Cắt bỏ khoảng trắng thừa và tách thành các từ
                // StringSplitOptions.RemoveEmptyEntries giúp tự động bỏ qua các khoảng trắng liên tiếp
                string[] words = rawName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // 2. Chuyển đổi thành Title Case (Viết hoa chữ cái đầu)
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    // Chữ cái đầu viết hoa + Các chữ cái sau viết thường
                    words[i] = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
                }

                // 3. Ghép lại thành tên chuẩn hóa
                string normalizedName = string.Join(" ", words);

                // 4. Tách Họ, Tên đệm, Tên
                string lastName = words[0];
                string firstName = words[words.Length - 1];
                string middleName = "";

                // Nếu mảng có lớn hơn 2 từ thì mới có tên đệm
                if (words.Length > 2)
                {
                    string[] middleWords = new string[words.Length - 2];
                    Array.Copy(words, 1, middleWords, 0, words.Length - 2); // Lấy từ vị trí số 1 đến áp chót
                    middleName = string.Join(" ", middleWords);
                }

                // 5. Tạo Username và Email (Loại bỏ dấu tiếng Việt và viết thường)
                string unaccentedFirst = RemoveAccents(firstName).ToLower();
                string unaccentedLast = RemoveAccents(lastName).ToLower();
                string unaccentedMiddle = RemoveAccents(middleName.Replace(" ", "")).ToLower(); // Xóa dấu cách trong tên đệm

                string username = $"{unaccentedFirst}.{unaccentedLast}{unaccentedMiddle}";
                string email = $"{username}@company.edu.vn";

                // 6. Xuất kết quả
                Console.WriteLine("--- OUTPUT ---");
                Console.WriteLine($"Họ tên chuẩn hóa: {normalizedName}");
                Console.WriteLine($"Họ: {lastName} | Tên đệm: {middleName} | Tên: {firstName}");
                Console.WriteLine($"Username tạo tự động: {username}");
                Console.WriteLine($"Email cấp phát: {email}");
            }

            // Hàm hỗ trợ: Loại bỏ dấu tiếng Việt cơ bản bằng cách thay thế chuỗi
            static string RemoveAccents(string text)
            {
                if (string.IsNullOrWhiteSpace(text)) return text;

                string[] vnSigns = new string[]
                {
                "aAeEoOuUiIdDyY",
                "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ",
                "óòọỏõôốồộổỗơớờợởỡ", "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ",
                "íìịỉĩ", "ÍÌỊỈĨ",
                "đ", "Đ",
                "ýỳỵỷỹ", "ÝỲỴỶỸ"
                };

                for (int i = 1; i < vnSigns.Length; i++)
                {
                    for (int j = 0; j < vnSigns[i].Length; j++)
                    {
                        // Thay thế ký tự có dấu bằng ký tự không dấu ở chuỗi vnSigns[0]
                        text = text.Replace(vnSigns[i][j], vnSigns[0][(i - 1) / 2]);
                    }
                }
                return text;
            }
        }
    }




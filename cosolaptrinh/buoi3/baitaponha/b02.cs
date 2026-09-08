using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi3.baitaponha
{
    internal class ex03
    {
        static void Main2(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Role = ");
            string role = Console.ReadLine()?.Trim().ToUpper(); //? để  tránh lỗi null nếu người dùng không nhập gì
            switch (role)
            {
                case "ADMIN":
                    Console.WriteLine("[Thông báo]: Toàn quyền quản trị hệ thống.");
                    break;
                case "MANAGER":
                    Console.WriteLine("[Thông bào]: Quyền quản lý nhân sự và xem báo cáo.");
                    break;
                case "EMPLOYEE":
                    Console.WriteLine("[Thông báo]: Quyền tạo và chỉnh sửa hồ sơ cá nhân.");
                    break;
                case "GUEST":
                    Console.WriteLine("[Thông báo]: Chỉ có quyền xem thông tin công khai.");
                    break;
                default: 
                    Console.WriteLine("Mã vai trò không hợp lệ!");
                    return; 


            }

        }
    }
}

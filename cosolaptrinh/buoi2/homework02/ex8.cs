using System;
using System.Collections.Generic;
using System.Text;

namespace cosolaptrinh.buoi2.homework02
{
    internal class ex8
    {
        static void Main8(string[] args)
        {
          
                // Mô phỏng hệ thống tạo sẵn mã OTP lúc hiện tại
                string heThongOTP = "839201";
                DateTime creationTime = DateTime.Now;

                Console.WriteLine("--- INPUT ---");
                Console.Write("Mã OTP nhận được: ");
                string inputOTP = Console.ReadLine();

                // Giả lập thời gian trôi qua để bạn dễ dàng test mã lỗi (Nhập theo định dạng Phút:Giây)
                Console.Write("Thời gian trôi qua (nhập mm:ss, ví dụ 02:15 hoặc 06:00): ");
                string timeInput = Console.ReadLine();

                // Xử lý chuỗi thời gian nhập vào để quy đổi thành đối tượng TimeSpan
                string[] timeParts = timeInput.Split(':');
                int phut = 0, giay = 0;
                if (timeParts.Length == 2)
                {
                    int.TryParse(timeParts[0], out phut);
                    int.TryParse(timeParts[1], out giay);
                }
                TimeSpan thoiGianTroiQua = new TimeSpan(0, phut, giay);

                // Tính ra thời điểm người dùng bấm nút "Xác thực"
                DateTime thoiDiemXacThuc = creationTime.Add(thoiGianTroiQua);

                Console.WriteLine("\n--- OUTPUT ---");

                // 1. Kiểm tra điều kiện 1: Đủ 6 ký tự và toàn là số
                // Dùng int.TryParse để ép kiểu. Nếu trả về true tức là chuỗi toàn số hợp lệ.
                bool isNumber = int.TryParse(inputOTP, out _);
                if (inputOTP.Length != 6 || !isNumber)
                {
                    Console.WriteLine("Trạng thái xác thực: LỖI - Định dạng không hợp lệ (Phải đủ 6 chữ số).");
                    return; // Kết thúc chương trình sớm
                }

                // 2. Kiểm tra điều kiện 3: Thời gian hiệu lực (Sử dụng TimeSpan theo gợi ý của đề)
                TimeSpan chenhLechThoiGian = thoiDiemXacThuc - creationTime;
                if (chenhLechThoiGian.TotalSeconds > 300) // 5 phút = 300 giây
                {
                    Console.WriteLine("Trạng thái xác thực: LỖI - Hết hạn OTP.");
                    return;
                }

                // 3. Kiểm tra điều kiện 2: Mã OTP khớp hoàn toàn
                if (inputOTP != heThongOTP)
                {
                    Console.WriteLine("Trạng thái xác thực: LỖI - Mã sai.");
                    return;
                }

                // Nếu vượt qua được toàn bộ các lớp bảo vệ (if) ở trên -> Thành công
                Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG - Giao dịch đã được phê duyệt.");
            }
        }
    }
    


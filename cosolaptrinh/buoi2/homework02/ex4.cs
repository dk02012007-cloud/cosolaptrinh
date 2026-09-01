using System;
using System.Globalization;

class Program
{
    static void Main4()
    {
        Console.WriteLine("--- INPUT ---");
        Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
        string input = Console.ReadLine();

        // 1. Chuyển đổi chuỗi thành DateTime bằng TryParseExact
        string format = "dd/MM/yyyy";
        if (!DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
        {
            Console.WriteLine("Định dạng ngày sinh không hợp lệ! Vui lòng nhập theo dạng dd/MM/yyyy (ví dụ: 15/09/2003).");
            return;
        }

        // 2. Lấy ngày hiện tại của hệ thống (bỏ qua phần giờ phút giây)
        DateTime today = DateTime.Now.Date;

        if (birthDate > today)
        {
            Console.WriteLine("Ngày sinh không thể lớn hơn ngày hiện tại!");
            return;
        }

        // 3. Tính tuổi chính xác
        int age = today.Year - birthDate.Year;
        // Nếu chưa đến ngày sinh nhật trong năm nay thì trừ đi 1 tuổi
        if (today < birthDate.AddYears(age))
        {
            age--;
        }

        // 4. Tính tổng số ngày đã sống
        TimeSpan totalLivedSpan = today - birthDate;
        int totalDaysLived = (int)totalLivedSpan.TotalDays;

        // 5. Xác định ngày sinh nhật tiếp theo
        DateTime nextBirthday = birthDate.AddYears(today.Year - birthDate.Year);
        if (nextBirthday < today)
        {
            // Nếu sinh nhật năm nay đã trôi qua, sinh nhật tiếp theo sẽ vào năm sau
            nextBirthday = nextBirthday.AddYears(1);
        }

        // Tính số ngày còn lại đến sinh nhật tiếp theo
        TimeSpan daysToNextBirthdaySpan = nextBirthday - today;
        int daysUntilNextBirthday = (int)daysToNextBirthdaySpan.TotalDays;

        // 6. Hiển thị kết quả (Sử dụng định dạng N0 để thêm dấu phẩy phân cách hàng nghìn)
        Console.WriteLine("--- OUTPUT ---");
        Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
        Console.WriteLine($"Bạn đã sống tổng cộng: {totalDaysLived:N0} ngày");
        Console.WriteLine($"Sinh nhật tiếp theo còn: {daysUntilNextBirthday} ngày nữa");
    }
}
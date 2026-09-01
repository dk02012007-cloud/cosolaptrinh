using System;
using System.Globalization; // 1. Khai báo thư viện để hết lỗi CultureInfo

class ex5 // 2. Bắt buộc phải có class bao bọc
{
    static void Main5(string[] args)
    {
        // Sử dụng InvariantCulture để đảm bảo việc nhập số thập phân bằng dấu '.' không bị lỗi
        CultureInfo culture = CultureInfo.InvariantCulture;

        Console.WriteLine("--- INPUT ---");

        // Gán sẵn số tín chỉ (TC) cho các môn như trong ví dụ minh họa
        int tcCsharp = 4;
        int tcToan = 3;
        int tcTiengAnh = 2;

        // Nhập điểm cho từng môn
        Console.Write($"C# ({tcCsharp} TC): ");
        double diemCsharp = double.Parse(Console.ReadLine(), culture);

        Console.Write($"Toán ({tcToan} TC): ");
        double diemToan = double.Parse(Console.ReadLine(), culture);

        Console.Write($"Tiếng Anh ({tcTiengAnh} TC): ");
        double diemTiengAnh = double.Parse(Console.ReadLine(), culture);

        // 1. Tính tổng tín chỉ và điểm trung bình trọng số (Thang 10)
        int tongTinChi = tcCsharp + tcToan + tcTiengAnh;
        double tongDiem = (diemCsharp * tcCsharp) + (diemToan * tcToan) + (diemTiengAnh * tcTiengAnh);

        double diemTB10 = tongDiem / tongTinChi;

        // Làm tròn điểm trung bình thang 10 đến 2 chữ số thập phân
        diemTB10 = Math.Round(diemTB10, 2);

        // Khởi tạo các biến để chứa kết quả quy đổi
        string diemChu;
        double diemGPA4;
        string xepLoai;

        // 2. Cấu trúc rẽ nhánh if-else để quy đổi điểm
        if (diemTB10 >= 8.5)
        {
            diemChu = "A";
            diemGPA4 = 4.0;
            xepLoai = "Xuất sắc / Giỏi";
        }
        else if (diemTB10 >= 7.0)
        {
            diemChu = "B";
            diemGPA4 = 3.0;
            xepLoai = "Khá";
        }
        else if (diemTB10 >= 5.5)
        {
            diemChu = "C";
            diemGPA4 = 2.0;
            xepLoai = "Trung bình";
        }
        else if (diemTB10 >= 4.0)
        {
            diemChu = "D";
            diemGPA4 = 1.0;
            xepLoai = "Yếu";
        }
        else
        {
            diemChu = "F";
            diemGPA4 = 0.0;
            xepLoai = "Kém (Trượt)";
        }

        // 3. Hiển thị kết quả
        Console.WriteLine("\n--- OUTPUT ---");
        Console.WriteLine($"Điểm TB Thang 10: {diemTB10:F2}");
        Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
        Console.WriteLine($"Điểm GPA Thang 4: {diemGPA4:F1}");
        Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");
    }
}
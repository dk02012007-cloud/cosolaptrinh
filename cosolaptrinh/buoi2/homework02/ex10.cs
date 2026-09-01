using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace cosolaptrinh.buoi2.homework02
{
    internal class ex10
    {
        static void Main(string[] args)
        {
           
                // Khai báo thông tin sản phẩm (có thể thay đổi dữ liệu để test các trường hợp)
                string productId = "KB-09";
                string productName = "Bàn phím Cơ Akko";
                int? quantity = null; // Giá trị khuyết thiếu (Chưa kiểm kê)
                int minThreshold = 10;
                DateTime? restockDate = null; // Chưa có lịch nhập hàng

                Console.WriteLine("--- INPUT / DATA ---");
                Console.WriteLine($"Sản phẩm: {productName} (Mã: {productId})");
                Console.WriteLine($"Số lượng tồn kho: {(quantity.HasValue ? quantity.ToString() : "null (Chưa kiểm kê)")}");
                Console.WriteLine($"Restock Date: {(restockDate.HasValue ? restockDate.Value.ToString("dd/MM/yyyy") : "null")}");

                // 1. Sử dụng toán tử ?? (Null-coalescing) để gán số lượng mặc định = 0 nếu null
                int displayQuantity = quantity ?? 0;

                // 2. Đánh giá trạng thái kho bằng enum StockStatus
                StockStatus status;
                if (quantity == null || quantity == 0)
                {
                    status = StockStatus.OutOfStock;
                }
                else if (quantity < minThreshold)
                {
                    status = StockStatus.LowStock;
                }
                else
                {
                    status = StockStatus.InStock;
                }

                // Chuyển trạng thái enum sang dạng chuỗi kèm mô tả
                string statusText = status switch
                {
                    StockStatus.OutOfStock => "OutOfStock (Hết hàng)",
                    StockStatus.LowStock => "LowStock (Sắp hết hàng)",
                    StockStatus.InStock => "InStock (Còn hàng)",
                    StockStatus.Discontinued => "Discontinued (Ngừng kinh doanh)",
                    _ => status.ToString()
                };

                // 3. Sử dụng toán tử ?. (Null-conditional) và ?? (Null-coalescing) để định dạng ngày
                string restockDisplay = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng";

                // 4. In kết quả đầu ra
                Console.WriteLine("--- OUTPUT ---");
                string warningNote = (quantity == null) ? " (Cảnh báo: Dữ liệu trống)" : "";
                Console.WriteLine($"Số lượng hiển thị: {displayQuantity}{warningNote}");
                Console.WriteLine($"Trạng thái kho: {statusText}");
                Console.WriteLine($"Dự kiến nhập hàng: {restockDisplay}");
            }
        }

        enum StockStatus
        {
            OutOfStock,
            LowStock,
            InStock,
            Discontinued
        }
    
}



 
        
        
    


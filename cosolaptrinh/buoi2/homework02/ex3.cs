using System;

namespace cosolaptrinh
{
    internal class ex3
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("--- INPUT ---");
            Console.Write("Nhập số tiền VNĐ: ");
            decimal vndAmount = decimal.Parse(Console.ReadLine());

            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            int choice = int.Parse(Console.ReadLine());
            CurrencyType selectedCurrency = (CurrencyType)choice;

            decimal rateUSD = 25400m;
            decimal rateEUR = 27200m;
            decimal rateJPY = 165m;
            decimal rateGBP = 32100m;

            decimal fee = vndAmount * 0.005m;
            decimal actualVnd = vndAmount - fee;

            decimal convertedAmount = 0m;
            string currencySymbol = "";

            switch (selectedCurrency)
            {
                case CurrencyType.USD:
                    convertedAmount = actualVnd / rateUSD;
                    currencySymbol = "USD";
                    break;
                case CurrencyType.EUR:
                    convertedAmount = actualVnd / rateEUR;
                    currencySymbol = "EUR";
                    break;
                case CurrencyType.JPY:
                    convertedAmount = actualVnd / rateJPY;
                    currencySymbol = "JPY";
                    break;
                case CurrencyType.GBP:
                    convertedAmount = actualVnd / rateGBP;
                    currencySymbol = "GBP";
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Phí dịch vụ (0.5%): {fee:N0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {actualVnd:N0} VNĐ");
            Console.WriteLine($"Số tiền {currencySymbol} nhận được: {convertedAmount:F2} {currencySymbol}");
        }
    }

    enum CurrencyType
    {
        USD = 1,
        EUR = 2,
        JPY = 3,
        GBP = 4
    }
}
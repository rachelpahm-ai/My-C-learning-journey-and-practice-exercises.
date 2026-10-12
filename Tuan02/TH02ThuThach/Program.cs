using System.Numerics;

namespace TH02ThuThach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;

            // Dùng TryParse bọc lại, gõ chữ hay gõ số âm thì bắt nhập lại đến khi nào chuẩn thì thôi
            while (true)
            {
                Console.Write("Nhập n (Thử gõ 13 hoặc 25 để test): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out n) && n >= 0)
                {
                    break; // Ngon lành thì đạp cửa thoát vòng lặp
                }

                Console.WriteLine("Lỗi: Dữ liệu không hợp lệ. Phải nhập số nguyên không âm!");
            }

            // Khai báo 3 hệ để so sánh
            int gtInt = 1;
            long gtLong = 1;
            BigInteger gtBig = 1;

            for (int i = 1; i <= n; i++)
            {
                gtInt *= i;
                gtLong *= i;
                gtBig *= i;
            }

            Console.WriteLine($"\n--- KẾT QUẢ {n}! ---");
            Console.WriteLine($"Kiểu int         : {gtInt}");
            Console.WriteLine($"Kiểu long        : {gtLong}");
            Console.WriteLine($"Kiểu BigInteger  : {gtBig}");
        }
    }
}

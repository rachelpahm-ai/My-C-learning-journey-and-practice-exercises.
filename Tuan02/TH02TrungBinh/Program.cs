namespace TH02TrungBinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Đặt mã hóa đầu ra để hiển thị tiếng Việt đúng cách
            Console.Write("Nhập một số nguyên không âm: ");

            int n = int.Parse(Console.ReadLine()); //nhập một số nguyên không âmm từ bàn phím
            long giaiThua = 1;

            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;  // Nhân dồn i vào giaiThua trước

                // In ra kết quả ngay tại bước i đó
                Console.WriteLine($"{i}! = {giaiThua}");
            }

            // Chốt hạ câu cuối cùng (thêm chữ cho rõ ràng, hoặc bạn thích thì bỏ đi cũng được)
            if (n == 0)
            {
                // Xử lý riêng trường hợp nhập số 0 vì nó không chui vào vòng lặp for
                Console.WriteLine($"0! = {giaiThua}");
            }
            else
            {
                Console.WriteLine($"=> Kết quả cuối cùng: Giai thừa của {n} là: {giaiThua}");
            }
        }
    }
}

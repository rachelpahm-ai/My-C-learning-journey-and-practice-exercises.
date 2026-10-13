namespace TH03TrungBinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("BẢNG CỬU CHƯƠNG DẠNG MA TRẬN\n");
            // in dòng tiêu đề: các cột từ 1 đến 10
            Console.Write("     ");
            for (int i = 1; i <= 10; i++)
                Console.Write($"{i,4}"); //{i,4} = canh phải trong 4 ô 
            Console.WriteLine("\n" + new String('-', 45)); // vẽ đường kẻ ngang


            // In từng hàng: mỗi hàng là một bảng cửu chương
            for (int i = 2; i <= 9; i++)
            {
                Console.Write($"{i,2} | ");        // đầu hàng: số bảng
                for (int j = 1; j <= 10; j++)
                    Console.Write($"{i * j,4}");   // mỗi tích chiếm 4 ô -> thẳng cột
                Console.WriteLine();               // hết hàng -> xuống dòng
            }

        }
    }
}

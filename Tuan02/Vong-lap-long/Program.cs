namespace Vong_lap_long
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = System.Text.Encoding.UTF8;
           Console.WriteLine("BẢNG CỬU CHƯƠNG TỪ 2 ĐẾN 9");
            //Vòng NGOÀI i là số bảng, chạy từ 2 tới 9
            for(int i=2; i<=9; i++)
            {
                Console.WriteLine($"\nBảng {i}: ");

                // Vòng TRONG j là thừa số nhân, chạy từ 1 tới 10
                for (int j=1; j<=10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i*j}");
                }
            }

        }
    }
}

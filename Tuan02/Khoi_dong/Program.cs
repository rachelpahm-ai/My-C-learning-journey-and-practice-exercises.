namespace Khoi_dong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //in bảng cửu chương của 1 số
            int number = 5;
            Console.WriteLine($"Bảng cửu chương của {number}:");

            for (int i = 1; i <= 10; i++)
            { 
                Console.WriteLine($"{number} x {i} = {number*i}");
            }
        }
    }
}

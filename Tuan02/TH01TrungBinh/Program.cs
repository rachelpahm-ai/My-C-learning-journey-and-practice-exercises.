namespace TH01TrungBinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập một số: ");
            int n =int.Parse(Console.ReadLine());
            if (n % 2 == 0 && n % 5 == 0)
                Console.WriteLine("Chia hết cho 10");
            else
                Console.WriteLine("Không thỏa");
        }
    }
}

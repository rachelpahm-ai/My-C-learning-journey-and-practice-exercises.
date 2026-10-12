namespace BT_ThucHanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
                Console.WriteLine("Bang 0");
            else if (n > 0)
            {
                if (n % 2 == 0)
                    Console.WriteLine("Duong va Chan");
                else
                    Console.WriteLine("Duong va Le");
            }
            else
            {
                if (n % 2 == 0)
                    Console.WriteLine("Am va Chan");
                else
                    Console.WriteLine("Am va Le");
            }
        }
    }
}

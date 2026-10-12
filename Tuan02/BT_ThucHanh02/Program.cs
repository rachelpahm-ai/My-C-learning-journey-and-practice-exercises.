namespace BT_ThucHanh02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                return;
            }
            if (n<0)
            {
                return;
            }
            long giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            Console.WriteLine($"{giaiThua}");



        }
    }
}

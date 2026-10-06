namespace Tuan02_CautrucdieukhienVaVonglap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mot so nguyen:");
            int so = Convert.ToInt32(Console.ReadLine());
            if (so % 2 == 0)
            {
                Console.WriteLine($"{so} la so chan");
            }
            else
            {
                Console.WriteLine($"{so} la so le");
            }

        }
    }
}

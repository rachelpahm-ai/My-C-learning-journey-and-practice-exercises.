namespace TH03De
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.WriteLine("Bảng cửu chương số 7");
            for (int i=1; i<=10;i++)
            {
                Console.WriteLine($"7 x {i} = {7 * i }");
            }
        }
    }
}

using System.Text;
using System.Xml;

namespace TH01De
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Xin chào!");
            Console.Write("Nhập số nguyên dương: ");
            int soNguyen=int.Parse(Console.ReadLine());
            if (soNguyen%3==0)
                Console.WriteLine($"{soNguyen} chia hết cho 3");
            else 
                Console.WriteLine($"{soNguyen} không chia hết cho 3");
        }
    }
}

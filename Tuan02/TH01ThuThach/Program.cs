using System.ComponentModel.Design;

namespace TH01ThuThach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
           while (true)
           {
                Console.Write("Hãy nhập một số: ");
                int n = int.Parse(Console.ReadLine()); //gán giá trị nguyên 
                if (n == 0)
                {
                    Console.WriteLine("Số 0 là số chẵn .Kết thúc chương trình!");
                    break;
                }
                else if (n > 0)
                {
                    Console.Write($"Số {n} là số nguyên dương và là");
                    if (n % 2 == 0)
                        Console.WriteLine(" số chẵn");
                    else
                        Console.WriteLine(" số lẻ");
                }
                else
                {
                    Console.Write($"Số {n} là số nguyên âm và là");
                    if (n % 2 == 0)
                        Console.WriteLine(" số chẵn");
                    else
                        Console.WriteLine(" số lẻ");
                }
           }

        }
    }
}

namespace TH03ThuThach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vòng ngoài: duyệt từng hàng i từ 1 đến 5
            for (int i = 1; i<=5; i++)
            {
                // Vòng trong: ở hàng thứ i thì chạy i lần để in đủ i dấu sao
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* "); // Dùng Write để các sao nằm trên cùng 1 hàng
                }

                // In đủ số sao của hàng đó rồi mới xuống dòng
                Console.WriteLine();
            }
            
        }
    }
}

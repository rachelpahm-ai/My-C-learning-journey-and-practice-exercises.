namespace TH02De
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Đặt mã hóa đầu ra để hiển thị tiếng Việt đúng cách
            Console.WriteLine("Nhập một số nguyên không âm: ");
            int n = int.Parse(Console.ReadLine());

            // Kiểm tra dữ liệu đầu vào: giai thừa không định nghĩa cho số âm 
            if (n<0)
            {
                Console.WriteLine("LỖI: Giai thừa chỉ định nghĩa cho số KHÔNG ÂM");
                return; //dừng chương trình sớm không tính tiếp 
            }

            long giaiThua = 1; // Khởi tạo biến giai thừa với giá trị ban đầu là 1, dùng long để tránh tràn số khi tính giai thừa của các số lớn

           for (int i=1;i<=n;i++)
           {
                giaiThua *= i;   
           }
            Console.WriteLine($"Giai thừa của {n} là: {giaiThua:N0}");
        }
    }
}

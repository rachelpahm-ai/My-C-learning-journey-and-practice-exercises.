namespace BaiTapXuatThongTinCaNhan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ============== [Dễ] =============
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("THỰC HÀNH 1");
            Console.Write("Nhập tên của bạn: ");
            string ten = Console.ReadLine();
            Console.WriteLine($"Xin chào {ten}, rất vui được gặp bạn!");


            // ============== [Trung bình] =============
            Console.WriteLine("\nTHỰC HÀNH 2");
            Console.Write("Nhập năm sinh của bạn: ");
            int namSinh = Convert.ToInt32(Console.ReadLine());
            int namHienTai = DateTime.Now.Year;
            int tuoi = namHienTai - namSinh;
            Console.WriteLine($"Tuổi của {ten} là {tuoi}");

            // ============== [Thử thách] =============
            Console.WriteLine("\nTHỰC HÀNH 3");
            int tuoi2;
            string input;
            while (true)
            {
                Console.Write("Nhập tuổi: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out tuoi2))
                {
                    Console.WriteLine($"Tuổi của {ten} là {tuoi2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ cho tuổi.");
                }
            }

            if (tuoi2<18)
            {
                Console.WriteLine("Chào bạn trẻ!");
            }
            else
            {
                Console.WriteLine("Chào khọm già!");
            }



        }
    }
}

namespace KhaiBaoBien_KieuDuLieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            // ======= [Dễ] ======
            try
            {
                Console.Write("Nhập số thứ nhất: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập số thứ hai: ");
                int b= Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập phép tính (+,-,*,/): ");
                string phep= Console.ReadLine();

                //Chọn phép toán bằng switch
                switch (phep)
                {
                    case "+": Console.WriteLine($"Kết quả: {a +b}"); break;
                    case "-": Console.WriteLine($"Kết quả: {a-b}"); break;
                    case "*": Console.WriteLine($"Kết quả: {a*b}"); break;
                    case "/": 
                        if (b == 0) 
                            Console.WriteLine("Không thể chia cho 0!");
                        else
                            Console.WriteLine($"Kết quả: {a/b:F2}");
                        break;
                    default: Console.WriteLine("Phép tính không hợp lệ!");
                        break;

                }


            }
            catch (FormatException)
            {
                //Người dùng nhập không phải số 
                Console.WriteLine("Lỗi: Bạn phải nhập số!");
            }

            // ====== [Trunng bình] ======
            try
            {
                Console.Write("Nhập số thứ ba: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhập số thứ bốn: ");
                double d = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhập phép tính (+,-,*,/): ");
                string phep = Console.ReadLine();

                //Chọn phép toán bằng switch
                switch (phep)
                {
                    case "+": Console.WriteLine($"Kết quả: {c +d:F2}"); break;
                    case "-": Console.WriteLine($"Kết quả: {c-d:F2}"); break;
                    case "*": Console.WriteLine($"Kết quả: {c*d:F2}"); break;
                    case "/":
                        if (d == 0)
                            Console.WriteLine("Không thể chia cho 0!");
                        else
                            Console.WriteLine($"Kết quả: {c/d:F2}");
                        break;
                    default:
                        Console.WriteLine("Phép tính không hợp lệ!");
                        break;

                }


            }
            catch (FormatException)
            {
                //Người dùng nhập không phải số 
                Console.WriteLine("Lỗi: Bạn phải nhập số!");
            }
            



            //====== [Thử thách] ======
            try
            {
                Console.Write("Nhập số thứ năm: ");
                double e = Convert.ToDouble(Console.ReadLine());
                if (e % 2 == 0)
                {
                    Console.WriteLine($"Số {e} là số chẵn");
                }
                else
                {
                     Console.WriteLine($"Số {e} là số lẻ");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Bạn phải nhập số!");
            }
            finally
            {
                Console.WriteLine("Chương trình kết thúc!");
            }


            int f = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(f + g);
        }
    }
}

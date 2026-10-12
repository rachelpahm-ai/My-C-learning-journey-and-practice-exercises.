namespace TongKetTuan01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bật UTF-8 để tiếng Việt hiển thị đúng dấu
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== CHƯƠNG TRÌNH QUẢN LÝ ĐIỂM SỐ ĐƠN GIẢN ===");

            int soMonHoc = 0;
            bool nhapThanhCong = false;

            while (!nhapThanhCong)
            {
                Console.Write("Nhập số lượng môn học: ");
                string  nhap = Console.ReadLine();
                // TryParse trả về true nếu chuỗi nhập vào là số nguyên hợp lệ
                if (int.TryParse(nhap, out soMonHoc))
                {
                    if (soMonHoc > 0)
                    {
                        nhapThanhCong = true;
                    }
                    else
                    {
                        Console.WriteLine("Số môn học phải lớn hơn 0. Vui lòng nhập lại!");
                    }
                }
                else
                {
                    Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập một số nguyên.");
                }

            }
            Console.WriteLine($"Bạn sẽ nhập điểm cho {soMonHoc} môn học.");


            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}

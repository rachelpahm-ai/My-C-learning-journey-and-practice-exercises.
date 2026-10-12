using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace QuanLyDiemSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("========= CHƯƠNG TRÌNH QUẢN LÝ ĐIỂM SỐ ĐƠN GIẢN =========");
            //1. Nhập số môn học (có kiểm tra hợp lệ)
            int soMonHoc = 0;
            bool nhapThanhCong = false;
            while (!nhapThanhCong)
            {
                Console.Write("\nNhập số lượng môn học: ");
                string nhap = Console.ReadLine();

                if (int.TryParse(nhap, out soMonHoc)) 
                {
                    if (soMonHoc > 0)
                    {
                        nhapThanhCong = true;
                    }
                    else
                    { 
                        Console.WriteLine("Số môn học phải lớn hơn 0 . Vui lòng học lại."); 
                    }                 
                }
                else
                {
                    Console.WriteLine("Số môn học phải là số nguyên. Vui lòng nhập lại.");
                }
            }
            //2. Nhập điểm từng môn học (vòng lặp for)
            double tongDiem = 0;
            for (int i = 1; i <= soMonHoc; i++)
            {
                bool nhapDiemOK = false;
                double diem = 0;
                while (!nhapDiemOK)
                {
                    Console.Write($"Nhập điểm môn thứ {i} (từ 0 đến 10): ");

                    if (double.TryParse(Console.ReadLine(), out diem))
                    {
                        if (diem >= 0 && diem < 10)
                        {
                            tongDiem += diem; //cộng dồn điểm hợp lệ vào tổng
                            nhapDiemOK = true; // thoát vòng ưhile, sang môn tiếp theo 
                        }
                        else
                        {
                            Console.WriteLine("Điểm phải từ 0 tới 10.Nhập lại!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập lại số!");
                    }
                }
            }

            //3. Tính trung bình và xếp loại (if - else)
            double diemTrungBinh = tongDiem / soMonHoc;
            string xepLoai;
            if (diemTrungBinh >= 9) xepLoai = "Xuất sắc";
            else if (diemTrungBinh >= 8) xepLoai = "Giỏi";
            else if (diemTrungBinh >= 7) xepLoai = "Khá";
            else if (diemTrungBinh >= 5) xepLoai = "Trung bình";
            else xepLoai = "Yếu";

            //4. In báo cáo kết quả 
            Console.WriteLine("\n========== KẾT QUẢ ==========");
            Console.WriteLine($"Số môn học      : {soMonHoc}");
            Console.WriteLine($"Tổng điểm       : {tongDiem}");
            Console.WriteLine($"Điểm trung bình : {diemTrungBinh:F2}");   // làm tròn 2 chữ số thập phân
            Console.WriteLine($"Xếp loại        : {xepLoai}");
            Console.WriteLine("=============================");


        }

    }
}

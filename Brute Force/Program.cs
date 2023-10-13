using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brute_Force
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai báo tiếng việt
            Console.OutputEncoding = Encoding.UTF8;

            //khai báo mảng chuỗi kí tự
            string [] charArry = {"Họ Và Tên","Lớp","Trường","Năm học" };

            string target = "Trường";
            //kí tự xuất hiện ở vị trí thứ
            int index = -1;

            //vòng lặp kiểm tra thứ tự xuất hiện
            for (int i = 0; i < charArry.Length; i++)
            {
                if (charArry[i] == target)
                {
                    index = i;
                    break;
                }
            }

            //xuất ra kết quả có xuất hiện hay không
            if (index != -1)
            {
                Console.WriteLine("Chữ " + target + " được tìm thấy tại vị trí " + index);
            }
            else
            {
                Console.WriteLine("Chữ " + target + " không tồn tại trong dãy.");
            }
            Console.ReadKey();
        }
    }
}

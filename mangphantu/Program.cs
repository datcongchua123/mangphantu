using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangphantu
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Nhap so luong phan tu :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            
               if (n <= 0 || n > 100)
                {
                    Console.WriteLine("So khong hop le!");

                }
                else
                {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Nhap phan tu thu " + (i + 1) + ":");
                    A[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Cac phan tu mang :");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Gia tri cua phan tu  " + (i + 1) + " la :" + A[i]);

                }
            }
            int SoamMAX = int.MinValue; // Khởi tạo  biến SoamMAX với giá trị nhỏ nhất của kiểu int

            foreach (var phanTu in A)
            {
                if (phanTu < 0 && phanTu > SoamMAX)
                {
                    SoamMAX = phanTu;
                }
            }

            if (SoamMAX != int.MinValue)
            {
                Console.WriteLine("Gia tri am lon nhat trong mang la " +SoamMAX);
            }
            else
            {
                Console.WriteLine("Trong mang khong co gia tri am.");
            }
            //Them gia tri tu vi tri p trong ban phim
            Console.Write("Nhap gia tri muon them: ");
            int giaTriCanThem;
            while (!int.TryParse(Console.ReadLine(), out giaTriCanThem))
            {
                Console.WriteLine("Vui long nhap mot so nguyen.");
                Console.Write("Nhap gia tri can them: ");
            }

            Console.Write("Nhap vi tri muon chen (0 <= p <= do dai mang): ");
            int viTriChen;
            while (!int.TryParse(Console.ReadLine(), out viTriChen) || viTriChen < 0 || viTriChen > A.Length)
            {
                Console.WriteLine("Vui lòng nhập số nguyên từ 0 đến ." +A.Length);
                Console.Write("Nhap vi tri chen: ");
            }

            int[] mangMoi = new int[A.Length + 1]; // Tạo mảng mới có kích thước lớn hơn 1 đơn vị
            for (int i = 0, j = 0; i < mangMoi.Length; i++)
            {
                if (i == viTriChen)
                {
                    mangMoi[i] = giaTriCanThem; // Thêm phần tử mới vào vị trí p
                }
                else
                {
                    mangMoi[i] =A[j++];
                }
            }

            Console.WriteLine("Mang sau khi them :");
            foreach (var item in mangMoi)
            {
                Console.Write(item + " ");
            }




            Console.ReadKey();
        }
    }
}



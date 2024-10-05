using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTWin_Chieu4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var num = new Random();
            num.Next(100, 999);

            //var userInput = Console.ReadLine();
            //Console.WriteLine(Convert.ToInt32(userInput));
            Console.WriteLine("Nhap so thu nhat:");
            int soThuNhat = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai:");
            int soThuHai = int.Parse(Console.ReadLine());

            int tong = soThuNhat + soThuHai;
            int hieu = soThuNhat - soThuHai;
            int tich = soThuNhat * soThuHai;
            float thuong = (float)soThuNhat / soThuHai;
            double luyThua = Math.Pow(soThuNhat, soThuHai);

            Console.WriteLine($"Tong: {tong}, hieu: {hieu}, tich: {tich}, thuong: {thuong}, luythua: {luyThua}");
        }
    }
}

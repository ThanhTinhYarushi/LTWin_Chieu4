using System.Text;

namespace Solution
{
    public class DoanSo
    {
        public string randomNum(int randomNum, int soChinhXac) 
        {
            int donVi = randomNum % 100; // 302 % 100
            if (randomNum % 100 == donVi)
            {
                return "00?";
            }

            return "cc";
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var randomNum = new Random();
            int soChinhXac = randomNum.Next(100, 999);

            int userInput;
            bool checkWin = false;

            while (!checkWin)
            {
                Console.WriteLine("- Hãy Nhập số bạn đoán (Tối đa 7 lần)");
                int cnt = 1;
                while(cnt < 7)
                {
                    Console.WriteLine($"Lần {cnt}:");
                    userInput = int.Parse(Console.ReadLine());
                    //Console.WriteLine(userInput);
                    cnt++;
                }
                checkWin = true;
            }

            Console.WriteLine((checkWin)?"Chúc Mừng bạn đã thắng":"Gà vcl");
        }
    }
}
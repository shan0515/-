using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 樂透機
{
    class Program
    {

        static void Main(string[] args)
        {
            // 背景顏色
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // 清除螢幕、延遲
            Console.Clear();
            System.Threading.Thread.Sleep(1000);

            // 顯示
            Console.WriteLine("大樂透號碼");

            // 產生亂數
            Random rand = new Random();

            // 紀錄產生次數
            int count = 0;
            
            // 重複產生
            while (count < 10)
            {
               
                // 用亂數物件產生亂數
                int r1 = rand.Next(1, 42);
                int r2 = rand.Next(1, 42);
                int r3 = rand.Next(1, 42);
                int r4 = rand.Next(1, 42);
                int r5 = rand.Next(1, 42);
                int r6 = rand.Next(1, 42);

                // 顯示
                Console.WriteLine("╔════════════════════════╗");
                Console.WriteLine("║                        ║");
                Console.WriteLine("║ 號碼:{0:00} {1:00} {2:00} {3:00} {4:00} {5:00} ║", r1, r2, r3, r4, r5, r6  );
                Console.WriteLine("║                        ║");
                Console.WriteLine("╚════════════════════════╝");

                // 累加產生次數
                count = count + 1;
                Console.ReadLine();
            }
           
            Console.ReadLine();
        }
    }
}

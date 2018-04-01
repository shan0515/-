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
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("大樂透號碼");
            Random rand = new Random();
            int count = 0;
            while (count < 10)
            {
                int r1 = rand.Next(1, 42);
                int r2 = rand.Next(1, 42);
                int r3 = rand.Next(1, 42);
                int r4 = rand.Next(1, 42);
                int r5 = rand.Next(1, 42);
                int r6 = rand.Next(1, 42);
                Console.WriteLine("╔════════════════════════╗");
                Console.WriteLine("║                        ║");
                Console.WriteLine("║ 號碼:{0:00} {1:00} {2:00} {3:00} {4:00} {5:00} ║", r1, r2, r3, r4, r5, r6  );
                Console.WriteLine("║                        ║");
                Console.WriteLine("╚════════════════════════╝");
                count = count + 1;
                Console.ReadLine();
            }
           
            Console.ReadLine();
        }
    }
}

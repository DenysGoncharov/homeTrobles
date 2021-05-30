using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static object locker = new object();

        static void WriteSecond()
        {
            Random rdm = new Random();

            int x = rdm.Next(0, Console.WindowWidth);
            int y = rdm.Next(0, Console.WindowHeight);
            int period = rdm.Next(50, 500);

            while (true)
            //for (int i = 0; i < 20; i++)
            {

                int k = rdm.Next(3, Console.WindowHeight / 5);
                lock (locker)
                {
                    Console.CursorTop = y;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    // Console.WriteLine(new string(' ', 10) + "Secondary");
                    for (int j = 0; j < k; j++)
                    {
                        Console.WriteLine(new string(' ', x) + ((char)rdm.Next(0, 255)));
                        Thread.Sleep(5);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', x) + ((char)rdm.Next(0, 255)));
                    Thread.Sleep(5);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string(' ', x) + ((char)rdm.Next(0, 255)));
                    Thread.Sleep(5);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(period);
                }
            }
        }

        static void Main()
        {
            // Console.SetWindowSize(80, 45);

            ThreadStart writeSecond = new ThreadStart(WriteSecond);

            Thread[] array = new Thread[Console.WindowWidth];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Thread(writeSecond);
            }
            //Thread thread = new Thread(writeSecond);


            foreach (var item in array)
            {
                item.Start();
            }

            //thread.Start();



            WriteSecond();
           

            // Delay.
            Console.ReadKey();
        }
    }
}

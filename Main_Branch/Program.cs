using System;
using System.Diagnostics;
using Lab_1_1;
using Lab_1_2;
using Lab_1_3;

namespace Main_Branch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var input = "";
            Console.WriteLine("***************************************************************\n" +
                "*                 Tolochik Igor Lab 1                         *\n" +
                "*                       cmd GUI                               *\n" +
                "*                     Input Commands:                         *\n" +
                "*                      1 - Lab1_1                             *\n" +
                "*                      2 - Lab1_2                             *\n" +
                "*                      3 - Lab1_3                             *\n" +
                "*                      exit - break                           *\n" +
                "*                                                             *\n" +
                "***************************************************************");
            while (input != "exit")
            {
                input = Console.ReadLine();
                if (input == "1") { Stopwatch sWatch = new Stopwatch(); Lab_1.Main(); sWatch.Start();sWatch.Stop();Console.BackgroundColor = ConsoleColor.Blue;Console.ForegroundColor = ConsoleColor.White;Console.Write("Работа завершена за {0}", sWatch.Elapsed.ToString());Console.ResetColor();}
                if (input == "2") { Stopwatch sWatch = new Stopwatch(); Lab_2.Main(); sWatch.Start(); sWatch.Stop(); Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.White; Console.Write("Работа завершена за {0}", sWatch.Elapsed.ToString()); Console.ResetColor(); }
                if (input == "3") { Stopwatch sWatch = new Stopwatch(); Lab_3.Main(); sWatch.Start(); sWatch.Stop(); Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.White; Console.Write("Работа завершена за {0}", sWatch.Elapsed.ToString()); Console.ResetColor(); }
            }
        }
    }
}

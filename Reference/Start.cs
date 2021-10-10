using System;
using System.IO;

namespace Reference
{
    public class Start
    {
        public static void Welcome(string num)
        {
            switch (num)
            {
                case "1":
                    break;
                default:
                    break;
            }
        }
        public static int ReadFormat(string key)
        {
            switch (key)
            {
                case "kb":
                    Console.WriteLine("Выбран режим ввода с клавиатуры.");
                    return 1;
                case "fl":
                    Console.WriteLine("Выбран режим ввода через .txt файл.\n\t Укажите название файла без .txt");
                    Console.ReadLine();
                    FindLab(1);
                    return 2;
                default:
                    return 0;
            }
        }
        private static int FindLab(int key)
        {
            switch (key)
            {
                case 1:
                    String line;
                    StreamReader sr = new StreamReader("input.txt");
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                    return 0;
                default:
                    return 0;
            }
        }
    }
}

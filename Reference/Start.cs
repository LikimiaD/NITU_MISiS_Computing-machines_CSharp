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
        public static void ReadFormat(string key)
        {
            switch (key)
            {
                case "kb":
                    Console.WriteLine("Выбран режим ввода с клавиатуры.");
                    FindLab(0, null);
                    break;
                case "fl":
                    Console.WriteLine("Выбран режим ввода через .txt файл.\n\t Укажите название файла без .txt");
                    var file = Console.ReadLine();
                    FindLab(1, file);
                    break;
                default:
                    break;
            }
        }
        private static (string format, int[] array) FindLab(int key, string file)
        {
            switch (key)
            {
                case 1:
                    StreamReader sr = new StreamReader($"{file}.txt");
                    string format = sr.ReadLine();
                    int[] intArray = Array.ConvertAll(sr.ReadLine().Split(" "), s => int.Parse(s));
                    sr.Close();
                    return (format, intArray);
                default:
                    return (null, null);
            }
        }
    }
}

using System;

namespace Reference
{
    public class Start
    {
        public static string Format()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Выберите функцию\nkb-> Ввод с клавиатуры\nfl -> Чтение ввода из файла\n");
            string format = Console.ReadLine();
            while ((format != "kb") && (format != "fl"))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Возможны только два варианта: kb и fl. Повторите попытку:");
                Console.ResetColor();
                format = Console.ReadLine();
            }
            return format;
        }

        public static int[] ReadArray()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] intArray;
            while (true)
            {
                try
                {
                    intArray = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
                    break;
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Массив должен состоять только из чисел\nПример: 5 10 3 4 5 6 7");
                    Console.ResetColor();
                    continue;
                }
            }
            return intArray;
        }

        public static int[] ReadMatrix()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] matrixvalue;
            while (true)
            {
                try
                {
                    matrixvalue = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
                    if (matrixvalue.Length == 2) break;
                    else throw new Exception("Для инициализации двумерный массив принимает два аргумента. \nПример: 2 3");
                }
                catch (Exception ex)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Двумерный массив принимает только численые значения");
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                    continue;
                }
            }
            return matrixvalue;
        }
    }
}

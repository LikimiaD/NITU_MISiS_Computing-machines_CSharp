using System;
using System.IO;
using Reference;

namespace Lab_1_3
{
    public class Lab_3
    {
        public static void Main()
        {
            Heart();
        }
        static void Heart()
        {
            int[][] matrix = null;
            int? min = null;
            int? max = null;
            int[] value = null;
            Console.WriteLine("Выберите функцию\nkb-> Ввод с клавиатуры\nfl -> Чтение ввода из файла\n");
            var format = Console.ReadLine();
            switch (format)
            {
                case "kb":
                    matrix = new int[int.Parse(Console.ReadLine())][];

                    for (int x = 0; x < matrix.GetLength(0); x++)
                    {
                        int[] intArray = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
                        matrix[x] = new int[intArray.Length];
                        if (min == null || max == null)
                        {
                            min = intArray[1];
                            max = intArray[1];
                        }
                        for (int y = 0; y < intArray.Length; y++)
                        {
                            matrix[x][y] = intArray[y];
                            min = min > intArray[y] ? intArray[y] : min;
                            max = max < intArray[y] ? intArray[y] : max;
                        }
                    }
                    value = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
                    Console.WriteLine();
                    for (int i = 0; i < matrix.GetLength(0); i++){Console.WriteLine("{0}", string.Join(" ", matrix[i]));}
                    break;

                case "fl":
                    StreamReader sr = new StreamReader("lab3.txt");
                    matrix = new int[int.Parse(sr.ReadLine())][];

                    for (int x = 0; x < matrix.GetLength(0); x++)
                    {
                        int[] intArray = Array.ConvertAll(sr.ReadLine().Split(" "), s => int.Parse(s));
                        matrix[x] = new int[intArray.Length];
                        if (min == null || max == null)
                        {
                            min = intArray[1];
                            max = intArray[1];
                        }
                        for (int y = 0; y < intArray.Length; y++)
                        {
                            matrix[x][y] = intArray[y];
                            min = min > intArray[y] ? intArray[y] : min;
                            max = max < intArray[y] ? intArray[y] : max;
                        }
                    }
                    value = Array.ConvertAll(sr.ReadLine().Split(" "), s => int.Parse(s));
                    sr.Close();
                    Console.WriteLine();
                    for (int i = 0; i < matrix.GetLength(0); i++) { Console.WriteLine("{0}", string.Join(" ", matrix[i])); }
                    break;
                default:
                    break;
            }
            Help.SteppedMatrixFindIndex(matrix, min);
            Help.SteppedMatrixFindIndex(matrix, max);
            Help.RandomValueChanger(matrix, value);
        }
    }

}
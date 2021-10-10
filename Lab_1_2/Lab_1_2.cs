using System;
using Reference;

namespace Lab_1_2
{
    class Lab_1_2
    {
        static void Main(string[] args)
        {
            int[] matrixvalue = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            int[,] matrix = new int[matrixvalue[0], matrixvalue[1]];

            int? min = null;
            int? max = null;
            for (int x = 0; x < matrixvalue[0]; x++)
            {
                int[] temp = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
                if (min == null || max == null)
                {
                    min = temp[0];
                    max = temp[1];
                }
                for (int y = 0; y < matrixvalue[1]; y++)
                {
                    matrix[x, y] = temp[y];
                    min = min > temp[y] ? temp[y] : min;
                    max = max < temp[y] ? temp[y] : max;
                }
            }

            int[] matrixvalue1 = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));

            int[,] matrix1 = new int[matrixvalue[0], matrixvalue[1]];
            for (int x = 0; x < matrixvalue1[0]; x++)
            {
                int[] temp = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
                for (int y = 0; y < matrixvalue1[1]; y++)
                {
                    matrix1[x, y] = temp[y];
                }
            }
            Console.WriteLine();
            for (int x = 0; x < matrixvalue[0]; x++)
            {
                var value1 = 0;
                var value2 = 0;
                var value3 = 0;

                for (int y = 0; y < matrixvalue[1]; y++)
                {
                    value1 = y == 0 ? matrix[x, y] : value1;
                    value2 = y == 1 ? matrix[x, y] : value2;
                    value3 = y == 2 ? matrix[x, y] : value3;
                }
                Console.WriteLine($"{value1} {value2} {value3}");
            }
            Help.findIndexMatrix(matrixvalue, matrix, max);
            Help.findIndexMatrix(matrixvalue, matrix, min);
            Help.solve(matrixvalue1, matrix, matrix1, "*");
            Help.solve(matrixvalue1, matrix, matrix1, "+");
            Help.solve(matrixvalue1, matrix, matrix1, "-");
        }
    }
}
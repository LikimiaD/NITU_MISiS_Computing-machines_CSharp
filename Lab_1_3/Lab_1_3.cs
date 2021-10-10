using System;
using Reference;

namespace Lab_1_3
{
    class Lab_1_3
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[int.Parse(Console.ReadLine())][];

            int? min = null;
            int? max = null;
            for (int x = 0; x < matrix.Length; x++)
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
            Console.WriteLine();
            Help.SteppedMatrixFindIndex(matrix, min);
            Help.SteppedMatrixFindIndex(matrix, max);
            Help.RandomValueChanger(matrix);
        }
    }
}
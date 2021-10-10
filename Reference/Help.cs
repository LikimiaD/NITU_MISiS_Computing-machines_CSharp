using System;

namespace Reference
{
    public class Help
    {
        public static int findIndex(int[] array, int item)
        {
            return Array.FindIndex(array, val => val.Equals(item));
        }
        public static void SteppedMatrixFindIndex(int[][] matrix, int? value)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix[x].Length; y++)
                {
                    if (matrix[x][y] == value)
                    {
                        Console.WriteLine("{0} {1} {2}", value, x, y);
                    }
                }
            }
        }
        public static void ParityArray(int[] array)
        {
            string[] parityArray = new string[array.Length];
            int value = 0;

            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    parityArray[value] = item.ToString();
                    value++;
                }

            }
            Console.WriteLine("{0}", string.Join(" ", parityArray));
        }
        public static void findIndexMatrix(int[] matrixvalue, int[,] matrix, int? num)
        {
            for (int x = 0; x < matrixvalue[0]; x++)
            {
                for (int y = 0; y < matrixvalue[1]; y++)
                {
                    if (matrix[x, y] == num)
                    {
                        Console.WriteLine($"{num} {x} {y}");
                        break;
                    }
                }
            }
        }

        public static void solve(int[] matrixvalue, int[,] matrix1, int[,] matrix2, string symbol)
        {
            switch (symbol)
            {
                case "*":
                    for (int x = 0; x < matrixvalue[0]; x++)
                    {
                        var value1 = 0;
                        var value2 = 0;
                        var value3 = 0;

                        for (int y = 0; y < matrixvalue[1]; y++)
                        {
                            value1 = y == 0 ? matrix1[x, y] * matrix2[x, y] : value1;
                            value2 = y == 1 ? matrix1[x, y] * matrix2[x, y] : value2;
                            value3 = y == 2 ? matrix1[x, y] * matrix2[x, y] : value3;
                        }
                        Console.WriteLine($"{value1} {value2} {value3}");
                    }
                    break;
                case "+":
                    for (int x = 0; x < matrixvalue[0]; x++)
                    {
                        var value1 = 0;
                        var value2 = 0;
                        var value3 = 0;

                        for (int y = 0; y < matrixvalue[1]; y++)
                        {
                            value1 = y == 0 ? matrix1[x, y] + matrix2[x, y] : value1;
                            value2 = y == 1 ? matrix1[x, y] + matrix2[x, y] : value2;
                            value3 = y == 2 ? matrix1[x, y] + matrix2[x, y] : value3;
                        }
                        Console.WriteLine($"{value1} {value2} {value3}");
                    }
                    break;
                case "-":
                    for (int x = 0; x < matrixvalue[0]; x++)
                    {
                        var value1 = 0;
                        var value2 = 0;
                        var value3 = 0;

                        for (int y = 0; y < matrixvalue[1]; y++)
                        {
                            value1 = y == 0 ? matrix1[x, y] - matrix2[x, y] : value1;
                            value2 = y == 1 ? matrix1[x, y] - matrix2[x, y] : value2;
                            value3 = y == 2 ? matrix1[x, y] - matrix2[x, y] : value3;
                        }
                        Console.WriteLine($"{value1} {value2} {value3}");
                    }
                    break;

                default:
                    break;
            }
        }
        public static void RandomValueChanger(int[][] matrix)
        {
            var value = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            Random ran = new Random();
            matrix[value[0]][value[1]] = ran.Next(0, 1000);
            Console.WriteLine("{0}", string.Join(" ", matrix[value[0]]));
        }
    }
}

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
        public static void findIndexMatrix(int[,] matrix, int? num)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (matrix[x, y] == num)
                    {
                        Console.WriteLine(String.Join(" ", num, x, y));
                        break;
                    }
                }
            }
        }

        public static void solve(int[,] matrix1, int[,] matrix2, string symbol)
        {
            switch (symbol)
            {
                case "*":
                    try
                {
                    for (int x = 0; x < matrix1.GetLength(0); x++)
                    {
                        var ONA_CHO_TO_DELAET = new int[matrix1.GetLength(1)];
                        for (int y = 0; y < matrix1.GetLength(1); y++) ONA_CHO_TO_DELAET[y] = (matrix1[x, y] * matrix2[x, y]);
                            Console.WriteLine("{0}", String.Join(" ", ONA_CHO_TO_DELAET));
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Add недопустима!");
                    break;
                }
                case "+":
                    try
                {
                    for (int x = 0; x < matrix1.GetLength(0); x++)
                    {
                            var ONA_CHO_TO_DELAET = new int[matrix1.GetLength(1)];
                            for (int y = 0; y < matrix1.GetLength(1); y++) ONA_CHO_TO_DELAET[y] = (matrix1[x, y] + matrix2[x, y]);
                            Console.WriteLine("{0}", String.Join(" ", ONA_CHO_TO_DELAET));
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Add недопустима!");
                    break;
                }
                case "-":
                    try
                {
                    for (int x = 0; x < matrix1.GetLength(0); x++)
                    {
                            var ONA_CHO_TO_DELAET = new int[matrix1.GetLength(1)];
                            for (int y = 0; y < matrix1.GetLength(1); y++) ONA_CHO_TO_DELAET[y] = (matrix1[x, y] - matrix2[x, y]);
                            Console.WriteLine("{0}", String.Join(" ", ONA_CHO_TO_DELAET));
                        }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Subtract недопустима!");
                    break;
                }
                default:
                    break;
            }
        }
        public static void RandomValueChanger(int[][] matrix, int[] value)
        {
            Random ran = new Random();
            matrix[value[0]][value[1]] = ran.Next(0, 1000);
            Console.WriteLine("{0}", string.Join(" ", matrix[value[0]]));
        }
    }
}

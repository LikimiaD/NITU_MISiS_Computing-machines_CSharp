using System;
using System.IO;
using Reference;

namespace Lab_1_2
{
    class Lab_1_2
    {
        static void Main(string[] args)
        {
            string format = Start.Format();

            int? min = null;
            int? max = null;
            int[] matrixvalue = null;
            int[] matrixvalue1 = null;
            int[,] matrix = null;
            int[,] matrix1 = null;
            switch (format)
            {
                case "kb":
                    matrixvalue = Start.ReadMatrix();
                    matrix = new int[matrixvalue[0], matrixvalue[1]];

                    for (int x = 0; x < matrixvalue[0]; x++)
                    {
                        int[] temp = Start.ReadArray();
                        if (min == null || max == null)
                        {
                            min = temp[0];
                            max = temp[0];
                        }
                        for (int y = 0; y < matrixvalue[1]; y++)
                        {
                            matrix[x, y] = temp[y];
                            min = min > temp[y] ? temp[y] : min;
                            max = max < temp[y] ? temp[y] : max;
                        }
                    }

                    matrixvalue1 = Start.ReadMatrix();

                    matrix1 = new int[matrixvalue[0], matrixvalue[1]];
                    for (int x = 0; x < matrixvalue1[0]; x++)
                    {
                        int[] temp = Start.ReadArray();
                        for (int y = 0; y < matrixvalue1[1]; y++)
                        {
                            matrix1[x, y] = temp[y];
                        }
                    }
                    Console.WriteLine();
                    for (int x = 0; x < matrixvalue[0]; x++)
                    {
                        for (int y = 0; y < matrixvalue[1]; y++)
                        {
                            Console.Write(matrix[x, y] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case "fl":
                    StreamReader sr = new StreamReader("input.txt");
                    matrixvalue = Array.ConvertAll(sr.ReadLine().Split(" "), s => int.Parse(s));
                    matrix = new int[matrixvalue[0], matrixvalue[1]];

                    for (int x = 0; x < matrixvalue[0]; x++)
                    {
                        int[] temp = Array.ConvertAll(sr.ReadLine().Split(" "), s => int.Parse(s));
                        if (min == null || max == null)
                        {
                            min = temp[0];
                            max = temp[0];
                        }
                        for (int y = 0; y < matrixvalue[1]; y++)
                        {
                            matrix[x, y] = temp[y];
                            min = min > temp[y] ? temp[y] : min;
                            max = max < temp[y] ? temp[y] : max;
                        }
                    }

                    matrixvalue1 = Array.ConvertAll(sr.ReadLine().Split(" "), s => int.Parse(s));

                    matrix1 = new int[matrixvalue[0], matrixvalue[1]];
                    for (int x = 0; x < matrixvalue1[0]; x++)
                    {
                        int[] temp = Array.ConvertAll(sr.ReadLine().Split(" "), s => int.Parse(s));
                        for (int y = 0; y < matrixvalue1[1]; y++)
                        {
                            matrix1[x, y] = temp[y];
                        }
                    }
                    Console.WriteLine();
                    for (int x = 0; x < matrixvalue[0]; x++)
                    {
                        for (int y = 0; y < matrixvalue[1]; y++)
                        {
                            Console.Write(matrix[x, y] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    break;
            }

            Help.findIndexMatrix(matrix, max);
            Help.findIndexMatrix(matrix, min);
            Help.solve(matrixvalue1, matrix, matrix1, "*");
            Help.solve(matrixvalue1, matrix, matrix1, "+");
            Help.solve(matrixvalue1, matrix, matrix1, "-");
        }
    }
}
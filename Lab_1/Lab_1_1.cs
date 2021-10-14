using System;
using System.Linq;
using System.Diagnostics;
using System.IO;
using Reference;

namespace Lab_1_1
{
    public static class Lab_1
    {
        public static void Main()
        {
            Heart();
        }
        static void Heart()
        {
            string format = Start.Format();
            string mode = "";
            int[] intArray = new int[1];
            if (format == "fl")
            {
                Console.WriteLine("Чтение ввода из файла\n");
                StreamReader sr = new StreamReader("lab1.txt");
                mode = sr.ReadLine();
                intArray = Array.ConvertAll(sr.ReadLine().Split(" "), s => int.Parse(s));
                sr.Close();
            }
            if (format == "kb")
            {
                Console.WriteLine("Ввод с клавиатуры\nФорма ввода:\nРежим\nМассив");
                mode = Console.ReadLine().ToString();
                while ((mode != "a") && (mode != "b"))
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Возможны только два варианта: a и b. Повторите попытку:");
                    Console.ResetColor();
                    mode = Console.ReadLine();
                }
                intArray = Start.ReadArray();
                Console.WriteLine();
            }

            int numMIN = 0;
            int numMAX = 0;

            Console.WriteLine("{0}", string.Join(" ", intArray));

            for (int i = 0; i < intArray.Length; i++)
            {
                if (i == 0)
                {
                    numMIN = intArray[i];
                    numMAX = intArray[i];
                }
                else
                {
                    numMIN = numMIN > intArray[i] ? intArray[i] : numMIN;
                    numMAX = numMAX < intArray[i] ? intArray[i] : numMAX;
                }
            }

            Console.WriteLine($"{numMAX} {Help.findIndex(intArray, numMAX)}");
            Console.WriteLine($"{numMIN} {Help.findIndex(intArray, numMIN)}");

            switch (mode)
            {
                case "a":
                    var copyArray = (int[])intArray.Clone();
                    int temp;
                    for (int i = 0; i < copyArray.Length - 1; i++)
                    {
                        for (int j = i + 1; j < copyArray.Length; j++)
                        {
                            if (copyArray[i] > copyArray[j])
                            {
                                temp = copyArray[i];
                                copyArray[i] = copyArray[j];
                                copyArray[j] = temp;
                            }
                        }
                    }
                    var reverseArray = (int[])copyArray.Clone();
                    temp = copyArray.Length-1;

                    foreach (var item in copyArray)
                    {
                        reverseArray[temp] = item;
                        temp--;
                    }

                    Console.WriteLine("{0}", string.Join(" ", copyArray));
                    Console.WriteLine("{0}", string.Join(" ", reverseArray));
                    Help.ParityArray(reverseArray);
                    break;
                case "b":
                    Console.WriteLine("{0}", string.Join(" ", intArray.OrderBy(c => c).ToArray()));
                    Console.WriteLine("{0}", string.Join(" ", intArray.OrderByDescending(c => c).ToArray()));
                    Help.ParityArray(intArray.OrderByDescending(c => c).ToArray());
                    break;
                default:
                    Console.WriteLine("Режим не выбран, заканчиваю работу…");
                    break;
            }
        }
    }
}

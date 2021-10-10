using System;
using System.Linq;
using Reference;

namespace Lab_1_1
{
    class Lab_1_1
    {
        static void Main(string[] args)
        {
            Start.ReadFormat(Console.ReadLine());
            string mode = Console.ReadLine();
            int[] intArray = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));

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
                    Help.ParityArray(intArray.OrderByDescending(c => c).ToArray());
                    break;
                default:
                    Console.WriteLine("Режим не выбран, заканчиваю работу…");
                    break;
            }
        }
    }
}

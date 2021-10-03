using System;
using System.Linq;

namespace Lab_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass1 = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            Console.WriteLine("{0}", string.Join(" ", mass1));
            int mn = 1000000;
            int mx = -100000;
            for (int i = 0; i < mass1.Length; i++)
            {
                if (mn > mass1[i])
                {
                    mn = mass1[i];
                }
                if (mx < mass1[i])
                {
                    mx = mass1[i];
                }
            }
            Console.WriteLine($"{mn} {mx}");
        }
    }
}
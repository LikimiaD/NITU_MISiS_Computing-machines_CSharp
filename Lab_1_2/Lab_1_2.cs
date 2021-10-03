using System;

namespace Lab_1_2
{
    class Lab_1_2
    {
        static void Main(string[] args)
        {
            int[] pepega = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
            int value = 0;
            foreach (var item in pepega)
            {
                value = value + item;
                Console.WriteLine(value);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace SortAListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 3, 10, 2, 1, 6, 7 };
            var lenght = numbers.Count;

            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght-1; j++)
                {
                    var temp = numbers[j];
                    if (numbers[j] > numbers[j + 1])
                    {
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}

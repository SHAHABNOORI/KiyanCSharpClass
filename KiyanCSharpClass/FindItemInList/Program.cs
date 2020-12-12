using System;
using System.Collections.Generic;
using System.Threading;

namespace FindItemInList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 17, 20, 14, 17, 10, 16, 17, 20, 14, 16, 10 };

            Console.WriteLine(Find(numbers, 14));
        }

        public static int Find(List<int> nums, int number)
        {
            var count = 0;
            foreach (var num in nums)
            {
                if (num == number)
                    count++;
            }

            return count;
        }
    }
}

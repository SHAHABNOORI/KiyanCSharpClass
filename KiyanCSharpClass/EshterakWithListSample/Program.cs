using System;
using System.Collections.Generic;

namespace EshterakWithListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOne = new List<int>() { 1, 3, 5, 6 };
            var listTwo = new List<int>() { 3, 4, 1 };
            var res = Eshterak(listOne, listTwo);
            foreach (var s in res)
            {
                Console.WriteLine(s);
            }

        }


        public static List<int> Eshterak(List<int> first, List<int> second)
        {
            List<int> result = new List<int>();

            foreach (var i in first)
            {
                foreach (var j in second)
                {
                    if (i == j)
                    {
                        result.Add(i);
                        break;
                    }
                }
            }

            return result;
        }
    }
}

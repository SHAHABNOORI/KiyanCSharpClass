using System;

namespace FindInTwoArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listOne = { 1, 3, 5, 6 };
            int[] listTwo = { 3, 4, 1 };
            var result = FindInList(6, listOne, listTwo);
        }

        public static Result FindInList(int number, int[] first, int[] second)
        {
            var result = new Result();
            foreach (var i in first)
            {
                if (number == i)
                {
                    result.IsFound = true;
                    result.InFirstList = true;
                    break;
                }
            }

            foreach (var i in second)
            {
                if (number == i)
                {
                    result.IsFound = true;
                    result.InSecondList = true;
                    break;
                }
            }

            return result;
        }
    }
}

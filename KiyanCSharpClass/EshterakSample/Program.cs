using System;

namespace EshterakSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listOne = { 1, 3, 5, 6 };
            int[] listTwo = { 3, 4, 1 };
            var res = Eshterak(listOne, listTwo);
            foreach (var x in res)
            {
                Console.WriteLine(x);
            }
        }

        public static int[] Eshterak(int[] one, int[] second)
        {
            var length = one.Length > second.Length ? second.Length : one.Length;

            //if (one.Length > second.Length)
            //    length = second.Length;
            //else
            //{
            //    length = one.Length;
            //}

            var result = new int[length];
            //for (int i = 0; i < result.Length; i++)
            //{
            //    result[i] = -1;
            //}
            var index = 0;
            foreach (var i in second)
            {
                foreach (var j in one)
                {
                    if (i == j)
                    {
                        result[index] = j;
                        index++;
                        break;
                    }
                }
            }

            return result;
        }
    }
}

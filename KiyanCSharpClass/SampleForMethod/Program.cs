using System;

namespace SampleForMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //var c = Sum(a, b);
            //Console.WriteLine(c);

            var x = Sum(10, 30);
            Hello();
        }

        static int Sum(int numberOne, int numberTwo)
        {
            var result = numberOne + numberTwo;
            return result;
        }

        static void Hello()
        {
            Console.WriteLine("Hello My Dear");
        }


    }
}

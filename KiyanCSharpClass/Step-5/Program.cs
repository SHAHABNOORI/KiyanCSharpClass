using System;
using System.Diagnostics;

namespace Step_5
{
    class Program
    {
        //Scope
        static void Main(string[] args)
        {
            //SayHello();
            //SayHello("Shahab");
            //SayHello("Shahab","Noori Goodarzi");

            //Argument
            //var test = Sum(5, 6);
            //var a = Sum(5, 6);
            //var bSum = Sum(5, 6);
            //var c = Sum(5, 6);
            //var tedst = Sum(5, 6);

            //int numberOne = 50;
            //int numberTwo = 90;
            //Console.WriteLine(Sum(numberOne, numberTwo));

            //SayHello("Shahab", "Noori", "Tehran");

            //var test = Sum(new double[] { 10, 20, 35, 40, 10, 30, 58 });
            //Console.WriteLine(test);
            
            //Named Arguments
            //SayHello(city: "Tehran", firstName: "Shahab", lastName: "Noori" );
        }

        /*
         *  {access modifier}  {OutPut Type} {Name} ({Parameter}){}
         */

        static void SayHello()
        {
            Console.WriteLine("Hello Dear");
        }

        static void SayHello(string firstName)
        {
            Console.WriteLine("Hello Dear " + firstName);
        }

        static void SayHello(string firstName, string lastName)
        {
            Console.WriteLine("Hello Dear " + firstName + " " + lastName);
        }

        // Optional Parameter
        static void SayHello(string firstName, string lastName, string city = "Karaj")
        {
            Console.WriteLine("Hello Dear " + firstName + " " + lastName + " From " + city);
        }
        //Reusable
        //Signature
        static double Sum(double x = 10, double y = 20)
        {
            var result = x + y;
            return result;
        }

        //Method OverLoading
        // سربارگذاری
        static double Sum(int x = 5, int y = 6)
        {
            var result = x + y;
            return result;
        }


        static double Sum(double[] numbers)
        {
            double result = 0;
            foreach (var number in numbers)
            {
                result = result + number;
            }

            return result;
        }

    }
}

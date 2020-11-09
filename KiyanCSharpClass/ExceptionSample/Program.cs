using System;

namespace ExceptionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var result = Div(10, 0);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    int[] myNumbers = { 1, 2, 3 };
            //    Console.WriteLine(myNumbers[1]);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Something went wrong.");
            //}
            //finally
            //{
            //    Console.WriteLine("The 'try catch' is finished.");
            //}

            try
            {
                CheckAge(15);
            }
           
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                try
                {
                    int x = 0;
                    Console.WriteLine(10 / x);
                }
                catch (ArithmeticException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            Console.ReadKey();
        }

        static void CheckAge(int age)
        {
            if (age < 18)
            {
                
               
                throw new ArgumentException("Access denied - You must be at least 18 years old.");
                
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
        static int Div(int numberOne, int numberTwo)
        {
            var result = numberOne / numberTwo;
            return result;
        }
    }
}

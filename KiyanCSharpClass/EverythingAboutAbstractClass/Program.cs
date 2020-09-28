using System;

namespace EverythingAboutAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorVersionTwo calc = new CalculatorVersionTwo();
            //var result = calc.Minus(10, 2);
            //Console.WriteLine(calc.Mul(2 , 5));
            Console.WriteLine(calc.Div(10, 2));

        }
    }
}

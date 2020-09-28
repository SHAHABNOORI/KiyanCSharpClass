using System;

namespace EverythingAboutAbstractClass
{
    public class CalculatorVersionTwo : Calculator
    {
        public override int Minus(int a, int b)
        {
            var result = a - b;
            Console.WriteLine($"Result = {result}");
            return result;
        }

        public override int Mul(int x, int y)
        {
            var result = x * y;
            Console.WriteLine($"Result = {result}");
            return result;
        }

        //Hide
        public new int  Div(int g, int h)
        {
            var result = g / h;
            return result;
        }
    }
}
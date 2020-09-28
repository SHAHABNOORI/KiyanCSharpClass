namespace EverythingAboutAbstractClass
{
    public abstract class Calculator
    {
        public int Sum(int x, int y)
        {
            var result = x + y;
            return result;
        }

        //without implementation
        public abstract int Minus(int a, int b);

        public virtual int Mul(int x, int y)
        {
            var result = x * y;
            return result;
        }

        public int Div(int numOne, int numeTwo)
        {
            var result = numOne / numeTwo;
            return result;
        }
    }
}
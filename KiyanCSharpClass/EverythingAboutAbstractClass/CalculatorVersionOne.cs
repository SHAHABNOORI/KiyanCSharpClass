namespace EverythingAboutAbstractClass
{
    //Plymorphism : چند ریختی
    public class CalculatorVersionOne : Calculator
    {
        public override int Minus(int a, int b)
        {
            var result = a - b;
            return result;
        }
    }
}
using System;

namespace GenericSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Custom custom = new Custom();
            //custom.Vorodiha = new[] { "Shahab", "Alireza", "Amirreza", "Hadi" };
            //custom.Print();

            //CustomeIntList custom = new CustomeIntList();
            //custom.Vorodiha = new[] { 10, 20, 30, 40, 50, 60 };
            //custom.Print();

            //GenericCustome<float> custom = new GenericCustome<float>
            //{
            //    Vorodiha = new[] {10.5f, 20.5f, 30.10f, 40.20f, 50.20f, 60.6f}
            //};
            //custom.Print();

            GenericCustome<int, string, float, bool> custome = new GenericCustome<int, string, float, bool>();
            custome.MyVorodi = true;
            var result = custome.PrintFour();
        }
    }
}

using System;
using System.Collections.Generic;

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

            //GenericCustome<int, string, float, bool> custome = new GenericCustome<int, string, float, bool>();
            //custome.MyVorodi = true;
            //var result = custome.PrintFour();

            //CustomeList<int> myCustomeListOne = new CustomeList<int>();
            //myCustomeListOne.MyList = new List<int>() { 10, 20, 36, 50, 16 };
            //myCustomeListOne.ShowSpecificItem(3);
            //myCustomeListOne.ShowListItems();


            CustomeList<string> myCustomeListOne = new CustomeList<string>();
            myCustomeListOne.MyList = new List<string>() { "Shahab","Alireza","Ahmad" };
            myCustomeListOne.ShowSpecificItem(2);

        }
    }
}

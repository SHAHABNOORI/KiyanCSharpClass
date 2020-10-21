using System;
using System.Collections.Generic;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> students = new SortedDictionary<int, string>();
            students.Add(10, "Shahab");
            students.Add(30, "Alireza");
            students.Add(20, "Hamid");
            students.Add(40, "Mehdi");


            foreach (var x in students)
            {
                Console.WriteLine($"{x.Key} {x.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace SortedListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> students = new SortedList<int, string>();

            students.Add(1, "Shahab");
            students.Add(10, "Ali");
            students.Add(2, "Mahdi");
            students.Add(5, "Mina");
            students.Add(3, "Vahid");


            foreach (var a in students)
            {
                Console.WriteLine($"{a.Key} {a.Value}");
            }
        }
    }
}

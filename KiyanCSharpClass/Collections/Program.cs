using Hasangholi;
using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(5);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            List<string> cities = new List<string>();
            cities.Add("Tehran");
            cities.Add("Karaj");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            var miveha = new List<Miveh>(){
                new Miveh(){Title="Siib"},
                new Miveh(){Title="Golabi"}            
            };

            //List<Miveh> miveha = new List<Miveh>();

            //miveha.Add(new Miveh()
            //{
            //    Title = "Sib"
            //});

            //miveha.Add(new Miveh()
            //{
            //    Title = "Golabi"
            //});

            //miveha.Add(new Miveh()
            //{
            //    Title = "Annar"
            //});
            //miveha.Add(new Miveh()
            //{
            //    Title = "Porteqal"
            //});


            //foreach (var miveh in miveha)
            //{
            //    Console.WriteLine(miveh.Title);
            //}
        }
    }
}

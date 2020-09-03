using System;

namespace Step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 8; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 8; i = i + 1)
            //{
            //    if (i % 2 != 0)
            //        break;

            //    Console.WriteLine(i);
            //}


            //for (int i = 0; i <= 8; i = i + 1)
            //{
            //    if (i % 2 != 0)
            //        continue;

            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 98; i = i + 2)
            //{
            //    if (i % 6 != 0)
            //        continue;
            //    Console.WriteLine(i);
            //}


            //string[] cars = { "Pride", "206", "Dena", "Rana" };
            //Console.WriteLine(cars[2]);

            //string[] cars = new string[4];
            //cars[0] = "Benz";
            //cars[1] = "BMW";
            //cars[2] = "FORD";
            //cars[3] = "Pride";

            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            //int[] numbers=new int[4];

            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;

            //for (int i = 0; i <=3 ; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = new int[4];

            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;

            //foreach (int x in numbers)
            //{
            //    Console.WriteLine(x);
            //}


            string[] cars = new string[4];
            cars[0] = "Benz";
            cars[1] = "BMW";
            cars[2] = "FORD";
            cars[3] = "Pride";

            foreach (var ghooli in cars)
            {
                Console.WriteLine(ghooli);
            }
        }
    }
}

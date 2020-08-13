using System;

namespace Step_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            const int arzeshAfzoode = 12;
            //string numberOne;
            //string numberTwo;
            //Console.WriteLine("Entern Number One :: ");
            //numberOne = Console.ReadLine();
            //Console.WriteLine("Entern Number Two :: ");
            //numberTwo = Console.ReadLine();
            //var result = numberOne + numberTwo;

            //int numberOne;
            //int numberTwo;
            //Console.WriteLine("Entern Number One :: ");
            //numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entern Number Two :: ");
            //numberTwo = int.Parse(Console.ReadLine());
            //var result = numberOne + numberTwo;
            //ctrl+k+c => Comment
            //ctrl+k+u => UnComment

            //int myInt = 20;
            //double myDoubleNumber = myInt; //Automatic Casting //Imlicitly
            //myDoubleNumber = 12.6;
            //myInt = (int)myDoubleNumber;
            //arzeshAfzoode = 5;

            int number;
            number = int.Parse(Console.ReadLine());
            var zojBoodan = number % 2;
            var mazrabiAzPanjBoodan = number % 5;
            var mazrabeChahar = number % 4;

            //if (zojBoodan == 0)
            //{
            //    Console.WriteLine("Adad Zoj Ast");
            //}
            //else
            //{
            //    Console.WriteLine("Adad Fard Ast");
            //}
            //true && false =false
            //    true && true=true

            //if (zojBoodan == 0 && mazrabiAzPanjBoodan == 0)
            //{
            //    Console.WriteLine("Adad Zoj Mazrabe Panj Ast");
            //}
            //else
            //{
            //    Console.WriteLine("Adad Zoj Mazrabe Panj Nist");
            //}


            if (zojBoodan == 0 && (mazrabiAzPanjBoodan == 0 || mazrabeChahar==0))
            {
                Console.WriteLine("Adad Zoj Mazrabe Panj Ast");
            }
            else
            {
                Console.WriteLine("Adad Zoj Mazrabe Panj Nist");
            }

            //if (condition | Conditions)
            //{
            //    Statement
            //}

        }
    }
}

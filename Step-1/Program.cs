using System;

namespace Step_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;

            Console.WriteLine("Please Enter First Name : ");
            firstName = Console.ReadLine();

            Console.WriteLine("Please Enter Last Name :");
            lastName = Console.ReadLine();


            Console.WriteLine(firstName + " " + lastName);

        }
    }
}

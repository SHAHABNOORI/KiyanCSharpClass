using System;

namespace Step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shift + Alt + C  => Shortcut for creating class
            // DRY => " Don't Repeat Yourself "
            // Access Modifier سطح دسترسی
            // Public 
            // Private
            // Property
            // Constructor سازنده
            // Parameterless constructor سازنده بدون پارامتر => untill you dont declare one
            // Constructor => a Method with name of class , Without return type even void [ Initialize ]


            //Person pOne = new Person()
            //{
            //    FirstName = "Shahab",
            //    LastName = "Noori Goodarzi",
            //    BirthDateYear = -1326
            //};

            //Person pOne = new Person("Shahab", "Noori Goodarzi")
            //{
            //    BirthDateYear = -1326
            //};

            Person pOne = new Person("Shahab", "Noori Goodarzi", 30)
            {
                BirthDateYear = -1326
            };

            //pOne.AgeSetter(-21);
            //pOne.AgeSetter(21);
            pOne.SayHello();
            //Console.WriteLine($"Age is {pOne.AgeGetter()}");
        }
    }
}

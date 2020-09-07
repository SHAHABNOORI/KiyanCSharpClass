using System;

namespace Step_6
{
    class Program
    {
        /*
         * OOP : Object Oriented Programming : برنامه نویسی شی گرا
         * Class : نوع ، قالب : Blue Print
         * Object : Attribute : Field , Property , Behavior : Method
         * Primitive Type : int , string , bool , float , double , ...
         * Customer Type : Class
         */
        static void Main(string[] args)
        {
            Daneshjoo dOne = new Daneshjoo()
            {
                City = "Karaj", 
                FirstName = "Shahab", 
                LastName = "Noori Goodarzi", 
                MobileNumber = "09359167820"
            };

            //Daneshjoo dOne = new Daneshjoo();
            //dOne.City = "Karaj";
            //dOne.FirstName = "Shahab";
            //dOne.LastName = "Noori Goodarzi";
            //dOne.MobileNumber = "09359167820";

            Console.WriteLine(dOne.FirstName);

        }
    }
}

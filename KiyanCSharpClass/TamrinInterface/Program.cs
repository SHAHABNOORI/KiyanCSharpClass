using System;

namespace TamrinInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IAlert alertServ = new Alert();
            var returnId = alertServ.AddAlert(DateTime.Now.AddDays(2));

            Console.WriteLine(alertServ.GetAlert(returnId));
        }
    }
}

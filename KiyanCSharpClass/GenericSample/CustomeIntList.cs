using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSample
{
    public class CustomeIntList
    {
        public int[] Vorodiha { get; set; }

        public void Print()
        {
            foreach (var vorodi in Vorodiha)
            {
                Console.WriteLine(vorodi);
            }
        }
    }
}

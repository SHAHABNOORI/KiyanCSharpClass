using System;

namespace GenericSample
{
    public class Custom
    {
        public string[] Vorodiha { get; set; }

        public void Print()
        {
            foreach (var vorodi in Vorodiha)
            {
                Console.WriteLine(vorodi);
            }
        }
    }
}

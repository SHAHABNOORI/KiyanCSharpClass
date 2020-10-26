using System;

namespace GenericSample
{
    public class GenericCustome<T>
    {
        public T[] Vorodiha { get; set; }

        public void Print()
        {
            foreach (var vorodi in Vorodiha)
            {
                Console.WriteLine(vorodi);
            }
        }
    }
}

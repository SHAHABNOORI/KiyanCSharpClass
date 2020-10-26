using System;

namespace GenericSample
{
    public class GenericCustome<T, TU, TV, TW>
    {
        public T[] VorodihaOne { get; set; }

        public TU[] VorodihaTwo { get; set; }

        public TV[] VorodihaThree { get; set; }

        public TW MyVorodi { get; set; }


        public void PrintOne()
        {
            foreach (var vorodi in VorodihaOne)
            {
                Console.WriteLine(vorodi);
            }
        }

        public void PrintTwo()
        {
            foreach (var vorodi in VorodihaOne)
            {
                Console.WriteLine(vorodi);
            }
        }

        public TW PrintFour()
        {
            return MyVorodi;
        }

        public void PrintThree()
        {
            foreach (var vorodi in VorodihaOne)
            {
                Console.WriteLine(vorodi);
            }
        }
    }
}

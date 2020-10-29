using System;

namespace DelegateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new Image("c:\\a.jpg");
            ImageProcessor processor = new ImageProcessor();
            ImageProcessor.ImageFilterHandler handler = SetBlackWithFIlter;
            processor.Process(image, handler);

            //processor.Process(image);

        }

        static void SetBlackWithFIlter(Image i)
        {
            Console.WriteLine("Black White filter applied");
        }
    }
}

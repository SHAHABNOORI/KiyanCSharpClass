using System;

namespace DelegateSample
{
    public class ImageFilter
    {
        public void ApplyBrightness(Image image)
        {
            Console.WriteLine("Apply Brightness");
        }

        public void ApplyContrast(Image image)
        {
            Console.WriteLine("Apply Contrast");
        }

        public void Resize(Image image)
        {
            Console.WriteLine("Apply Resize");
        }
    }
}

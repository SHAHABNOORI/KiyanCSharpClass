namespace DelegateSample
{
    public class ImageProcessor
    {
        //Type
        public delegate void ImageFilterHandler(Image image);

        public void Process(Image image, ImageFilterHandler filterHandler)
        {
            filterHandler.Invoke(image);
        }

        public void Process(Image image)
        {
            ImageFilter filter = new ImageFilter();
            filter.ApplyBrightness(image);
            filter.ApplyContrast(image);
            filter.Resize(image);
        }
    }
}

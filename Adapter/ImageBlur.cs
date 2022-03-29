using Source;
using System;

namespace Adapter
{
    public class ImageBlur : IFilter<Image>
    {
        public void Apply(Image source)
        {
            Console.WriteLine("Applying Blur filter");
        }
    }
}

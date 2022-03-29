using Source;
using System;

namespace Adapter
{
    public class VideoBlur : IFilter<Video>
    {
        public void Apply(Video source)
        {
            Console.WriteLine("Applying video filter");
        }
    }
}

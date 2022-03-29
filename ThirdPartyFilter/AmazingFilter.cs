using Adapter;
using System;

namespace ThirdPartyFilter
{
    public class AmazingFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying amazing filter");
        }
    }
}

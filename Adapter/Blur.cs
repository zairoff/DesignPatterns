using System;

namespace Adapter
{
    public class Blur : IFilter
    {
        public void Apply(object obj)
        {
            Console.WriteLine("Applying Blur filter");
        }
    }
}

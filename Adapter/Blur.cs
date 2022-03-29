using System;

namespace Adapter
{
    public class Blur : IFilter<object>
    {
        public void Apply(object source)
        {
            Console.WriteLine("Applying Blur filter");
        }
    }
}

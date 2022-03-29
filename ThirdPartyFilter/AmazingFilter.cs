using System;

namespace ThirdPartyFilter
{
    public class AmazingFilter : IFilter
    {
        public void Apply(object obj)
        {
            Console.WriteLine("Applying amazing filter");
        }
    }
}

using System;

namespace ThirdPartyFilter
{
    public class AmazingFilter : IFilter<object>
    {
        public void Apply(object obj)
        {
            Console.WriteLine("Applying amazing filter");
        }
    }
}

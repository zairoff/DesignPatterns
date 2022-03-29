using System;
using System.Collections.Generic;
using System.Text;
using ThirdPartyFilter;

namespace Adapter
{
    public class AmazingFilterAdapter : IFilter
    {
        private readonly AmazingFilter _amazingFilter;

        public AmazingFilterAdapter(AmazingFilter amazingFilter)
        {
            _amazingFilter = amazingFilter;
        }

        public void Apply(object obj)
        {
            _amazingFilter.Apply(obj);
        }
    }
}

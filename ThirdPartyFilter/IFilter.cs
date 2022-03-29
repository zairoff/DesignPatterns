using Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdPartyFilter
{
    public interface IFilter
    {
        void Apply(object obj);
    }
}

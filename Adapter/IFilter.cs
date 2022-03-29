using System;

namespace Adapter
{
    public interface IFilter<T>
    {
        void Apply(T source);
    }
}

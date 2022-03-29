using Adapter;
using System;

namespace Factory
{
    public class FiltersFactory<T>
    {
        public static IFilter<T> GetFilter(string filterType)
        {
            IFilter<T> filter = null;
            switch (filterType)
            {
                case "blur": filter = new Blur(); break;
                default: break;
            }
        }
    }
}

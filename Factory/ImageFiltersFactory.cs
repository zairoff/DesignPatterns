using Adapter;
using Source;

namespace Factory
{
    public static class ImageFiltersFactory
    {
        public static IFilter<Image> GetFilter(string filterType)
        {
            IFilter<Image> filter = null;
            switch (filterType)
            {
                case "blur": filter = new ImageBlur(); break;
                case "amazing": filter = new ImageAmazingFilterAdapter(new ThirdPartyFilter.AmazingFilter()); break;
                default: break;
            }
            return filter;
        }
    }
}

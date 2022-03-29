using Source;
using ThirdPartyFilter;

namespace Adapter
{
    public class ImageAmazingFilterAdapter : IFilter<Image>
    {
        private readonly AmazingFilter _amazingFilter;

        public ImageAmazingFilterAdapter(AmazingFilter amazingFilter)
        {
            _amazingFilter = amazingFilter;
        }

        public void Apply(Image obj)
        {
            _amazingFilter.Apply(obj);
        }
    }
}

namespace Adapter
{
    public class ImageViewer<T>
    {
        private readonly T _source;

        public ImageViewer(T source)
        {
            _source = source;
        }

        public void ApplyFilter(IFilter<T> filter)
        {
            filter.Apply(_source);
        }
    }
}

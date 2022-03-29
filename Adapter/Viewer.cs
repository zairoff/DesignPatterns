namespace Adapter
{
    public class Viewer<T>
    {
        private readonly T _source;

        public Viewer(T source)
        {
            _source = source;
        }

        public void ApplyFilter(IFilter<T> filter)
        {
            filter.Apply(_source);
        }
    }
}

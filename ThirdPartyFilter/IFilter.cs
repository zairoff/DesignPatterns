namespace ThirdPartyFilter
{
    public interface IFilter<T>
    {
        void Apply(T source);
    }
}

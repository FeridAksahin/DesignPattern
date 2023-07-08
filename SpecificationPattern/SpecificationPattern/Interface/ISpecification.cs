namespace SpecificationPattern.Interface
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T candidate);
    }
}

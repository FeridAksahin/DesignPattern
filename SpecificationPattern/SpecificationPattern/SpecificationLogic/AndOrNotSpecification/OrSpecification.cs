using SpecificationPattern.Interface;

namespace SpecificationPattern.SpecificationLogic.AndOrNotSpecification
{
    public class OrSpecification<T> : ISpecification<T>
    {
        ISpecification<T> Left;
        ISpecification<T> Right;
        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            Left = left;
            Right = right;
        }
        public bool IsSatisfied(T candidate)
        {
            return Left.IsSatisfied(candidate) || Right.IsSatisfied(candidate);
        }
    }
}

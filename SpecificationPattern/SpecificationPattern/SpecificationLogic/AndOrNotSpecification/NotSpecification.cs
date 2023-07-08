using SpecificationPattern.Interface;

namespace SpecificationPattern.SpecificationLogic.AndOrNotSpecification
{
    internal class NotSpecification<T> : ISpecification<T>
    {
    
        ISpecification<T> Candidate;
        public NotSpecification(ISpecification<T> candidate)
        {

            Candidate = candidate;
        }
        public bool IsSatisfied(T candidate)
        {
            return !Candidate.IsSatisfied(candidate);
        }
    }
}

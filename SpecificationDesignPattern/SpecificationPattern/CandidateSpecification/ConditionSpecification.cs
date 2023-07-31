using SpecificationPattern.Enum;
using SpecificationPattern.Interface;

namespace SpecificationPattern.CandidateSpecification
{
    public class ConditionSpecification : ISpecification<Product>
    {
        public Condition Condition;

        public ConditionSpecification(Condition condition)
        {
            Condition = condition;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Condition == Condition;
        }
    }
}

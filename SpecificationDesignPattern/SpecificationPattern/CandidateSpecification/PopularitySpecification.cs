using SpecificationPattern.Enum;
using SpecificationPattern.Interface;

namespace SpecificationPattern.CandidateSpecification
{
    public class PopularitySpecification : ISpecification<Product>
    {
        public Popularity Popularity;

        public PopularitySpecification(Popularity popularity)
        {
            Popularity = popularity;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Popularity == Popularity;
        }
    }
}

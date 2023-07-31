using SpecificationPattern.Enum;

namespace SpecificationPattern
{
    public class Product
    {
        public string Name;
        public Condition Condition;
        public Popularity Popularity;

        public Product(string name, Condition condition, Popularity popularity)
        {
            Name = name;
            Condition = condition;
            Popularity = popularity;
        }
    }
}

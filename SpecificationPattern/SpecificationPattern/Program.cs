using SpecificationPattern.Enum;
using static System.Console;
using SpecificationPattern.SpecificationLogic;
using SpecificationPattern.CandidateSpecification;
using SpecificationPattern.SpecificationLogic.AndOrNotSpecification;

namespace SpecificationPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filter = new FilterSpecification();
            WriteLine("New Products:");
            foreach (var product in filter.Filter(GetDummyProductData(), new ConditionSpecification(Condition.New)))
            {
                WriteLine($" - {product.Name}");
            }
            WriteLine("---------------------------");
            WriteLine("Best Seller Products:");
            foreach (var product in filter.Filter(GetDummyProductData(), new PopularitySpecification(Popularity.BestSeller)))
            {
                WriteLine($" - {product.Name}");
            }
            WriteLine("---------------------------");

            //Composite filter
            WriteLine("Best Seller And Used Products:");
            foreach (var product in filter.Filter(GetDummyProductData(), new AndSpecification<Product>(new PopularitySpecification(Popularity.BestSeller),
                new ConditionSpecification(Condition.Used))))
            {
                WriteLine($" - {product.Name}");
            }
        }

        private static Product[] GetDummyProductData()
        {
            return new Product[]
            {
               new Product(OfficeElectronicProduct.DocumentCamera.ToString(), Condition.New, Popularity.BestSeller),
               new Product(OfficeElectronicProduct.Calculator.ToString(), Condition.Renewed, Popularity.NewArrival),
               new Product(OfficeElectronicProduct.ElectronicDictionary.ToString(), Condition.Used, Popularity.Trend),
               new Product(OfficeElectronicProduct.Scanner.ToString(), Condition.Used, Popularity.BestSeller),
               new Product(OfficeElectronicProduct.Projector.ToString(), Condition.Used, Popularity.Trend),
               new Product(OfficeElectronicProduct.PresentationProduct.ToString(), Condition.Used, Popularity.Recommended),
               new Product(OfficeElectronicProduct.Printer.ToString(), Condition.New, Popularity.BestSeller)
            };
        }
    }
}
using FactoryDesignPattern.Enum;
using FactoryDesignPattern.Factory;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storageFactory = new StorageFactory();
            var storageService = storageFactory.GetStorageService(ServiceType.FileStorage);
            Console.WriteLine(storageService.SaveFile("example.txt"));
        }
    }
}
using FactoryDesignPattern.ConcreteProduct;
using FactoryDesignPattern.Enum;
using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.Factory
{
    public class StorageFactory
    {
        internal StorageService GetStorageService(ServiceType serviceType)
        {
            return serviceType switch
            {
                ServiceType.ObjectStorage => new ObjectStorage(),
                ServiceType.BlockStorage => new BlockStorage(),
                ServiceType.FileStorage => new FileStorage(),
                _ => throw new ArgumentException($"Invalid storage service entered. Service Type : {serviceType}"),
            };
        }
    }
}
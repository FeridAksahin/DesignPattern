using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.ConcreteProduct
{
    internal class ObjectStorage : StorageService
    {
        public override string SaveFile(string fileName)
        {
            //File saving with Object Storage
            //...
            return "File saved with Object Storage.";
        }
    }
}

using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.ConcreteProduct
{
    internal class BlockStorage : StorageService
    {
        public override string SaveFile(string fileName)
        {
            //File saving with Block Storage
            //...
            return "File saved with Block Storage.";
        }
    }
}

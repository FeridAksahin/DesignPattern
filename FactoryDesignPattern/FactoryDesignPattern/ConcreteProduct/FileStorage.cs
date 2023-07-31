using FactoryDesignPattern.Product;

namespace FactoryDesignPattern.ConcreteProduct
{
    internal class FileStorage : StorageService
    {
        public override string SaveFile(string fileName)
        {
            //File saving with File Storage
            //...
            return "File saved with File Storage.";
        }
    }
}

using PrototypeDesignPattern.Abstract;
using PrototypeDesignPattern.Enum;

namespace PrototypeDesignPattern.ConcretePrototype
{
    public class AdminPrototype : Prototype
    {
        public string AdminName { get; set; }
        public string AdminLevel { get; set; }
        public AdmicFeaturePrototype AdminFeature { get; set; }

        public AdminPrototype(string adminName, string adminLevel, AdmicFeaturePrototype adminFeature)
        {
            AdminName = adminName;
            AdminLevel = adminLevel;
            AdminFeature = adminFeature;
        }

        public AdminPrototype(AdminPrototype otherInstance) //copy constructor method for deep copy
        {
            AdminName = otherInstance.AdminName;
            AdminLevel = otherInstance.AdminLevel;
            AdminFeature = new AdmicFeaturePrototype(otherInstance.AdminFeature);
        }

        public override Prototype Clone() //shallow copy
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}

using PrototypeDesignPattern.Abstract;

namespace PrototypeDesignPattern.ConcretePrototype
{
    public class AdmicFeaturePrototype : Prototype
    {
        public bool IsHaveUpdateMember { get; set; }
        public bool IsHaveDeleteTopic { get; set; }
        /*
        .
        .
        .
        */
        public AdmicFeaturePrototype(bool isHaveUpdateMember, bool isHaveDeleteTopic)
        {
            IsHaveUpdateMember = isHaveUpdateMember;
            IsHaveDeleteTopic = isHaveDeleteTopic;
        }
        
        public AdmicFeaturePrototype(AdmicFeaturePrototype otherInstance) //copy constructor method for deep copy
        {
            IsHaveDeleteTopic = otherInstance.IsHaveDeleteTopic;
            IsHaveUpdateMember = otherInstance.IsHaveUpdateMember;
        }

        public override Prototype Clone() //shallow copy
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}

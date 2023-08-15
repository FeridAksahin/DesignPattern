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
        public AdmicFeaturePrototype(AdmicFeaturePrototype otherInstance)
        {
            IsHaveDeleteTopic = otherInstance.IsHaveDeleteTopic;
            IsHaveUpdateMember = otherInstance.IsHaveUpdateMember;
        }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}

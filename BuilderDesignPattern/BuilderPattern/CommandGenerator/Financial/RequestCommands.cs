using System.ComponentModel;

namespace BuilderPattern.CommandGenerator.Financial
{
    public enum RequestCommand
    {
        [Description("How much is the notary fee?")]
        NotaryPriceInfo,
        [Description("I have been charged more money from my card.")]
        EmergencyCardSituation

    }
}

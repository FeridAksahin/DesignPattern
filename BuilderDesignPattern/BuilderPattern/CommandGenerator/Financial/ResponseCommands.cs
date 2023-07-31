using System.ComponentModel;

namespace BuilderPattern.CommandGenerator.Financial
{
    public enum ResponseCommand
    {
        [Description("$457")]
        NotaryPrice,
        [Description("Your information has been transferred to the financial department. We apologize for the inconvenience. Checks are being conducted")]
        EmergencyCardSituationResponse
    }
}

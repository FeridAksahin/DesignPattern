using System.ComponentModel;

namespace BuilderPattern.CommandGenerator.Financial
{
    public class ResponseGenerator
    {
        public string GetResponse(RequestCommand requestCommand)
        {
            int requestIndex = Array.IndexOf(Enum.GetValues(typeof(RequestCommand)), requestCommand);
            var enumValue = (ResponseCommand)Enum.GetValues(typeof(ResponseCommand)).GetValue(requestIndex);
            return GetEnumDescription(enumValue);
        }

        public static string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
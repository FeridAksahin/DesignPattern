using AdapterDesignPattern.Interface;

namespace AdapterDesignPattern.Concrete
{
    public class NewMessageService : IMessage
    {
        public string GetMessage()
        {
            return "New Message Service";
        }
    }
}

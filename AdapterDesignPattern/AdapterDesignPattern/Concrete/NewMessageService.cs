using AdapterDesignPattern.Interface;

namespace AdapterDesignPattern.Concrete
{
    public class NewMessageService : IMessage
    {
        public Task<string> GetMessage()
        {
            return Task.FromResult("New Message Service");
        }
    }
}

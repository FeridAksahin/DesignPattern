using AdapterDesignPattern.Concrete;
using AdapterDesignPattern.Interface;

namespace AdapterDesignPattern.Adapter
{
    public class OldMessageAdapter : IMessage
    {
        private readonly OldMessageService _newMessageService;
        public OldMessageAdapter(OldMessageService newMessageService)
        {
            _newMessageService = newMessageService;
        }

        public string GetMessage()
        {
            return _newMessageService.FetchNewMessage();
        }

    }
}

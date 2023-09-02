namespace AdapterDesignPattern.Concrete
{
    public class OldMessageService
    {
        public Task<string> FetchNewMessage()
        {
            return Task.FromResult("Example Message");
        }
    }

}

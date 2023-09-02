namespace AdapterDesignPattern.Interface
{
    public interface IMessage
    {
        Task<string> GetMessage();
    }
}

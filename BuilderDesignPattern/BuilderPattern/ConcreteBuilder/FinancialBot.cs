using BuilderPattern.Builder;
using BuilderPattern.CommandGenerator.Financial;
using BuilderPattern.Product;

namespace BuilderPattern.ConcreteBuilder
{
    public class FinancialBot : BotBuilder
    {
        private RequestCommand _request;
        private ResponseMessage _responseCommands;
        public FinancialBot(RequestCommand request)
        {
            _request = request;
            bot = new Bot();
        }

        public override string BuildBotCommands()
        {
            _responseCommands = new ResponseMessage(_request);
            return bot.BuildBotCommands = _responseCommands.SendResponseMessage();
        }

        public override string BuildBotDescription()
        {
            return "";
        }
    }
}

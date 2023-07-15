using BuilderPattern.Builder;
using BuilderPattern.CommandGenerator.Financial;
using BuilderPattern.ConcreteBuilder;
using BuilderPattern.Director;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BotBuilder builder = new FinancialBot(RequestCommand.NotaryPriceInfo);
            BotRouter router = new BotRouter();
            router.BotDirector(builder);
            Console.WriteLine(builder.Bot.BuildBotCommands);
        }
    }
}
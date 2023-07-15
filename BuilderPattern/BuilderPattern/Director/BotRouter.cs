using BuilderPattern.Builder;

namespace BuilderPattern.Director
{
    public class BotRouter
    {
        public void BotDirector(BotBuilder botBuilder)
        {
            botBuilder.BuildBotCommands();
            botBuilder.BuildBotDescription(); 
        }
    }
}

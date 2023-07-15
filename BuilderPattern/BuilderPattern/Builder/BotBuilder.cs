using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public abstract class BotBuilder
    {
        public abstract string BuildBotCommands();
        public abstract string BuildBotDescription();

        protected Bot bot;
        public Bot Bot { get { return bot; } }
    }
}

namespace DesignPatterns.Strategy.Service
{
    using DesignPatterns.Strategy.IService;

    public abstract class AdvancedAnalysis : IStrategy
    {

        public void analyze()
        {
            start();
            analyzeMemory();
            analyzeKeyloggers();
            analyzeRootKits();
            unZip();
            stop();
        }

        public abstract void start();

        public abstract void analyzeMemory();

        public abstract void analyzeKeyloggers();

        public abstract void analyzeRootKits();

        public abstract void unZip();

        public abstract void stop();
    }
}

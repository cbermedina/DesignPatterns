using DesignPatterns.Strategy.IService;

namespace DesignPatterns.Strategy.Service
{
    public abstract class SimpleAnalysis : IStrategy
    {
        public void analyze()
        {
            start();
            jumpZip();
            stop();
        }
        public abstract void start();

        public abstract void jumpZip();

        public abstract void stop();
    }
}

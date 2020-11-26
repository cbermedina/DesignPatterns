namespace DesignPatterns.Observer.Observer
{
    using DesignPatterns.Observer.Classes;
    public abstract class MainObserver
    {
        protected Subject subject;
        public abstract void update();
    }
}

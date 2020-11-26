namespace DesignPatterns.Observer.Classes
{
    using DesignPatterns.Observer.Observer;
    using System.Collections.Generic;
    public class Subject
    {
        private List<MainObserver> mainObservers = new List<MainObserver>();
        private int status;

        public int getState()
        {
            return status;
        }

        public void setState(int estado)
        {
            this.status = estado;
            notifyAllObservers();
        }

        public void add(MainObserver mainObserver)
        {
            mainObservers.Add(mainObserver);
        }

        public void notifyAllObservers()
        {
            mainObservers.ForEach(x => x.update());
        }
    }
}

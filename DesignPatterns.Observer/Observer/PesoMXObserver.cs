namespace DesignPatterns.Observer.Observer
{
    using DesignPatterns.Observer.Classes;
    using System;
    public class PesoMXObserver : MainObserver
    {

        private double valeChange = 19.07;

        public PesoMXObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.add(this);
        }
        public override void update()
        {
            Console.WriteLine("MX: " + (subject.getState() * valeChange));
        }
    }
}

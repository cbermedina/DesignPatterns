namespace DesignPatterns.Observer.Observer
{
    using DesignPatterns.Observer.Classes;
    using System;
    public class SolObserver : MainObserver
    {
        private double valueChange = 3.25;

        public SolObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.add(this);
        }

        public override void update()
        {
            Console.WriteLine("PEN: " + (subject.getState() * valueChange));
        }
    }
}

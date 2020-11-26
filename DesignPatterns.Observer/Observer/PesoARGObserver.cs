namespace DesignPatterns.Observer.Observer
{
    using DesignPatterns.Observer.Classes;
    using System;
    public class PesoARGObserver : MainObserver
    {
        private double valorCambio = 29.86;

        public PesoARGObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.add(this);
        }
        public override void update()
        {
            Console.WriteLine("ARG: " + (subject.getState() * valorCambio));
        }
    }
}

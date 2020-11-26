namespace DesignPatterns.Memento.Classes
{
    using System;
    public class Game
    {

        private String _name;
        private int _checkpoint;

        public int getCheckpoint()
        {
            return _checkpoint;
        }

        public void setCheckpoint(int checkpoint)
        {
            this._checkpoint = checkpoint;
        }

        public String getName()
        {
            return _name;
        }

        public void setName(String name)
        {
            this._name = name;
        }

        public String toString()
        {
            return "Game [name=" + _name + ", checkpoint=" + _checkpoint + "]";
        }
    }
}

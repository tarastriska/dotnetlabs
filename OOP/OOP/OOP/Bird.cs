using OOP.Interfaces;
using System;

namespace OOP
{
    public abstract class Bird : Animal, IFlyable
    {
        private long _atHeight;

        protected Bird(DateTime dateOfBirth, string name)
            : base(dateOfBirth, name)
        {
            Console.WriteLine("Creating a bird");
        }

        public virtual void Fly(int height)
        {
            _atHeight = height;
            Console.WriteLine($"Bird is flying at: {height} m");
        }

        public long GetBirdPositionAboveGround() => _atHeight;
    }
}

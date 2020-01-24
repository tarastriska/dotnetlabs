using OOP.Interfaces;
using System;

namespace OOP.Animals
{
    public class Dog : Animal, IWalkable, ISwimmable
    {
        private int _stepsWalked;
        public static readonly double StepSize;

        static Dog()
        {
            Console.WriteLine("Setting dog's step size");
            StepSize = 0.3;
        }

        public Dog(DateTime dateOfBirth, string name)
            : base(dateOfBirth, name)
        {
            Console.WriteLine("Creating a dog");
        }

        public double DistanceWalked => _stepsWalked * StepSize;

        public override void Voice()
        {
            Console.WriteLine($"Dog {Name} says woof");
        }

        public void Walk(int steps)
        {
            _stepsWalked += steps;
            Console.WriteLine($"Dog {Name} is walking");
        }

        public void Swim(long depth)
        {
            Console.WriteLine($"Dog {Name} is swimming. Depth: {depth}");
        }

        public void ShowSpecialAction(string passcode)
        {
            if (passcode == "Bone")
            {
                SpecialAction();
            }
            else
            {
                Console.WriteLine("Sorry, your passcode is wrong");
            }
        }

        protected new void SpecialAction()
        {
            Console.WriteLine("Dog is your best friend");
        }
    }
}

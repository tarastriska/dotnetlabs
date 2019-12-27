using OOP.Interfaces;
using System;

namespace OOP.Animals
{
    public class Cat : Animal, IWalkable
    {
        private int stepsWalked;
        public static double StepSize = 0.1;

        public Cat(DateTime dateOfBirth, string name)
            : base(dateOfBirth, name)
        {
            Console.WriteLine("Creating a cat");
        }

        public double DistanceWalked => stepsWalked * StepSize;

        public override void Voice()
        {
            Console.WriteLine($"Cat {Name} with age {Age} says meeeow");
        }

        public void Walk(int steps)
        {
            stepsWalked += steps;
            Console.WriteLine($"Cat {Name} walks {steps} steps");
        }

        public void TryGetSecret(int age)
        {
            if (Age == age)
            {
                SpecialAction();
            }
        }

        protected override void SpecialAction()
        {
            base.SpecialAction();
            Console.WriteLine("And also someday I'll conquer the world !");
        }
    }
}

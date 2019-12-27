using System;

namespace OOP.Animals
{
    public class Colibri : Bird
    {
        public Colibri(DateTime dateOfBirth)
            : base(dateOfBirth, "Unknown colibri")
        {
            Console.WriteLine("Creating a colibri");
        }

        public Colibri()
            : this(DateTime.Now)
        {
            Console.WriteLine("Creating new colibri. Just born");
        }

        public override void Voice()
        {
            Console.WriteLine($"{Name} produces some colibri voice");
        }

        public override void Fly(int height)
        {
            base.Fly(height);
            
            if (height > 10)
            {
                Console.WriteLine($"I'm a small bird and can not fly at {height} m too long");
            }
        }

        public override string ToString()
        {
            return $"Colibri's age: {Age}";
        }
    }
}

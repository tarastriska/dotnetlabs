using System;

namespace ObjectsAndTypes
{
    class Animal
    {
        private readonly int age;
        private string mood;

        private bool isHealthy;

        // Animal is constantly not a human.
        public const bool IsHuman = false;

        public string Name;

        // Property with field.
        public bool IsHealthy
        {
            get => isHealthy;
            set
            {
                isHealthy = value;
                if (!isHealthy)
                {
                    Console.WriteLine($"You need to go to vet with {Name}");
                }
            }
        }

        /// <summary>
        /// Gets or sets the type of the animal.
        /// </summary>
        /// <value>
        /// The type of the animal.
        /// </value>
        public AnymalType AnimalType { get; set; }

        // Readonly auto property. Our animal is always hungry if it's age is less than 3.
        public bool IsHungry => age < 3;

        public Animal(int age)
        {
            this.age = age;
        }

        public void Voice()
        {
            Console.WriteLine("Voice");
            
            // Can not change readonly.
            // age = 2;

            mood = "Good";
            Console.WriteLine($"Animal {Name} is in {mood} mood.");
        }
    }
}

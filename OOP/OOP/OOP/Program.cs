using OOP.Animals;
using OOP.Interfaces;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // ConstructorShowCase();
            PolymorphismShowCase();
            // IsAndAsShowcase();
        }

        public static void ConstructorShowCase()
        {
            var cat = new Cat(new DateTime(2015, 12, 12), "Barsik");
            Console.WriteLine();

            var someColibri = new Colibri(new DateTime(2018, 1, 1));
            var newBornColibri = new Colibri();
        }

        public static void PolymorphismShowCase()
        {
            var animals = new Animal[]
            {
                new Cat(new DateTime(2015, 12, 12), "Murchyk"),
                new Dog(new DateTime(2008, 8, 8), "Jack"),
                new Colibri(DateTime.Now.AddDays(-14)),
            };

            Console.WriteLine();
            Console.WriteLine("Let's hear from animals");

            foreach (var animal in animals)
            {
                animal.Voice();
            }

            Console.WriteLine();
            Console.WriteLine("Show all animals");

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        public static void IsAndAsShowcase()
        {
            var animals = new Animal[]
            {
                new Cat(new DateTime(2015, 12, 12), "Murchyk"),
                new Cat(new DateTime(2018, 10, 10), "Barsik"),
                new Dog(new DateTime(2008, 8, 8), "Jack"),
                new Dog(new DateTime(2017, 9, 9), "Hatiko"),
                new Colibri(DateTime.Now.AddDays(-18)),
            };

            foreach (var animal in animals)
            {
                Console.WriteLine();
                Console.WriteLine($"Name: {animal.Name}");

                if (animal is IFlyable)
                {
                    ((IFlyable)animal).Fly(15);
                }

                (animal as ISwimmable)?.Swim(5);

                if (animal is IWalkable)
                {
                    var walkableAnimal = animal as IWalkable;
                    walkableAnimal.Walk(30);
                    walkableAnimal.Walk(4);

                    // Note: walkableAnimal doesn't have Name, so we use animal here.
                    Console.WriteLine($"{animal.Name} walked {walkableAnimal.DistanceWalked:F2} m");
                }

                (animal as Dog)?.ShowSpecialAction(animal.Name == "Hatiko" ? "Bone" : "Fish");
                (animal as Cat)?.TryGetSecret(4);
            }
        }
    }
}

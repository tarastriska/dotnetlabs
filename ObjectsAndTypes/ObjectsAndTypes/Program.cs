using System;

namespace ObjectsAndTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal(1);
            animal.Name = "Bob";
            animal.AnimalType = AnymalType.Dog;

            animal.Voice();
            animal.IsHealthy = false;

            Console.WriteLine($"Is our animal hungry? - {animal.IsHungry}");

            var anonymous = new
            {
                Occupation = "hacker",
                NickName = "007"
            };

            Console.WriteLine($"Anonymous is {anonymous}");
        }
    }
}

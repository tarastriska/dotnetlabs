using System;
namespace ExplodingKitten
{
    class Program
    {
        static void Main(string[] args)
        {
            var kitten = new Kitten();
            kitten.sayHi();
            Console.WriteLine("Ask for something ?");
            var a = Console.ReadLine();
            while(a != "exit")
            {
                kitten.describePerson(a);
                Console.WriteLine("Ask for something ?");
                a = Console.ReadLine();
            }
        }
    }
}

using System;
namespace ExplodingKitten
{
    class Program
    {
        public void Greeting()
        {
            Console.WriteLine("Ask for something ?");
        }

        static void Main(string[] args)
        {
            var Kitten = new Kitten();
            Kitten.SayHi();
            Helper.Greeting();
            var a = Console.ReadLine();
            while(a != "exit")
            {
                Kitten.DescribePerson(a);
                Helper.Greeting();
                a = Console.ReadLine();
            }
        }
    }
}

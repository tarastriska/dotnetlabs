using System;

namespace CoreCSharp
{
    class Program
    {
        // Field.
        private static string field = "I am field";
        private const int MAX_AGE = 50;

        static void Main(string[] args)
        {
            // Local integer variables.
            int integerVar = 222;
            var alsoIntegerVar = 777;

            // Example of directive.
#if DEBUG
            Console.WriteLine("DEBUG Mode.");
            field = "Debug field";
#else
            field = "Release field";
            Console.WriteLine("Release Mode.");
#endif
            // Will not compile because it is declared in loop.
            // var j = 123;

            var random = new Random().Next(1, 10);

            if (random > 5)
            {
                Console.WriteLine($"random:{random} is greater than 5");
            }
            else
            {
                Console.WriteLine($"random:{random} is equal or lower than 5");
            }

            switch (random)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Random is 1,2 or 3");
                    break;
                default:
                    Console.WriteLine("Default behavior.");
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                integerVar++;
                var j = i + 100;
                Console.WriteLine($"j variable in loop:{j}, field:{field}");
            }

            Console.WriteLine($"integerVar:{integerVar}");

            var whileString = Console.ReadLine();
            while (whileString != "done")
            {
                Console.WriteLine("Working");
                whileString = Console.ReadLine();
            }

            // Can not change constant.
            // MAX_AGE = 40;

            StructVsClassDiff();
        }

        static void StructVsClassDiff()
        {
            var pointOne = new PointStruct
            {
                X = 1,
                Y = 1
            };

            var pointTwo = pointOne;

            pointTwo.X = 2;
            pointOne.Y = 2;

            Console.WriteLine($"struct point one x:{pointOne.X}, y:{pointOne.Y}");
            Console.WriteLine($"struct point two x:{pointTwo.X}, y:{pointTwo.Y}");

            var pointThree = new PointClass
            {
                X = 1,
                Y = 1
            };

            var pointFour = pointThree;

            pointFour.X = 2;
            pointThree.Y = 2;

            Console.WriteLine($"class point three x:{pointThree.X}, y:{pointThree.Y}");
            Console.WriteLine($"class point four x:{pointFour.X}, y:{pointFour.Y}");
        }
    }

    struct PointStruct
    {
        /// <summary>
        /// Property.
        /// Gets or sets the x.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Property.
        /// Gets or sets the y.
        /// </summary>
        public int Y { get; set; }
    }

    class PointClass
    {
        /// <summary>
        /// Property.
        /// Gets or sets the x.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Property.
        /// Gets or sets the y.
        /// </summary>
        public int Y { get; set; }
    }
}

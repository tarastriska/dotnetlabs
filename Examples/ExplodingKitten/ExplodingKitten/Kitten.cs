using System;
using System.Text;
using Figgle;
namespace ExplodingKitten
{
    public class Kitten
    {
        public Kitten()
        {
           
        }

        public string getCat(string command)
        {
            string phrase = @"     \`   " + command + "'/";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"      /\___/\");
            sb.AppendLine(@"     /       \");
            sb.AppendLine(@"    / <|> <|> \");
            sb.AppendLine(@"    \    *    / ");
            sb.AppendLine(phrase);
            sb.AppendLine(@"      `-----'");
            return sb.ToString();
        }

        public void sayHi()
        {
            Console.WriteLine(this.getCat("Hi"));
        }

        public void describePerson(string person)
        {
            switch (person)
            {
                case "lex":
                    Console.WriteLine(this.getCat("vorovskoy"));
                    break;
                case "oleh":
                    Console.WriteLine(this.getCat("rozbiynuk"));
                    break;
                default:
                    Console.WriteLine(this.getCat("Don't care"));
                    break;
            }
        }
    }
}

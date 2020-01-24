using System;
using System.Text;
using Figgle;
namespace ExplodingKitten
{
    public class Kitten
    {
        public string GetCat(string command)
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

        public void SayHi()
        {
            Console.WriteLine(this.GetCat("Hi"));
        }

        public void DescribePerson(string person)
        {
            switch (person)
            {
                case "lex":
                    Console.WriteLine(this.GetCat("vorovskoy"));
                    break;
                case "oleh":
                    Console.WriteLine(this.GetCat("rozbiynuk"));
                    break;
                default:
                    Console.WriteLine(this.GetCat("Don't care"));
                    break;
            }
        }
    }
}

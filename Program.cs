using System;
using System.IO;
using System.Linq;

namespace Passphrase
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File
                        .ReadAllLines("google-10000-english-usa.txt")
                        .Where(a => !string.IsNullOrWhiteSpace(a))
                        .Select(a => a.Trim())
                        .Where(a => a.Length > 3)
                        .ToList();

            var generator = new EnglishGenerator(words, new Random());
            var password = string.Join(" ", generator.Generate(7));
            Console.WriteLine(password);
        }
    }
}

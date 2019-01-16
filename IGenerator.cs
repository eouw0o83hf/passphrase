using System;
using System.Linq;
using System.Collections.Generic;

namespace Passphrase
{
    public interface IGenerator
    {
        IEnumerable<string> Generate(int length);
    }

    public class EnglishGenerator : IGenerator
    {
        private readonly IList<string> _words;
        private readonly Random _random;
        
        public EnglishGenerator(IList<string> words, Random random)
        {
            _words = words;
            _random = random;
        }

        public IEnumerable<string> Generate(int length)
        {
            var indeces = new HashSet<int>();
            while(indeces.Count < length)
            {
                var next = _random.Next(_words.Count);
                if(!indeces.Contains(next))
                {
                    indeces.Add(next);
                }
            }

            return indeces.Select(a => _words[a]);
        }
    }
}
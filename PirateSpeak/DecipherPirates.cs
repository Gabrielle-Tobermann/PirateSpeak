using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateSpeak
{
    public class DecipherPirates
    {
        public List<string> GetPossibleWords(string pirateWord, List <string> possibleWords)
        {
            var result = new List<string>();

            var pirateWordOrdered = string.Concat(pirateWord.OrderBy(c => c));

            possibleWords.ForEach(word =>
            {
                var ordered = string.Concat(word.OrderBy(c => c));
                if (pirateWordOrdered == ordered)
                {
                    result.Add(word);
                }

            });
            
            return result;
        }
    }
}

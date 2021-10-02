using System;
using System.Collections.Generic;

namespace PirateSpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            var decipher = new DecipherPirates();

            decipher.GetPossibleWords("nlad", new List<string>() { "land", "lands", "landed" });
        }
    }
}

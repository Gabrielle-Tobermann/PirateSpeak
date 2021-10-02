using System;
using System.Collections.Generic;
using Xunit;

namespace PirateSpeak.Tests
{
    public class ReturnPossibleWords
    {
        public static IEnumerable<object[]> PossibleWordsData()
        {
            return new List<object[]> {
                new object[]
                {
                    "ortsp",
                    new List<string> { "sport", "parrot", "ports", "matey" },
                    new List<string> {"sport", "ports"}
                },
                new object[]
                {
                    "ortp",
                    new List<string> { "sport", "parrot", "ports", "matey" },
                    new List<string> {"port"}
                }
            };
        }

        [Theory]
        [MemberData(nameof(PossibleWordsData))]
        public void Return_possible_words_that_match_pirate_word(string pirateWord,
            List<string> inputWords,
            List<string> expectedResult)
        {
            var decipher = new DecipherPirates();

            var actualResult = decipher.GetPossibleWords(pirateWord, inputWords);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}

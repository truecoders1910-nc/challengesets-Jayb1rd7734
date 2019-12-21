using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;
            foreach (var item in words)
            {
                if (item == null) continue;
                if (ignoreCase)
                {
                    if (item.ToLower() == word.ToLower()) return true;
                }
                else if (item == word) return true;
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 2) return true;
            if (num % 2 == 0 || num < 2) return false;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}

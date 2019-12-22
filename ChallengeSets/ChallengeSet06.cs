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
            int index = -1;
            if (str.Length == 0) return index;
            string substr = "";
            for (int i = 0; i < str.Length; i++)
            {
                substr = str.Substring(i, 1);
                if (str.IndexOf(substr) == str.LastIndexOf(substr)) index = i;
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int topCount = 1, count = 1;
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                if (numbers[i + 1] == numbers[i]) count++;
                else count = 1;
                if(count > topCount) topCount = count;
            }
            return topCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if(elements == null || elements.Count == 0 || n < 1) return new double[0];
            List<double> list = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                list.Add(elements[i]);
            }
            return list.ToArray();
        }
    }
}

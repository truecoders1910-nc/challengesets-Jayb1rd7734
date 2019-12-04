using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) return 0;
            bool firstTime = true;
            double max = 0, min = 0;
            foreach (var item in numbers)
            {
                if (firstTime)
                {
                    max = item;
                    min = item;
                    firstTime = false;
                }
                max = Math.Max(max, item);
                min = Math.Min(min, item);
            }
            return max + min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length <= str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum=0;
            if (numbers == null) return 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null) return 0;
            foreach (var item in numbers)
            {
               if(item % 2 == 0)sum += item;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null) return false ;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum % 2 == 0 ? false : true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number > 0)
            {
                return number % 2 == 0 ? number / 2 :(number - 1) / 2;
            }
            return 0; 
        }
    }
}

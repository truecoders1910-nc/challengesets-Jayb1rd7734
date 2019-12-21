using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            do
            {
                startNumber++;
            } while (startNumber % n != 0);
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0d) businesses[i].Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                if (numbers[i] > numbers[i + 1]) return false;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            int sum = 0;
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                if (numbers[i] % 2 == 0) sum += numbers[i + 1];
            }
            return sum;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null) return "";
            string sentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == " " || words[i] == "" || words[i] == "  ")
                    continue;
                if((i == words.Length - 1))
                    sentence += (words[i].Trim() + ".");
                else 
                    sentence += (words[i].Trim() + " ");
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> nums = new List<double>();
            if (elements == null || elements.Count < 4) return new double[0];
            for (int i = 3; i < elements.Count; i += 4)
            {
                nums.Add(elements[i]);
            }
            return nums.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length < 2) return false;
            for (int i = 0; i < (nums.Length - 1); i++)
            {
                for (int j = i + 1; j < (nums.Length); j++)
                {
                    if (nums[i] + nums[j] == targetNumber) return true;
                }
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(var item in vals)
            {
                if (item == false) return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null) return false;
            foreach (var item in numbers)
            {
                if (item % 2 != 0) sum += item;
            }
            if(sum % 2 != 0) return true;
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            char[] pword = password.ToCharArray();
            bool upper = false, lower = false, num = false;
            foreach (var item in pword)
            {
                if (char.IsUpper(item)) upper = true;
                if (char.IsLower(item)) lower = true;
                if (char.IsNumber(item)) num = true;
            }
            if (upper && lower && num) return true;
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char[] str = val.ToCharArray();
            return str[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] str = val.ToCharArray();
            return str[str.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0;
            return Math.Round(dividend / divisor, 4);
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }
        public int[] GetOddsBelow100()
        {
            List<int> nums = new List<int>();
            for (int i = 1; i < 100; i += 2)
            {
                nums.Add(i);
            }
            return nums.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}

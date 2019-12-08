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
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {

            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }
        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}

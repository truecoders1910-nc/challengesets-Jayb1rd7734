using System;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                switch(numbers[i] % 2)
                {
                    case 0:
                        sum += numbers[i];
                        break;
                    default:
                        sum -= numbers[i];
                        break;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
           return Math.Min(Math.Min(Math.Min(str3.Length, str4.Length), str2.Length), str1.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(Math.Min(number3, number4), number2), number1);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 + sideLength2) > sideLength3 &&
                (sideLength1 + sideLength3) > sideLength2 &&
                (sideLength2 + sideLength3) > sideLength1) return true;
            return false;
        }

        public bool IsStringANumber(string input)
        {
            double result;
            if (Double.TryParse(input, out result)) return true;
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            for(int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null) nullCount++;
            }
            if (nullCount > objs.Length / 2) return true;
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            double sum = 0, count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }
            if(count == 0) return 0;
            return sum / count;
        }

        public int Factorial(int number)
        {
            if (number == 0) return 1;
            return number * Factorial(number - 1);
        }
    }
}

using System;
namespace ChallengeSets
{
    public class ChallengeSet08
    {
        public bool CanHopAcross(int[] hopAmount)
        {
            int index = 0;
            while (true)
            {
                if ((hopAmount[index] + index) < 0 || hopAmount[index] == 0) return false;
                if ((hopAmount[index] + index) > (hopAmount.Length - 1)) return true;
                if (index + hopAmount[index] + hopAmount[index + hopAmount[index]] == index) return false;
                index = index + hopAmount[index];
            }
        }

        public enum Frogger { Y, N }
        public Frogger GetTheFrogAcross(char[,] finalResult)
        {
            throw new NotImplementedException();
        }
    }
}

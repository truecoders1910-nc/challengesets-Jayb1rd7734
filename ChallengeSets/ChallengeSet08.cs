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
                /*Implemented an infinite while loop. One of the following four if statements is
                 * guaranteed to break the loop and produce a solution.
                */
                //
                int value = hopAmount[index];
                // Test for underrun                  Test for stall.
                if ((value + index) < 0 || value == 0) return false;
                // Test for overrun ( win ).
                if ((value + index) > (hopAmount.Length - 1)) return true;
                // Test for infinite loop.
                if (index + value + hopAmount[index + value] == index) return false;
                // Increment index by indicated amount.
                index = index + value;
            }
        }

        public enum Frogger { Y, N }
        public Frogger GetTheFrogAcross(char[,] finalResult)
        {
            throw new NotImplementedException();
        }
    }
}

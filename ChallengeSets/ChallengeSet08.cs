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
                /* Implemented an infinite while loop. Only four conditions can occur:
                 *      1) The values in the array cause an index underrun producing a failure.
                 *      2) The values in the array cause an index overrun, producing a success.
                 *      3) The Index lands on a '0' causing a stall, producing a failure.
                 *      4) The index lands on a a value that creates an infinite loop, producing a failure.
                 * One of the following four if statements is guaranteed to break the loop and produce a solution.
                */

                // Create a local variable to hold value @current index.
                int value = hopAmount[index];
                // Test for underrun       Test for stall.
                if ((value + index) < 0 || value == 0) return false;
                // Test for overrun ( success ).
                if ((value + index) > (hopAmount.Length - 1)) return true;
                // Test for infinite loop.
                if (index + value + hopAmount[index + value] == index) return false;
                // Increment index by amount contained in value.
                index = index + value;
            }
        }

        public enum Frogger { Y, N }
        public Frogger GetTheFrogAcross(char[,] finalResult)
        {
            string win = "111000000000000110011000000000110010011000000110010010011000110010010010011" +
                         "011110000000000000111000000000000110011000000000110010011000000110010010011" +
                         "011010110000000000011110000000000000111000000000000110011000000000110010011" +
                         "011010010110000000011010011000000000011110000000000000111000000000000110011" +
                         "011010010010110000011010010110000000011010011000000000011110000000000000111";
            string test = "";
            char[] check;
            for (int x = 0; x < 25; x++)
            {
                check = win.Substring(x * 15, 15).ToCharArray();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (finalResult[i, j] == 'O') check[i * 3 + j] = '0';
                    }
                }
                test = new string(check);
                if (test == "000000000000000") return Frogger.Y;
            }
            return Frogger.N;
        }
    }
}

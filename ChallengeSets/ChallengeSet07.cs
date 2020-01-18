using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            if (businesses == null || businesses.Count == 0) return 0;
            int count = 0;
            foreach (var item in businesses)
            {
                if (item.TotalRevenue - item.TotalExpenses < 0) count++;
            }
            return count;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            string str = "";
            List<string> list = new List<string>();
            for(int i = 0; i<businesses.Count; i++)
            {
                double one = businesses[i].TotalRevenue;
                double two = businesses[i].TotalExpenses;

                if (one - two < 1) continue;
                list.Add(businesses[i].Name);
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (i != (list.Count - 1)) str += list[i] + ",";
                else str += list[i];
            }
            return str;
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            if (business.ParentCompany == null) return business.Name;
            business.Name = GetNameOfHighestParentCompany(business.ParentCompany);
            return business.Name;
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            string win = "100100100010010010001001001111000000000111000000000111100010001001010100";
            string test = "";
            char[] check;
            for(int x = 0; x < 8; x++)
            {
                check = win.Substring(x * 9, 9).ToCharArray();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (finalBoard[i, j] == 'X') check[i * 3 + j] = '0';
                    }
                }
                test = new string(check);
                if (test == "000000000") return TicTacToeResult.X;
            }

            for (int x = 0; x < 8; x++)
            {
                check = win.Substring(x * 9, 9).ToCharArray();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (finalBoard[i, j] == 'O') check[i * 3 + j] = '0';
                    }
                }
                test = new string(check);
                if (test == "000000000") return TicTacToeResult.O;
            }
            return TicTacToeResult.Draw;
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
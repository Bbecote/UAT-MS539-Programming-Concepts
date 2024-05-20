using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsSimC_
{
    internal class CrapsTable
    {
        //Attributes
        public bool Button = false;
        public int ObjectRoll = 0;
        private Dictionary<string, int[]> betDictionary = new Dictionary<string, int[]>
        {
            { "PassLineBet", new int[4] },
            { "PassLineOdds", new int[4] },
            { "DontPassBet", new int[4] },
            { "DontPassBetOdds", new int[4] },
            { "FieldBet", new int[4] },
            { "ComeBet", new int[4] },
            { "DontComeBet", new int[4] },
            { "4LineBet", new int[4] },
            { "4DontLineBet", new int[4] },
            { "4PlaceBet", new int [4] },
            { "5LineBet", new int[4] },
            { "5DontLineBet", new int[4] },
            { "5PlaceBet", new int[4] },
            { "6LineBet", new int[4] },
            { "6DontLineBet", new int[4] },
            { "6PlaceBet", new int [4] },
            { "8LineBet", new int[4] },
            { "8DontLineBet", new int[4] },
            { "8PlaceBet", new int [4] },
            { "9LineBet", new int[4] },
            { "9DontLineBet", new int[4] },
            { "9PlaceBet", new int [4] },
            { "10LineBet", new int[4] },
            { "10DontLineBet", new int[4] },
            { "10PlaceBet", new int [4] },
        };
        
        
        public int [] PassLineBets = new int[4];
        public CrapsTable() { }

        private int[] GetBetType(string bet)
        {
            if (betDictionary.ContainsKey(bet)) { return betDictionary[bet]; }
            else return null;
        }

        public void AddBet(int betAmount, int playerID, string bet)
        {
            int[] betArray = this.GetBetType(bet);
            if (betArray != null)
            {
                betArray[playerID] = betAmount;
            }
            else { throw new Exception("Bad Bet Type");};
        }

    }
}

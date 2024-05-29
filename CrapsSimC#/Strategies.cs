using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsSimC_
{
    internal static class Strategies
    {
        private static string BetStrategy { get; set; }
        private static string WinningsStrategy { get; set; }
        private static int MinimumBet { get; set; }

        //public List<(string bet, int betAmount, bool won, int rollcount)> HistoricalBetTracker  = new List<(string, int, bool, int)>(); //Tracks the individual bets

        //--------- Betting Strategies---------//

        public static void PlayerBet(CrapsTable table, Players player)
        {
            string strategy = (string)player.Strategy[1];
            switch (strategy)
            {
                case "Martingale Pass With No Odds":
                    betMartingalePassNoOdds(table, player);
                    break;
            }
        }

        //--------- Betting Logic---------//
        public static void betMartingalePassNoOdds(CrapsTable table, Players player)
        {
            //if the button is off, if there's a bet on there already do nothing. If there's no bet, check to see if the last bet was won or lost.  If won, bet minimum. If lost, bet twice what the last bet was.
            //if the button is on, do nothing.
            if (!table.Button)
            {
                foreach ((string bet, int amount) in player.ActiveBetTracker){
                    if (!bet.Equals("PassLineBet"))
                    {
                        var lastbetTuple = player.HistoricalBetTracker.LastOrDefault(tuple => tuple.Item1 == "PassLineBet");
                        if (!lastbetTuple.Item3)
                        {
                            int betAmount = lastbetTuple.betAmount * 2;
                            player.ActiveBankroll -= betAmount;
                            (string, int) newBet = ("PasslineBet", betAmount);
                            player.ActiveBetTracker.Add(newBet);
                            table.MakeBet(betAmount, player, "PassLineBet");
                        }
                    }
                }
            }
        }

        //--------- Winnings Strategies---------//
        public static void CollectWinnings(CrapsTable table, Players player)
        {
            string strategy = (string)(player.Strategy[0]);
            switch (strategy)
            {
                case "Press All":
                    PressAll();
                    break;
                case "Press 50 Percent":
                    Press50Percent();
                    break;
                case "Collect All":
                    CollectAll();
                    break;
                case "Come Down Won Bets":
                    ComeDownWonBets();
                    break;
                case "Regress50Percent":
                    Regress50Percent();
                    break;
            }
        }

        //--------- Winnings Logic ---------//
        public static void PressAll()
        {

        }

        public static void Press50Percent()
        {

        }

        public static void CollectAll()
        {

        }

        public static void ComeDownWonBets()
        {

        }

        public static void Regress50Percent()
        {

        }
    }
}

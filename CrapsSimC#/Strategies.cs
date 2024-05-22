using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsSimC_
{
    internal class Strategies
    {
        private string BetStrategy { get; set; }
        private string WinningsStrategy { get; set; }
        private int MinimumBet { get; set; }

        //public List<(string bet, int betAmount, bool won, int rollcount)> HistoricalBetTracker  = new List<(string, int, bool, int)>(); //Tracks the individual bets

        public void PlayerBet(CrapsTable table, Players player, Dice dice)
        {
            if (player.Strategy[0].Equals("Martingale Bets on the Passline with No Odds"))
            {
                betMartingalePassNoOdds(table, player, dice);
            }
        }

        // Bet Strategies
        public void betMartingalePassNoOdds(CrapsTable table, Players player, Dice dice)
        {
            //if the button is off, if there's a bet on there already do nothing. If there's no bet, check to see if the last bet was won or lost.  If won, bet minimum. If lost, bet twice what the last bet was.
            //if the button is on, do nothing.
            if (!table.Button)
            {
                foreach ((string bet, int amount, int rollcount) in player.ActiveBetTracker){
                    if (!bet.Equals("PassLineBet"))
                    {
                        var lastbetTuple = player.HistoricalBetTracker.LastOrDefault(tuple => tuple.Item1 == "PassLineBet");
                        if (!lastbetTuple.Item3)
                        {
                            int betAmount = lastbetTuple.betAmount * 2;
                            player.ActiveBankroll -= betAmount;
                            (string, int, int) newBet = ("PasslineBet", betAmount, dice.rollcount);
                            player.ActiveBetTracker.Add(newBet);
                            table.AddBet(betAmount, player.PlayerID, "PassLineBet");
                        }
                    }
                }
            }


        }

    }
}

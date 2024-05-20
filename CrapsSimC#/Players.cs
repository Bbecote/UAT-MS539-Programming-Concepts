using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsSimC_
{
    internal class Players
    {
        //Attributes required on Player Creation
        public int PlayerID = 0; //Track which player is which without passing the entire player object
        private bool Watching = true; //A player is Watching until they set a bankroll and begin betting.  Once they bust their bankroll, or hit the Win_Walk or Loss_Walk amount, they also return to Watching.
        private int InitialBankRoll {  get; set; } //Starting amount of money to play with
        public List<(string betStrategy, string winningsStrategy, int minimumBet)> Strategy { get; set; } //From the STRATEGIES class, defines automatic play
        private int WinWalk { get; set; }
        private int LossWalk { get; set; }

        //Attributes updated through play
        //private bool HasDice; Requires the player to have a bet on the Pass or Don't Pass Line, may impliment later
        public int ActiveBankRoll; //The amount the player has not including whats on the Table
        private int CurrentStandings; //This is the amount won or lost since starting
        public List<(string bet, int betAmount, int rollcount)> ActiveBetTracker = new List<(string, int, int)>(); //Tracks the individual bets 


        //Historicals tracked over time
        private List<int> TableAverage = new List<int>(); //The average amount the player has on the table each roll
        private List<int> StandingsHistory = new List<int>(); //Tracks the standings between each Come Out roll - later will calculate wins and losses
        public List<(string bet, int betAmount, bool won, int rollcount)> HistoricalBetTracker  = new List<(string, int, bool, int)>(); //Tracks the individual bets 

        private Players()
        {
            Strategy = new List<(string, string, int)>();
            PlayerID = PlayerID ++;
        }

        //Methods
        private void Player_Bet(CrapsTable table, Dice dice)
        {
            if (Strategy[0].Equals("FreePlay"))
            {
                //Accept input from user inpunt to include PlayerID, Amount, Bet
            }
            else
            {
                Strategies Strategy = new Strategies();
                Strategy.PlayerBet(table, this, dice);
            }
        }


    }
}

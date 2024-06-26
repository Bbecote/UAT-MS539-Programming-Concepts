﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsSimC_
{
    public class Players
    {
        //Attributes required on Player Creation
        internal int PlayerID = 0; //Track which player is which without passing the entire player object
        internal bool Watching = true; //A player is Watching until they set a bankroll and begin betting.  Once they bust their bankroll, or hit the Win_Walk or Loss_Walk amount, they also return to Watching.
        internal int InitialBankroll { get; set; } = 0; //Starting amount of money to play with

        //Array to manage the Player Strategy. 0 = string betStrategy 1 = string winningsStrategy, 2 = int minimumBet, 3 = int max maximum bet
        internal object[] Strategy = new object [4];
        //From the STRATEGIES class, defines automatic play
        internal int WinWalk { get; set; } = 0;
        internal int LossWalk { get; set; } = 0;

        //Attributes updated through play
        //private bool HasDice; Requires the player to have a bet on the Pass or Don't Pass Line, may impliment later
        internal int ActiveBankroll = 0; //The amount the player has not including whats on the Table
        internal int CurrentStanding = 0; //This is the amount won or lost since starting
        
        //TODO Needs to be updated to a List of Tuples
        internal List<(string bet, int betAmount)> ActiveBetTracker = new List<(string, int)>(); //Tracks the active individual bets 
        internal int totalBetAmount = 0;


        //Historicals tracked over time
        internal List<int> TableAverage = new List<int>(); //The average amount the player has on the table each roll
        internal List<int> StandingsHistory = new List<int>(); //Tracks the standings between each Come Out roll - later will calculate wins and losses
        internal List<(string bet, int betAmount, bool won)> HistoricalBetTracker  = new List<(string, int, bool)>(); //Tracks the individual bets 

        //Methods

        internal void UpdatePlayer()
        {
            CurrentStanding = ActiveBankroll - InitialBankroll;
            StandingsHistory.Add(CurrentStanding);
            totalBetAmount = ActiveBetTracker.Sum(bet => bet.betAmount);
            //Update Table Average
        }

        internal void ResetPlayer()
        {
            ActiveBankroll = InitialBankroll;
            CurrentStanding = 0;
            ActiveBetTracker.Clear();
            TableAverage.Clear();
            StandingsHistory.Clear();
            HistoricalBetTracker.Clear();
            ActiveBetTracker.Clear();
            totalBetAmount = 0;
        }

        internal void Player_Bet()
        {
            if (Strategy[0].Equals("Free Play"))
            {
                UpdatePlayer();
                //Accept input from user inpunt to include PlayerID, Amount, Bet0
                //Update Historical Tracker
                //Update ActiveTracker
                //Update totalbetAmount
                //Update Table Average
            }
            else
            {
                //Strategies Strategy = new Strategies();
                //Strategy.PlayerBet(table, this, dice);
            }
        }

        internal void Player_Lost()
        {
            UpdatePlayer();
            //Accept input from user inpunt to include PlayerID, Amount, Bet0
            //Update Historical Tracker
            //Update ActiveTracker
            //Update totalbetAmount
            //Update Table Average
        }
    }
}

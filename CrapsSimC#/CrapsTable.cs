using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CrapsSimC_
{
    public class CrapsTable
    {
        //Properties
        public bool Button {get; set;} = false;
        public int ObjectRoll { get; set; } = 0;
        public int[] PassLineBets { get; set; } = new int[4];
        public int dealerBankroll { get; set; } = 1000000;


        //Fields & Constructor including Players created in the Form1 Class passed here for update purposes
        private Players[] playerTracker = new Players[4];
        private Players player0;
        private Players player1;
        private Players player2;
        private Players player3;
        private List<string> ActiveBets;

        public CrapsTable(Players player0, Players player1, Players player2, Players player3)
        {
            this.player0 = player0;
            this.player1 = player1;
            this.player2 = player2;
            this.player3 = player3;
            this.playerTracker = new [] { player0, player1, player2, player3};
        }

        //Manages the Bets on the Table.  The string indicates the type of bet, the array indicates player (by placement in the array: 0-3) and the int within is the current amount bet on the table.
        //TODO Odds on Line Bets (that were come bets)
 //private static Dictionary<string Name, (int[] Bets, double Odds)> betDictionary = new Dictionary<string, (int[], double)>
          public Dictionary <string, (int[], double, bool)> betDictionary = new Dictionary<string, (int[] PlayerTracker, double Odds, bool currentBetSet)> 
       
        {
            { "PassLineBet", (new int[4], 1, false) },
            { "DontPassBet", (new int[4], 1, false)},
            { "Field", (new int[4], 1, false) }, //pays double when a 2 or 12 rolls
            { "ComeBet", (new int[4], 1, false) },
            { "DontComeBet", (new int[4], 1, false) },

            { "4_LineBet", (new int[4], 1, false) },
            { "4_DontLineBet", (new int[4], 1, false) },
            { "4_PlaceBet", (new int[4], 1.8, false) },
            { "4_LineOdds", (new int[4], 2, false)},
            { "4_DontLineOdds", (new int[4], .833, false)},
            { "4_BuyBet", (new int[4], 2, false)},

            { "5_LineBet", (new int[4], 1, false) },
            { "5_DontLineBet", (new int[4], 1, false) },
            { "5_PlaceBet", (new int[4], 1.4, false) },
            { "5_LineOdds", (new int[4], 1.5, false)},
            { "5_DontLineOdds", (new int[4], .833, false)},
            { "5_BuyBet", (new int[4], 1.5, false)},

            { "6_LineBet", (new int[4], 1, false) },
            { "6_DontLineBet", (new int[4], 1, false) },
            { "6_PlaceBet", (new int[4], 1.166, false) },
            { "6_LineOdds", (new int[4], 1.2, false)},
            { "6_DontLineOdds", (new int[4], .833, false)},

            { "8_LineBet", (new int[4], 1, false) },
            { "8_DontLineBet", (new int[4], 1, false) },
            { "8_PlaceBet", (new int[4], 1, false) },
            { "8_LineOdds", (new int[4], 1.2, false)},
            { "8_DontLineOdds", (new int[4], .833, false)},

            { "9_LineBet", (new int[4], 1, false) },
            { "9_DontLineBet", (new int[4], 1, false) },
            { "9_PlaceBet", (new int[4], 1, false) },
            { "9_LineOdds", (new int[4], 1.5, false)},
            { "9_DontLineOdds", (new int[4], .833, false)},
            { "9_BuyBet", (new int[4], 1.5, false)},

            { "10_LineBet", (new int[4], 1, false) },
            { "10_DontLineBet", (new int[4], 1, false) },
            { "10_PlaceBet", (new int[4], 1, false) },
            { "10_LineOdds", (new int[4], 2, false)},
            { "10_DontLineOdds", (new int[4], .833, false)},
            { "10_BuyBet", (new int[4], 2, false)},
        };

        private void UpdatePlaceBets(string placeBet, string lineBet)
        {
            int[] placeBetArray = betDictionary[placeBet].Item1;
            int[] lineBetArray = betDictionary[lineBet].Item1;
            for (int i = 0; i < placeBetArray.Length; i++)
            {
                if (placeBetArray[i] > 0)
                {
                    lineBetArray[i] = placeBetArray[i];
                    betDictionary[lineBet] = (lineBetArray, betDictionary[lineBet].Item2, true);
                    placeBetArray[i] = 0;
                    betDictionary[placeBet] = (placeBetArray, betDictionary[lineBet].Item2, false);
                }
            }
        }

        public int getTotalBetAmount(Players player, string bet)
        {
            int[] betArray = betDictionary[bet].Item1;
            return betArray[player.PlayerID];
        }

        //Need a means to confirm if a bet is legal
        public void MakeBet(int betAmount, Players player, string bet)
        {
            //If bet is legal
            if (true)
            {
                int[] betArray = betDictionary[bet].Item1;
                betArray[player.PlayerID] += betAmount;
                betDictionary[bet] = (betArray, betDictionary[bet].Item2, true);
                player.ActiveBankroll -= betAmount;
                player.ActiveBetTracker.Add((bet, betAmount));
                player.UpdatePlayer();
            }
            else { throw new Exception("Bad Bet Type");};
        }

        private void BetUpdate(string bet, bool win, bool fieldDouble = false)
        {
            if (!betDictionary[bet].Item3) { return; }
            int[] playerArray = betDictionary[bet].Item1;
            if (win)
            {
                double odds = betDictionary[bet].Item2;
                for (int i = 0; i < playerArray.Length; i++)
                {
                    if (playerArray[i] > 0)
                    {
                        int wonBet = (int)(Math.Round(playerArray[i] * odds));
                        this.dealerBankroll -= wonBet;
                        Players Currentplayer = playerTracker[i];
                        switch (bet)
                        {
                            //These payouts are regardless of player strategy
                            //Bets remain on the table, payout to the player
                            case "PassLineBet":
                            case "DontPassBet":
                            case "ComeBet":
                            case "DontComeBet":
                                Currentplayer.ActiveBankroll += wonBet;
                                Currentplayer.UpdatePlayer();
                                break;
                            //Bet and payout goes to the player
                            //TODO Player Strategy
                            case "4_LineBet":
                            case "4_DontLineBet":
                            case "4_LineOdds":
                            case "4_DontLineOdds":

                            case "5_LineBet":
                            case "5_DontLineBet":
                            case "5_LineOdds":
                            case "5_DontLineOdds":

                            case "6_LineBet":
                            case "6_DontLineBet":
                            case "6_LineOdds":
                            case "6_DontLineOdds":

                            case "8_LineBet":
                            case "8_DontLineBet":
                            case "8_LineOdds":
                            case "8_DontLineOdds":

                            case "9_LineBet":
                            case "9_DontLineBet":
                            case "9_LineOdds":
                            case "9_DontLineOdds":

                            case "10_LineBet":
                            case "10_DontLineBet":
                            case "10_LineOdds":
                            case "10_DontLineOdds":
                                Currentplayer.ActiveBankroll += (int)(Math.Round(playerArray[i] * betDictionary[bet].Item2));
                                playerArray[i] = 0;
                                Currentplayer.UpdatePlayer();
                                break;

                            //TODO Strategy for Field
                            case "Field":
                                if(fieldDouble)
                                {
                                    dealerBankroll -= wonBet;
                                    Currentplayer.ActiveBankroll += wonBet * 2;
                                    playerArray[i] = 0;
                                }
                                else
                                {
                                    Currentplayer.ActiveBankroll += wonBet;
                                    playerArray[i] = 0;
                                }
                                break;
                            //determine payout strategy based on player stragy
                            default:
                                // case "4_PlaceBet": case "5_PlaceBet": case "6_PlaceBet": case "8_PlaceBet": case "9_PlaceBet": case "10_PlaceBet": case "4_BuyBet": case "5_BuyBet": case "6_BuyBet": case "9_BuyBet": case "10_BuyBet":
                                wonBet = (int)(Math.Round(playerArray[i] * betDictionary[bet].Item2) + playerArray[i]);
                                Strategies.CollectWinnings(this, Currentplayer);
                                break;
                        }
                    }
                }
            }
            //If the bet was a loss
            else
            {
                for (int i = 0; i < playerArray.Length; i++)
                {
                    if (playerArray[i] > 0)
                    {
                        int lostBet = playerArray[i];
                        this.dealerBankroll += lostBet;
                        playerArray[i] = 0;
                        //Update Player Active Betting 
                    }
                }

                //run it to the strategy class for rebetting
            }
            
            //Sets the boolean flag on the bet to determine if there are active bets on table for this bet
            if (betDictionary[bet].Item1.All(num => num == 0))
            {
                betDictionary[bet] = (playerArray, betDictionary[bet].Item2, false);
            }
            else
            {
                betDictionary[bet] = (playerArray, betDictionary[bet].Item2, true);
            }
        }

        //Need to intiate placing odds on COME and Dont Bets when the button is off
        public void TableUpdate(int rollAmount)
        {
            if (!Button)
            {
                switch(rollAmount)
                {

                    case 2:
                        BetUpdate("Field", true, true);
                        break;
                    case 3:
                        BetUpdate("PassLineBet", false);
                        BetUpdate("DontPassBet", true);
                        BetUpdate("Field", true);
                        break;
                    case 4:
                        BetUpdate("4_LineBet", true);
                        BetUpdate("4_DontLineBet", false);
                        BetUpdate("Field", true);
                        UpdatePlaceBets("PassLineBet", "4_LineBet");
                        UpdatePlaceBets("DontPassBet", "4_DontLineBet");

                        break;
                    case 5:
                        BetUpdate("5_LineBet", true);
                        BetUpdate("5_DontLineBet", false);
                        BetUpdate("Field", false);
                        UpdatePlaceBets("PassLineBet", "5_LineBet");
                        UpdatePlaceBets("DontPassBet", "5_DontLineBet");
                        break;
                    case 6:
                        BetUpdate("6_LineBet", true);
                        BetUpdate("6_DontLineBet", false);
                        BetUpdate("Field", false);
                        UpdatePlaceBets("PassLineBet", "6_LineBet");
                        UpdatePlaceBets("DontPassBet", "6_DontLineBet");
                        break;
                    case 7:
                        BetUpdate("DontPassBet", false);
                        BetUpdate("PassLineBet", true);
                        BetUpdate("Field", false);
                        BetUpdate("4_DontLineBet", true);
                        BetUpdate("4_DontLineOdds", true);
                        BetUpdate("5_DontLineBet", true);
                        BetUpdate("5_DontLineOdds", true);
                        BetUpdate("6_DontLineBet", true);
                        BetUpdate("6_DontLineOdds", true);
                        BetUpdate("8_DontLineBet", true);
                        BetUpdate("8_DontLineOdds", true);
                        BetUpdate("9_DontLineBet", true);
                        BetUpdate("9_DontLineOdds", true);
                        BetUpdate("10_DontLineBet", true);
                        BetUpdate("10_DontLineOdds", true);
                        BetUpdate("4_LineBet", false);
                        BetUpdate("4_LineOdds", false);
                        BetUpdate("5_LineBet", false);
                        BetUpdate("5_LineOdds", false);
                        BetUpdate("6_LineBet", false);
                        BetUpdate("6_LineOdds", false);
                        BetUpdate("8_LineBet", false);
                        BetUpdate("8_LineOdds", false);
                        BetUpdate("9_LineBet", false);
                        BetUpdate("9_LineOdds", false);
                        BetUpdate("10_LineBet", false);
                        BetUpdate("10_LineOdds", false);
                        break;
                    case 8:
                        BetUpdate("8_LineBet", true);
                        BetUpdate("8_DontLineBet", false);
                        BetUpdate("Field", false);
                        UpdatePlaceBets("PassLineBet", "8_LineBet");
                        UpdatePlaceBets("DontPassBet", "8_DontLineBet");
                        break;
                    case 9:
                        BetUpdate("9_LineBet", true);
                        BetUpdate("9_DontLineBet", false);
                        BetUpdate("Field", true);
                        UpdatePlaceBets("PassLineBet", "9_LineBet");
                        UpdatePlaceBets("DontPassBet", "9_DontLineBet");
                        break;
                    case 10:
                        BetUpdate("10_LineBet", true);
                        BetUpdate("10_DontLineBet", false);
                        BetUpdate("Field", true);
                        UpdatePlaceBets("PassLineBet", "10_LineBet");
                        UpdatePlaceBets("DontPassBet", "10_DontLineBet");
                        break;
                    case 11:
                        BetUpdate("DontPassBet", false);
                        BetUpdate("PassLineBet", true);
                        BetUpdate("Field", true);
                        break;
                    case 12:
                        BetUpdate("PassLineBet", false);
                        BetUpdate("Field", true, true);
                        break;
                }
                
            }
            //Need to intiate placing odds on Pass and Dont Bets when the button is on
            //If button is ON
            else
            {
                switch (rollAmount)
                {
                    case 2:
                        BetUpdate("ComeBet", false);
                        BetUpdate("DontComeBet", true);
                        BetUpdate("Field", true, true);
                        break;
                    case 3:
                        BetUpdate("ComeBet", false);
                        BetUpdate("DontComeBet", true);
                        BetUpdate("Field", true);
                        break;
                    case 4:
                        BetUpdate("Field", true);
                        BetUpdate("4_LineBet", true);
                        BetUpdate("4_LineOdds", true);
                        BetUpdate("4_DontLineBet", false);
                        BetUpdate("4_DontLineOdds", false);
                        BetUpdate("4_PlaceBet", true);
                        BetUpdate("4_BuyBet", true);
                        UpdatePlaceBets("ComeBet", "4_LineBet");
                        UpdatePlaceBets("DontComeBet", "4_DontLineBet");
                        break;
                    case 5:
                        BetUpdate("5_LineBet", true);
                        BetUpdate("5_LineOdds", true);
                        BetUpdate("5_DontLineBet", false);
                        BetUpdate("5_DontLineOdds", false);
                        BetUpdate("5_PlaceBet", true);
                        BetUpdate("5_BuyBet", true);
                        UpdatePlaceBets("ComeBet", "5_LineBet");
                        UpdatePlaceBets("DontComeBet", "5_DontLineBet");
                        break;
                    case 6:
                        BetUpdate("6_LineBet", true);
                        BetUpdate("6_LineOdds", true);
                        BetUpdate("6_DontLineBet", false);
                        BetUpdate("6_DontLineOdds", false);
                        BetUpdate("6_PlaceBet", true);
                        UpdatePlaceBets("ComeBet", "6_LineBet");
                        UpdatePlaceBets("DontComeBet", "6_DontLineBet");
                        break;
                    case 7:
                        BetUpdate("ComeBet", true);
                        BetUpdate("DontComeBet", false);
                        BetUpdate("4_DontLineBet", true);
                        BetUpdate("4_DontLineOdds", true);
                        BetUpdate("5_DontLineBet", true);
                        BetUpdate("5_DontLineOdds", true);
                        BetUpdate("6_DontLineBet", true);
                        BetUpdate("6_DontLineOdds", true);
                        BetUpdate("8_DontLineBet", true);
                        BetUpdate("8_DontLineOdds", true);
                        BetUpdate("9_DontLineBet", true);
                        BetUpdate("9_DontLineOdds", true);
                        BetUpdate("10_DontLineBet", true);
                        BetUpdate("10_DontLineOdds", true);
                        BetUpdate("4_LineBet", false);
                        BetUpdate("4_LineOdds", false);
                        BetUpdate("5_LineBet", false);
                        BetUpdate("5_LineOdds", false);
                        BetUpdate("6_LineBet", false);
                        BetUpdate("6_LineOdds", false);
                        BetUpdate("8_LineBet", false);
                        BetUpdate("8_LineOdds", false);
                        BetUpdate("9_LineBet", false);
                        BetUpdate("9_LineOdds", false);
                        BetUpdate("10_LineBet", false);
                        BetUpdate("10_LineOdds", false);
                        BetUpdate("4_PlaceBet", true);
                        BetUpdate("4_BuyBet", true);
                        BetUpdate("5_PlaceBet", true);
                        BetUpdate("5_BuyBet", true);
                        BetUpdate("6_PlaceBet", true);
                        BetUpdate("8_PlaceBet", true);
                        BetUpdate("9_PlaceBet", true);
                        BetUpdate("9_BuyBet", true);
                        BetUpdate("10_PlaceBet", true);
                        BetUpdate("10_BuyBet", true);
                        break;
                    case 8:
                        BetUpdate("8_LineBet", true);
                        BetUpdate("8_LineOdds", true);
                        BetUpdate("8_DontLineBet", false);
                        BetUpdate("8_DontLineOdds", false);
                        BetUpdate("8_PlaceBet", true);
                        UpdatePlaceBets("ComeBet", "8_LineBet");
                        UpdatePlaceBets("DontComeBet", "8_DontLineBet");
                        break;
                    case 9:
                        BetUpdate("9_LineBet", true);
                        BetUpdate("9_LineOdds", true);
                        BetUpdate("9_DontLineBet", false);
                        BetUpdate("9_DontLineOdds", false);
                        BetUpdate("Field", true);
                        BetUpdate("9_PlaceBet", true);
                        BetUpdate("9_BuyBet", true);
                        UpdatePlaceBets("ComeBet", "9_LineBet");
                        UpdatePlaceBets("DontComeBet", "9_DontLineBet");
                        break;
                    case 10:
                        BetUpdate("10_LineBet", true);
                        BetUpdate("10_LineOdds", true);
                        BetUpdate("10_DontLineBet", false);
                        BetUpdate("10_DontLineOdds", false);
                        BetUpdate("10_PlaceBet", true);
                        BetUpdate("10_BuyBet", true);
                        BetUpdate("Field", true);
                        UpdatePlaceBets("ComeBet", "10_LineBet");
                        UpdatePlaceBets("DontComeBet", "10_DontLineBet");
                        break;
                    case 11:
                        BetUpdate("ComeBet", true);
                        BetUpdate("DontComeBet", false);
                        BetUpdate("Field", true);
                        break;
                    case 12:
                        BetUpdate("ComeBet", false);
                        BetUpdate("Field", true, true);
                        break;

                }
            }
        }
    }
}

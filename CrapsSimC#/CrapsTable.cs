using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CrapsSimC_
{
    public class CrapsTable
    {
        //Attributes
        public bool Button = false;
        public int ObjectRoll = 0;
        public int[] PassLineBets = new int[4];


        //Attributes & Constructor including Players created in the Form1 Class passed here for update purposes
        private Players[] playerTracker = new Players[4];
        private Players player0;
        private Players player1;
        private Players player2;
        private Players player3;

        public CrapsTable(Players player0, Players player1, Players player2, Players player3)
        {
            this.player0 = player0;
            this.player1 = player1;
            this.player2 = player2;
            this.player3 = player3;
            this.playerTracker = new [] { player0, player1, player2, player3};
        }

        //Manages the Bets on the Table.  The string indicates the type of bet, the array indicates player (by placement in the array) and the current amount bet on the table.
        //TODO Odds on Line Bets (that were come bets)
        //TODO impliment buying a place bet
 //private static Dictionary<string Name, (int[] Bets, double Odds)> betDictionary = new Dictionary<string, (int[], double)>
          public Dictionary <string, (int[], double)> betDictionary = new Dictionary<string, (int[] PlayerTracker, double Odds)> 
       
        {
            { "PassLineBet", (new int[4], 1) },
            { "DontPassBet", (new int[4], 1)},
            { "FieldBet", (new int[4], 1) }, //pays double when a 2 or 12 rolls
            { "ComeBet", (new int[4], 1) },
            { "DontComeBet", (new int[4], 1) },

            { "4_LineBet", (new int[4], 1) },
            { "4_DontLineBet", (new int[4], 1) },
            { "4_PlaceBet", (new int[4], 1.8) },
            { "4_LineOdds", (new int[4], 2)},
            { "4_DontLineOdds", (new int[4], .833)},
            { "4_BuyBet", (new int[4], 2)},

            { "5_LineBet", (new int[4], 1) },
            { "5_DontLineBet", (new int[4], 1) },
            { "5_PlaceBet", (new int[4], 1.4) },
            { "5_LineOdds", (new int[4], 1.5)},
            { "5_DontLineOdds", (new int[4], .833)},
            { "5_BuyBet", (new int[4], 1.5)},

            { "6_LineBet", (new int[4], 1) },
            { "6_DontLineBet", (new int[4], 1) },
            { "6_PlaceBet", (new int[4], 1.166) },
            { "6_LineOdds", (new int[4], 1.2)},
            { "6_DontLineOdds", (new int[4], .833)},

            { "8_LineBet", (new int[4], 1) },
            { "8_DontLineBet", (new int[4], 1) },
            { "8_PlaceBet", (new int[4], 1) },
            { "8_LineOdds", (new int[4], 1.2)},
            { "8_DontLineOdds", (new int[4], .833)},

            { "9_LineBet", (new int[4], 1) },
            { "9_DontLineBet", (new int[4], 1) },
            { "9_PlaceBet", (new int[4], 1) },
            { "9_LineOdds", (new int[4], 1.5)},
            { "9_DontLineOdds", (new int[4], .833)},
            { "9_BuyBet", (new int[4], 1.5)},

            { "10LineBet", (new int[4], 1) },
            { "10DontLineBet", (new int[4], 1) },
            { "10PlaceBet", (new int[4], 1) },
            { "10_LineOdds", (new int[4], 2)},
            { "10_DontLineOdds", (new int[4], .833)},
            { "10_BuyBet", (new int[4], 2)},
        };

        public int[] GetBetType(string bet)
        {
            if (betDictionary.ContainsKey(bet)) { return betDictionary[bet].Item1; }
            else return null;
        }

        public void AddBet(int betAmount, int playerID, string bet)
        {
            int[] betArray = GetBetType(bet);
            if (betArray != null)
            {
                betArray[playerID] = betAmount;
            }
            else { throw new Exception("Bad Bet Type");};
        }

        private void BetUpdate(string bet, bool win, int rollamount = 0)
        {
            //Form1 formInstance;
            if (win)
            {
                int [] playerArray = betDictionary[bet].Item1;
                double odds = betDictionary[bet].Item2;
                for (int i = 0; i < playerArray.Length; i++)

                {
                    if (playerArray[i] > 0)
                    {
                        Players Currentplayer = playerTracker[i];
                        switch (bet)
                        {
                            //These payouts are regardless of player strategy
                            //Bets remain on the table, payout to the player
                            case "PassLineBet":
                            case "DontPassBet":
                            case "ComeBet":
                            case "DontComeBet":
                                Currentplayer.ActiveBankroll += (int)(Math.Round(playerArray[i] * betDictionary[bet].Item2));
                                Currentplayer.UpdatePlayer();
                                break;
                            //Bet and payout goes to the player
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
                          
                                Currentplayer.ActiveBankroll += (int)(Math.Round(playerArray[i] * betDictionary[bet].Item2) + playerArray[i]);
                                playerArray[i] = 0;
                                Currentplayer.UpdatePlayer();
                                break;

                            //determine payout strategy based on player stragy
                            default:
                                // case "4_PlaceBet": case "5_PlaceBet": case "6_PlaceBet": case "8_PlaceBet": case "9_PlaceBet": case "10_PlaceBet": case "4_BuyBet": case "5_BuyBet": case "6_BuyBet": case "9_BuyBet": case "10_BuyBet":
                                Strategies.CollectWinnings(this, Currentplayer, rollamount);
                                break;
                        }
                    }
                }
            }
        }


        public void TableUpdate(int rollAmount)
        {
            if (!Button)
            {
                switch(rollAmount)
                {

                    case 2:
                    case 3:
                        BetUpdate("PassLineBet", false);
                        BetUpdate("ComeBet", false);
                        BetUpdate("DontComeBet", true);
                        BetUpdate("DontPassBet", true);

                        break;
                    case 4:
                        //turn off the off button, turn on the on button on 4
                        
                        BetUpdate("4_DontLineBet", false);
                        break;
                    case 5:
                        BetUpdate("5_DontLineBet", false);
                        break;
                    case 6:
                        BetUpdate("6_DontLineBet", false);
                        break;
                    case 7:
                        BetUpdate("DontPassBet", false);
                        BetUpdate("DontComeBet", false);
                        BetUpdate("PassLineBet", true);
                        BetUpdate("ComeBet", true);
                        break;
                    case 8:
                        BetUpdate("8_DontLineBet", false);
                        break;
                    case 9:
                        BetUpdate("9_DontLineBet", false);
                        break;
                    case 10:
                        BetUpdate("10_DontLineBet", false);
                        break;
                    case 11:
                        BetUpdate("DontPassBet", false);
                        BetUpdate("DontComeBet", false);
                        BetUpdate("PassLineBet", true);
                        BetUpdate("ComeBet", true);
                        break;
                    case 12:
                        BetUpdate("PassLineBet", false);
                        BetUpdate("ComeBet", false);
                        break;

                }
                
            }
            else
            {
                switch (rollAmount)
                {
                    case 2:
                        BetUpdate("DontComeBet", true, 2);
                        break;
                    case 3:
                        //Take bets from the Pass Line and Come 
                        BetUpdate("DontComeBet", true);
                        break;
                    case 4:
                    //Take Don't Pass, Don't Come on 4
                    //turn off the off button, turn on the on button on 4
                    case 5:
                    case 6:
                    case 7:
                        //Take bets from the Don't Pass and Don't Come
                        BetUpdate("ComeBet", true);
                        break;
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        //Take bets from the Don't Pass and Don't Come
                        BetUpdate("ComeBet", true);
                        break;
                    case 12:
                        //Take bets from the Pass Line and Come
                        break;

                }
            }
        }


    }
}

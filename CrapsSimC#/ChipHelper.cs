using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsSimC_
{
    internal static class ChipHelper
    {
        internal static (Point location, string bet) ChipPlacer(Players player, string bet, int betAmount)
        {
            switch (player.PlayerID)
            {
                case 0:
                    switch (bet)
                    {
                        case "PassLineBet":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(185, 460), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(185, 460), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(185, 460), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(185, 460), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(185, 460), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(185, 460), "chipsButton_500Mini");
                                default:
                                    return (new Point(185, 460), "chipsButton_1000Mini");
                            }
                        case "DontPassBet":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(185, 395), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(185, 395), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(185, 395), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(185, 395), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(185, 395), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(185, 395), "chipsButton_500Mini");
                                default:
                                    return (new Point(185, 395), "chipsButton_1000Mini");
                            }

                        case "Field":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(185, 325), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(185, 325), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(185, 325), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(185, 325), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(185, 325), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(185, 325), "chipsButton_500Mini");
                                default:
                                    return (new Point(185, 325), "chipsButton_1000Mini");
                            }

                        case "DontComeBet":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(85, 245), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(85, 245), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(85, 245), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(85, 245), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(85, 245), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(85, 245), "chipsButton_500Mini");
                                default:
                                    return (new Point(85, 245), "chipsButton_1000Mini");
                            }

                        case "ComeBet":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(500, 245), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(500, 245), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(500, 245), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(500, 245), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(500, 245), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(500, 245), "chipsButton_500Mini");
                                default:
                                    return (new Point(500, 245), "chipsButton_1000Mini");
                            }

                        case "4_PlaceBet":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(65, 140), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(65, 140), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(65, 140), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(65, 140), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(65, 140), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(65, 140), "chipsButton_500Mini");
                                default:
                                    return (new Point(65, 140), "chipsButton_1000Mini");
                            }

                        case "5_PlaceBet":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(255, 140), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(255, 140), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(255, 140), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(255, 140), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(255, 140), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(255, 140), "chipsButton_500Mini");
                                default:
                                    return (new Point(255, 140), "chipsButton_1000Mini");
                            }

                        case "6_PlaceBet":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(445, 140), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(445, 140), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(445, 140), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(445, 140), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(445, 140), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(445, 140), "chipsButton_500Mini");
                                default:
                                    return (new Point(445, 140), "chipsButton_1000Mini");
                            }

                        case "8_PlaceBet":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(635, 140), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(635, 1400), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(635, 140), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(635, 140), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(635, 140), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(635, 140), "chipsButton_500Mini");
                                default:
                                    return (new Point(635, 140), "chipsButton_1000Mini");
                            }

                        case "9_PlaceBet":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(825, 140), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(825, 140), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(825, 140), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(825, 140), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(825, 140), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(825, 140), "chipsButton_500Mini");
                                default:
                                    return (new Point(825, 140), "chipsButton_1000Mini");
                            }

                        case "10_PlaceBet":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(1015, 140), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(1015, 140), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(1015, 140), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(1015, 140), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(1015, 140), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(1015, 140), "chipsButton_500Mini");
                                default:
                                    return (new Point(1015, 140), "chipsButton_1000Mini");
                            }

                        case "lineOdds":
                            switch (betAmount)
                            {
                                case < 5:
                                    return (new Point(185, 475), "chipsButton_1Mini");
                                case < 10:
                                    return (new Point(185, 460), "chipsButton_5Mini");
                                case < 25:
                                    return (new Point(1015, 140), "chipsButton_10Mini");
                                case < 100:
                                    return (new Point(1015, 140), "chipsButton_25Mini");
                                case < 500:
                                    return (new Point(1015, 140), "chipsButton_100Mini");
                                case < 1000:
                                    return (new Point(1015, 140), "chipsButton_500Mini");
                                default:
                                    return (new Point(1015, 140), "chipsButton_1000Mini");
                            }
                        default: return (new Point(185, 460), "chipsButton_1000Mini"); //TODO PlaceHolder for additional bets
                    }
                default: return (new Point(185, 460), "chipsButton_1000Mini"); //TODO Placeholder for additional players
            }






        }





    }
}

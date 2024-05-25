using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsSimC_
{

    internal class Dice
    {
        //Properties
        private readonly Random rnd = new Random();
        public int rollcount = 0;
        private List <(int die_1, int die_2, int roll_count)> rollHistory = new List <(int, int, int)> ();  //Keeps track of the roll history in a list of tuple
        internal int LastRoll1 = 0;
        internal int LastRoll2 = 0;

    //Methods
    internal void RollDice(CrapsTable table)
        {
            
            LastRoll1 = rnd.Next(1, 7);
            LastRoll2 = rnd.Next(1, 7);
            int rollAmount = LastRoll1 + LastRoll2;
            rollcount ++;
            rollHistory.Add((LastRoll1, LastRoll2, rollcount));
            table.TableUpdate(rollAmount);
        }
    }
}

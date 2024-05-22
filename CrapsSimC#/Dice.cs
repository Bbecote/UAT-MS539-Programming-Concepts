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
        public int rollcount = 0;
        private List <(int die_1, int die_2, int roll_count)> rollHistory = new List <(int, int, int)> ();  //Keeps track of the roll history in a list of tuple
        internal int LastRoll1 = 0;
        internal int LastRoll2 = 0;

    //Methods
    internal void RollDice()
        {
            Random rnd = new Random();
            LastRoll1 = rnd.Next(1, 7);
            LastRoll2 = rnd.Next(1, 7);
            rollcount ++;
            rollHistory.Add((LastRoll1, LastRoll2, rollcount));
        }
    }
}

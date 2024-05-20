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
        private List <(int die_1, int die_2, int roll_count)> rollHistory = new List <(int, int, int)> ();  //Keeps track of the roll history in a list of tuples
        
        //Methods
        private void RollDice(out int die_1, out int die_2)
        {
            Random rnd = new Random();
            die_1 = rnd.Next(1, 7);
            die_2 = rnd.Next(1, 7);
            rollcount ++;
            rollHistory.Add((die_1, die_2, rollcount));
        }
    }
}

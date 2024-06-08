using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class Budget
    {
        public Budget() { }

        public string Name { get; set; }
        public string Catagory { get; set; }
        public string StartDate { get; set; }
        public double StartAmount { get; set; }
        public double OpeningCash { get; set; }

    }
}

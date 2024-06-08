using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class Account
    {
        public Account() { }

        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string OpeningDate { get; set; }
        public string ClosingDate { get; set; }
        public double StartBalance { get; set; }
        public byte[] Image { get; set; }

    }
}

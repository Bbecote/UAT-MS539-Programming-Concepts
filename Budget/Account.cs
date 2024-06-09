using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class Account
    {

        internal static Dictionary<string, List<Account>> Accounts { get; }
        static Account() 
        {
            Accounts = DBManager.GetAccountDetailsFromDatabase();
        }

        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string StartDate { get; set; }
        public string ClosingDate { get; set; }
        public decimal OpeningBalance { get; set; }
        public byte[] Image { get; set; }

    }
}

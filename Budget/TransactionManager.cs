using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class TransactionManager
    {
        private List<Transaction> _transactions;

        public TransactionManager() 
        {
            //_transactions = new List<Transaction>();
            //_transactions.ListChanged += Transactions_ListChanged;
        }

        public List<Transaction> Transactions
        {
            get { return _transactions; }
        }

        public void Transactions_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged) 
            {
                Transaction modifiedTransaction = _transactions[e.NewIndex];
                UpdateTransactionInDatabase(modifiedTransaction);
            }
        }

        private void UpdateTransactionInDatabase(Transaction modifiedTransaction)
        {
            //TODO method to the database class to update transactions
        }
    }
}

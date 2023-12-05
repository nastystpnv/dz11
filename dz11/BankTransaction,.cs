using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    internal class BankTransaction
    {
        private int transactionId;
        private DateTime transactionDate;
        private string description;
        private double amount;

        public BankTransaction(int transactionId, DateTime transactionDate, string description, double amount)
        {
            this.transactionId = transactionId;
            this.transactionDate = transactionDate;
            this.description = description;
            this.amount = amount;
        }

        public int TransactionId 
        {
            get { return transactionId; }
        }

        public DateTime TransactionDate 
        {
            get { return transactionDate; }
        }

        public string Description 
        {
            get { return description; }
        }

        public double Amount 
        {
            get { return amount; }
        }
    }

}

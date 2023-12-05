using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    
    internal enum BankAccountType
    {
        Current,
        Saving
    }

    internal class BankAccount
    {
        private int Account_number { get; }
        private double Balance;
        private BankAccountType Type { get; }
        private int Generic;
        private List<BankTransaction> transactions; 

        private string AccountHolder { get; set; }

        static Random r = new Random();
        private static int generic_number = r.Next(999, 10000);

        public BankAccount(int account_number, BankAccountType type)
        {
            this.Account_number = account_number;
            Balance = 0;
            Type = type;
            Generic = generic_number++;
        }

        public BankAccount(int account_number, BankAccountType type, double balance)
        {
            this.Account_number = account_number;
            Balance = balance;
            Type = type;
            Generic = generic_number++;
        }

        public double PutOnAccount(double balance)
        {
            Console.Write("введите сумму для заполнения: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            return balance + temp;
        }

        public double WithdrawFromAccount(double balance)
        {
            Console.Write("введите сумму для снятия: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            if (balance >= temp)
            {
                return balance - temp;
            }
            else
            {
                Console.WriteLine("на вашем счете недостаточно средств!");
                return balance;
            }
        }

        public void Transfer(BankAccount destinationAccount, double amount)
        {
            Console.Write("введите сумму для перевода: ");
            double transferAmount = Convert.ToDouble(Console.ReadLine());

            if (this.Balance >= transferAmount)
            {
                this.Balance -= transferAmount;
                destinationAccount.Balance += transferAmount;
                Console.WriteLine($"перевод успешен! Сумма {transferAmount}$ переведена со счета {destinationAccount.Account_number} на счет {destinationAccount.Account_number}");
            }
            else
            {
                Console.WriteLine("на вашем счете недостаточно средств для перевода.");
            }
            Console.ReadKey();
        }

        public int AccountNumber 
        {
            get { return Account_number; }
        }

        public BankAccountType AccountType 
        {
            get { return Type; }
        }

        public string AccountHolderName 
        {
            get { return AccountHolder; }
            set { AccountHolder = value; }
        }
        public BankTransaction this[int index]
        {
            get
            {
                if (index >= 0 && index < transactions.Count)
                {
                    return transactions[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
        }  
        public void AddTransaction(BankTransaction transaction)
        {
            transactions.Add(transaction);
        }
    }
}

using System;

class CheckingAccount : BankAccount
    {
        
        public decimal balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                if (value < 500)
                    Console.WriteLine("Insufficient Amount");
                else 
                {
                this._balance = value;
                }
            }
        }
        public CheckingAccount()
            : base()
        {
        }
        public CheckingAccount(String accountNumber, String name, decimal balance)
            : base(accountNumber, name, balance)
        {

        }
        public new void calculateInterest()
        {
            decimal interestRate = 0.75M;
            this._balance += interestRate * this._balance;
            Console.WriteLine("Added interest and updated Balance");
        }
        public override void withdraw(decimal amount)
        {
            if (this._balance < 500)
                Console.WriteLine("Insufficient balance");
            else
            {
                base.withdraw(amount);
            }
        }
    }
using System;

 class SavingsAccount : BankAccount
    {
        public decimal balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                if (value < 2500)
                    throw new ArgumentException();
                this._balance = value;
            }
        }
        public SavingsAccount()
            : base()
        {
        }
        public SavingsAccount(String accountNumber, String name, decimal balance)
            : base(accountNumber, name, balance)
        {

        }
        public new void calculateInterest()
        {
            decimal interestRate = 0.05M;
            this._balance += interestRate * this._balance;
            Console.WriteLine("Added interest and updated Balance");
        }
        public override void withdraw(decimal amount)
        {
            if (this._balance < 2500)
                Console.WriteLine("Insufficient balance");
            else
            {
                base.withdraw(amount);
            }
        }
    }
    
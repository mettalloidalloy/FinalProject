using System;

class BankAccount
    {
        private String _accountNumber;
        public String accountNumber
        {
            get
            {
                return this._accountNumber;
            }
            set
            {
                if (value.Length != 6)
                    throw new ArgumentException();
                this._accountNumber = value;
            }
        }
        public String name { get; set; }
        public decimal _balance;
        public decimal balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                this._balance = value;
            }
        }
        private DateTime _date;
        public DateTime date
        {
            get
            {
                return this._date;
            }
            set
            {
                if (value > DateTime.Today)
                    throw new ArgumentException();
                this._date = value;
            }
        }

        public BankAccount()
        {
            this.date = DateTime.Today;
        }

        public BankAccount(String accountNumber, String name, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.balance = balance;
            this.date = DateTime.Today;
        }

        public void displayAccountInfo()
        {
            Console.WriteLine("Account Number: " + this.accountNumber + ", Name: " + this.name + ", Balance: " + this.balance);
        }
        public void deposit(decimal amount)
        {
            this._balance += amount;
            Console.WriteLine("Current Balance: " + this._balance);
        }
        public virtual void withdraw(decimal amount)
        {
            if (this._balance < amount)
                Console.WriteLine("Oops! Insufficient balance");
            else
            {
                this._balance -= amount;
                Console.WriteLine("Current Balance: " + this._balance);
            }
        }
        public void calculateInterest()
        {
            Console.WriteLine("This method will calculate interest");
        }
    }
   
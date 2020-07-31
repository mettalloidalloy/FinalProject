using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine("**Testing BankAccount**");
    BankAccount b1 = new BankAccount();
    b1.accountNumber = "000001";
    b1.name = "My Bank Account";
    b1.balance = 3000;
    b1.displayAccountInfo();
    b1.deposit(1000);
    b1.displayAccountInfo();
    b1.withdraw(500);
    b1.displayAccountInfo();
    b1.calculateInterest();
    

    Console.WriteLine("**Testing SavingsAccount**");
    SavingsAccount s1 = new SavingsAccount();
    s1.accountNumber = "019283";
    s1.name = "My Saving Account";
    s1.balance = 10000;
    s1.displayAccountInfo();
    s1.calculateInterest();
    s1.displayAccountInfo();
    s1.withdraw(5000);
    s1.displayAccountInfo();

    Console.WriteLine("**Testing CheckingAccount**");
    CheckingAccount c1 = new CheckingAccount();
    c1.accountNumber = "555666";
    c1.name = "My Checking Account";
    c1.balance = 5000;
    c1.displayAccountInfo();
    c1.calculateInterest();
    c1.displayAccountInfo();
    c1.withdraw(500);
    
    





  }
}
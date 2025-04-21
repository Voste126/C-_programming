using System;
using System.Collections.Generic;

class MobileBankingApp
{
    static void Main()
    {
        Bank bank = new Bank("MyBank");
        bank.Run();
    }
}

class Bank
{
    private string Name;
    private List<Account> Accounts;

    public Bank(string name)
    {
        Name = name;
        Accounts = new List<Account>();
    }

    public void Run()
    {
        Console.WriteLine($"Welcome to {Name} Mobile Banking App!");
        while (true)
        {
            Console.WriteLine("\n1. Create Account\n2. Deposit\n3. Withdraw\n4. Check Balance\n5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateAccount();
                    break;
                case "2":
                    Deposit();
                    break;
                case "3":
                    Withdraw();
                    break;
                case "4":
                    CheckBalance();
                    break;
                case "5":
                    Console.WriteLine("Thank you for using our app. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private void CreateAccount()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter initial deposit: ");
        double initialDeposit = Convert.ToDouble(Console.ReadLine());

        Account newAccount = new Account(name, initialDeposit);
        Accounts.Add(newAccount);

        Console.WriteLine($"Account created successfully! Your account number is {newAccount.AccountNumber}.");
    }

    private void Deposit()
    {
        Console.Write("Enter account number: ");
        int accountNumber = Convert.ToInt32(Console.ReadLine());
        Account account = FindAccount(accountNumber);

        if (account != null)
        {
            Console.Write("Enter deposit amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            account.Deposit(amount);
            Console.WriteLine("Deposit successful.");
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    private void Withdraw()
    {
        Console.Write("Enter account number: ");
        int accountNumber = Convert.ToInt32(Console.ReadLine());
        Account account = FindAccount(accountNumber);

        if (account != null)
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (account.Withdraw(amount))
            {
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    private void CheckBalance()
    {
        Console.Write("Enter account number: ");
        int accountNumber = Convert.ToInt32(Console.ReadLine());
        Account account = FindAccount(accountNumber);

        if (account != null)
        {
            Console.WriteLine($"Account Balance: {account.Balance}");
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    private Account FindAccount(int accountNumber)
    {
        return Accounts.Find(a => a.AccountNumber == accountNumber);
    }
}

class Account
{
    private static int AccountCounter = 1000;
    public int AccountNumber { get; private set; }
    public string Owner { get; private set; }
    public double Balance { get; private set; }

    public Account(string owner, double initialDeposit)
    {
        AccountNumber = AccountCounter++;
        Owner = owner;
        Balance = initialDeposit;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}
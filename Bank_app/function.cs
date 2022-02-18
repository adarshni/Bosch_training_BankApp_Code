using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app
{
    public class AccountLimitExceeded : Exception
    {

        public AccountLimitExceeded(string message) : base(message)
        {

        }
    }

    class Saving
    {
        public int balance = 2000;
        public virtual void deposit(int money)
        {
            try
            {
                Console.WriteLine("Enter Name of the depositor :");
                String name = Console.ReadLine();
                if (money > 100000)
                {
                    throw new AccountLimitExceeded("User Defined Exception: Limit exceeded ");
                }
                balance += money;
                Console.WriteLine(" You have deposited rs. " + money + " in ur savings acc.");
                Console.WriteLine($"The balance of {name} is: " + balance);
                Console.WriteLine("===================================================");
            }
            catch (AccountLimitExceeded e)
            {
                Console.WriteLine("account limit is 100000Rs." + e.Message);
            }
        }

        
    }
    class Current : Saving
    {
        public int balance1 = 2000;
        public override void deposit(int money)
        {
            try
            {
                Console.WriteLine("Enter Name of the depositor :");
                String name = Console.ReadLine();
                if (money > 200000)
                {
                    throw new AccountLimitExceeded("User Defined Exception: Limit Exceeded");
                }
                balance1 += money;
                Console.WriteLine(" You have deposited rs. " + money + " in ur current acc.");
                Console.WriteLine($"The balance of {name} is: " + balance1);
                Console.WriteLine("===================================================");
            }
            catch (AccountLimitExceeded e)
            {
                Console.WriteLine("account limit is 200000Rs." + e);
            }
        }
    }
    class child : Current
    {
        public int balance2= 0;
        public override void deposit(int money)
        {
            try
            {
                Console.WriteLine("Enter Name of the depositor :");
                String name = Console.ReadLine();
                if (money > 50000)
                {
                    throw new AccountLimitExceeded("User Defined Exception: Limit exceeded");
                }
                balance2 += money;
                Console.WriteLine(" You have deposited rs. " + money + " in ur child acc.");
                Console.WriteLine($"The balance of {name} is: " + balance1);
                Console.WriteLine("===================================================");
            }
            catch (AccountLimitExceeded e)
            {
                Console.WriteLine("account limit is 50000Rs." + e);
            }
        }

    }
    class function
    {
        string name;
        int withdraw;      
        public delegate void withdrawAmount(int bal);

        public void deduct(int money,int bal)
        {
            double prvs_total = bal;
            bal = bal - money;
            Console.WriteLine($"ATM limit exceeded.{name} Fine of INR 500 applicable.");
            Console.WriteLine($"Before deducting Balance is {prvs_total} & Total Balance amount in the account after deducting {money}  : " + bal);
            Console.WriteLine($"Thank You for visiting us.{name}");
            
        }
        public void fun2(int balance)
        {
            Console.Write("Enter Account Name :  ");
            name = Console.ReadLine();
            
            Console.Write("Enter Withdraw Amount :  ");
            withdraw = Convert.ToInt32(Console.ReadLine());
            if (withdraw <= balance)
            {
                balance = balance - withdraw;
                Console.WriteLine("\n----------------------------------------------\n");
                Console.WriteLine("Account-Holder Name : " + name);
                //Console.WriteLine("Account Number: " + account);
                Console.WriteLine("After Withdraw Amount balance is : INR" + balance);
            }
            else
                Console.WriteLine("\n\nWithdraw Amount does not Exist in your Account.");
        }
    }
}

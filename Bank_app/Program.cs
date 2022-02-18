using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app
{       
    class Program:function
    { 
        static void Main(string[] args)
        {
            //getCustData();
            int count = 0;
            Saving s = new Saving();
            Current c = new Current();
            child e = new child();
            Program p = new Program();
            Console.Write("++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("Enter Type of account Which u want to open: " + "\n Choose from below dropdown:\n");
            Boolean t = true;
            function a = new function();
            List<employee> em = new List<employee>();
            employee e1 = null;
            while (t)
            {
                Console.WriteLine("1.Savings Account \n2. Current Account \n3. Child Account\n4.Display Customer Details \n5.Save Customer Details in File\n6.Exit\n");
                Console.WriteLine("===================================================");
                Console.WriteLine("Enter ur choice");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Welcome to ur Savings account menu.");
                        Console.WriteLine("Your account limit is Rs. 100000");
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                        e1 = new employee();
                        e1 = e1.CreateCustomer(e1, choice, s.balance);
                        em.Add(e1);
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Choose 1.ATM  2.For exit");
                        int check = Convert.ToInt32(Console.ReadLine());
                        function k = new function();
                        if (check == 1)
                        {
                            char agn;
                            do
                            {

                                Console.WriteLine("WELCOME TO HDFC BANK ATM SERVICE\n");
                                Console.WriteLine("\nPress 1. for Deposit an Amount. \nPress 2. for Withdraw an Amount.");
                                Console.WriteLine("Press 3. Current Balance\n");
                                Console.WriteLine("***********************************\n\n");
                                Console.WriteLine("ENTER YOUR CHOICE : ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                switch (num)
                                {
                                    case 1:
                                        Console.WriteLine("Enter Deposit Amount :");
                                        count++;
                                        int money = Convert.ToInt32(Console.ReadLine());
                                        s.deposit(money);

                                        if (count >= 3)
                                        {
                                            k.deduct(500, s.balance);
                                            t = false;
                                            break;
                                        }
                                        break;
                                    case 2:
                                        count++;
                                        withdrawAmount del1 = new withdrawAmount(a.fun2);
                                        del1(s.balance);
                                        if (count >= 3)
                                        {
                                            k.deduct(500, s.balance);
                                            t = false;
                                            break;
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs : {0} ", s.balance);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Selection!!!");
                                        break;
                                }
                                Console.WriteLine("\nDo you want to continue this program? (y/n)");
                                agn = Convert.ToChar(Console.ReadLine());
                                //Console.WriteLine("===================================================");

                            } while (agn == 'y');
                           e1.balance = s.balance;
                            
                            

                            Console.WriteLine("===================================================");
                            continue;
                        }
                        else
                        {
                           // t = false;
                            continue;
                        }
                    case 2:
                        count = 0;
                        Console.WriteLine("Welcome to ur Current account menu.");
                        Console.WriteLine("Your account limit is Rs. 200000");
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                        e1 = new employee();
                        e1 = e1.CreateCustomer(e1, choice, c.balance);
                        em.Add(e1);
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Choose 1.ATM  2.For exit");
                        int check1 = Convert.ToInt32(Console.ReadLine());
                        function k1 = new function();
                        if (check1 == 1)
                        {
                            char agn;
                            do
                            {
                                Console.WriteLine("WELCOME TO HDFC BANK ATM SERVICE\n");

                                Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.\n ");
                                Console.WriteLine("Press 3. Current Balance\n");
                                Console.WriteLine("**********************************\n\n");
                                Console.WriteLine("ENTER YOUR CHOICE : ");

                                int num = Convert.ToInt32(Console.ReadLine());
                                switch (num)
                                {
                                    case 1:
                                        count++;
                                        Console.WriteLine("Enter Deposit Amount :");
                                        int money = Convert.ToInt32(Console.ReadLine());
                                        c.deposit(money);
                                        if (count >= 3)
                                        {
                                            k1.deduct(500, c.balance1);
                                            break;
                                        }
                                        
                                        break;
                                    case 2:
                                        count++;
                                        // Used an ** DELEGATE ** for calling method
                                        withdrawAmount del2 = new withdrawAmount(a.fun2);
                                        del2(c.balance1);
                                        if (count >= 3)
                                        {
                                            k1.deduct(500, c.balance1);
                                            break;
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs : {0} ", c.balance1);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Selection!!!");
                                        break;
                                }
                                Console.WriteLine("\nDo you want to continue this program? (y/n)");
                                agn = Convert.ToChar(Console.ReadLine());

                            } while (agn == 'y');
                            e1.balance = c.balance1;
                            Console.WriteLine("===================================================");
                            continue;
                        }
                        else
                        {
                            //t = false;
                            continue;
                        }
                    case 3:
                        Console.WriteLine("Welcome to ur Child account menu.");
                        Console.WriteLine("Your account limit is Rs. 50000");
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                        e1 = new employee();
                        e1 = e1.CreateCustomer(e1, choice, e.balance2);
                        em.Add(e1);
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Choose 1.ATM  2.For exit");
                        int check2 = Convert.ToInt32(Console.ReadLine());
                        function k2 = new function();
                        if (check2 == 1)
                        {
                            char agn;
                            do
                            {

                                Console.WriteLine("Please Select Any Function.");
                                Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.\n @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                                int num = Convert.ToInt32(Console.ReadLine());
                                switch (num)
                                {
                                    case 1:
                                        count++;
                                        Console.WriteLine("Enter Deposit Amount :");
                                        int money = Convert.ToInt32(Console.ReadLine());
                                        c.deposit(money);
                                        if (count >= 3)
                                        {
                                            k2.deduct(500, e.balance2);
                                            //t = false;
                                            break;
                                        }
                                        break;
                                    case 2:
                                        count++;
                                        k2.fun2(e.balance2);
                                        if (count >= 3)
                                        {
                                            k2.deduct(500, e.balance2);
                                            //t = false;
                                            break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Selection!!!");
                                        break;
                                }
                                Console.WriteLine("\nDo you want to continue this program? (y/n)");
                                agn = Convert.ToChar(Console.ReadLine());

                            } while (agn == 'y');
                            e1.balance = e.balance2;
                            Console.WriteLine("===================================================");
                            continue;
                        }
                        else
                        {
                            //t = false;
                            continue;
                        }
                    case 4:
                        //t = false;
                        Program1 m = new Program1();
                        m.getCustomerDetails(em);
                        continue;
                    case 6:
                        
                        break;
                    case 5:
                        Program1 z = new Program1();
                        z.SaveCustomerDetailsonFile(em);
                        break;
                    default:
                        Console.WriteLine("Wrong input taken");
                        break;
                }
                break;
            }
            Console.ReadKey();
        }
    }
}

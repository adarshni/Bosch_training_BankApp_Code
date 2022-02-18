using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_app
{
    public class employee
    {
        public employee CreateCustomer(employee c1, int Acc_type, int bal1)
        {

            String acc_type = "";
            Console.Write("\nEnter ur name: ");
            c1.name = Console.ReadLine();
            Console.Write("Enter your Gender: ");
            c1.Gender = Console.ReadLine();
            Console.Write("Enter ur address: ");
            c1.Address = Console.ReadLine();
            Console.Write("Enter ur age: ");
            c1.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ur Acc_id: ");
            c1.acc_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (Acc_type == 1)
            {
                acc_type = "Savings";
            }
            else if (Acc_type == 2)
            {
                acc_type = "Current";
            }
            else
            {
                acc_type = "Child";
            }
            c1.Acc_Type = acc_type;
            c1.balance = bal1;
            return c1;

        }
        public int acc_id
        {
            get; set;
        }
        public string name
        {
            get;
            set;
        }
        public string Acc_Type
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public int age
        {
            get;
            set;
        }
        public int balance
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }

    }

    class Program1
    {
        public void SaveCustomerDetailsonFile(List<employee> lst)// Here I am saving details of customers in a file First.txt.
        {
            string filepath = "C:\\First.txt";
            
                try
                {
                File.Create(filepath).Close();
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.Write(Environment.NewLine +"!!  Welcome To HDFC BANK Services  !!"+Environment.NewLine+"||****<<- Customer Details ->>****||"+Environment.NewLine+Environment.NewLine+
                        "||##################################################################################||"+Environment.NewLine+
                        "||Acc_ID ||  A/C Type  ||   A/C Name    ||  Age  ||  \tAddress\t  ||  Balance       ||"+Environment.NewLine+ "||##################################################################################||"
                     +Environment.NewLine   );
                    foreach(employee objAd in lst)
                    {
                        sw.Write("|| " +
                    +objAd.acc_id + "     ||  " +
                    objAd.Acc_Type + "   ||" + "\t" +
                    objAd.name + "" + "  ||  " + objAd.age + "   ||\t" + objAd.Address + "\t  ||\t " + objAd.balance + " \t    || \n" + Environment.NewLine);
                    }
                    sw.Close();
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
        }
       public void getCustomerDetails(List<employee> lst)
        {
            Console.WriteLine();
            Console.WriteLine("||###############################################################################################||");
            Console.WriteLine("||Acc_ID ||  A/C Type  ||   A/C Name    ||   Gender   ||  Age  ||     Address\t  ||  Balance    ||");
            Console.WriteLine("||###############################################################################################||");
            foreach (employee objAC in lst)
            {
                //int id = objAC.;
                Console.Write("|| " + 
                    + objAC.acc_id + "     ||  " +
                    objAC.Acc_Type + "   ||" + "    " +
                    objAC.name + "   " + "  ||    "+objAC.Gender+"    ||  " + objAC.age + "   ||\t" + objAC.Address + "\t  ||\t " + objAC.balance + " \t || "+ "");
                //Console.WriteLine("||********************************************************************************************************||");
                Console.WriteLine("\n||-----------------------------------------------------------------------------------------------||");
                
            }
            Console.WriteLine();



        }

    }
    }




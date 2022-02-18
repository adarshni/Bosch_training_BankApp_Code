using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app
{
    class customerdetails
    {
        public class Customer
        {
            public string name
            {
                get;
                set;
            }
            public int Acc_id
            {
                get;
                set;
            }
            public int age
            {
                get; set;
            }
            public string address
            {
                get;
                set;
            }
            public string Acc_type
            {
                get;
                set;
            }
            public int balance
            {
                get;
                set;
            }
        }
        public Customer Getlistdetails(Customer fetchvalues)
        {
            Customer cus1 = new Customer()
            {
                Acc_id= 101,
                name = "amit",
                Acc_type = "Savings",
                age = 20000,
                balance=2500,
                address="hgdgsh"

            };
            Customer cus2 = new Customer()
            {
                Acc_id = 101,
                name = "amit",
                Acc_type = "Savings",
                age = 20000,
                balance = 2500,
                address = "hgdgsh"

            };
            List<Customer> em = new List<Customer>();
            em.Add(cus1);
            em.Add(cus2);

            return fetchvalues;
        }
    }
}

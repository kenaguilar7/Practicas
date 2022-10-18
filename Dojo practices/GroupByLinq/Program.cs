using System;
using System.Collections.Generic;
using System.Linq; 

namespace GroupByLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = string.Empty; 

            for (int i = 0; i < 5; i++)
            {
               text = string.Concat(text, "hello "); 
            }
            Console.WriteLine(text); 
        /*
           var customers = GetCustomerTest(); 

            var sss = customers.GroupBy(t=> new {t.CustomerId}, p=> new {p.InvoiceId, p.InvoiceAmount}); 
            
            var pp = from n in customers group n by new {n.CustomerId} into g select g; 

            foreach (var item in sss)
            {
                var gg = item.ToList().First(); 
            }


            Console.WriteLine(sss); 
            */
        }

        public static List<Customer> GetCustomerTest(){
            return new List<Customer>(){
                new Customer(){CustomerId=1, InvoiceId= 1, InvoiceAmount= 100}, 
                new Customer(){CustomerId=1, InvoiceId= 2, InvoiceAmount= 100}, 
                new Customer(){CustomerId=2, InvoiceId= 3, InvoiceAmount= 100}, 
                new Customer(){CustomerId=2, InvoiceId= 4, InvoiceAmount= 100}, 
                new Customer(){CustomerId=2, InvoiceId= 5, InvoiceAmount= 100}, 
                new Customer(){CustomerId=2, InvoiceId= 6, InvoiceAmount= 100}, 
                new Customer(){CustomerId=3, InvoiceId= 7, InvoiceAmount= 100}, 
                new Customer(){CustomerId=4, InvoiceId= 8, InvoiceAmount= 100}, 
                new Customer(){CustomerId=4, InvoiceId= 9, InvoiceAmount= 100}, 
            }; 
        }
    }

    public class Customer {
        public int CustomerId { get; set; }
        public int InvoiceId { get; set; }
        public int InvoiceAmount { get; set; }
    }
}

using System;
using Liskov_Substitution.Library;

namespace Liskov_Substitution {
    class Program {
        static void Main (string[] args) {
            
            Manager accountingVP = new Manager ();

            accountingVP.FirstName = "Steve Aguilar";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate (4);

            IManager man = new Manager();
            IManager man1 = new CEO(); 
            
            IEmployee man2 = new CEO();  
            



            IManaged emp = new Manager();

            emp.FirstName = "Kenneth";
            emp.LastName = "Aguilar";
            emp.AssignManager (accountingVP);
            emp.CalculatePerHourRate (2);

            Console.WriteLine ($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine ();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Models;

namespace SKU
{
    class Program
    {
        static void Main(string[] args)
        {

            SimpleModel simpleModel = new SimpleModel(); 
            // simpleModel = null; 

            TestOperators(simpleModel); 
        }

        public static void TestOperators(SimpleModel simpleModel){
            
            var sss = simpleModel?.UserId; 

        }

        // public static void AccessTest(){
        // }
        // public static void TestDate()
        // {
        //     DateTime? date = new DateTime();
        //     Console.WriteLine(date);
        // }

        // public static void GroupByTest()
        // {
        //     // var list = new List<Product>();
        //     // list.Add(new Product(){ Parent = "Fruta", Category = "Papaya"});
        //     // list.Add(new Product(){Parent="Fruta",Category ="Melon"});
        //     // list.Add(new Product(){Parent="Fruta",Category ="Sandia"});
        //     // list.Add(new Product(){Parent="Verdura",Category ="Papa"});
        //     // list.Add(new Product(){Parent="Verdura",Category ="Platano"});

        //     // list.GroupBy(p => new { p.Parent, p.Category },
        //     //              StringComparer.InvariantCultureIgnoreCase);
        // }

        // public static void GuidTest()
        // {
        //     bool test = true;

        //     Console.WriteLine(Convert.ToInt16(test));

        //     for (int i = 0; i < 20; i++)
        //     {
        //         Guid obj = Guid.NewGuid();
        //         Console.WriteLine(obj.ToString());
        //     }
        // }

        // private string GetDebuggerDisplay()
        // {
        //     return ToString();
        // }
    }

    public class Product
    {
        public string Parent { get; set; }
        public string Category { get; set; }
    }
}

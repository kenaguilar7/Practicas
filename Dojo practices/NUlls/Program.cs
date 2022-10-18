using System;

namespace NUlls
{
    class Program
    {
        static void Main(string[] args)
        {
           // 20210812T220000Z

            var dd = DateTimeOffset.ParseExact("20210812T220000Z"); 
            Console.WriteLine(dd); 

        }
    }
}

using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNum = "+14804627796";
            string phoneFormat = "+0 000 000 ####";
            phoneNum = phoneNum.ToString(phoneFormat);
            Console.WriteLine(phoneNum); 
        }
    }
}

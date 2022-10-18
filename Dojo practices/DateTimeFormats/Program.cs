using System;
using System.Globalization;

namespace DateTimeFormats
{
    class Program
    {
        static void Main(string[] args)
        {
            TestRecurrenceExceptions(); 
            //    TestDates();  

        }

        public static void TestRecurrenceExceptions(){
            var myDateTime = "20220113T200000Z"; 

            var sysDateTime = DateTime.ParseExact(myDateTime,"yyyyMMddTHHmmssZ", CultureInfo.InvariantCulture );
            var newDate = sysDateTime.AddHours(-5); 

            var newStringDate = newDate.ToString("yyyyMMddTHHmmssZ"); 

        }

        public static void TestDates(){
            var myDateTime = "20210926T000001Z"; 
            // var myDateTime = "20210807T235959Z"; 

            // DateTime.ParseExact(lastUpdatedDate, "yyyyMMddTHHmmss:fffffff", cultureInfoProvider);
            var sysDateTime = DateTime.ParseExact(myDateTime,"yyyyMMddTHHmmssZ", CultureInfo.InvariantCulture );

            var dateAndTime = new DateTimeOffset(sysDateTime.Ticks, new TimeSpan(-7, 0, 0));

            Console.WriteLine(sysDateTime); 
            Console.WriteLine(sysDateTime.ToUniversalTime()); 
            Console.WriteLine(dateAndTime); 
            // var iuValue = ""; 
            // var dbValue = "";

            // var recurrentExceptionWithDifferences =
            //     (string.IsNullOrEmpty(iuValue) ? string.Empty : iuValue) !=
            //     dbValue;

            // //Set better name
            // var recurrenceExceptionChange = string.IsNullOrEmpty(iuValue) &&
            //                                 !string.IsNullOrEmpty(dbValue);

            // if (recurrentExceptionWithDifferences && !recurrenceExceptionChange)
            //     Console.WriteLine("inside if"); 
            // else
            //     Console.WriteLine("outside if"); 
            
            // var dd = "202101"; 
            // ParseToDateTimeWithFromMimFormat(dd); 

            var dateString = "202101"; 

            var stringlenght = dateString.Length; 
            var year = dateString.Substring(0, 4);
            var month = dateString.Substring(4, 2);
        }

        

        public static DateTime ParseToDateTimeWithFromMimFormat(string dateString)
        {
            var sss = dateString.Length; 
            var year = dateString.Substring(0, 4);
            var month = dateString.Substring(4, 4);

            return new DateTime(); 
        }
    }
}

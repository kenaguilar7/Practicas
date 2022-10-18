using System;

namespace staticTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "hola mundo"; 
            WithOutRef(text); 
            Console.WriteLine(text);
            

            var person = new Person(){Name="kenneth"};
            PersonWithOutRef(person); 
            Console.WriteLine(person.Name); 

        }

        static void WithRef(ref string text){
            text = text.ToUpper(); 
        }

        static void WithOutRef(string text){
            text = text.ToUpper(); 
        }

        static void PersonWithRef(ref Person person){
            person.Name = "withRef"; 
        }

        static void PersonWithOutRef(Person person){
            person.Name = "withOutRef"; 
        }
    }

    public class Person{
        public string Name { get; set; }
        public void TalkWithRef(ref string text){
            text = text.ToUpper(); 
        }

         public void TalkWithOutRef(string text){
            text = text.ToUpper(); 
        }
    }
}

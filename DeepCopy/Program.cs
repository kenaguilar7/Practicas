using System;

namespace DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class ClassesDto
    {
        public int Id { get; set; }
        public string StaffId { get; set; }
        public int LocationId { get; set; }
        public int Capacity { get; set; }
        public int WaitingQueue { get; set; }
        public DateTimeOffset From { get; set; }

        public DateTimeOffset To { get; set; }
        public string RecurrenceException { get; set; }
        public int RecurrenceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string RepeatInterval { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool isAllDay { get; set; }

        public DateTimeOffset OriginalDate { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using System;

namespace ConsoleApp1
{
    class FullName
    {
        public FullName(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            var fullName = new FullName("Takahiro", "Kojima");
            Console.WriteLine(fullName.FirstName);
            Console.WriteLine(fullName.LastName);
        }
    }
}

using System;

namespace CA.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customer = new Customer
            {
                City = "Ankara",
                FirstName = "Muhammed",
                Id = 1,
                LastName = "YILMAZ"
            };
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }


    class Customer : Person
    {
        public string City { get; set; }
    }


}

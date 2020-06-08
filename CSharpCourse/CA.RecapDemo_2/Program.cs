using System;

namespace CA.RecapDemo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.logger = new DatabaseLogger();
            customer.Add();

        }
    }

    class Customer
    {

        public ILogger logger { get; set; }
        public void Add()
        {
            /*DatabaseLogger logger = new DatabaseLogger();
            logger.Log();*/

            logger.Log();
            Console.WriteLine("Customer Added");
        }

    }

    class DatabaseLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class FileLogger: ILogger 
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }

        
    }

    interface ILogger
    {
        void Log();
    }
}

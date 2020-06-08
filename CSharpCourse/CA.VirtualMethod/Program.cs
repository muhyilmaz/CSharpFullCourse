using System;

namespace CA.VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("DB Added");
        }

        public virtual void Delete()
        {
            Console.WriteLine("DB Deleted");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("SQL Added");
            //base.Add();
        }

        public override void Delete()
        {
            Console.WriteLine("SQL Deleted");
        }
    }
}

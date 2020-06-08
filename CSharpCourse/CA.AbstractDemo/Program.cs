using System;

namespace CA.AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Database dbOracle = new Oracle();
            Database dbSql = new SqlServer();
            dbOracle.Delete();
            dbSql.Delete();

            dbOracle.Add();
            dbSql.Add();


        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("DB added");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SQL");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}

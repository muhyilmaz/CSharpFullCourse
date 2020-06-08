using System;

namespace CA.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerTest();

            CustomerTest_2();
        }

        private static void CustomerTest_2()
        {
            ICustomerDal[] customerDals = new ICustomerDal[2]
                        {
                new SqlServerCustormerDal(),
                new OracleServerCustormerDal()
                        };

            foreach (var item in customerDals)
            {
                item.Add();
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustormerDal());
            customerManager.Add(new OracleServerCustormerDal());
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }
}


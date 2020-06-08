using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Delete();
        void Update();
    }

    class SqlServerCustormerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Add");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Delete");
        }

        public void Update()
        {
            Console.WriteLine("SQL Update");
        }
    }

    class OracleServerCustormerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Add");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Delete");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Update");
        }
    }

    class CustomerManager
    {
        public void Add (ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }


}

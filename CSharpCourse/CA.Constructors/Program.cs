using System;

namespace CA.Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(1);
            CustomerManager customerManager2 = new CustomerManager(1);

        }
    }

    class CustomerManager
    {
        private int _id = 1;
        public CustomerManager(int id)
        {
            _id = id;
            List();
        }

        public CustomerManager()
        {
            List();
        }

        public void List()
        {
            Console.WriteLine("List {0} items",_id);
        }

        public void Add()
        {
            Console.WriteLine("List items");
        }
    }

    class Product
    {
        private int _id;
        private string _name;
        public int Id { get; set; }
        public string Name { get; set; }
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}

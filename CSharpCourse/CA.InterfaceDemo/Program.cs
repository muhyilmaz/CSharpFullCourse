using System;

namespace CA.InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(), new Worker(), new Robot()

            };

            foreach (var item in workers)
            {
                item.Work();
            }
        }

        interface IWorker
        {
            void Work();
            

        }

        interface IEat
        {
            void Eat();
        }

        interface IGetSalary
        {
            void GetSalary();
        }



        class Manager : IWorker , IEat, IGetSalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Worker : IWorker, IEat , IGetSalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                
            }
        }
    }
}

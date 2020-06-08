using System;
using System.Collections.Generic;

namespace CA.ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //ErrorTest_1();
            
            HandlingException(()=> {
                FindStudent();
            });
            Console.ReadLine();
        }

        private static void HandlingException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);

            }

        }

        private static void FindStudent()
        {
            List<string> students = new List<string> { "A", "B", "C" };
            if (!students.Contains("D"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
        }

        private static void ErrorTest_1()
        {
            try
            {
                string[] student = new string[3] { "M", "d", "g" };
                student[3] = "sd";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);

            }
        }
    }
}

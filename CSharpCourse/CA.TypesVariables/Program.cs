using System;

namespace CA.TypesVariables
{
    class Program
    {
        enum Days
        {
            Pazartesi,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar
        }
        static void Main(string[] args)
        {
            //Value Types 
            int number_1 = 10;

            if ((int)Days.Pazar == 6)
            {
                Console.WriteLine("ADAMMM");
            }
            Console.WriteLine("Hello World {0}", number_1);
            Console.ReadLine();
        }
    }
}

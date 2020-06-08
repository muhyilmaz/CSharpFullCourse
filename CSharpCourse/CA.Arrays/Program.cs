using System;

namespace CA.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayExmple();
        }

        private static void ArrayExmple()
        {
            string[] students = new string[3];

            students[0] = "Muhammed";
            students[1] = "Enes";
            students[2] = "Yılmaz";

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}

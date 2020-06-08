using System;

namespace CA.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Muhammed YILMAZ ";

            Print(sentence.EndsWith('ğ').ToString());
            Print(sentence.StartsWith('ğ').ToString());
            Print(sentence.IndexOf("ed").ToString());

        }

        private static void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}

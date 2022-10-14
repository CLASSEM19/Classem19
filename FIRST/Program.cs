using System;

namespace FIRST
{
    class Program
    {
        static void Main(string[] args)
        {
           calc();
        //    name();
        }
        public static void calc()
        {
            Console.WriteLine("Enter first num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second num");
            int num2 = int.Parse(Console.ReadLine());
            if(num1 > num2)
            {
                Console.WriteLine(num1 - num2);
                
            }
            else if(num1 < num2)
            {
                Console.WriteLine(num2 - num1);
            }
            else if(num1 == num2)
            {
                Console.WriteLine(num1 - num2);
            }
        }
        public static void name()
        {
            string word = "wonder ade bolu";
            char[] words = new char[15];
            words[0] = words.ToUpper();
            words[7] = words.ToUpper();
            words[11] = words.ToUpper();


            Console.WriteLine($"{words[0]}onder {words[7]}de {words[11]}ola");

            // char words = capiTalIze tHe titLe;
            
        }
    }
}

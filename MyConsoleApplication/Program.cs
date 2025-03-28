using System;

namespace MyConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator APP");
            Console.WriteLine("Enter first value:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Value:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Select your Choice 1 (or) 2 (or) 3 :\n 1, Addition\n 2, Substraction\n 3, Multiplication");
            int c;
            int result;
            Calculator obj = new Calculator();
            while (true)
            {
                c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    result = obj.Add(a, b);
                    
                    break;
                }
                else if (c == 2)
                {
                    result = obj.Sub(a, b);
                    break;
                }
                else if (c == 3)
                {
                    result = obj.Mul(a, b);
                    break;
                }
                else
                {
                    Console.WriteLine("Please select choice from the above options:");
                    
                }
            }
            Console.WriteLine("Answer is :" + result);


            Console.ReadLine();
        }

            
       
        
    }
}

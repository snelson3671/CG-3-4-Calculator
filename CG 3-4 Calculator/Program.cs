using System;

namespace CG_3_4_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sandra's calculator");
            
            Console.Write("Please type the operation you would like to perform. (+, -, *, or /)   ");
            string operation = Console.ReadLine();

            Console.Write("Now type the first number.  ");
            string x = Console.ReadLine();

            Console.Write("Now type the second number.  ");
            string y = Console.ReadLine();
            decimal c = 0;

            
            decimal a = Convert.ToDecimal(x);
            decimal b = Convert.ToDecimal(y);
            
            
            if (operation == "+")
                c = a + b;
            else if (operation == "-")
                c = a - b;
            else if (operation == "*")
                c = a * b;
            else if (operation == "/")
                c = a / b;
            else
                Console.WriteLine("I don't understand.  Please try again.");

            Console.WriteLine($"Your answer is {c}" );
            Console.ReadLine();
           
               


            
        }
    }
}

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

            decimal a = Convert.ToDecimal(x);
            decimal b = Convert.ToDecimal(y);

            string message = "";

            if (operation == "+")
                {
                    decimal addResult = a + b;
                    message = ($"Your answer is {addResult} ");
                }
            else if (operation == "-")
                {
                    decimal subResult = a - b;
                    message = ($"Your answer is {subResult}");
                }
            else if (operation == "*")
                {
                    decimal multResult = a * b;
                    message = ($"Your answer is {multResult}");
                }
            else if (operation == "/")
                {
                    decimal divResult = a / b;
                    message = ($"Your answer is {divResult}"); }
            else
                Console.WriteLine("I don't understand.  Please try again.");

            Console.WriteLine(message);
            Console.ReadLine();
            

            
        }
    }
}

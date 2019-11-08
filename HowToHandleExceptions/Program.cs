using System;

namespace HowToHandleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            double number3;

            try
            {
                Console.WriteLine("Enter number 1: ");
                number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number 2: ");
                number2 = int.Parse(Console.ReadLine());
                number3 = number1 / number2;
                Console.WriteLine(number3);
            } catch(DivideByZeroException e)
            {
                Console.WriteLine("You mustn't divide by zero!");
            }
            catch(FormatException e)
            {
                Console.WriteLine("You've used invalid format.");
            }

            

            

        }
    }
}

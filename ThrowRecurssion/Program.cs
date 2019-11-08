using System;

namespace ThrowRecurssion
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAge();
            Console.ReadLine();
        }

        public static void GetAge()
        {
            int yearOfBirth;
            Console.WriteLine("Enter your year of birth: ");
            try
            {
                yearOfBirth = int.Parse(Console.ReadLine());
                Console.WriteLine($"You are {2019 - yearOfBirth} years old");
            }
            catch
            {
                Console.WriteLine("Invalid date format");
                GetAge();
            }
        }
    }
}

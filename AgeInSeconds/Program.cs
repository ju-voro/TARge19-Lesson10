using System;
using System.Collections.Generic;
using System.Linq;

namespace AgeInSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name three colors");
            string userInput = Console.ReadLine();

            string[] colors = userInput.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> colorList = colors.ToList();
            foreach (string color in colorList)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("Add/Remove a color:");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "add")
            {
                Console.WriteLine("Enter a color to add: ");
                string userAnswerToAdd = Console.ReadLine();
                colorList.Add(userAnswerToAdd);
            } else if (userChoice.ToLower() == "remove")
            {
                Console.WriteLine("Enter a color to remove ");
                string userAnswerToRemove = Console.ReadLine();
                colorList.Remove(userAnswerToRemove);
            } else
            {
                Console.WriteLine("Unknown Command");
            }

            foreach (string color in colorList)
            {
                Console.WriteLine(color);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	/*Lab 4
	 * Task: Create the factorial of a number.
	 * The application will:
	 * 1. Prompt the user to enter an interger from 1 to 10.
	 * 2. Display the factorial of the number entered by the user.
	 * 3. Prompt the user to continue.
	 * Build specifications:
	 * 1. Use a for loop to calculate the factorial.
	 * 2. Assume the user will enter valid data.
	 * 3. Use the long type to store the factorial.
	*/ 
	class Program
	{
		static void Main(string[] args)
		{
			bool run = true;
			while (run == true)
			{
				Console.WriteLine("Welcome to the Factorial Calculator! \nPlease enter an interger from 1 to 10:");
				int input = Int32.Parse(Console.ReadLine());
				long factorial = 1;
				if (input >= 1 && input <= 10)
				{
					for (int i = 1; i <= input; i++)
					{
						factorial = factorial * i;
					}
					Console.WriteLine("The factorial of " + input + " is " + factorial + ".");
				}
				else
				{
					Console.WriteLine("I'm sorry, that's not an interger from 1-10, plesae try again.");
				}
				run = Continue();
			}
		}
		public static bool Continue()
		{
			Console.WriteLine("Do you wish to continue? y/n");
			string input = Console.ReadLine();
			input = input.ToLower();
			bool goOn;
			if (input == "y")
			{
				goOn = true;
			}
			else if (input == "n")
			{
				goOn = false;
			}
			else
			{
				Console.WriteLine("I don't understand that, let's try again");
				goOn = Continue();
			}
			return goOn;
		}
	}
}


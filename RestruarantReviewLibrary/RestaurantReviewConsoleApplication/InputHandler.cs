using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestruarantReviewLibrary;

namespace RestaurantReviewConsoleApplication
{
	public class InputHandler
	{
		public string input { get; set; }

		public InputHandler()
		{
			// Default constructor
		}

		// Determine if input is add or show
		public void ValInput(string input)
		{
			try	// try block to catch out of index operations on input string
			{
				if (input.Substring(0, 3) == "Add" || input.Substring(0, 3) == "add")
				{
					Console.Write("Adding new entry...\n");
					AddEntry(input);
				}
				else if (input.Substring(0, 4) == "Show" || input.Substring(0, 4) == "show")
				{
					if (input.Substring(0, 4) == "Show")    // check if by ID
					{
						Console.Write(input.Substring(5));
						Console.ReadKey();
					}

					else if (input.Substring(5) == "All")   // check to display all
					{
						Console.Write("Printing all ... ");
						Console.ReadKey();
					}

					else    // invalid input
					{
						Console.Write("Something went wrong.\n");
					}
				}
				else
				{
					// Invalid input
					Console.Write("\nInvalid Input\n" +
									"Press any key to return\n");
					Console.ReadKey();
				}
			}
			catch(IndexOutOfRangeException e)
			{
				Console.Write("I made a mistake, sorry about that\n." +
								"Press any key to continue...\n");
				Console.ReadKey();
			}
		}

		public void AddEntry(string input)
		{

		}

		public void Show(int id)
		{

		}

		public void Show(string all)
		{

		}
	}
}

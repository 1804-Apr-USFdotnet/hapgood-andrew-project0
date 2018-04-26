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
		public string _input { get; set; }

		public InputHandler()
		{

		}

		public void ValInput(string input)
		{
			Console.Write("Validating input ...\n");
			input = input.ToLower();	
			if (input == "add")
			{
				Add();
			}
			else if (input == "show")
			{
				Show();
			}
			else if (input == "search")
			{
				Search();
			}
			else
			{
				// Bad input
				Console.Write("Invalid input.\n"+
							  "Press any key to continue...");
				Console.ReadKey();
			}
		}

		public void Add()
		{
			// Creates new data member
			Console.Clear();
			Console.WriteLine("Name: ");
			string add_input = "";
			Restaurant restaurant = new Restaurant();
			while (add_input != "q" || add_input != "quit")
			{
				add_input = Console.ReadLine();
				restaurant.Name = add_input;

			}

		}

		public void Show()
		{
			Console.Write("Showing...");
			Console.ReadKey();
		}

		public void Search()
		{
			Console.Write("Searching...");
			Console.ReadKey();
		}
	}
}

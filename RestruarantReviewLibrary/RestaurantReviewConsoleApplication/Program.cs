using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestruarantReviewLibrary;

namespace RestaurantReviewConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			
			const string add_message = "Add Name, id, rating, review";
			const string dispaly_restaurant = "Show id# or all";
			const string display_top_3 = "Show top3";
			string message = $"Add Review: {add_message}\n" +
							 $"Display a Restaurant: {dispaly_restaurant}\n" +
							 $"Dispaly top 3: {display_top_3}\n" +
							 "To Quit: q or quit\n";

			string input;
			InputHandler handler = new InputHandler();

			// Mainloop
			while (true)
			{
				Console.Clear();
				Console.Write(message);
				input = Console.ReadLine();
				// parse inputs here	
				// test for quit
				if (input.Equals("q") || input.Equals("quit"))
				{
					break;
				}
				else
				{
					handler.ValInput(input);	// Validate input
				}
			}
		}
	}
}

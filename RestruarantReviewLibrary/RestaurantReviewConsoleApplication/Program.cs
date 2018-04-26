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

			string message; // welcome message
			message =   "|----------------------|\n"+
						"|Add Restuarant        |\n"+
						"|Add Review            |\n"+
						"|Show                  |\n"+
						"|Search                |\n"+
						"|Quit                  |\n"+
						"|----------------------|\n";

			string input;
			InputHandler handler = new InputHandler();

			// Mainloop
			while (true)
			{
				Console.Clear();
				Console.Write(message);
				input = Console.ReadLine();
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

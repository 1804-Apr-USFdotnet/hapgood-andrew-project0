using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalendrome
{
	class Program
	{
		static void Main(string[] args)
		{
			isPalendrome check = new isPalendrome();
			while (true)
			{
				Console.Write("Enter string or number: ");
				string input = Console.ReadLine();
				Console.Write(check.Display(input.ToLower()));
				Console.ReadKey();
				input = "";
			}
		}
	}

	public class isPalendrome
	{
		public string Display(string input)
		{
			List<int> remove = new List<int>();
			for (int i = input.Length -1; i >= 0; i--)
			{
				if (!(((int)input[i] > 48 && (int)input[i] < 57) || ((int)input[i] > 65 && (int)input[i] < 91) || ((int)input[i] > 97 && (int)input[i] < 123)))
				{
					remove.Add(i);
				}
			}

			foreach(int i in remove)
			{
				input.Remove(i);
			}
			string reverse = "";
			for (int i = input.Length - 1; i >= 0; i--)
			{
				reverse += input[i];
			}
			//Console.Write(input + "\n" + reverse);
			//Console.ReadKey();
			if (input == reverse)
			{
				return "Is Palendrome";
			}
			else
			{
				return "Is not Palendrome";
			}
		}
	}
}

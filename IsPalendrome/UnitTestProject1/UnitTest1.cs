using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using IsPalendrome;

namespace IsPalendromeTest
{
	[TestClass]
	public class isPalendromeTest
	{
		[TestMethod]
		public void DisplayTest()
		{
			// arange
			isPalendrome check = new isPalendrome();
			string test = "racecar";    // is palendrome

			// act
			string result = check.Display(test);


			// assert
			Assert.AreEqual(result, "Is Palendrome");

		}
	}
}

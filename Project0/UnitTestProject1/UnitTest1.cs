using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Project0;
using ClientLibrary;
using DataAccess;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			// 1. Test for invalid input
			// arranage
			Project0.InputHandler t = new Project0.InputHandler();

			//act
			string result = t.ValidateInput("blah blah blah");   // should return "Invalid input.\n"

			//assert
			Assert.AreEqual(result,"Invalid input.\n");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientLibrary.Interfaces;

using DataAccess;

namespace ClientLibrary
{
	public class Restuarant : IRestuarant
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public float Rating { get; set; }
		public List<Review> Reviews { get; set; }
	}

	public class Review : IReview
	{
		public string UserName { get; set; }
		public int Score { get; set; }
		public string Message { get; set; }
	}

	public class MethodHandler
	{
		public void AddRestuarant(string name, string address)
		{
			// accesss data layer, sends a restuarant object
			// to be inserted into database
			DataAccess.DataAccess restuarant_crud = new DataAccess.DataAccess();
			restuarant_crud.AddRestuarant(name, address);
		}

		public void AddReview(string _name, string _score, string _message, string _id)
		{
			// check to see if score can be *.ToInt()
			DataAccess.DataAccess restuaraunt_crud = new DataAccess.DataAccess();
			int i = 0, j = 0;
			try
			{
				i = Int32.Parse(_score);
				j = Int32.Parse(_id);
			}
			catch (Exception e)
			{
				Console.Write("\nBad Restuarant ID\n");
				return;
			}

			restuaraunt_crud.AddReview(_name,i,_message,j);
		}

		public List<string> GetAll()
		{
			// returns a list of all recorded restuarant names
			DataAccess.DataAccess restuarant_crud = new DataAccess.DataAccess();
			var restuarants_list = restuarant_crud.GetRestuarants();
			List<string> results = new List<string>();
			foreach (var temp in restuarants_list)
			{
				results.Add(temp.name);
			}
			return results;
		}

		public List<string> GetReviews(int id)
		{
			DataAccess.DataAccess restuarant_crud = new DataAccess.DataAccess();
			var reviews = restuarant_crud.GetReviews(id);
			List<string> result = new List<string>();
			foreach (var temp in reviews)
			{
				result.Add(temp.message);
			}
			return result;
		}
	}
}

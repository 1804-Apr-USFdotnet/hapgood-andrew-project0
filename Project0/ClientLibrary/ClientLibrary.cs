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

		public void AddReview(string _name, int _score, int _id, string _message)
		{
			// check to see if score can be *.ToInt()
			DataAccess.DataAccess restuaraunt_crud = new DataAccess.DataAccess();
			restuaraunt_crud.AddReview(_name,_score,_id, _message);
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
			UpdateDB();
			return result;
		}

		public void UpdateDB()
		{
			DataAccess.DataAccess restuarant_crud = new DataAccess.DataAccess();
			restuarant_crud.UpdateDB();
		}

		public List<ClientLibrary.MyData> GetRestuarantRating(int n)
		{
			DataAccess.DataAccess restuarant_crud = new DataAccess.DataAccess();
			var temp = restuarant_crud.ReturanRating();
			List<MyData> results = new List<MyData>();
			// sort temp
			temp.Sort((x,y) => y.rating.CompareTo(x.rating));
			for (int i = 0; i < n; i++)
			{
				MyData t = new MyData(temp[i].rating, temp[i].name);
				results.Add(t);
			}
			return results;
		}

		public List<string> Search(string input)
		{
			DataAccess.DataAccess restuarant_crud = new DataAccess.DataAccess();
			List<string> results = new List<string>();
			foreach (var t in restuarant_crud.GetRestuarants())
			{
				if (t.name.ToLower().Contains(input.ToLower()))
				{
					results.Add(t.name);
				}
			}
			return results;
		}
	}
	public struct MyData
	{
		public double rating { get; set; }
		public string name { get; set; }

		public MyData(double _rating, string _name)
		{
			rating = _rating;
			name = _name;
		}

	}
}

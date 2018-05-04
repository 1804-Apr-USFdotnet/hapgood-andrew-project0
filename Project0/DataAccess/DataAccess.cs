using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class DataAccess
	{
		project0Entities db = new project0Entities();

		// add restuarant
		public void AddRestuarant(string _name, string _address)
		{
			try
			{
				db.restuarants.Add(new restuarant
				{
					name = _name,
					rating = null,
					address = _address
				});
				db.SaveChanges();
			}
			catch (Exception e)
			{
				Console.Write("\nSomething went terribly wrong.\n");
			}
		}

		// return all restuarants
		public IEnumerable<restuarant> GetRestuarants()
		{
			return db.restuarants.ToList();
		}

		// add review
		public void AddReview(string _name, int _score, int _id, string _message)
		{
			try
			{
				review test = new review();
				test.name = _name;
				test.score = _score;
				test.message = _message;
				test.id = _id;
				db.reviews.Add(test);
				db.SaveChanges();
			}
			catch
			{
			}
		}

		// get all reviews for a given restuarant
		public IEnumerable<review>GetReviews(int _id)
		{
			// search to see if restuarant exist
			List<review> result = new List<review>();
			foreach (var temp in db.reviews.ToList())
			{
				if (temp.id == _id)
				{
					result.Add(temp);
				}
			}
			return result;
		}

		public void UpdateDB()
		{
			List<restuarant> rest_temp = db.restuarants.ToList();
			List<review> review_temp = db.reviews.ToList();
			List<int> k = new List<int>();
			double new_rating = 0;
			foreach(var i in rest_temp)
			{
				// get all reviews referencing temp.id
				foreach(var j in review_temp)
				{
					// get all relevant reviews
					if (j.id == i.id)
					{
						k.Add(j.score);
					}
				}
				// calculate new rating
				foreach (float l in k)
				{
					new_rating += l;
				}
				if (k.Count == 0)
				{
					i.rating = null;
				}
				else
				{
					new_rating = k.Sum() / k.Count;
					i.rating = (float)new_rating;
				}
				// update db
				db.SaveChanges();
				new_rating = 0;
				k.Clear();
			}
		}

		public List<MyDate> ReturanRating()
		{
			var temp = db.restuarants.ToList();
			List<MyDate> results = new List<MyDate>();
			// sort temp by rating
			temp.OrderBy(x => x.rating);
			foreach (var i in temp)
			{
				if (i.rating == null)
				{
					MyDate t = new MyDate(0, i.name);
					results.Add(t);
				}
				else
				{
					MyDate t = new MyDate((double)i.rating, i.name);
					results.Add(t);
				}
			}
			return results;
		}
	}

	public struct MyDate
	{
		public double rating { get; set; }
		public string name { get; set; }

		public MyDate(double _rating, string _name)
		{
			rating = _rating;
			name = _name;
		}
	}
}

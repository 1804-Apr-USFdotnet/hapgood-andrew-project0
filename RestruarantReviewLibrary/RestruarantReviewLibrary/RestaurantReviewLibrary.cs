using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestruarantReviewLibrary
{
    public class Restaurant : IRestuarant
	{
		public string Name { get; set; }
		public int Id { get; set; }
		public string Address { get; set; }
		public List<Review> RestuarantReview { get; set; }
		public float Rating { get; set; }

		// Constructors
		public Restaurant()
		{

		}

		public Restaurant(string Name, int Id, string Address)
		{
			// find new resturant
		}

		public void AddEntry(Review review)
		{ 
			this.RestuarantReview.Add(review);

		}

		public float GetAverageRating()
		{
			float temp = 0.0f;	// Default for NYG Pizza
			for (int i = 0; i < this.RestuarantReview.Count; i++)
			{
				temp += this.RestuarantReview[i].Score;
			}
			if (temp == 0)
			{
				// no reviews
				return temp;
			}
			return temp / this.RestuarantReview.Count; ;

		}

		public void SortBy(string[] options, ref List<Restaurant> t)
		{
			// possible options for sorting, ascend/descend by rating
			// add others here
			int ascen;
			if ("ascen" == options[0]){
				ascen = 1;
			}
			else
			{
				ascen = 0;
			}

			// try and make a generic sort for rating
			Restaurant temp = new Restaurant();
			for (int i = 0; i < t.Count - 1; i++)
			{
				for (int j = 1; j < t.Count; j++)
				{
					if ((ascen == 1) && (t[j].Rating > t[i].Rating))
					{
						temp = t[j];
						t[j] = t[i];
						t[i] = temp;
					}
				}
			}
		}

		public List<Restaurant> GetTopN(int n, List<Restaurant> t)
		{
			// resturns a list of Reviews

			string[] options  = { "ascen" };
			SortBy(options, ref t);

			if (t.Count > n)
			{
				// more restuarants then asked for
				return t;
			}
			else {
				List<Restaurant> temp = new List<Restaurant>();
				for (int i = 0; i < n; i++)
				{
					temp.Add(t[i]);
				}
				return temp;
			}
		}

		public string Display(string[] options)
		{
			// Default Display, show all
			return "placeholder";
		}
	}

	public class Review : IReview
	{
		public int Score { get; set; }
		public string ReviewerName { get; set;}
		public string ReviewMessage { get; set; }
	}
}

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
		public List<Review> RestuarantReview { get; set; }
	}

	public class Review : IReview
	{
		public int Score { get; set; }
		public string ReviewerName { get; set;}
		public string ReviewMessage { get; set; }
	}
}

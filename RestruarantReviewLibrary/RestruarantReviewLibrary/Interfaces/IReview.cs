using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestruarantReviewLibrary
{
	interface IReview
	{
		// Set of attribues and methods all Review objects should implement
		int Score { get; set; }				// 1-5 stars
		string ReviewerName { get; set; }
		string ReviewMessage { get; set; }
	}
}

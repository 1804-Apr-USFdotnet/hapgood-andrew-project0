using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestruarantReviewLibrary
{
	interface IRestuarant
	{
		// Set of attributes and methods all Restuarant objects 
		// should interface
		string Name { get; set; }			// Name of restuarant
		int Id { get; set; }                // Specifier for a restuarant

		List<Review> RestuarantReview { get; set; }

		
	}
}

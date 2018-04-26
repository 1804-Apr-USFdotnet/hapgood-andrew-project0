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
		string Address { get; set; }		// Location
		float Rating { get; set; }			// Average rating

		List<Review> RestuarantReview { get; set; }		// Reviews for restuarant

		void AddEntry(Review review);		// Serializes new entity
		float GetAverageRating();			// Averages out all scores and sets the new rating
		List<Restaurant> GetTopN(int n, List<Restaurant>t);	
		string Display(string[] options);		// shows all feilds based on options
	}
}

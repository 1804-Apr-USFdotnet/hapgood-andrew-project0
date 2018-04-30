using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLibrary.Interfaces
{
	public interface IRestuarant
	{
		string Name { get; set; }
		string Address { get; set; }
		float Rating { get; set; }
		List<Review> Reviews { get; set; }
	}
}

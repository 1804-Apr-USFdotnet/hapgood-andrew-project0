using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLibrary.Interfaces
{
	public interface IReview
	{
		string UserName { get; set; }
		int Score { get; set; }
		string Message { get; set; }
	}
}

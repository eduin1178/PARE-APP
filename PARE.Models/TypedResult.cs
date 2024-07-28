using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARE.Models
{
	public class TypedResult<T> : Result
	{
		public T Data { get; set; }
	}
}

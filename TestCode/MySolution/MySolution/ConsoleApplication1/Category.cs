using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Category
	{
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }

		public IList<Product> Products { get; set; }
	}
}

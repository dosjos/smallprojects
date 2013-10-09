using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Product
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public int Price { get; set; }

		public Category Category { get; set; }
	}
}

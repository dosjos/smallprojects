using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public class BirthYearChangedEventArgs : EventArgs
	{
		public int Original { get; set; }
		public int New { get; set; }

	}
}

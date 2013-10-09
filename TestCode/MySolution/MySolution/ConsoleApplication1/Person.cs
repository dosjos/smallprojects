using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Person : IFormattable, IComparable
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		private int _birthYear;
		public int BirthYear
		{
			get
			{
				return _birthYear;
			}
			set
			{
				if (value != _birthYear)
				{
					int origBirthYear = _birthYear;
					_birthYear = value;
					if (BirthYearChanged != null)
					{
						BirthYearChanged(this, new BirthYearChangedEventArgs
													{
														Original = origBirthYear,
														New = _birthYear
													});
					}
				}
			}
		}

		public event EventHandler<BirthYearChangedEventArgs> BirthYearChanged;

		private readonly DateTime _created;

		public string FullName
		{
			get { return string.Format("{0} {1}", FirstName, LastName); }
			set
			{
				string[] parts = value.Split(' ');
				FirstName = parts[0];
				LastName = parts[1];
			}
		}




		public Person()
		{
			_created = DateTime.Now;
		}

		public Person(string firstName, string lastName)
			: this(firstName, lastName, 0)
		{
		}

		public Person(string firstName, string lastName, int birthYear)
			: this()
		{
			FirstName = firstName;
			LastName = lastName;
			BirthYear = birthYear;
		}


		public int GetAge()
		{
			return 2012 - BirthYear;
		}

		public override string ToString()
		{
			return string.Format("{0} {1} ({2})", FirstName, LastName, GetAge());
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			switch (format)
			{
				case "fn": return FirstName;
				case "ln": return LastName;
				case "full": return FullName;
				case "age": return GetAge().ToString();
				case "birthyear": return BirthYear.ToString();
				default: return ToString();
			}
		}

		public int CompareTo(object obj)
		{
			Person other = (Person)obj;

			return this.LastName.CompareTo(other.LastName);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	/// <summary>
	/// Denne representerer ett tidspunkt
	/// </summary>
	public class Date
	{
		internal const int MonthsPrYear = 12;
		internal const int HoursPrDay = 24;
		internal const int MinutesPrHour = 60;

		/// <summary>
		/// Denne representerer året...
		/// </summary>
		public int Year { get; private set; }
		public int Month { get; private set; }
		public int Day { get; private set; }

		private int _minutesPastMidnight;

		//private int _hour;
		public int Hour
		{
			get { return _minutesPastMidnight / MinutesPrHour; }
			set
			{
				if (value < 0 || value >= HoursPrDay)
				{
					_minutesPastMidnight = Minute;
					return;
				}

				_minutesPastMidnight = value * 60 + Minute;
			}
		}

		//private int _minute;
		public int Minute
		{
			get { return _minutesPastMidnight % MinutesPrHour; }
			set
			{
				if (value < 0 || value >= MinutesPrHour)
				{
					_minutesPastMidnight = Hour * MinutesPrHour;
					return;
				}

				_minutesPastMidnight = value + Hour * MinutesPrHour;
			}
		}

		public Date(int year, int month, int day, int hour, int minute)
		{
			Year = year;
			Month = month;
			Day = day;
			Hour = hour;
			Minute = minute;
		}


		public Date(int month, int day, int hour, int minute)
			: this(DateTime.Now.Year, month, day, hour, minute)
		{
		}

		/// <summary>
		/// Lager en klone av Date-objektet du sender inn
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="original">Det er denne vi skal lage en kopi av</param>
		/// <returns>En kopi av det du sendte inn</returns>
		public static Date Clone(Date original)
		{
			Date copy = (Date)original.MemberwiseClone();
			return copy;
		}

		public string MakeString()
		{
			return string.Format("{2}/{1}-{0} {3}:{4:d2}", Year, Month, Day, Hour, Minute);
		}

		public bool MinutesPastMidnight(out int minutes)
		{
			if (Hour < 0 || Hour >= HoursPrDay || Minute < 0 || Minute >= MinutesPrHour)
			{
				minutes = 0;
				return false;
			}

			minutes = _minutesPastMidnight;
			return true;
		}

		public static Date AddYears(Date original, int yearsToAdd)
		{
			Date copy = Clone(original);

			copy.Year += yearsToAdd;

			return copy;
		}
	}
}

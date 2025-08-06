using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkirat2.GlobalClass
{
	public class clsDate
	{

		public static string Short(DateTime dateTime)
		{
			return dateTime.ToString("dd-MMM-yyyy");
		}

		public static DateTime ToDate(string D)
		{
			if (DateTime.TryParse(D, out DateTime NewDate))
			{
				return NewDate;
			}
			return DateTime.Now;
		}

		public static DateTime Now()
		{
			DateTime now = DateTime.Now;

			return new DateTime(now.Year, now.Month, now.Day);
		}

		public static string Hour()
		{
			return DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
		}
	}
}

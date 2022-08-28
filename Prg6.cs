using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class Prg6
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the Year");
			int year = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the Month");
			int month = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the Date");
			int day = int.Parse(Console.ReadLine());
			if (isValidDate(year, month, day) is true)
			{
				Console.WriteLine($"year = {year}, month = {month}, day = {day} is a valid date.");
			}
		}
		static bool isValidDate(int year, int month, int day)
		{
			if (month > 12)
			{
				Console.WriteLine($"year = {year}, month = {month}, day = {day} is an invalid date as the possible values for month is 1 to 12.");
				return false;
			}

			if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
			{
				if ((month == 2 )&& (day > 29))
				{
					Console.WriteLine($"year = {year}, month = {month}, day = {day} s an invalid date as the maximum days in February is 29 in the year {year}");
					return false;
				}
			}
			else
				if ((month == 2) && (day > 28))
			{
				Console.WriteLine($"year = {year}, month = {month}, day = {day} s an invalid date as the maximum days in February is 28 in the year {year}");
				return false;
			}

			if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 ) && day > 31)
			{
				Console.WriteLine($"year = {year}, month = {month}, day = {day} s an invalid date as the maximum days in {month} is 31 in the year {year}");
				return false;
			}
			else if ((month == 2 || month == 4 || month == 6 || month == 9 || month == 11 && day > 30))
			{
				Console.WriteLine($"year = {year}, month = {month}, day = {day} s an invalid date as the maximum days in {month} is 30 in the year {year}");
				return false;
			}
			return true;
		}
	}
}

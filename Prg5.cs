using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class Prg5
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the Principle Amount");
			double p = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter the Rate of Interset");
			double r = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter the Time Period (in years)");
			double t = double.Parse(Console.ReadLine());
			Console.WriteLine($"The Interset for the Amount {p} with at rate of {r} for a time period of {t} = {(p * r * t) / 100}");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class Prg7
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number");
			int n = int.Parse(Console.ReadLine());
			if (isPrimeNumber(n) is true)
			{
				Console.WriteLine($"The {n} is Prime");
			}
			else Console.WriteLine($"The {n} is not Prime");
		}
		static bool isPrimeNumber(int num)
		{
			int m = 0, i, flag = 0;
			m = num / 2;
			for (i = 2; i <= m; i++)
			{
				if (num % i == 0)
				{
					return false;
				}
			}
			if (flag == 0)
				return true;
			return false;
		}
	}
}

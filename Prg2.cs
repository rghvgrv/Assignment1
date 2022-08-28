using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class Prg2
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the Size of the Array");
			int c = int.Parse(Console.ReadLine());
			int[] oddeve = new int[c];
			AddNumber(oddeve);
			Solution(oddeve);
		}

		private static void Solution(int[] oddeve)
		{
			foreach (var item in oddeve)
			{
				if (item % 2 == 0) Console.WriteLine($"{item} is Even ");
				else Console.WriteLine($"{item} is Odd ");
			}
		}

		private static void AddNumber(int[] oddeve)
		{
			for (int i = 0; i < oddeve.Length; i++)
			{
				Console.WriteLine("Enter the no that is added to Array");
				oddeve[i] = int.Parse(Console.ReadLine());
			}
		}
	}
}

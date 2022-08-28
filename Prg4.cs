using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class Prg4
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the size of the Array");
			int size = int.Parse(Console.ReadLine());
			int[] arr = new int[size];
			for (int i = 0; i < size; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			sum0ddEven(arr);
		}
		private static void sum0ddEven(int[] arr)
		{
			int even = 0;
			int odd = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 == 0)
					even += arr[i];
				else odd += arr[i];
			}
			Console.WriteLine($"The Sum of Even Elements are {even} and the Sum of ODD Elements are {odd}");

		}
	}
}

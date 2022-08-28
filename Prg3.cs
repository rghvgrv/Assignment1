using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class Prg3
	{
		static void Main(string[] args)
		{
			OperationOfNumber();
		}

		private static void OperationOfNumber()
		{
			bool n = true;
			do
			{
				Console.WriteLine("Enter the First Number");
				double value1 = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter the Second Number");
				double value2 = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter the Operations\n1.+\n2.-\n3.x\n4./\n5.STOP\n");
				var choice = Console.ReadLine();
				if (choice == "1")
					Console.WriteLine($"The + operation results : {value1 + value2}");
				else if (choice == "2")
					Console.WriteLine($"The - operation results : {value1 - value2}");
				else if (choice == "3")
					Console.WriteLine($"The X operation results : {value1 * value2}");
				else if (choice == "4")
					Console.WriteLine($"The / operation results : {value1 / value2}");
				else if (choice == "5")
					n = false;
			} while (n == true);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	class Prg9
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the String");
			string str = Console.ReadLine();
			string ReverseStr = reverseByWords(str);
			Console.WriteLine(ReverseStr);
		}

		private static string reverseByWords(string str)
		{
			string[] result = str.Split(' ');
			Array.Reverse(result);
			string reverseResult = "";
			foreach (string item in result)
			{
				//Console.WriteLine(item);
				reverseResult += item + " ";
			}
			return reverseResult;
		}
	}
}

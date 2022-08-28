using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	abstract class Account
	{
		public int AccountNo { get; set; }
		public string HolderName { get; set; }
		public double Balance { get; set; }
		public void Credit(double amount) => Balance += amount;

		public void Debit(double amount)
		{
			if (Balance < amount)
			{
				throw new Exception("Insufficient funds!!!");
			}
			Balance -= amount;
		}

		public abstract void CalculateInterest();

	}

	class SBAccount : Account
	{
		public override void CalculateInterest()
		{
			double principle = Balance;
			double rate = 0.065;
			double term = 0.5;

			var interest = principle * rate * term;
			Credit(interest);
		}
	}
	class FDAccount : Account
	{
		public override void CalculateInterest()
		{
			double principle = Balance;
			double rate = 0.05;
			double term = 0.5;

			var interest = principle * rate * term;
			Credit(interest);
		}
	}
	class RDAccount : Account
	{
		public override void CalculateInterest()
		{
			double principle = Balance;
			double rate = 0.015;
			double term = 0.5;

			var interest = principle * rate * term;
			Credit(interest);
		}
	}
	static class AccountFactory
	{
		public static Account CreateAccount(string accType)
		{
			if (accType.ToLower() == "saving normal")
				return new SBAccount();
			else if (accType.ToLower() == "fd")
				return new FDAccount();
			else return new RDAccount();
		}
	}
	class Prg12
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the type of account as Saving, FD,RD");
			string accountType = Console.ReadLine();
			Account acc = AccountFactory.CreateAccount(accountType);
			Console.WriteLine("Enter The Account No. ");
			acc.AccountNo = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter The Account Holder Name ");
			acc.HolderName = Console.ReadLine() ;
			Console.WriteLine("Enter The Account Balance ");
			acc.Balance = int.Parse(Console.ReadLine());
			acc.CalculateInterest();
			Console.WriteLine("The Current Balance of " + char.ToUpper(accountType[0]) + accountType.Substring(1) + " account is : " + acc.Balance);
		}
		
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
	namespace Entities
	{
		class Customer
		{
			public int CustomerId { get; set; }
			public string CustomerName { get; set; }
			public string CustomerAddress { get; set; }
			public double CustomerPhone { get; set; }
		}
	}
	namespace Repository
	{
		using Entities;
		class CustomerRepo
		{
			public CustomerRepo(int size) //constructor
			{
				_Customers = new Customer[size];
			}
			private Customer[] _Customers = null; //null for reference types

			public void AddNewCustomer(Customer Customer)
			{
				//find the first occurance of null in the array
				for (int i = 0; i < _Customers.Length; i++)
				{
					if (_Customers[i] == null)
					{
						_Customers[i] = new Customer
						{
							CustomerId = Customer.CustomerId,
							CustomerName = Customer.CustomerName,
							CustomerAddress = Customer.CustomerAddress,
							CustomerPhone = Customer.CustomerPhone,
						};
						return;
					}
					else continue;
				}
				throw new Exception("No further Customers can be added here!!!");
			}

			public void UpdateCustomer(int id, Customer Customer)
			{
				//find the first occurance of null in the array
				for (int i = 0; i < _Customers.Length; i++)
				{
					if (_Customers[i] != null && _Customers[i].CustomerId == id)
					{
						_Customers[i] = new Customer
						{
							CustomerId = Customer.CustomerId,
							CustomerName = Customer.CustomerName,
							CustomerAddress = Customer.CustomerAddress,
							CustomerPhone = Customer.CustomerPhone,
						};
						return;
					}
					else continue;
				}
				throw new Exception("No Customer was found to Update!!!");
			}

			public void DeleteCustomer(int id)
			{
				for (int i = 0; i < _Customers.Length; i++)
				{
					if (_Customers[i] != null && _Customers[i].CustomerId == id)
					{ 
						_Customers[i] = null;
						return;
					}
				}
			}

			public Customer FindCustomer(int id)
			{
				foreach (Customer Customer in _Customers)
				{
					if (Customer.CustomerId == id)
						return Customer;
				}
				throw new Exception("No Customer was found by id " + id);
			}

			public Customer FindCustomer(string address)
			{
				foreach (Customer Customer in _Customers)
				{
					if (Customer.CustomerName.Equals(address))
						return Customer;
				}
				throw new Exception("No Customer was found by id " + address);

			}

			public void ViewCustomer()
			{
				Console.WriteLine(_Customers);
			}

		}
	}
	namespace UserInterface
	{
		using Entities;
		/// <summary>
		/// Helper class to take inputs from the User based on the questions asked.
		/// </summary>
		class Util
		{
			public static string GetString(string question)
			{
				Console.WriteLine(question);
				return Console.ReadLine();
			}

			public static int GetNumber(string question)
			{
				return int.Parse(GetString(question));
			}
			public static short GetShortNumber(string question) => short.Parse(GetString(question));

			public static double GetDoubleNumber(string question) => double.Parse(GetString(question));
		}

		class Prg11
		{
			private static Repository.CustomerRepo repo = null;
			const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~Customer REPOSTORE MANAGER~~~~~~~~~~~~~~~~~~~~~~~\nTO ADD NEW Customer------------>PRESS N\nTO UPDATE Customer------------->PRESS U\nTO DELETE A Customer----------->PRESS D\nTO FIND BY ID-------------->PRESS F\nPS: ANY OTHER KEY IS EXIT.............................................";
			static void Main(string[] args)
			{
				int size = Util.GetNumber("Enter the no of Customers in your store");
				repo = new Repository.CustomerRepo(size);
				var processing = true;
				do
				{
					string choice = Util.GetString(menu);
					processing = processMenu(choice);
				} while (processing);
			}

			private static bool processMenu(string choice)
			{
				switch (choice)
				{
					case "N"://for adding
						addingCustomerFeature();
						break;
					case "D"://for deleting
						deletingCustomerFeature();
						break;
					case "U"://for updating
						updatingCustomerFeature();
						break;
					case "F"://finding by id
						findingByIdFeature();
						break;
					default:
						return false;
				}
				return true;
			}

			private static void viewAllCustomer()
			{
				Console.WriteLine("The All Customers in the Repo are : -");
				Console.WriteLine("---------------------------------");
				repo.ViewCustomer();
			}

			private static void findingByIdFeature()
			{
				//take id from the user
				int id = Util.GetNumber("Enter the Id of the Customer to find");
				//call the repo function
				var foundCustomer = repo.FindCustomer(id);
				if (foundCustomer != null)
				{
					//display the Customer details 
					Console.WriteLine($"The Name of the Customer is {foundCustomer.CustomerName} whose address is {foundCustomer.CustomerAddress} have Phone Number {foundCustomer.CustomerPhone} and with an ID {foundCustomer.CustomerId}");
				}
				else
				{
					Console.WriteLine("Customer not found to display!!!!");
				}
			}

			private static void updatingCustomerFeature()
			{
				//take inputs from the user
				var cus = createCustomer();
				//call the add method of the repo and pass the Customer into it. 
				repo.UpdateCustomer(cus.CustomerId, cus);
				//display the message
				Console.WriteLine("Customer updated successfully");
			}

			private static Customer createCustomer()
			{
				int id = Util.GetNumber("Enter the Id of the Customer ");
				string name = Util.GetString("Enter the name of Customer ");
				string address = Util.GetString("Enter the address of Customer ");
				double phone = Util.GetDoubleNumber("Enter the Phone no of the Customer ");
				Customer cus = new Customer
				{
					CustomerId = id,
					CustomerName = name,
					CustomerAddress = address,
					CustomerPhone = phone,
				};
				return cus;
			}
			private static void deletingCustomerFeature()
			{
				//Ask the user to enter the id of the Customer
				int id = Util.GetNumber("Enter the Id of the Customer to delete");
				//call the Repo's function to delete
				repo.DeleteCustomer(id);
				//display the message
				Console.WriteLine("Customer deleted Successfully");
			}

			private static void addingCustomerFeature()
			{
				//take inputs from the user
				Customer cus = createCustomer();
				//call the add method of the repo and pass the Customer into it. 
				repo.AddNewCustomer(cus);
				//display the message
				Console.WriteLine("Customer added successfully");
			}
		}
	}
}

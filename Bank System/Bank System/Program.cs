﻿using Bank_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hi, in my system");
			while (true)
			{
				Console.WriteLine("Click (1) admin      Click (2) user      Click (Q)  exit");
				string choice = Console.ReadLine();
				if (choice == "Q" || choice == "q")
				{
					break;
				}
				else if (choice == "1")
				{
					Employee employee = new Employee();
					while (true)
					{
						Console.WriteLine("Click (1) register     Click (Q , q) exit");
						choice = Console.ReadLine();
						if (choice == "1")
						{
							employee.register();
							break;
						}
						else if (choice == "Q" || choice == "q")
						{
							break;
						}
						else
						{
							Console.WriteLine("invalide input");
							break;
						}
					}

					while (true)
					{
						Console.WriteLine("Enter your email please ?");
						string tempEmail = Console.ReadLine();
						Console.WriteLine("Enter your password please ?");
						string tempPassword = Console.ReadLine();
						Console.WriteLine("Enter Show to show data ?");
						choice = Console.ReadLine();
						if (tempEmail == employee.EMAIL && tempPassword == employee.PASSWORD)
						{
							Console.WriteLine("Hi, " + employee.NAME);
						}
						else if (choice == "show" || choice == "Show")
						{
							break;
						}
						else
						{
							Console.WriteLine("Invalid password or email");
						}
					}

					Random random = new Random();
					employee.ID = random.Next(10000, 10000000);
					Console.WriteLine("*********************** Employee data ************************");
					Console.WriteLine($"Employee id : {employee.ID}");
					Console.WriteLine($"Employee name : {employee.NAME}");
					Console.WriteLine($"Employee age : {employee.AGE}");
					Console.WriteLine($"Employee email : {employee.EMAIL}");
					Console.WriteLine($"Employee password : {employee.PASSWORD}");

					while (true)
					{
						Console.WriteLine("Click (1) Veiw number of customer     Click ( q , Q) to exit");
						choice = Console.ReadLine();
						if (choice == "1")
						{
							employee.ViewNumberOfCustomer();
						}
						else if (choice == "Q" || choice == "q")
						{
							break;
						}
						else
						{
							Console.WriteLine("Invalid Input");
						}
					}
				}

				else if (choice == "2")
				{
					Customer customer = new Customer();
					while (true)
					{
						Console.WriteLine("Click (1) register Click ( q ,Q ) exit ");
						choice = Console.ReadLine();
						if (choice == "1")
						{
							customer.register();
						}
						else if (choice == "q" || choice == "Q")
						{
							break;
						}
						else
						{
							Console.WriteLine("Invalid input");
						}
					}

					Console.WriteLine("Logging in system your data: ?");
					while (true)
					{
						Console.WriteLine("Enter your email please : ?");
						string logemail = Console.ReadLine();
						Console.WriteLine("Enter your password please :?");
						string logpass = Console.ReadLine();
						Console.WriteLine("do you want to exite enter( Q , q ): ?");
						choice = Console.ReadLine();
						if (logemail == customer.EMAIL && logpass == customer.PASSWORD)
						{
							Console.WriteLine("Hi, " + customer.NAME);
							break;
						}
						else if (choice == "Q" || choice == "q")
						{
							break;
						}
						else
						{
							Console.WriteLine("Invalid password or email");
						}
					}

					Random random = new Random();
					customer.ID = random.Next(100000000, 999999999);
					Console.WriteLine("****************************\nname : " + customer.NAME +
						"\n****************************\nage : " + customer.AGE + "\n****************************\nemail : " + customer.EMAIL +
						"\n****************************\npassword : " + customer.PASSWORD + "\n****************************\nbalance : " + customer.BANALACE);


					while (true)
					{
						Console.WriteLine("Click (1) deposit ------ Click (2) withdraw ------ Click (3) show data ------ Click (4) exit");
						choice = Console.ReadLine();
						if (choice == "1")
						{
							customer.deposit();
							Console.WriteLine("Your balance : " + customer.BANALACE);
						}
						else if (choice == "2")
						{
							customer.withdraw();
							Console.WriteLine("Your balance : " + customer.BANALACE);
						}
						else if (choice == "3")
						{
							Console.WriteLine("****************************\nname : " + customer.NAME +
						  "\n****************************\nage : " + customer.AGE + "\n****************************\nemail : " + customer.EMAIL +
						  "\n****************************\npassword : " + customer.PASSWORD + "\n****************************\nbalance : " + customer.BANALACE);
						}
						else if (choice == "4")
						{
							break;
						}
						else
						{
							Console.WriteLine("Invalide input");
						}
					}

				}
				else
				{
					Console.WriteLine("invalid choice");
				}
			}
		}
	}
}

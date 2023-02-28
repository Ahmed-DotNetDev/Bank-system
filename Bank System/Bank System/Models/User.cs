using Bank_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bank_System
{
	public abstract class User
	{
		protected int id;
		protected string name;
		protected string email;
		protected string password;
		protected int age;
		public abstract void register();

		public void ViewNumberOfCustomer()
		{
			Console.WriteLine($"The number of customer sign in ('{Customer.counter}')");
		}

	}
}

using System;

namespace Bank_System.Models
{
	/// <summary>
	/// This class used as a services to calculate balance money through 2 mehtods deposit and withdraw
	/// </summary>
	public class  MoneyCustomerServices:Customer
	{
		public new double deposit()
		{
			Console.WriteLine($"your balance now ('{balance}$') Enter The amount you want to add: ? ");
			double AddingMoney = Convert.ToInt32(Console.ReadLine());
			balance += AddingMoney;
			return balance;
		}

		public new double withdraw()
		{
			Console.WriteLine($"your balance now ('{balance}$') Enter The amount you want to pull: ? ");
			double PullMoney = Convert.ToInt32(Console.ReadLine());
			balance -= PullMoney;
			return balance;
		}

	}
}

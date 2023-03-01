using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Models
{
	public class Customer : User
	{
		protected static double balance;
		public static int counter;

		public int ID { get => id; set => id = value; }
		public string NAME { get => name; set => name = value; }
		public string EMAIL { get => email; set => email = value; }
		public string PASSWORD { get => password; set => password = value; }
		public int AGE { get => age; set => age = value; }

        public double BANALACE { get => balance; set => balance = value; }


		/// <summary>
		/// This constructor count the number of customer
		/// </summary>
		public  Customer() => counter++;

		/// <summary>
		/// This method is used to register customer  Name:(string) Age:(int) Email:(string) Password:(string)
		/// </summary>
		public override void register()
		{
            Console.WriteLine("Enter Your Name Please: ? ");
			name = Console.ReadLine();
            Console.WriteLine("Enter Your Age Please: ? ");
			age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Your Email Please: ? ");
			email = Console.ReadLine();
			Console.WriteLine("Enter Your Password Please: ? ");
			password = Console.ReadLine();
        }
		/// <summary>
		/// This method is called deposit implementation the amount of money
		/// </summary>
		public void deposit()
		{
			MoneyCustomerServices moneyServices = new MoneyCustomerServices();
			moneyServices.deposit();
        }
		/// <summary>
		/// This method is called withdraw implementation the amount of money
		/// </summary>
		public void withdraw()
		{
			MoneyCustomerServices moneyServices = new MoneyCustomerServices();
			moneyServices.withdraw();
		}
	}
}

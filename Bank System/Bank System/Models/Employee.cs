using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Models
{
	public class Employee : User
	{
		private new readonly string email=@"ahmed@gmail.com";
		private new readonly string password="ahmed@";
		public static int counter=0;
		public int ID { get => id; set => id = value; }
		public string NAME { get=>name;  set => name=value; }
		public string EMAIL { get => email;}
		public string PASSWORD { get => password;}
		public int AGE { get => age; set => age = value; }


		/// <summary>
		/// This method is used to register user name:(string) and age:(int) 
		/// </summary>
		public override void register()
		{
			
            Console.WriteLine("Enter Your Name Please: ? ");
			name = Console.ReadLine();
            Console.WriteLine("Enter Your Age Please: ? ");
			age = Convert.ToInt32(Console.ReadLine());
        }
	}

}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MonthsOfYr_Enum_14 {
	/// <summary>
	/// Enumeration with each month assigned a number
	/// </summary>
	enum MonthsOfYr { Jan = 1, Feb = 2, Mar = 3, Apr = 4, May = 5, Jun = 6, Jul = 7, Aug = 8, Sep = 9, Oct = 10, Nov = 11, Dec = 12 };
	class Program {
		static void Main(string[] args) {

			// Get month number
			Console.WriteLine("Enter a number between 1 & 12: ");
			string numberStr = Console.ReadLine();
			int number = Convert.ToInt32(numberStr);

			// Check for valid range
			if(number > 0 && number <= 12) {
				Console.WriteLine();
				MonthsOfYr month = (MonthsOfYr)number;
				Console.WriteLine($"The month of the year is {month}.");
			}
			else {
				Console.WriteLine();
				Console.WriteLine("That is not a valid number! Too Bad! So Sad! You are out of tries !!! ");
			}


			//if(number < 1 || number > 12) {
			//	Console.WriteLine();
			//	Console.WriteLine("That is not a valid number! Enter a number between 1 & 12: ");
			//	numberStr = Console.ReadLine();
			//	number = Convert.ToInt16(numberStr);
			//	if(number < 1 && number > 12) {
			//		Console.WriteLine();
			//		Console.WriteLine("That is not a valid number! Too Bad! So Sad! You are out of tries !!! ");

			//	}
			//	else {
			//		MonthsOfYr month = (MonthsOfYr)number;
			//		Console.WriteLine("The month of the year is {month}.");
			//	}
			//	// Check for valid range
			//	if(number < 1 && number > 12) {
			//		Console.WriteLine();
			//		Console.WriteLine("That is not a valid number! Enter a number between 1 & 12: ");
			//		numberStr = Console.ReadLine();
			//		number = Convert.ToInt16(numberStr);
			//		if(number < 1 && number > 12) {
			//			Console.WriteLine();
			//			Console.WriteLine("That is not a valid number! Too Bad! So Sad! You are out of tries !!! ");

			//		}
			//		else {
			//			month = (MonthsOfYr)number;
			//			Console.WriteLine("The month of the year is {month}.");

			//		}


			//	}
			//}
			Console.ReadKey();
		}
	}
}

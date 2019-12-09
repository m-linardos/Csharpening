using System;

namespace CsPG_10 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Even or Odd");
			Console.WriteLine("Please enter an integer: ");
			string numberString = Console.ReadLine();
			int number = Convert.ToInt16(numberString);
			
			if(number%2==0) {
				Console.WriteLine($"The number {number} is EVEN.");
			}
			else {
				Console.WriteLine($"The number {number} is ODD.");
			}
			Console.ReadKey();
		}
	}
}

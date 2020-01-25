using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPG_12_FizzBuzz {
	class Program {
		static void Main(string[] args) {
			int num = 0;
			Console.WriteLine("FizzBuzz");
			Console.WriteLine();
			// Loop through #s 1-100
			for(num = 1; num < 101; num++) 
			{
				// Print FizzBuzz if multiple of both 3 & 5
				if(num % 3 == 0 && num % 5 == 0) {
					Console.Write("FizzBuzz");
				}
				// Print Fizz if multiple of 3
				else if(num % 3 == 0) {
					Console.Write("Fizz");
				 }
				//  Print Buzz if multiple of 5
				else if(num % 5 == 0) {
					Console.Write("Buzz");
				 }
				//  Otherwise print the number 'num'
				else {
					Console.Write(num);
				 }
				Console.Write(" ");
			}
			Console.ReadKey();

		}
	}
}

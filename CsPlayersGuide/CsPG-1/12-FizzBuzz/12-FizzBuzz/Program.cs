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
				if(num % 3 == 0) {
					Console.Write("Fizz");						
				}
				 else if(num % 5 == 0) {
					Console.Write("Buzz");
				 }
				 else if(num % 3 == 0 && num % 5 == 0) {
					Console.Write("FizzBuzz");
				 }
				 else {
					Console.Write(num);
				 }
				Console.Write(" ");
			}
			Console.ReadKey();

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReversingArray_15 {
	class Program {
		/// <summary>
		/// Generates numbers, reverses order & prints array
		/// </summary>
		/// <param name="args">The arguments.</param>
		static void Main(string[] args) {
			Console.WriteLine();
			Console.WriteLine("Reversing Array");
			Console.WriteLine();

			int[] numbers = GenerateNumbers();
			Reverse(numbers);
			PrintNumbers(numbers);

			Console.ReadKey();
		}
		
		/// <summary>
		/// Generates Array of 10 #s
		/// </summary> 
		static int[] GenerateNumbers() {
			int[] numbers = new int[10];
			for(int i = 0; i < 10; i++) {
				numbers[i] = i + 1;         // Adding 1 to index so that list starts with 1	  				
			}
			return numbers;
		}
		/// <summary>
		/// Prints array
		/// </summary>
		/// <param name="numbers"></param>	 		
		static void PrintNumbers(int[] numbers) {
		for(int i = 0; i < numbers.Length; i++)	{
			Console.Write(numbers[i] + " ");
			}
			Console.WriteLine();
		}
		

		// Reverse Array
		static void Reverse(int[] numbers) {
			int iFirst = 0;
			int iLast = numbers.Length - 1;
		while(iFirst < iLast) {
				// We need to swap the index numbers, using a temporary variable for the transition
				int iTemp = numbers[iFirst];
				numbers[iFirst] = numbers[iLast];
				numbers[iLast] = iTemp;

				// Continue to next pair
				iFirst++;
				iLast--;
		}	
		
		
		}
	
		
	}
}

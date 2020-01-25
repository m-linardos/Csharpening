using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray_13 {
	class Program {
		static void Main(string[] args) {
		// Create array
			string[] family = new[] { "Mom", "Dad", "Me", "Caitlin", "Joey", "Petey", "Phill", "Sammy", "John", "Brian", "Danny", "Susan", "Kristen", "Craig" };
			// Copy value from family array to a copy
			string[] familyCopy = new string[family.Length];
			for(int i = 0; i < family.Length; i++) {
				familyCopy[i] = family[i];
			}	 

			// Print original array
			for(int i = 0; i < family.Length; i++) {
				Console.Write(family[i] + " ");
			}
			Console.WriteLine();

			// Print copy
			for(int i = 0; i < familyCopy.Length; i++)	{
				Console.WriteLine(familyCopy[i] + " ");
			}
			Console.WriteLine();

			// Print the number of family members
			int numberOfMembers = family.Length;
			Console.WriteLine($"There are {numberOfMembers}	family members.");
			Console.WriteLine();
			

			Console.ReadKey();

		}
	}
}

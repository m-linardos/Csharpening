using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPG_12_Pyramid {
	class Program {
		static void Main(string[] args) {

			Console.WriteLine("Pyramid");

			// Add a line
			for(int row = 0; row < 5; row++) {
				// Print spaces
				for(int space = 0; space < 5 - row - 1; space++) {
					Console.Write(" ");
				}
				// Print stars
				for(int star = 0; star < row * 2 + 1; star++) {
					Console.Write("*");
				}

				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRolling_17 {
	class Program {
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		/// <param name="args">The arguments.</param>
		static void Main(string[] args) {
			Random rand = new Random();

			// Get # dice to roll
			Console.WriteLine("Enter how many dice to roll: ");
			string diceNumbStr = Console.ReadLine();
			int diceNumb = Convert.ToInt32(diceNumbStr);

			// 	Get total of each dice roll
			int rollTotal = 0;
			for(int index = 0; index < diceNumb; index++) {
				int roll = rand.Next(6) + 1;              // Use random class to get Random dice roll
				rollTotal += roll;

			// Print each roll
			if(index != diceNumb - 1) {
				Console.Write(roll + "+");
			}
			else {
				Console.Write(roll);
			}
		}
			Console.WriteLine();

			// Print total of dices roll
			Console.WriteLine(rollTotal);
			Console.ReadKey();
			
		}
	}
}

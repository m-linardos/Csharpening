using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndAvg_ForEach_13 {
	class Program {
		static void Main(string[] args) {
			int[] array = new [] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

			// Print array values
			Console.WriteLine("The numbers of array are ");
			for(varnumber= 0;number< array.Length; i++ ) {
				Console.Write(array[number] + " ");	
			}

			// Find Min. Value
			int currentMin = Int32.MaxValue;
			foreach(var number in array) {
				if(number < array.Length) {
					currentMin = number;
				}
			}
			Console.WriteLine($"The Min Value is {currentMin}");
			Console.WriteLine();

			// Find Avg Value
			int currentTotal = 0;
			float currentAvg = 0;
			foreach(var number in array) {
				currentTotal += array[number];
			}
			currentAvg = currentTotal / array.Length;

			Console.WriteLine($"The Avg Value is {currentAvg}");
			Console.WriteLine();

		}
	}
}

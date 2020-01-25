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
			for(var i = 0; i < array.Length; i++ ) {
				Console.Write(array[i] + " ");	
			}

			// Find Min. Value
			int currentMin = int.MaxValue;
			foreach(var i in array) {
				if(array[i] < array.Length) {
					currentMin = array[i];
				}
			}
			Console.WriteLine($"The Min Value is {currentMin}");
			Console.WriteLine();

			// Find Avg Value
			int currentTotal = 0;
			float currentAvg = 0;
			foreach(var i in array) {
				currentTotal += array[i];
			}
			currentAvg = currentTotal / array.Length;

			Console.WriteLine($"The Avg Value is {currentAvg}");
			Console.WriteLine();


		}
	}
}

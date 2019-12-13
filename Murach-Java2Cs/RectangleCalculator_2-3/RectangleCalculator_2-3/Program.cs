using System;

namespace RectangleCalculator_2_3 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Rectangle Calculator");
			string choice = "Y";

			while(choice == "Y") {

			// Get Input
				Console.WriteLine("Enter length: ");
				
				string strLength = Console.ReadLine();
				decimal length = Convert.ToDecimal(strLength);

				Console.WriteLine("Enter width:  ");
				string strWidth = Console.ReadLine();
				decimal width = Convert.ToDecimal(strWidth);

			// Calculate
				decimal area = length * width;
				decimal perimeter = (2 * width) + (2 * length);

			// Output
				Console.WriteLine($"Area:        {area}");
				Console.WriteLine($"Perimeter:   {perimeter}");

				Console.WriteLine("Continue?(Y/N): ");
				string strChoice = Console.ReadLine();
				choice = choice.ToUpper();
				Console.ReadKey();

			 }
			Console.WriteLine("Have a Fantastic Day!!");
		}
	}
}

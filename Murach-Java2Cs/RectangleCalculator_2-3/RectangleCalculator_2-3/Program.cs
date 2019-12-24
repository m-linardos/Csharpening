using System;

namespace RectangleCalculator_2_3 {
	static class Program {
		static void Main(string[] args) {
			Console.WriteLine("Rectangle Calculator");


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

			Console.WriteLine("Have a Fantastic Day!!");
			Console.ReadKey();

		}

	}
}	 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPG_11 {
	class Program {
		static void Main(string[] args) {

			Console.WriteLine("	Welcome to Simple Calculator");
			Console.WriteLine();
			Console.WriteLine();
			bool isOperand = true;

			// Get operand
			Console.Write("	What math function would you like. Choose from  + , - , * , / , % : " );
			Console.WriteLine();
			string operand = Console.ReadLine();
			switch(operand) {
				case "+":
				case "-":
				case "*":
				case "/":
				case "%":
					Console.WriteLine("	Good choice!");
					Console.WriteLine();
					break;
				default:
					Console.WriteLine();
					Console.WriteLine("	That is not an option");
					Console.WriteLine();
					Console.Write("	What math function would you like.  Choose from  + , - , * , / , % : ");
					Console.WriteLine();
					operand = Console.ReadLine();
					switch(operand) {
						case "+":
						case "-":
						case "*":
						case "/":
						case "%":
							Console.WriteLine();
							Console.WriteLine("	Good choice!");
							Console.WriteLine();
							break;
						default:
							Console.WriteLine();
							Console.WriteLine("	REALLY !!!  I'm done with with you !!!");
							isOperand = false;
							break;
					}
					break;
			}

			// Quit if isOperand = false, otherwise continue
			if(isOperand) {
				// Get inputs & convert to double
				Console.WriteLine();
				Console.Write("	Enter a number: ");
				string num1Str = Console.ReadLine();
				double num1 = Convert.ToDouble(num1Str);

				Console.WriteLine();
				Console.Write("	Enter another number: ");
				string num2Str = Console.ReadLine();
				double num2 = Convert.ToDouble(num2Str);

				// Perform calculation based on operand input
				double result = 0;
				switch(operand) {
					case "+":
						result = num1 + num2;
						break;
					case "-":
						result = num1 - num2;
						break;
					case "*":
						result = num1 * num2;
						break;
					case "/":
						result = num1 / num2;
						break;
					case "%":
						result = num1 % num2;
						break;
				}
				// Print out the answer
				Console.WriteLine();
				Console.WriteLine($"	{num1} {operand} {num2} = {result}");
			} else { }		
			 
			Console.ReadKey();		 	

		}
	}
}

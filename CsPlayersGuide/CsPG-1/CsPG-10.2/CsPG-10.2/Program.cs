using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsPG_10._2 {
	class Program {
		static void Main(string[] args) {

			// Get two numbers from user	   
			Console.WriteLine("Please Enter a number: ");
			string strInput1 = Console.ReadLine();
			double input1 = Convert.ToDouble(strInput1);

			Console.WriteLine("Please Enter another number: ");
			string strInput2 = Console.ReadLine();
			double input2 = Convert.ToDouble(strInput1);

			// Determine if the numbers are positive, negative or '0'
			if(input1 == 0 || input2 == 0) {
				Console.WriteLine("One or both of the inputs are '0', therefore the product will not be positive or negative.");
			}
			else {
				bool input1Positive;
				bool input2Positive;


				if(input1 > 0) {
					input1Positive = true;
				}
				else {
					input1Positive = false;
				}
				if(input2 > 0) {
					input2Positive = true;
				}
				else {
					input2Positive = false;
				}

				// If the inputs have the same sign, print product will be positive
				// if the inputs DO NOT have the same sign, print product will be negative
				if((input1Positive && input2Positive) || (!input1Positive && !input2Positive)) {
					Console.WriteLine("The product will be positive.");
				}
				 else if((input1Positive && !input2Positive) || (!input1Positive && input2Positive)) {
					Console.WriteLine("The product will be negative.");
				 }
					
			}

			Console.ReadKey();
		}
	}
}

		  
		 
	
	


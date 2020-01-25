using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator_3_3 {
	class Program {
		static void Main(string[] args) {

			Console.WriteLine("Welcome to Interest Calculator");

			Console.WriteLine("Enter loan amount: ");
			string strLoanAmt = Console.ReadLine();
			decimal loanAmt = Convert.ToDecimal(strLoanAmt);
			strLoanAmt = String.Format("Loan amount: {0, 0:C2}", loanAmt);
			

			Console.WriteLine("Enter interest rate %: ");
			string strIntRate = Console.ReadLine();
			decimal intRate = Convert.ToDecimal(strIntRate);
			intRate = intRate/100;
			strIntRate = String.Format("Interest rate: {0, 0:F2}", intRate);
			

			decimal intCalc = loanAmt * intRate;
			string strIntCalc = String.Format("Interest: {0, 0:C2}", intCalc);

			Console.WriteLine(strLoanAmt);
			Console.WriteLine(strIntRate);
			Console.WriteLine(strIntCalc);

			Console.ReadKey();






		}
	}
}

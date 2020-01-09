using System;

namespace GradeConverter_2_2 {
	class Program {
		static void Main(string[] args) {
			
			string gradeLetter;
			//string choice = "Y";

			Console.WriteLine("GradeConverter");

			//while(choice = "Y"){
			Console.WriteLine("Enter Numerical Grade: ");
			String stringGradeNumber = Console.ReadLine();
			int gradeNumber = Convert.ToInt32(stringGradeNumber);

			if(gradeNumber > 87) {
				gradeLetter = "A";
			}
			else if(gradeNumber < 88 && gradeNumber > 79) {
				gradeLetter = "B";
			}
			else if(gradeNumber < 80 && gradeNumber > 66) {
				gradeLetter = "C";
			}
			else if(gradeNumber < 68 && gradeNumber > 59) {
				gradeLetter = "D";
			}
			else {
				gradeLetter = "F";
			}

			Console.WriteLine($"Letter Grade: {gradeLetter}");

			//Console.WriteLine("Continue(Y/N): ");
			//choice = Console.ReadLine();
			//string choice = choice.ToUpper();
			//continue;
			Console.ReadKey();

		}
	}
}

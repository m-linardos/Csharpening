using System;

namespace ConsoleApp1 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Student Registration Form");

			Console.WriteLine("Enter First Name: ");
			String firstName = Console.ReadLine();

			Console.WriteLine("Enter Last Name: ");
			String lastName = Console.ReadLine();

			Console.WriteLine("Enter Year of Birth: ");
			String stringYOB = Console.ReadLine();
			
			Console.WriteLine($"Welcome {firstName} {lastName}!");
			Console.WriteLine("Your Registration is complete.");
			Console.WriteLine($"Your temporary password is: {firstName}*{stringYOB}");

			Console.ReadKey();
		}
	}
}

using System;

namespace StructsAndEnums {
	class Program {
		static void Main(string[] args) {
			try {
				doWork();
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}

		static void doWork() {
			Date defaultDate = new Date();
			Console.WriteLine(defaultDate);
			Date birthdayDate = new Date(1998, Month.January, 26);
			Console.WriteLine(birthdayDate);

			Date birthdayDateCopy = birthdayDate;
			Console.WriteLine($"Value of copy is {birthdayDateCopy}");

			birthdayDate.AdvanceMonth();
			Console.WriteLine($"New value of birthdayDate is {birthdayDate}");
			Console.WriteLine($"Value of copy is still {birthdayDateCopy}");
		}
	}
}

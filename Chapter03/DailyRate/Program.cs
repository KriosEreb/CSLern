using System;

namespace DailyRate {
	class Program {
		static void Main(string[] args) {
			(new Program()).run();
		}

		void run() {
			double dailyRate = readDouble("Enter your daily rate: ");
			int noOfDays = readInt("Enter the number of days: ");
			writeFree(calculateFree(dailyRate, noOfDays));
		}

		private double readDouble(string v) {
			Console.Write(v);
			string line = Console.ReadLine();
			return double.Parse(line);
		}

		private int readInt(string v) {
			Console.Write(v);
			string line = Console.ReadLine();
			return int.Parse(line);
		}

		private double calculateFree(double dailyRate, int noOfDays) => dailyRate * noOfDays;

		private void writeFree(double v) => Console.WriteLine($"The consultant's fee is: {v * 1.1}");
	}
}

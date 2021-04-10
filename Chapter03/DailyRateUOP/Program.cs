using System;

namespace DailyRateUOP {
	class Program {
		static void Main(string[] args) {
			(new Program()).run();
		}

		void run() {
			double fee = calculateFree(theDailyRate: 375.0);
			Console.WriteLine($"Fee is {fee}");
		}

		private double calculateFree(double theDailyRate = 500.0, int noOfDays = 1) {
			Console.WriteLine("calculateFree using optional parameters");
			return theDailyRate * noOfDays;
		}

		private double calculateFree(double dailyRate = 500.0) {
			Console.WriteLine("calculateFree using one parameter");

			int defaultNoOfDays = 1;
			return dailyRate * defaultNoOfDays;
		}

		private double calculateFree() {
			Console.WriteLine("calculateFree using hardcoded values");

			double defaultDailyRate = 400.0;
			int defaultNoOfDays = 1;
			return defaultDailyRate * defaultNoOfDays;
		}
	}
}

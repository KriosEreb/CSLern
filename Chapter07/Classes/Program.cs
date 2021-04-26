using System;

namespace Classes {
	class Program {
		static void Main(string[] args) {
			try {
				doWork();
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}

		static void doWork() {
			Point origin = new Point();
			Point bottomRight = new Point(1366, 768);

			double distance = origin.DistanceTo(bottomRight);
			Console.WriteLine($"Distance is: {distance}");

			Console.WriteLine($"Number of Point object: {Point.ObjectCount()}");
		}
	}
}

using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace DoStatement {
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void showStepsClick(object sender, RoutedEventArgs e) {
			int amount = int.Parse(number.Text);
			step.Text = "";
			string current = "";

			do {
				int nextDigit = amount % 8;
				amount /= 8;
				int digitCode = '0' + nextDigit;
				char digit = Convert.ToChar(digitCode);
				current = digit + current;
				step.Text += current + '\n';

			} while (amount != 0);
		}
	}
}
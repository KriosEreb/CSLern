using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace Methods {
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void calculateClick(object sender, RoutedEventArgs e) {
			int calculatedValue = 0;

			try {
				int lhs = int.Parse(lhsOperand.Text);
				int rhs = int.Parse(rhsOperand.Text);

				if (addition.IsChecked.HasValue && addition.IsChecked.Value) {

					calculatedValue = addValues(lhs, rhs);
					showResult(calculatedValue);

				} else if (subtraction.IsChecked.HasValue && subtraction.IsChecked.Value) {

					calculatedValue = substractValues(lhs, rhs);
					showResult(calculatedValue);

				} else if (multiplication.IsChecked.HasValue && multiplication.IsChecked.Value) {

					calculatedValue = multiplyValues(lhs, rhs);
					showResult(calculatedValue);

				} else if (division.IsChecked.HasValue && division.IsChecked.Value) {

					calculatedValue = divideValues(lhs, rhs);
					showResult(calculatedValue);

				} else if (remainder.IsChecked.HasValue && remainder.IsChecked.Value) {

					calculatedValue = remainderValues(lhs, rhs);
					showResult(calculatedValue);
				}
			} catch (Exception caught) {
				experession.Text = "";
				result.Text = caught.Message;
			}
		}

		private int addValues(int lhs, int rhs) {
			experession.Text = $"{lhs} + {rhs}";
			return lhs + rhs;
		}

		private int substractValues(int lhs, int rhs) {
			experession.Text = $"{lhs} - {rhs}";
			return lhs - rhs;
		}

		private int multiplyValues(int lhs, int rhs) {
			experession.Text = $"{lhs} * {rhs}";
			return lhs * rhs;
		}

		private int divideValues(int lhs, int rhs) {
			experession.Text = $"{lhs} / {rhs}";
			return lhs / rhs;
		}

		private int remainderValues(int lhs, int rhs) {
			experession.Text = $"{lhs} % {rhs}";
			return lhs % rhs;
		}

		private void showResult(int answer) => result.Text = answer.ToString();
	}
}
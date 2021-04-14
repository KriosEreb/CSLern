using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace Selection {
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			firstDate.SelectedDate = DateTimeOffset.Now;
			secondDate.SelectedDate = DateTimeOffset.Now;
		}

		private void compareClick(object sender, RoutedEventArgs e) {
			if (firstDate.SelectedDate.HasValue && secondDate.SelectedDate.HasValue) {
				int diff = dateCompare(firstDate.SelectedDate.Value.DateTime, secondDate.SelectedDate.Value.DateTime);

				info.Text = "";
				show("firstDate == secondDate", diff == 0);
				show("firstDate != secondDate", diff != 0);
				show("firstDate < secondDate", diff < 0);
				show("firstDate <= secondDate", diff <= 0);
				show("firstDate > secondDate", diff > 0);
				show("firstDate >= secondDate", diff >= 0);
			}
		}

		private void show(string exp, bool result) {
			info.Text += exp;
			info.Text += " : " + result.ToString();
			info.Text += '\n';
		}

		private int dateCompare(DateTime lhs, DateTime rhs) {
			int result;

			if (lhs.Year < rhs.Year) {
				result = -1;
			} else if (lhs.Year > rhs.Year) {
				result = 1;
			} else if (lhs.Month < rhs.Month) {
				result = -1;
			} else if (lhs.Month > rhs.Month) {
				result = 1;
			} else if (lhs.Day < rhs.Day) {
				result = -1;
			} else if (lhs.Day > rhs.Day) {
				result = 1;
			} else {
				result = 0;
			}

			return result;
		}
	}
}
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace SwitchStatement {
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void copyClick(object sender, RoutedEventArgs e) {
			target.Text = "";
			string from = sourse.Text;
			for (int i = 0; i < from.Length; i++) {
				char current = from[i];
				copyOne(current);
			}
		}

		private void copyOne(char current) {
			switch (current) {
				case '<':
					target.Text += "&lt;";
					break;
				case '>':
					target.Text += "&gt;";
					break;
				case '&':
					target.Text += "&amp;";
					break;
				case '\"':
					target.Text += "&#34;";
					break;
				case '\'':
					target.Text += "&#39;";
					break;
				default:
					target.Text += current;
					break;
			}
		}
	}
}
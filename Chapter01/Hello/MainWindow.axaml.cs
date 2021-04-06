using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using MessageBox.Avalonia;

namespace Hello {
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		public void button_Click(object sender, RoutedEventArgs e) {
			if (userName.Text != null) {
				var msg = MessageBoxManager.GetMessageBoxStandardWindow("title", "Hello " + userName.Text);
				msg.Show();
			} else {
				var msg = MessageBoxManager.GetMessageBoxStandardWindow("Error", "Name is empty!");
				msg.Show();
			}
		}
	}
}

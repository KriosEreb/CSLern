using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using MessageBox.Avalonia;

namespace Hello {
	public class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif
		}

		public void button_Click(object sender, RoutedEventArgs e) {
			var userName = this.FindControl<TextBox>("userName");
			if (userName.Text != null) {
				var msg = MessageBoxManager.GetMessageBoxStandardWindow("title", "Hello " + userName.Text);
				msg.Show();
			} else {
				var msg = MessageBoxManager.GetMessageBoxStandardWindow("Error", "Name is empty!");
				msg.Show();
			}
		}

		private void InitializeComponent() {
			AvaloniaXamlLoader.Load(this);
		}
	}
}

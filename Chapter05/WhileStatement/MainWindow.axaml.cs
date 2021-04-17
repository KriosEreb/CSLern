using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace WhileStatement {
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private async void openFileClick(object sender, RoutedEventArgs e) {
			var fp = new OpenFileDialog();
			fp.InitialDirectory = "/home/krios/VSCode";
			fp.Filters.Add(new FileDialogFilter() { Name = "All", Extensions = { "*" } });

			var file = await fp.ShowAsync(Window);
		}
	}
}
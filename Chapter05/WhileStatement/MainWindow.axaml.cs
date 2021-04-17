using System.IO;
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
			fp.Directory = "/home/krios/Desktop/";
			fp.Filters.Add(new FileDialogFilter() { Name = "All", Extensions = { "*" } });

			var file = await fp.ShowAsync(this);
			if (file != null) {
				fileName.Text = file[0];
				TextReader reader = new StreamReader(file[0]);

				displayData(reader);
			}
		}

		private void displayData(TextReader reader) {
			source.Text = "";
			string? line = reader.ReadLine();

			while (line != null) {
				source.Text += line + '\n';
				line = reader.ReadLine();
			}

			reader.Dispose();
		}
	}
}
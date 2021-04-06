using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PrimitiveDataTypes {
	public class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif
		}

		private void InitializeComponent() {
			AvaloniaXamlLoader.Load(this);
		}

		private void typeSelectedChanged(object sender, SelectionChangedEventArgs e) {
			ListBox listBox = this.FindControl<ListBox>("type");
			ListBoxItem selectedType = (ListBoxItem)listBox.SelectedItem;
			switch (selectedType.Content.ToString()) {
				case "int":
					showIntValue();
					break;
				case "long":
					showLongValue();
					break;
				case "float":
					showFloatValue();
					break;
				case "double":
					showDoubleValue();
					break;
				case "decimal":
					showDecimalValue();
					break;
				case "string":
					showStringValue();
					break;
				case "char":
					showCharValue();
					break;
				case "bool":
					showBoolValue();
					break;
			}
		}

		private void showIntValue() {
			var value = this.FindControl<TextBox>("value");
			int intVar = 42;
			value.Text = intVar.ToString();
		}

		private void showLongValue() {
			var value = this.FindControl<TextBox>("value");
			long longVar = 42L;
			value.Text = longVar.ToString();
		}

		private void showFloatValue() {
			var value = this.FindControl<TextBox>("value");
			float floatVar = 0.42F;
			value.Text = floatVar.ToString();
		}

		private void showDoubleValue() {
			var value = this.FindControl<TextBox>("value");
			double doubleVar = 0.42;
			value.Text = doubleVar.ToString();
		}

		private void showDecimalValue() {
			var value = this.FindControl<TextBox>("value");
			decimal decimalVar = 0.42M;
			value.Text = decimalVar.ToString();
		}

		private void showStringValue() {
			var value = this.FindControl<TextBox>("value");
			string stringVar = "forty two";
			value.Text = stringVar;
		}

		private void showCharValue() {
			var value = this.FindControl<TextBox>("value");
			char charVar = 'x';
			value.Text = charVar.ToString();
		}

		private void showBoolValue() {
			var value = this.FindControl<TextBox>("value");
			bool boolVar = false;
			value.Text = boolVar.ToString();
		}
	}
}
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PrimitiveDataTypes {
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void typeSelectedChanged(object sender, SelectionChangedEventArgs e) {
			ListBoxItem selectedType = (types.SelectedItem as ListBoxItem);
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
			int intVar = 42;
			value.Text = intVar.ToString();
		}

		private void showLongValue() {
			long longVar = 42L;
			value.Text = longVar.ToString();
		}

		private void showFloatValue() {
			float floatVar = 0.42F;
			value.Text = floatVar.ToString();
		}

		private void showDoubleValue() {
			double doubleVar = 0.42;
			value.Text = doubleVar.ToString();
		}

		private void showDecimalValue() {
			decimal decimalVar = 0.42M;
			value.Text = decimalVar.ToString();
		}

		private void showStringValue() {
			string stringVar = "forty two";
			value.Text = stringVar;
		}

		private void showCharValue() {
			char charVar = 'x';
			value.Text = charVar.ToString();
		}

		private void showBoolValue() {
			bool boolVar = false;
			value.Text = boolVar.ToString();
		}
	}
}
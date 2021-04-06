using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace MathOperators {
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

		private void calculateClick(object sender, RoutedEventArgs e) {
			try {
				if ((bool)this.FindControl<RadioButton>("additional").IsChecked) {
					addValues();
				} else if ((bool)this.FindControl<RadioButton>("subtraction").IsChecked) {
					substractValues();
				} else if ((bool)this.FindControl<RadioButton>("multiplication").IsChecked) {
					multiplyValues();
				} else if ((bool)this.FindControl<RadioButton>("division").IsChecked) {
					divideValues();
				} else if ((bool)this.FindControl<RadioButton>("remainder").IsChecked) {
					remainderValues();
				}
			} catch (Exception caught){
				 this.FindControl<TextBlock>("expression").Text = "";
				this.FindControl<TextBlock>("result").Text = caught.Message;
			}
		}

		private void addValues() {
			int lhs = int.Parse(this.FindControl<TextBox>("lhsOperand").Text);
			int rhs = int.Parse(this.FindControl<TextBox>("rhsOperand").Text);
			int outcome = 0;
			// TODO: 
			this.FindControl<TextBlock>("expression").Text = $"{lhs} + {rhs}";
			this.FindControl<TextBlock>("result").Text = outcome.ToString();
		}

		private void substractValues() {
			int lhs = int.Parse(this.FindControl<TextBox>("lhsOperand").Text);
			int rhs = int.Parse(this.FindControl<TextBox>("rhsOperand").Text);
			int outcome = 0;
			// TODO: 
			this.FindControl<TextBlock>("expression").Text = $"{lhs} - {rhs}";
			this.FindControl<TextBlock>("result").Text = outcome.ToString();
		}

		private void multiplyValues() {
			int lhs = int.Parse(this.FindControl<TextBox>("lhsOperand").Text);
			int rhs = int.Parse(this.FindControl<TextBox>("rhsOperand").Text);
			int outcome = 0;
			// TODO: 
			this.FindControl<TextBlock>("expression").Text = $"{lhs} * {rhs}";
			this.FindControl<TextBlock>("result").Text = outcome.ToString();
		}

		private void divideValues() {
			int lhs = int.Parse(this.FindControl<TextBox>("lhsOperand").Text);
			int rhs = int.Parse(this.FindControl<TextBox>("rhsOperand").Text);
			int outcome = 0;
			// TODO: 
			this.FindControl<TextBlock>("expression").Text = $"{lhs} / {rhs}";
			this.FindControl<TextBlock>("result").Text = outcome.ToString();
		}

		private void remainderValues() {
			int lhs = int.Parse(this.FindControl<TextBox>("lhsOperand").Text);
			int rhs = int.Parse(this.FindControl<TextBox>("rhsOperand").Text);
			int outcome = 0;
			// TODO: 
			this.FindControl<TextBlock>("expression").Text = $"{lhs} % {rhs}";
			this.FindControl<TextBlock>("result").Text = outcome.ToString();
		}
	}
}
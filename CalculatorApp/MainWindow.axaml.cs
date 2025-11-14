using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CalculatorApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnAddClicked(object? sender, RoutedEventArgs e) => PerformCalculation((a, b) => a + b);

    private void OnSubtractClicked(object? sender, RoutedEventArgs e) => PerformCalculation((a, b) => a - b);

    private void OnMultiplyClicked(object? sender, RoutedEventArgs e) => PerformCalculation((a, b) => a * b);

    private void OnDivideClicked(object? sender, RoutedEventArgs e)
    {
        if (!TryGetInputs(out var first, out var second))
        {
            return;
        }

        if (Math.Abs(second) < double.Epsilon)
        {
            ShowError("Nie można dzielić przez zero.");
            return;
        }

        ShowResult(first / second);
    }

    private void OnClearClicked(object? sender, RoutedEventArgs e)
    {
        Input1TextBox.Text = string.Empty;
        Input2TextBox.Text = string.Empty;
        ResultTextBox.Text = string.Empty;
        ErrorTextBlock.Text = string.Empty;
        Input1TextBox.Focus();
    }

    private void PerformCalculation(Func<double, double, double> operation)
    {
        if (!TryGetInputs(out var first, out var second))
        {
            return;
        }

        var result = operation(first, second);
        ShowResult(result);
    }

    private bool TryGetInputs(out double first, out double second)
    {
        ClearFeedback();

        var hasFirst = double.TryParse(Input1TextBox.Text, out first);
        var hasSecond = double.TryParse(Input2TextBox.Text, out second);

        if (!hasFirst || !hasSecond)
        {
            ShowError("Podaj dwie poprawne liczby rzeczywiste.");
            return false;
        }

        return true;
    }

    private void ShowResult(double value)
    {
        ResultTextBox.Text = value.ToString();
        ErrorTextBlock.Text = string.Empty;
    }

    private void ShowError(string message)
    {
        ResultTextBox.Text = string.Empty;
        ErrorTextBlock.Text = message;
    }

    private void ClearFeedback()
    {
        ErrorTextBlock.Text = string.Empty;
    }
}

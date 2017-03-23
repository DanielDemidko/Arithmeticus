using System;
using System.Windows.Controls;

partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TextChanged(Object sender, TextChangedEventArgs e)
    {
        if(EditBox.Text.Length == 0)
        {
            ResultBox.Text = String.Empty;
            return;
        }
        Analysis result = EditBox.Text.IsCalculable();
        if(result.IsSuccessfully)
        {
            try
            {
                ResultBox.Text = EditBox.Text.Calculate().ToString();
            }
            catch(Exception error)
            {
                ResultBox.Text = error.Message;
            }
            return;
        }
        if(result.UncorrectSymbol != null)
        {
            ResultBox.Text = $"Недопустимый символ: '{result.UncorrectSymbol}'";
        }
    }
}


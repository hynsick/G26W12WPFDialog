using System.Windows;

namespace G26W12WPFDialog;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void OnAdd(object sender, RoutedEventArgs e)
    {
        GundamDlg dialog = new() { Owner = this };
        if (dialog.ShowDialog() != true)
            return;
    }
}
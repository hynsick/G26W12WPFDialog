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

        ResultText.Text += $"{dialog.Faction}의 {dialog.MSModel} {dialog.MSName}{(HasJongsung(dialog.MSName) ? "이" : "가")} 추가되었습니다.\n";
    }

    public static bool HasJongsung(string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        char last = str[^1]; // 뒤에서 첫 번째 글자

        // 한글 완성형 범위('가': 0xAC00 ~ '힣': 0xD7A3)가 아니면 받침 없음으로 처리
        if (last < 0xAC00 || last > 0xD7A3)
            return false;

        return (last - 44032) % 28 != 0;
    }
}
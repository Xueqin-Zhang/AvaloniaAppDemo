using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using AvaloniaAppDemo.views;

namespace AvaloniaAppDemo; 
public partial class MainWindow : Window {
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        (DataContext as MainWindowViewModel)?.ToogleSideMenuCommand?.Execute(null);
    }
}

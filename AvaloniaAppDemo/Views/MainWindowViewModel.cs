using Avalonia.Controls;
using AvaloniaAppDemo.ViewModel;
using AvaloniaAppDemo.Views.Pages;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaAppDemo.views;

public partial class MainWindowViewModel : BaseViewModel
{
    [ObservableProperty] private string _title = "Hello World";

    [ObservableProperty]
    private BasePageViewModel _currentPage = new HistoryViewModel();
}
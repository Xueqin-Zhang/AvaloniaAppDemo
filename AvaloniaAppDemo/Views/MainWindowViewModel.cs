using AvaloniaAppDemo.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaAppDemo.views;

public partial class MainWindowViewModel : BaseViewModel
{
    [ObservableProperty] private string _title = "Hello World";

    public MainWindowViewModel()
    {
        
    }
}
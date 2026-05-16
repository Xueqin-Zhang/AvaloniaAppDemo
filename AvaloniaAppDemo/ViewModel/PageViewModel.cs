using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaAppDemo.ViewModel;

public partial class BasePageViewModel : BaseViewModel
{
    [ObservableProperty] private string _pageName = "";
}
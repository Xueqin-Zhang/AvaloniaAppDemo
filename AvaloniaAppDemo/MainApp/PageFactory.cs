using System;
using AvaloniaAppDemo.ViewModel;

namespace AvaloniaAppDemo.MainApp;

public class PageFactory(Func<Type, BasePageViewModel> factory)
{
      public BasePageViewModel GetPageViewModel(Type type) => factory(type);
}
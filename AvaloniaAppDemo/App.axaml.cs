using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaAppDemo.views;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaAppDemo {
    public partial class App : Application {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        public override void OnFrameworkInitializationCompleted()
        {
            var services = new ServiceCollection();
            AddServices(services);
            
            var serviceProvider = services.BuildServiceProvider();
            
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();
                desktop.MainWindow.DataContext = serviceProvider.GetRequiredService<MainWindowViewModel>();
            }
            base.OnFrameworkInitializationCompleted();
        }

        private void AddServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
        }
    }
}
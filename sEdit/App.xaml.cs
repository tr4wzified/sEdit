using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using sEdit.Framework;
using sEdit.ViewModels;
using sEdit.Views;
using Sextant;
using Sextant.Avalonia;
using Splat;
using MessageBox.Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace sEdit {
    public partial class App : Application
    {
        public override void Initialize() => AvaloniaXamlLoader.Load(this);

        public override void OnFrameworkInitializationCompleted()
        {
            Locator.CurrentMutable
                   .RegisterViewForNavigation(() => new MainView(), () => new MainViewModel())
                   .RegisterViewModelFactory(() => new DefaultViewModelFactory())
                   .RegisterNavigationView(() => new NavigationView());

            Locator.Current.GetService<IViewStackService>()!.PushPage(new MainViewModel());

            Interactions.ErrorMessage.RegisterHandler(context => MessageBoxManager
                                                                 .GetMessageBoxStandardWindow("Notification", context.Input.ToString())
                                                                 .Show());

            new Window { Content = Locator.Current.GetNavigationView() }.Show();
            base.OnFrameworkInitializationCompleted();
                                                                            
    
        /*
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel()
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
        */
        }
    }
}

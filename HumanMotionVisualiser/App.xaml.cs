namespace HumanMotionVisualiser
{
    using System.Windows;
    using Prism.Ioc;
    using Prism.Mvvm;
    using View;
    using ViewModel;

    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
            ViewModelLocationProvider.Register<DataFileLoaderView, DataFileLoaderViewModel>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}

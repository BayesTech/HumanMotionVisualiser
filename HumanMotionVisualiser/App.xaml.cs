namespace HumanMotionVisualiser
{
    using System;
    using System.Windows;
    using NLog;
    using Prism.Ioc;
    using Prism.Mvvm;
    using View;
    using ViewModel;

    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            if (containerRegistry == null)
            {
                throw new ArgumentNullException(nameof(containerRegistry));
            }

            containerRegistry.RegisterInstance(typeof(LogFactory), new LogFactory(LogManager.Configuration));

            ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
            ViewModelLocationProvider.Register<ToolBarPanelView, ToolBarPanelViewModel>();
            ViewModelLocationProvider.Register<DataFileLoaderView, DataFileLoaderViewModel>();
            ViewModelLocationProvider.Register<PlayControllersView, PlayControllersViewModel>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}

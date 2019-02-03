namespace HumanMotionVisualiser.ViewModel
{
    using Prism.Mvvm;

    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            Title = "Human Motion Visualiser";
        }

        public string Title { get; }
    }
}

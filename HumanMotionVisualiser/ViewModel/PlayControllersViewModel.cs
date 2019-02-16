namespace HumanMotionVisualiser.ViewModel
{
    using Prism.Commands;
    using Prism.Mvvm;

    public class PlayControllersViewModel : BindableBase
    {
        public PlayControllersViewModel()
        {
            PlayButtonClickedCommand = new DelegateCommand(OnPlayButtonClicked, () => true);
        }

        public DelegateCommand PlayButtonClickedCommand { get; set; }

        private void OnPlayButtonClicked()
        {
        }
    }
}

namespace HumanMotionVisualiser.ViewModel
{
    using System;
    using NLog;
    using Prism.Commands;
    using Prism.Mvvm;

    public class PlayControllersViewModel : BindableBase
    {
        private readonly ILogger _logger;

        public PlayControllersViewModel(LogFactory logFactory)
        {
            if (logFactory == null)
            {
                throw new ArgumentNullException(nameof(logFactory));
            }

            _logger = logFactory.GetCurrentClassLogger();

            PlayButtonClickedCommand = new DelegateCommand(OnPlayButtonClicked, () => true);
        }

        public DelegateCommand PlayButtonClickedCommand { get; set; }

        private void OnPlayButtonClicked()
        {
            _logger.Info("Play button clicked");
        }
    }
}

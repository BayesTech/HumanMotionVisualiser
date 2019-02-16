namespace HumanMotionVisualiser.ViewModel
{
    using System.Windows.Forms;
    using Prism.Commands;
    using Prism.Mvvm;

    public class DataFileLoaderViewModel : BindableBase
    {
        private string _dataFilePath;

        public DataFileLoaderViewModel()
        {
            LoadButtonClickedCommand = new DelegateCommand(OnLoadButtonClicked, () => true);
        }

        public string DataFilePath
        {
            get => _dataFilePath;
            set => SetProperty(ref _dataFilePath, value);
        }

        public DelegateCommand LoadButtonClickedCommand { get; set; }

        private void OnLoadButtonClicked()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataFilePath = openFileDialog.FileName;
                }
            }
        }
    }
}

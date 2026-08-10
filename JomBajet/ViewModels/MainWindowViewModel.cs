using Prism.Mvvm;

namespace JomBajet.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "JomBajet";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}

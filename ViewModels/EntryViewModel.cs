using System.Windows.Input;

namespace StudyN.ViewModels
{
    public class EntryViewModel : BaseViewModel
    {
        public const string ViewName = "EntryPage";
        public EntryViewModel()
        {
            Title = "Home";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.devexpress.com/xamarin/"));
        }
        
        public ICommand OpenWebCommand { get; }
    }
}

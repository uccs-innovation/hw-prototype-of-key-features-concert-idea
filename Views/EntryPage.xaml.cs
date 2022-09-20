using StudyN.ViewModels;

namespace StudyN.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryPage : ContentPage
	{
		public EntryPage()
		{
			InitializeComponent();
			BindingContext = new EntryViewModel();
		}
	}
}
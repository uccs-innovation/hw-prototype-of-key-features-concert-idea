using StudyN.ViewModels;

namespace StudyN.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalendarPage : ContentPage
	{
		public CalendarPage()
		{
			InitializeComponent();
			BindingContext = new CalendarViewModel();
		}

	}
}
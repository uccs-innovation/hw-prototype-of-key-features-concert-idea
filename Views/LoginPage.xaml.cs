namespace StudyN.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
			BindingContext = new LoginViewModel();
		}

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }
    }
}
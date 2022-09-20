using DevExpress.Maui.Core.Themes;
using StudyN.Services;
using StudyN.Views;

namespace StudyN
{
    public partial class App : Application
    {
        //private bool themeIsSetting;

        internal event EventHandler ThemeChangedEvent;
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<NavigationService>();
            Routing.RegisterRoute(typeof(ItemDetailPage).FullName, typeof(ItemDetailPage));
            Routing.RegisterRoute(typeof(NewItemPage).FullName, typeof(NewItemPage));
            MainPage = new MainPage();
        }
        void ApplyTheme(bool isLightTheme)
        {
            ThemeManager.ThemeName = isLightTheme ? Theme.Light : Theme.Dark;
            MainPage.BackgroundColor = (Color)Resources["BackgroundThemeColor"];
            ThemeChangedEvent?.Invoke(this, EventArgs.Empty);
        }
        internal void ApplyTheme(bool isLightTheme, bool force)
        {
            if (force)
            {
                ApplyTheme(isLightTheme);
                //themeIsSetting = true;
            }
        }
    }
}
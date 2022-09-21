using DevExpress.Maui.Core.Themes;

namespace StudyN.Views
{
	public partial class IconView : Image
	{
		public static readonly BindableProperty ThemeNameProperty = BindableProperty.Create("ThemeName", typeof(string),
			typeof(IconView), propertyChanged: ThemeNamePropertyChanged, defaultValue: Theme.Light);

		public static readonly BindableProperty IconProperty = BindableProperty.Create("Icon", typeof(string),
			typeof(IconView), propertyChanged: IconPropertyChanged, defaultValue: null);

		static void ThemeNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			IconView iconView = (IconView)bindable;
			iconView.OnThemeNameChanged((string)newValue);
			if (!string.IsNullOrEmpty(iconView.Icon))
				iconView.SetValue(SourceProperty, GetImageSource(((IconView)bindable).Icon));
		}

		public string ThemeName
		{
			get => (string)GetValue(ThemeNameProperty);
			set => SetValue(ThemeNameProperty, value);
		}
		public string Icon { get; set; }
		public IconView()
		{
			InitializeComponent();
			if(App.Current is StudyN.App mainApp)
			{
				mainApp.ThemeChangedEvent += OnDisplayAppThemeChanged;
			}
		}

		static void IconPropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			((IconView)bindable).SetValue(SourceProperty, GetImageSource(newValue as string));
		}

		void OnThemeNameChanged(string newValue)
		{

		}

		void OnDisplayAppThemeChanged(object sender, EventArgs e)
		{
			ThemeName = ThemeManager.ThemeName;
			if(Source is FileImageSource)
				OnPropertyChanged(nameof(Source));
		}
		static string GetImageSource(string icon)
		{
			return ThemeManager.ThemeName.ToLower() + icon;
		}
	}
}
using DevExpress.Maui.DataForm;
using StudyN.Models;
using StudyN.Views;

namespace StudyN.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        public const string ViewName = "NewItemPage";


        string name;
        string description;
        DateTime start;
        DateTime startTime;
        DateTime end;
        DateTime endTime;
        DateTime newStartDateTime;
        DateTime newEndDateTime;

        public NewItemViewModel()
        {
            Title = "New Item";
            start = DateTime.Now;
            startTime = DateTime.Now;
            end = DateTime.Now;
            endTime = DateTime.Now;
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }


        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public DateTime Start
        {
            get => start;
            set => SetProperty(ref start, value);
        }
        
        public DateTime StartTime
        {
            get => startTime;
            set => SetProperty(ref startTime, value);
        }

        public DateTime End
        {
            get => end;
            set => SetProperty(ref end, value);
        }

        public DateTime EndTime
        {
            get => endTime;
            set => SetProperty(ref endTime, value);
        }

        [DataFormDisplayOptions(IsVisible = false)]
        public Command SaveCommand { get; }

        [DataFormDisplayOptions(IsVisible = false)]
        public Command CancelCommand { get; }


        bool ValidateSave()
        {
            return !string.IsNullOrWhiteSpace(name)
                && !string.IsNullOrWhiteSpace(description);
        }

        async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Navigation.GoBackAsync();
        }

        async void OnSave()
        {
            MapDateTime();
            var newItem = new CalendarEvent()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Name,
                Description = Description,
                Start = newStartDateTime,
                End = newEndDateTime
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Navigation.GoBackAsync();
        }

        void MapDateTime()
        {
            newStartDateTime = DateTime.Parse(start.ToString("yyyy-MM-dd") + " " + startTime.TimeOfDay.ToString());
            newEndDateTime = DateTime.Parse(end.ToString("yyyy-MM-dd") + " " + endTime.TimeOfDay.ToString());
        }
    }
}
using StudyN.Models;
using System.Collections.ObjectModel;

namespace StudyN.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        CalendarEvent _selectedItem;
        Notification notification;


        public ItemsViewModel()
        {
            Title = "Task Manager";
            Items = new ObservableCollection<CalendarEvent>();
            LoadItemsCommand = new Command(() => ExecuteLoadItemsCommand());
            ItemTapped = new Command<CalendarEvent>(OnItemSelected);
            AddItemCommand = new Command(OnAddItem);
        }


        public ObservableCollection<CalendarEvent> Items { get; }

        public Command LoadItemsCommand { get; }

        public Command AddItemCommand { get; }

        public Command<CalendarEvent> ItemTapped { get; }

        public CalendarEvent SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        public Notification Notification
        {
            get => notification;
            set
            {
                SetProperty(ref notification, value);
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
            ExecuteLoadItemsCommand();
        }

        void ExecuteLoadItemsCommand()
        {
            IsBusy = true;
            try
            {
                Items.Clear();
                var items = DataStore.GetItems(true);
                if (items != null && items.Count() != 0)
                {
                    notification = new Notification
                    {
                        Text = string.Empty
                    };
                    foreach (var item in items)
                    {
                        var it = new CalendarEvent
                        {
                            Name = item.Name,
                            Description = item.Description,
                            Id = item.Id
                        };
                        Items.Add(it);
                    }
                }
                else
                {
                    Items.Add(new CalendarEvent
                    {
                        Name = "You don't currently have any tasks."
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        async void OnAddItem(object obj)
        {
            await Navigation.NavigateToAsync<NewItemViewModel>(null);
        }

        async void OnItemSelected(CalendarEvent item)
        {
            if (item == null)
                return;
            await Navigation.NavigateToAsync<ItemDetailViewModel>(item.Id);
        }
    }
}
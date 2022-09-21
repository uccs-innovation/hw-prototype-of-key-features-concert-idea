using StudyN.Models;
using System.Collections.ObjectModel;
using System.Web;

namespace StudyN.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel, IQueryAttributable
    {
        public const string ViewName = "ItemDetailPage";

        string name;
        string description;
        DateTime? start;
        DateTime? end;
        bool completed = false;
        ObservableCollection<Item> subTasks = new();


        public string Id { get; set; }

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

        public ObservableCollection<Item> SubTasks
        {
            get => subTasks;
            set => SetProperty(ref subTasks, value);
        }

        public DateTime? Start
        {
            get => start;
            set => SetProperty(ref start, value);
        }

        public bool Completed { get => completed; set => SetProperty(ref completed, value); }   
        public DateTime? End
        {
            get => end;
            set => SetProperty(ref end, value);
        }

        public async Task LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Name = item.Name;
                Description = item.Description;
                Start = item.Start;
                End = item.End;
                Completed = item.Completed;
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Failed to Load Item");
            }
        }

        public override async Task InitializeAsync(object parameter)
        {
            await LoadItemId(parameter as string);
        }

        public async void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            string id = HttpUtility.UrlDecode(query["id"] as string);
            await LoadItemId(id);
        }
    }
}
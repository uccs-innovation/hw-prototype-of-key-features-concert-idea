using StudyN.Interfaces;
using StudyN.Models;
using StudyN.Services;
using System.Windows.Input;

namespace StudyN.ViewModels
{
    public class TaskManagerViewModel : BaseViewModel, IQueryAttributable
    {
        IDisplayData data;
        TaskManagerDisplayItem selectedItem;
        public List<TaskManagerDisplayItem> DisplayItems => data?.DisplayItems;
        public TaskManagerDisplayItem SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                if (selectedItem == null)
                    return;
                NavigationDisplayCommand.Execute(selectedItem);
            }
        }
        public ICommand NavigationDisplayCommand { get; }
        public TaskManagerViewModel()
        {
            NavigationDisplayCommand = new DelegateCommand<TaskManagerDisplayItem>(async (displayItem) => await NavigationService.NavigateToDisplay(displayItem));
        }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if(query.TryGetValue("DisplayData", out object data))
            {
                SetProperty(ref data, data as IDisplayData, propertyName: nameof(DisplayItems));
            }
        }
    }
}

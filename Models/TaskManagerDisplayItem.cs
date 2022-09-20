using StudyN.Interfaces;

namespace StudyN.Models
{
    public class TaskManagerDisplayItem
    {
        string pageTitle = null;
        string icon = null;
        string controlsPageTitle = null;
        Type module;
        List<TaskManagerDisplayItem> displayItems;

        public string Title { get; set; }
        public string Description { get; set; }
        public bool ShowItemUnderline { get; set; } = true;
        public bool IsHeader { get; set; }
        public List<TaskManagerDisplayItem> DisplayItems => displayItems;

        public string Icon
        {
            get => string.IsNullOrEmpty(icon) ? null : icon;
            set => icon = value;
        }
        public string ControlsPageTitle
        {
            get => controlsPageTitle ?? Title;
            set => controlsPageTitle = value;
        }
        public Type Module
        {
            get => module;
            set
            {
                module = value;
                if (value != null && value.GetInterface("IDisplayData") != null)
                {
                    displayItems = ((IDisplayData)Activator.CreateInstance(value)).DisplayItems;
                }
            }
        }
    }
}

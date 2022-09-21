using StudyN.Models;

namespace StudyN.Interfaces
{
    public interface IDisplayData
    {
        List<TaskManagerDisplayItem> DisplayItems { get; }
        string Title { get; }
    }
}

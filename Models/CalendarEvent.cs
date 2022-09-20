using System.Collections.ObjectModel;

namespace StudyN.Models
{
    public class CalendarEvent
    {
        /// <summary>
        /// The event identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The name of the event
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The event's description/details
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The start date and time of the event
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// The end date and time of the event
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// Event completed
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// Sub-tasks of the event
        /// </summary>
        public ObservableCollection<Item> SubTasks { get; set; }
    }
}

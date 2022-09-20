using StudyN.Models;

namespace StudyN.Services
{
    public class MockDataStore : IDataStore<CalendarEvent>
    {
        readonly List<CalendarEvent> items;

        public MockDataStore()
        {
            DateTime baseDate = DateTime.Today;
            items = new List<CalendarEvent>();
        }

        public async Task<bool> AddItemAsync(CalendarEvent item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(CalendarEvent item)
        {
            var oldItem = items.Where((CalendarEvent arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((CalendarEvent arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<CalendarEvent> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<CalendarEvent>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
        public IEnumerable<CalendarEvent> GetItems(bool forceRefresh = false)
        {
            return items;
        }
    }
}
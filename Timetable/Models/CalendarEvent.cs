namespace Timetable.Models
{
    public class CalendarEvent
    {
        public string? Id { get; set; } = Guid.NewGuid().ToString(); 
        public string Title { get; set; } = string.Empty;
        public DateTime Start { get; set; }
    }
}

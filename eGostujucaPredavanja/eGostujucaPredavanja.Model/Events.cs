namespace eGostujucaPredavanja.Model
{
    public class Events
    {
        public int EventId { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }
    }
}
namespace API.Entities
{
    public class AppEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] Description { get; set; }
        public string YtUrl { get; set; }
    }
}
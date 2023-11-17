namespace WebApplication1.Models
{
    public class Album
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public List<Song>? Songs { get; set; }
    }
}

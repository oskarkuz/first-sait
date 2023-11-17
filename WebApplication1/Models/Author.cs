namespace WebApplication1.Models
{
    public class Author
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<Album>? Albums { get; set; }
    }
}

using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ISong
    {
        IEnumerable<Song> Songs(ISongAuthor songAuthors);
        IEnumerable<Song> Songs(Author author);
        IEnumerable<Song> Songs(Album album);
    }
}

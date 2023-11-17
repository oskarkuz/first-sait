using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ISongAlbum
    {
        IEnumerable<Album> Albums(Author author);
    }
}

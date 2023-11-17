using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AlbumService : ISongAlbum
    {
        public IEnumerable<Album> Albums(Author author) => author.Albums;
    }
}

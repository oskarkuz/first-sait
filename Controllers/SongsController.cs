using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    public class SongsController : Controller
    {
        public readonly ISong _songs;
        public readonly ISongAlbum _songAlbums;
        public readonly ISongAuthor _songAuthors;
        public SongsController(ISong songs, ISongAlbum songAlbums, ISongAuthor songAuthors)
        {
            _songs = songs;
            _songAlbums = songAlbums;
            _songAuthors = songAuthors;
        }
        public ViewResult AllSongs()
        {
            var songs = _songs.Songs(_songAuthors);
            return View(songs);
        }
    }
}

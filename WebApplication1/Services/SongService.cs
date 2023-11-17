using WebApplication1.Models;
using WebApplication1.Interfaces;

namespace WebApplication1.Services
{
    public class SongService : ISong
    {
        public IEnumerable<Song> Songs(ISongAuthor songAuthors)
        {
            List<Song> songs = new List<Song>();
            foreach (var author in songAuthors.Authors()){
                foreach (var album in author.Albums){
                    foreach (var song in album.Songs){
                        songs.Add(song);
                    }
                }
            }
            return songs;
        }
        public IEnumerable<Song> Songs(Author author)
        {
            List<Song> songs = new List<Song>();
            foreach(var album in author.Albums){
                foreach(var song in album.Songs){
                    songs.Add(song);
                }
            }
            return songs;
        }
        public IEnumerable<Song> Songs(Album album)
        {
            List<Song> songs = new List<Song>();
            foreach (var song in album.Songs){
                songs.Add(song);
            }
            return songs;
        }
    }
}
